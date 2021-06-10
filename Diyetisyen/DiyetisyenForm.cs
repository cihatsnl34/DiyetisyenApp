using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiyetisyenApp.DB;
using DiyetisyenApp.Diyetisyen;
using DiyetisyenApp.Rapor;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DiyetisyenApp
{
    public partial class DiyetForm : Form
    {
        private DiyetisyenContext _db;
        readonly yaziSartlari _sart;
        private string _diyetisyenAdi;
        public DiyetForm(string DiyetisyenAdi)
        {
            InitializeComponent();
            _diyetisyenAdi = DiyetisyenAdi;
            _db = new DiyetisyenContext();
            _sart = new yaziSartlari();
        }
        private void DiyetForm_Load(object sender, EventArgs e)
        {
            lbl_Diyetisyen_Adi.Text = _diyetisyenAdi;
            var hastaList = _db.HastaTables.Where(q => q.doktorAdi == _diyetisyenAdi).ToList();
            foreach (var l in hastaList)
            {
                ListViewItem addhasta = new ListViewItem(l.tc);
                addhasta.SubItems.Add(l.adi);
                addhasta.SubItems.Add(l.soyadi);
                addhasta.SubItems.Add(l.hastalikTipi);
                addhasta.SubItems.Add(l.uygulanacakDiyet);
                HastaList.Items.Add(addhasta);

            }

            HastaFabrikasi hf = new HastaFabrikasi();
            DiyetFabrikasi df = new DiyetFabrikasi();

            List<string> hastalikListe = hf.HastalikSirala();
            foreach (var item in hastalikListe)
            {
                CB_Hastalik_Tipi.Items.Add(item);
            }

            List<string> diyetListele = df.DiyetSirala();
            foreach (var item in diyetListele)
            {
                CB_Uygulanacak_Diyet.Items.Add(item);
            }

        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            if (txt_hasta_ad.Text == "" && txt_hasta_kilo.Text == "" && txt_hasta_soyad.Text == "" && txt_hasta_tc.Text == "" && txt_hasta_yas.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız..", "Boş Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var hasta = new HastaTable
                {
                    adi = txt_hasta_ad.Text,
                    kilo = int.Parse(txt_hasta_kilo.Text),
                    soyadi = txt_hasta_soyad.Text,
                    tc = txt_hasta_tc.Text,
                    yas = int.Parse(txt_hasta_yas.Text),
                    hastalikTipi = CB_Hastalik_Tipi.Text,
                    uygulanacakDiyet = CB_Uygulanacak_Diyet.Text,
                    doktorAdi = _diyetisyenAdi
                };

                _db.HastaTables.Add(hasta);       
                _db.SaveChanges();
                 MessageBox.Show("Hasta Kaydı ve Diyet Atama Başarıyla Tamamlanmıştır!", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 txt_hasta_ad.Text = "";
                 txt_hasta_kilo.Text = "";
                 txt_hasta_soyad.Text = "";
                 txt_hasta_tc.Text = "";
                 txt_hasta_yas.Text = "";
            }

            //update the list when adding new patient 
            HastaList.Items.Clear();
            var hastaList = _db.HastaTables.Where(q => q.doktorAdi == _diyetisyenAdi).ToList();
            foreach (var l in hastaList)
            {
                ListViewItem addhasta = new ListViewItem(l.tc);
                addhasta.SubItems.Add(l.adi);
                addhasta.SubItems.Add(l.soyadi);
                addhasta.SubItems.Add(l.hastalikTipi);
                addhasta.SubItems.Add(l.uygulanacakDiyet);
                HastaList.Items.Add(addhasta);

            }

        }

        private void txt_hasta_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            _sart.AllowNumberOnly(e, txt_hasta_tc, errorProvider1);
        }

        private void txt_hasta_kilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _sart.AllowNumberOnly(e, txt_hasta_tc, errorProvider2);
        }

        private void txt_hasta_yas_KeyPress(object sender, KeyPressEventArgs e)
        {
            _sart.AllowNumberOnly(e, txt_hasta_tc, errorProvider3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HastaList.SelectedItems.Count >0)
            {
                var tc = HastaList.SelectedItems[0].SubItems[0].Text;
                dosyaOlusturForm dof = new dosyaOlusturForm(tc.ToString());
                dof.Show(); 
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm k = new LoginForm();
            this.Hide();
            k.Show();
        }

    }
}

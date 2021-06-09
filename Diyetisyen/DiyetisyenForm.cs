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
using DiyetisyenApp.Rapor;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DiyetisyenApp
{
    public partial class DiyetForm : Form
    {
        Dictionary<string, string> Hasta = new Dictionary<string, string>();
        Akdeniz akdeniz = new Akdeniz();
        GlutenFree glf = new GlutenFree();
        DenizUrunleri dnzurn = new DenizUrunleri();
        YesilliklerDunya yslk = new YesilliklerDunya();
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


                //diyet ve hastalik fabrikalari uygulamasi
                IHastalikTipi hastalik = HastaFabrikasi.HastaOlustur(CB_Hastalik_Tipi.Text);
                IDiyetTipi diyet = DiyetFabrikasi.DiyetOlustur(CB_Uygulanacak_Diyet.Text);
                // factory implementation -------------------------
                MessageBox.Show(hastalik.hastalik(), "Hastalik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(diyet.Diyet().ToString(), "Diyet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //-------------------------------------------------

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
                MessageBox.Show(tc);
                var getHasta = _db.HastaTables.FirstOrDefault(q=>q.tc==tc);
                var hastaAdi = getHasta.adi;
                var hastaSoyadi = getHasta.soyadi;
                var hastaTc = getHasta.tc;
                var hastaKilosu = getHasta.kilo;
                var hastaYasi = getHasta.yas;
                var hastaDiyet = getHasta.uygulanacakDiyet;
                var hastalikTipi = getHasta.hastalikTipi;
               
                Hasta.Add("Hasta Adı:", getHasta.adi);
                Hasta.Add("Hasta Soyadı:", getHasta.soyadi);
                Hasta.Add("Hasta Tc:", getHasta.tc);
                Hasta.Add("Hasta Kilosu:", getHasta.kilo.ToString());
                Hasta.Add("Hasta Yasi:", getHasta.yas.ToString());
                Hasta.Add("Hasta Diyet:", getHasta.uygulanacakDiyet);
                Hasta.Add("Hastalık Tipi:", getHasta.hastalikTipi);
                
                dosyaolustur(hastaDiyet);
                //string fileName = "Akdeniz_Rapor.json";
                //var JsonObject = JsonConvert.SerializeObject(Hasta);
                //string writeText = JsonObject + akdeniz.Diyet();
                //FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                //fs.Close();
                //File.AppendAllText(fileName, Environment.NewLine + writeText);




            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm k = new LoginForm();
            this.Hide();
            k.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public void dosyaolustur(string hastadiyet)
        {

            MessageBox.Show(hastadiyet);
            if (hastadiyet.ToString() == "Akdeniz")
            {
                string fileName = "Akdeniz_Rapor.json";
                var JsonObject = JsonConvert.SerializeObject(Hasta);
                string writeText = JsonObject + akdeniz.Diyet();
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
                File.AppendAllText(fileName, Environment.NewLine + writeText);
                Hasta.Clear();
            }
            if (hastadiyet.ToString() == "Gluten Free")
            {
                string fileName = "Gluten_Free_Rapor.json";
                var JsonObject = JsonConvert.SerializeObject(Hasta);
                string writeText = JsonObject + glf.Diyet();
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
                File.AppendAllText(fileName, Environment.NewLine + writeText);
                Hasta.Clear();
            }
            if (hastadiyet.ToString() == "Yeşillikler Dünyası")
            {
                string fileName = "Yeşillikler_Dünyası_Rapor.json";
                var JsonObject = JsonConvert.SerializeObject(Hasta);
                string writeText = JsonObject + yslk.Diyet();
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
                File.AppendAllText(fileName, Environment.NewLine + writeText);
                Hasta.Clear();
            }
            if (hastadiyet.ToString() == "Deniz Ürünleri")
            {
                string fileName = "Deniz_Ürünleri_Rapor.json";
                var JsonObject = JsonConvert.SerializeObject(Hasta);
                string writeText = JsonObject + dnzurn.Diyet();
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
                File.AppendAllText(fileName, Environment.NewLine + writeText);
                Hasta.Clear();
            }


            

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiyetisyenApp.DB;

namespace DiyetisyenApp
{
    public partial class AdminForm : Form
    {
        private readonly DiyetisyenContext _db;
        public AdminForm()
        {
            InitializeComponent();
            _db = new DiyetisyenContext();
        }

        private void btnDiyetisyenEkle_Click(object sender, EventArgs e)
        {
            DiyetisyenEkleForm sf = new DiyetisyenEkleForm();
            this.Hide();
            sf.Show();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            var diyetisyenListesi = _db.KullaniciTables.ToList();
            foreach (var l in diyetisyenListesi)
            {
                if (l.TC != null)
                {
                    ListViewItem addDiyetisyen = new ListViewItem(l.KullaniciAdi);
                    addDiyetisyen.SubItems.Add(l.Sifre);
                    addDiyetisyen.SubItems.Add(l.TC);
                    DiyetisyenList.Items.Add(addDiyetisyen);
                }
            }

            var hastaList = _db.HastaTables.ToList();
            foreach (var l in hastaList)
            {

                ListViewItem addhasta = new ListViewItem(l.adi + " " + l.soyadi);
                addhasta.SubItems.Add(l.hastalikTipi);
                addhasta.SubItems.Add(l.uygulanacakDiyet);
                addhasta.SubItems.Add(l.doktorAdi);
                HastaList.Items.Add(addhasta);

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
    }
}

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
using System.Xml.Serialization;
using DiyetisyenApp.DB;
using DiyetisyenApp.Rapor;
using DiyetisyenApp.Rapor.XML;
using Newtonsoft.Json;

namespace DiyetisyenApp.Diyetisyen
{
    public partial class dosyaOlusturForm : Form
    {
        private DiyetisyenContext _db;
        private string _hastaTC;
        public dosyaOlusturForm(string tc)
        {
            InitializeComponent();
            _db = new DiyetisyenContext();
            _hastaTC = tc;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnJson_Click(object sender, EventArgs e)
        {

            var getHasta = _db.HastaTables.FirstOrDefault(q => q.tc == _hastaTC);
            DiyetFabrikasi fabrika = new DiyetFabrikasi();
            IDiyetTipi diyet = fabrika.DiyetOlustur(getHasta.uygulanacakDiyet);
            DiyetBilgileriJson getRoot = (DiyetBilgileriJson)diyet.DiyetJson();
            getRoot.hastaBilgileri = new Rapor.HastaBilgileri
            {
                hastaTc = getHasta.tc,
                hastaAdi = getHasta.adi,
                hastaSoyadi = getHasta.soyadi,
                hastaYasi = getHasta.yas.ToString(),
                hastaKilosu = getHasta.kilo.ToString(),
                hastalikTipi = getHasta.hastalikTipi,
                hastaDiyet = getHasta.uygulanacakDiyet
            };
            dosya_olustur(getHasta.adi + "_" + getHasta.soyadi + "_diyeti.json", getRoot , 1);
            this.Hide();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            var getHasta = _db.HastaTables.FirstOrDefault(q => q.tc == _hastaTC);

            DiyetFabrikasi fabrika = new DiyetFabrikasi();
            IDiyetTipi diyet = fabrika.DiyetOlustur(getHasta.uygulanacakDiyet);

            DiyetBilgileriXml getRoot = (DiyetBilgileriXml)diyet.DiyetXml();
            getRoot.HastaBilgileri = new Rapor.XML.HastaBilgileri
            {
                HastaTc = getHasta.tc, 
                HastaAd = getHasta.adi,
                HastaSoyad = getHasta.soyadi,
                HastaYas = getHasta.yas.ToString(),
                HastaKilo = getHasta.kilo.ToString(),
                Hastalik = getHasta.hastalikTipi,
                Diyet = getHasta.uygulanacakDiyet
            };
            dosya_olustur(getHasta.adi + "_" + getHasta.soyadi + "_diyeti.xml", getRoot , 2);
            this.Hide();
        }

        private void dosya_olustur(string fileName, object root, int key)
        {
            string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = $@"{DesktopPath}\" + fileName;

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                // Create a new file     
                using (FileStream fs = File.Create(path))
                {
                    if (key == 1)
                    {
                        var JsonObjectHastaBilgileri = JsonConvert.SerializeObject(root);
                        byte[] hastaBilgileri = new UTF8Encoding(true).GetBytes(JsonObjectHastaBilgileri.ToString());
                        fs.Write(hastaBilgileri, 0, hastaBilgileri.Length);
                    }
                    else
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(DiyetBilgileriXml));
                        serializer.Serialize(fs,root);
                    }
                    MessageBox.Show(fileName + " adılı dosya masaüstünde başarıyla oluşturulmuştur....", "Dosya Oluşturulmuş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}

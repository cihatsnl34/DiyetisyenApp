using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenApp
{
    public class DiyetFabrikasi
    {
        public IDiyetTipi DiyetOlustur(string diyetTipi)
        {
            switch (diyetTipi)
            {
                case "Deniz Ürünleri":
                    return new DenizUrunleri();
                case "Yesillikler Dunyasi":
                    return new YesilliklerDunyasi();
                case "Gluten Free":
                    return new GlutenFree();
                case "Akdeniz":
                    return new Akdeniz();
                default:
                    return null;
            }
        }
        public List<string> DiyetSirala()
        {
            DenizUrunleri denizUrunleri =  new DenizUrunleri();
            YesilliklerDunyasi yesilliklerDunyasi = new YesilliklerDunyasi();
            GlutenFree glutenFree =  new GlutenFree();
            Akdeniz akdeniz = new Akdeniz();

            List<string> items = new List<string>
            {
                denizUrunleri.DiyetAdi(),
                akdeniz.DiyetAdi(),
                glutenFree.DiyetAdi(),
                yesilliklerDunyasi.DiyetAdi()
            };

            return items;
        }
    }
}

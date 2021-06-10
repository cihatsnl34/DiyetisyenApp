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
                case "Yeşillikler Dünyası":
                    return new YesilliklerDunyasi();
                case "Gluten Free":
                    return new GlutenFree();
                case "Akdeniz":
                    return new Akdeniz();
                default:
                    return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenApp
{
    public class HastaFabrikasi
    {
        public IHastalikTipi HastalikOlustur(string hastalikTipi)
        {
            switch (hastalikTipi)
            {
                case "Obez Hastalığı":
                    return new Obez();
                case "Çölyak Hastalığı":
                    return new Colyak();
                case "Şeker Hastalığı":
                    return new SekerHastalik();
                default:
                    return null;
            }
        }
        public List<string> HastalikSirala()
        {
            Obez obez = new Obez();
            Colyak colyak = new Colyak();
            SekerHastalik sekerHastalik =  new SekerHastalik();

            List<string> items = new List<string>
            {
                obez.hastalik(),
                colyak.hastalik(),
                sekerHastalik.hastalik()
            };

            return items;
        }
    }
}

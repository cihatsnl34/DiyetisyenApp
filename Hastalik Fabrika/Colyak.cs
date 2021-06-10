using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenApp
{
    public class Colyak:IHastalikTipi
    {
        public string hastalik()
        {
            return this.colyakHastalik();
        }
        private string colyakHastalik()
        {
            return "Çölyak Hastalığı";
        }
        
    }
}

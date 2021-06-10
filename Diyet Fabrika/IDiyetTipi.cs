using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenApp
{
    public interface IDiyetTipi
    {
        object DiyetJson();
        object DiyetXml();
        string DiyetAdi();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenApp.Rapor
{
        public class HastaBilgileri
        {
            public string hastaAdi { get; set; }
            public string hastaSoyadi { get; set; }
            public string hastaTc { get; set; }
            public string hastaKilosu { get; set; }
            public string hastaYasi { get; set; }
            public string hastaDiyet { get; set; }
            public string hastalikTipi { get; set; }
        }

        public class Gun1
        {
            public string kahvalti { get; set; }
            public string OgleYemegi { get; set; }
            public string AksamYemegi { get; set; }
            public string AraOgun { get; set; }
        }

        public class Gun2
        {
            public string kahvalti { get; set; }
            public string OgleYemegi { get; set; }
            public string AksamYemegi { get; set; }
            public string AraOgun { get; set; }
        }

        public class Gun3
        {
            public string kahvalti { get; set; }
            public string OgleYemegi { get; set; }
            public string AksamYemegi { get; set; }
            public string AraOgun { get; set; }
        }

        public class Gun4
        {
            public string kahvalti { get; set; }
            public string OgleYemegi { get; set; }
            public string AksamYemegi { get; set; }
            public string AraOgun { get; set; }
        }

        public class Gun5
        {
            public string kahvalti { get; set; }
            public string OgleYemegi { get; set; }
            public string AksamYemegi { get; set; }
            public string AraOgun { get; set; }
        }

        public class DiyetBilgileriJson
    {
            public HastaBilgileri hastaBilgileri { get; set; }
            public Gun1 Gun_1 { get; set; }
            public Gun2 Gun_2 { get; set; }
            public Gun3 Gun_3 { get; set; }
            public Gun4 Gun_4 { get; set; }
            public Gun5 Gun_5 { get; set; }
        }



    
}

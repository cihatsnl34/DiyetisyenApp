using DiyetisyenApp.Rapor;
using DiyetisyenApp.Rapor.XML;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenApp
{
    public class DenizUrunleri:IDiyetTipi
    {
        public object DiyetJson()
        {
            return this.DenizDiyet();
        }

        public object DiyetXml()
        {
            return this.DenizDiyetXml();
        }

        private object DenizDiyet()
        {
            DiyetBilgileriJson root = new DiyetBilgileriJson
            {
                Gun_1 = new Gun1
                {
                    kahvalti = "(DenizUrunleri) 2 dilim kepekli ekmek (çavdar, ekşi mayalı ekmek de tüketebilirsiniz), 1 dilim tuzsuz beyaz peynir, 5-6 adet tuzsuz zeytin, 1 yemek kaşığı zeytinyağı, bolca salatalık, domates ve yeşillik",
                    OgleYemegi = "Ton balıklı, zeytinyağlı yeşil salata + 1 dilim kepek ekmeği",
                    AksamYemegi = "Zeytinyağlı sebze yemeği + yarım yağlı yoğurt + salata",
                    AraOgun = "Meyve + yarım yağlı süt + çiğ badem (çiğ fındık, ceviz, kaju vb)"
                },
                Gun_2 = new Gun2
                {
                    kahvalti = "2 dilim kepekli ekmek (çavdar, ekşi mayalı ekmek de tüketebilirsiniz), 1 dilim tuzsuz beyaz peynir, 5-6 adet tuzsuz zeytin, 1 yemek kaşığı zeytinyağı, bolca salatalık, domates ve yeşillik",
                    OgleYemegi = "Ton balıklı, zeytinyağlı yeşil salata + 1 dilim kepek ekmeği",
                    AksamYemegi = "Zeytinyağlı sebze yemeği + yarım yağlı yoğurt + salata",
                    AraOgun = "Meyve + yarım yağlı süt + çiğ badem (çiğ fındık, ceviz, kaju vb)"
                },
                Gun_3 = new Gun3
                {
                    kahvalti = "2 dilim kepekli ekmek (çavdar, ekşi mayalı ekmek de tüketebilirsiniz), 1 dilim tuzsuz beyaz peynir, 5-6 adet tuzsuz zeytin, 1 yemek kaşığı zeytinyağı, bolca salatalık, domates ve yeşillik",
                    OgleYemegi = "Ton balıklı, zeytinyağlı yeşil salata + 1 dilim kepek ekmeği",
                    AksamYemegi = "Zeytinyağlı sebze yemeği + yarım yağlı yoğurt + salata",
                    AraOgun = "Meyve + yarım yağlı süt + çiğ badem (çiğ fındık, ceviz, kaju vb)"
                },
                Gun_4 = new Gun4
                {
                    kahvalti = "2 dilim kepekli ekmek (çavdar, ekşi mayalı ekmek de tüketebilirsiniz), 1 dilim tuzsuz beyaz peynir, 5-6 adet tuzsuz zeytin, 1 yemek kaşığı zeytinyağı, bolca salatalık, domates ve yeşillik",
                    OgleYemegi = "Ton balıklı, zeytinyağlı yeşil salata + 1 dilim kepek ekmeği",
                    AksamYemegi = "Zeytinyağlı sebze yemeği + yarım yağlı yoğurt + salata",
                    AraOgun = "Meyve + yarım yağlı süt + çiğ badem (çiğ fındık, ceviz, kaju vb)"
                },
                Gun_5 = new Gun5
                {
                    kahvalti = "2 dilim kepekli ekmek (çavdar, ekşi mayalı ekmek de tüketebilirsiniz), 1 dilim tuzsuz beyaz peynir, 5-6 adet tuzsuz zeytin, 1 yemek kaşığı zeytinyağı, bolca salatalık, domates ve yeşillik",
                    OgleYemegi = "Ton balıklı, zeytinyağlı yeşil salata + 1 dilim kepek ekmeği",
                    AksamYemegi = "Zeytinyağlı sebze yemeği + yarım yağlı yoğurt + salata",
                    AraOgun = "Meyve + yarım yağlı süt + çiğ badem (çiğ fındık, ceviz, kaju vb)"
                }
            };
            return root;
        }
        private object DenizDiyetXml()
        {
            DiyetBilgileriXml dbXml = new DiyetBilgileriXml
            {
                Diyet = new Diyet
                {
                    Gun_1 = new Gun_1
                    {
                        Kahvalti = "(Deniz Urunleri)2 dilim kepekli ekmek (çavdar, ekşi mayalı ekmek de tüketebilirsiniz), 1 dilim tuzsuz beyaz peynir, 5-6 adet tuzsuz zeytin, 1 yemek kaşığı zeytinyağı, bolca salatalık, domates ve yeşillik",
                        OgleYemegi = "Ton balıklı, zeytinyağlı yeşil salata + 1 dilim kepek ekmeği",
                        AksamYemegi = "Zeytinyağlı sebze yemeği + yarım yağlı yoğurt + salata",
                        AraOgun = "Meyve + yarım yağlı süt + çiğ badem (çiğ fındık, ceviz, kaju vb)"
                    },
                    Gun_2 = new Gun_2
                    {
                        Kahvalti = "2 dilim kepekli ekmek (çavdar, ekşi mayalı ekmek de tüketebilirsiniz), 1 dilim tuzsuz beyaz peynir, 5-6 adet tuzsuz zeytin, 1 yemek kaşığı zeytinyağı, bolca salatalık, domates ve yeşillik",
                        OgleYemegi = "Ton balıklı, zeytinyağlı yeşil salata + 1 dilim kepek ekmeği",
                        AksamYemegi = "Zeytinyağlı sebze yemeği + yarım yağlı yoğurt + salata",
                        AraOgun = "Meyve + yarım yağlı süt + çiğ badem (çiğ fındık, ceviz, kaju vb)"
                    },
                    Gun_3 = new Gun_3
                    {
                        Kahvalti = "2 dilim kepekli ekmek (çavdar, ekşi mayalı ekmek de tüketebilirsiniz), 1 dilim tuzsuz beyaz peynir, 5-6 adet tuzsuz zeytin, 1 yemek kaşığı zeytinyağı, bolca salatalık, domates ve yeşillik",
                        OgleYemegi = "Ton balıklı, zeytinyağlı yeşil salata + 1 dilim kepek ekmeği",
                        AksamYemegi = "Zeytinyağlı sebze yemeği + yarım yağlı yoğurt + salata",
                        AraOgun = "Meyve + yarım yağlı süt + çiğ badem (çiğ fındık, ceviz, kaju vb)"
                    },
                    Gun_4 = new Gun_4
                    {
                        Kahvalti = "2 dilim kepekli ekmek (çavdar, ekşi mayalı ekmek de tüketebilirsiniz), 1 dilim tuzsuz beyaz peynir, 5-6 adet tuzsuz zeytin, 1 yemek kaşığı zeytinyağı, bolca salatalık, domates ve yeşillik",
                        OgleYemegi = "Ton balıklı, zeytinyağlı yeşil salata + 1 dilim kepek ekmeği",
                        AksamYemegi = "Zeytinyağlı sebze yemeği + yarım yağlı yoğurt + salata",
                        AraOgun = "Meyve + yarım yağlı süt + çiğ badem (çiğ fındık, ceviz, kaju vb)"
                    },
                    Gun_5 = new Gun_5
                    {
                        Kahvalti = "2 dilim kepekli ekmek (çavdar, ekşi mayalı ekmek de tüketebilirsiniz), 1 dilim tuzsuz beyaz peynir, 5-6 adet tuzsuz zeytin, 1 yemek kaşığı zeytinyağı, bolca salatalık, domates ve yeşillik",
                        OgleYemegi = "Ton balıklı, zeytinyağlı yeşil salata + 1 dilim kepek ekmeği",
                        AksamYemegi = "Zeytinyağlı sebze yemeği + yarım yağlı yoğurt + salata",
                        AraOgun = "Meyve + yarım yağlı süt + çiğ badem (çiğ fındık, ceviz, kaju vb)"
                    }
                }
            };
            return dbXml;
        }
    }
}

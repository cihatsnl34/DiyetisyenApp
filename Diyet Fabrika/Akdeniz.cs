using DiyetisyenApp.Rapor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json; 

namespace DiyetisyenApp
{
    public  class Akdeniz:IDiyetTipi
    {
        public object Diyet()
        {
            return this.AkdenizDiyet();
        }
        private object AkdenizDiyet()
        {
            DiyetBilgileri diyetBilgileri = new DiyetBilgileri();
            
            var model = @"{
  'Gün 1': {
    ‘Kahvaltı’: [
      {
        'Diyet': ‘2 dilim kepekli ekmek (çavdar, ekşi mayalı ekmek de tüketebilirsiniz), 1 dilim tuzsuz beyaz peynir, 5-6 adet tuzsuz zeytin, 1 yemek kaşığı zeytinyağı, bolca salatalık, domates ve yeşillik’
      }
    ],
    ‘Öğlen yemeği’: [
      {
        'Diyet': ‘Ton balıklı, zeytinyağlı yeşil salata + 1 dilim kepek ekmeği’
      }
    ],
    ‘Akşam yemegi’: [
      {
        'Diyet': ‘Zeytinyağlı sebze yemeği + yarım yağlı yoğurt + salata’
      }
    ],
    ‘Ara öğünlerde’: [
      {
        'Diyet': ‘Meyve + yarım yağlı süt + çiğ badem (çiğ fındık, ceviz, kaju vb)’
      }
    ]
  },
  ‘Gün 2’: {
    ‘Kahvaltı’: [
      {
        'Diyet': ‘2 dilim kepekli ekmek (çavdar, ekşi mayalı ekmek de tüketebilirsiniz), 1 dilim tuzsuz beyaz peynir, 5-6 adet tuzsuz zeytin, 1 yemek kaşığı zeytinyağı, bolca salatalık, domates ve yeşillik’
      }
    ],
    ‘Öğlen yemeği’: [
      {
        'Diyet': ‘Ton balıklı, zeytinyağlı yeşil salata + 1 dilim kepek ekmeği’
      }
    ],
    ‘Akşam yemeğ’: [
      {
        'Diyet': ‘Zeytinyağlı sebze yemeği + yarım yağlı yoğurt + salata’
      }
    ],
    ‘Ara öğünlerde’: [
      {
       'Diyet': ‘Meyve + yarım yağlı süt + çiğ badem (çiğ fındık, ceviz, kaju vb)’
      }
    ]
  },
  ‘Gün 3’: {
    ‘Kahvaltı’: [
      {
        ‘Diyet’: ‘2 dilim kepekli ekmek (çavdar, ekşi mayalı ekmek de tüketebilirsiniz), 1 dilim tuzsuz beyaz peynir, 5-6 adet tuzsuz zeytin, 1 yemek kaşığı zeytinyağı, bolca salatalık, domates ve yeşillik’
      }
    ],
    ‘Öğlen yemeği’: [
      {
        ‘Diyet’: ‘Ton balıklı, zeytinyağlı yeşil salata + 1 dilim kepek ekmeği’
      }
    ],
    ‘Akşam yemeğ’: [
      {
        ‘Diyet’: ‘Zeytinyağlı sebze yemeği + yarım yağlı yoğurt + salata’
      }
    ],
    ‘Ara öğünlerde’: [
      {
        ‘Diyet’: ‘Meyve + yarım yağlı süt + çiğ badem (çiğ fındık, ceviz, kaju vb)’
      }
    ]
  },
  ‘Gün 4’: {
    ‘Kahvaltı’: [
      {
        ‘Diyet’: ‘2 dilim kepekli ekmek (çavdar, ekşi mayalı ekmek de tüketebilirsiniz), 1 dilim tuzsuz beyaz peynir, 5-6 adet tuzsuz zeytin, 1 yemek kaşığı zeytinyağı, bolca salatalık, domates ve yeşillik’
      }
    ],
    ‘Öğlen yemeği’: [
      {
        ‘Diyet’: ‘Ton balıklı, zeytinyağlı yeşil salata + 1 dilim kepek ekmeği’
      }
    ],
    ‘Akşam yemeğ’: [
      {
        ‘Diyet’: ‘Zeytinyağlı sebze yemeği + yarım yağlı yoğurt + salata’
      }
    ],
    ‘Ara öğünlerde’: [
      {
        ‘Diyet’: ‘Meyve + yarım yağlı süt + çiğ badem (çiğ fındık, ceviz, kaju vb)’
      }
    ]
  },
  ‘Gün 5’: {
    ‘Kahvaltı’: [
      {
        ‘Diyet’: ‘2 dilim kepekli ekmek (çavdar, ekşi mayalı ekmek de tüketebilirsiniz), 1 dilim tuzsuz beyaz peynir, 5-6 adet tuzsuz zeytin, 1 yemek kaşığı zeytinyağı, bolca salatalık, domates ve yeşillik’
      }
    ],
    ‘Öğlen yemeği’: [
      {
        ‘Diyet’: ‘Ton balıklı, zeytinyağlı yeşil salata + 1 dilim kepek ekmeği’
      }
    ],
    ‘Akşam yemegi’: [
      {
        ‘Diyet’: ‘Zeytinyağlı sebze yemeği + yarım yağlı yoğurt + salata’
      }
    ],
    ‘Ara öğünlerde’: [
      {
        ‘Diyet’: ‘Meyve + yarım yağlı süt + çiğ badem (çiğ fındık, ceviz, kaju vb)’
      }
    ]
  }
  
}
";



            var JsonObjectDiyet = JsonConvert.SerializeObject(model);
            return JsonObjectDiyet;
        }

    }
}

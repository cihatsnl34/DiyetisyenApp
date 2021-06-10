using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DiyetisyenApp.Rapor.XML
{

	[XmlRoot(ElementName = "hastaBilgileri")]
	public class HastaBilgileri
	{

		[XmlElement(ElementName = "hastaTc")]
		public string HastaTc { get; set; }

		[XmlElement(ElementName = "hastaAd")]
		public string HastaAd { get; set; }

		[XmlElement(ElementName = "hastaSoyad")]
		public string HastaSoyad { get; set; }

		[XmlElement(ElementName = "hastaYas")]
		public string HastaYas { get; set; }

		[XmlElement(ElementName = "hastaKilo")]
		public string HastaKilo { get; set; }

		[XmlElement(ElementName = "hastalik")]
		public string Hastalik { get; set; }

		[XmlElement(ElementName = "diyet")]
		public string Diyet { get; set; }
	}

	[XmlRoot(ElementName = "gun_1")]
	public class Gun_1
	{

		[XmlElement(ElementName = "kahvalti")]
		public string Kahvalti { get; set; }

		[XmlElement(ElementName = "OgleYemegi")]
		public string OgleYemegi { get; set; }

		[XmlElement(ElementName = "AksamYemegi")]
		public string AksamYemegi { get; set; }

		[XmlElement(ElementName = "AraOgun")]
		public string AraOgun { get; set; }
	}

	[XmlRoot(ElementName = "gun_2")]
	public class Gun_2
	{

		[XmlElement(ElementName = "kahvalti")]
		public string Kahvalti { get; set; }

		[XmlElement(ElementName = "OgleYemegi")]
		public string OgleYemegi { get; set; }

		[XmlElement(ElementName = "AksamYemegi")]
		public string AksamYemegi { get; set; }

		[XmlElement(ElementName = "AraOgun")]
		public string AraOgun { get; set; }
	}

	[XmlRoot(ElementName = "gun_3")]
	public class Gun_3
	{

		[XmlElement(ElementName = "kahvalti")]
		public string Kahvalti { get; set; }

		[XmlElement(ElementName = "OgleYemegi")]
		public string OgleYemegi { get; set; }

		[XmlElement(ElementName = "AksamYemegi")]
		public string AksamYemegi { get; set; }

		[XmlElement(ElementName = "AraOgun")]
		public string AraOgun { get; set; }
	}

	[XmlRoot(ElementName = "gun_4")]
	public class Gun_4
	{

		[XmlElement(ElementName = "kahvalti")]
		public string Kahvalti { get; set; }

		[XmlElement(ElementName = "OgleYemegi")]
		public string OgleYemegi { get; set; }

		[XmlElement(ElementName = "AksamYemegi")]
		public string AksamYemegi { get; set; }

		[XmlElement(ElementName = "AraOgun")]
		public string AraOgun { get; set; }
	}

	[XmlRoot(ElementName = "gun_5")]
	public class Gun_5
	{

		[XmlElement(ElementName = "kahvalti")]
		public string Kahvalti { get; set; }

		[XmlElement(ElementName = "OgleYemegi")]
		public string OgleYemegi { get; set; }

		[XmlElement(ElementName = "AksamYemegi")]
		public string AksamYemegi { get; set; }

		[XmlElement(ElementName = "AraOgun")]
		public string AraOgun { get; set; }
	}

	[XmlRoot(ElementName = "diyet")]
	public class Diyet
	{

		[XmlElement(ElementName = "gun_1")]
		public Gun_1 Gun_1 { get; set; }

		[XmlElement(ElementName = "gun_2")]
		public Gun_2 Gun_2 { get; set; }

		[XmlElement(ElementName = "gun_3")]
		public Gun_3 Gun_3 { get; set; }

		[XmlElement(ElementName = "gun_4")]
		public Gun_4 Gun_4 { get; set; }

		[XmlElement(ElementName = "gun_5")]
		public Gun_5 Gun_5 { get; set; }
	}

	[XmlRoot(ElementName = "DiyetBilgileriXml")]
	public class DiyetBilgileriXml
	{

		[XmlElement(ElementName = "hastaBilgileri")]
		public HastaBilgileri HastaBilgileri { get; set; }

		[XmlElement(ElementName = "diyet")]
		public Diyet Diyet { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Udemy.Entities;

namespace Udemy.BLL
{
    public class BusinessLogicLayer
    {
        Udemy.Core.DatabaseLogicLayer DLL;
        public BusinessLogicLayer()
        {
            DLL = new Core.DatabaseLogicLayer();
        }
        public int KullaniciKontrol(string KullaniciAdi, string Sifre)
        {
            int sonuc = 0;
            if (!string.IsNullOrEmpty(KullaniciAdi) && !string.IsNullOrEmpty(Sifre))
            {
                Kullanici kullanici = new Kullanici();
                kullanici.kullaniciAdi = KullaniciAdi;
                kullanici.sifre = Sifre;
                sonuc = DLL.KullaniciKontrol(kullanici);
            }
            else
            {
                sonuc = -100; //Eksik parametre hatası
            }
            return sonuc;
        }
        public int YeniKayit(Guid ID, string Isim, string Soyisim, string telefonI, string telefonII,
          string telefonIII, string adres, string email, string website, string aciklama)
        {
            int sonuc = 0;
            if (ID != Guid.Empty && !string.IsNullOrEmpty(Isim) && !string.IsNullOrEmpty(Soyisim) && !string.IsNullOrEmpty(telefonI))
            {
                RehberKayit Kayit = new RehberKayit();
                Kayit.id = ID;
                Kayit.isim = Isim;
                Kayit.soyisim = Soyisim;
                Kayit.telefon1 = telefonI;
                Kayit.telefonII = telefonII;
                Kayit.telefonIII = telefonIII;
                Kayit.Website = website;
                Kayit.EMailAdres = email;
                Kayit.Aciklama = aciklama;
                Kayit.Adres = adres;

                sonuc = DLL.YeniKayit(Kayit);
            }
            else
            {
                sonuc = -100; // Eksik parametre hatası
            }
            return sonuc;
        }
        public int KayitGuncelle(Guid ID, string Isim, string Soyisim, string telefonI, string telefonII,
          string telefonIII, string adres, string email, string website, string aciklama)
        {
            int sonuc = 0;
            if (ID != Guid.Empty && !string.IsNullOrEmpty(Isim) && !string.IsNullOrEmpty(Soyisim) && !string.IsNullOrEmpty(telefonI))
            {
                RehberKayit Kayit = new RehberKayit();
                Kayit.id = ID;
                Kayit.isim = Isim;
                Kayit.soyisim = Soyisim;
                Kayit.telefon1 = telefonI;
                Kayit.telefonII = telefonII;
                Kayit.telefonIII = telefonIII;
                Kayit.Website = website;
                Kayit.EMailAdres = email;
                Kayit.Aciklama = aciklama;
                Kayit.Adres = adres;
                sonuc = DLL.KayitGuncelle(Kayit);
            }
            else
            {
                sonuc = -100;
            }
            return sonuc;
        }
        public int KayitSil(Guid ID)
        {
            return DLL.KayitSil(ID);
        }
        public List<RehberKayit> RehberKayitlariGetir()
        {
            return DLL.RehberKayitlariGetir();
        }
        public int XMLDataVer()
        {
            int sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlarim = DLL.RehberKayitlariGetir();

                XDocument Doc = new XDocument(new XDeclaration("1.0.0.1", "UTF-8", "yes"),
                    new XElement("RehberKayitlar",
                    Kayitlarim.Select(i =>
                    new XElement("Kayit",
                    new XElement("ID", i.id),
                    new XElement("Isim", i.isim),
                    new XElement("Soyisim", i.soyisim),
                    new XElement("TelefonI", i.telefon1),
                    new XElement("TelefonII", i.telefonII),
                    new XElement("TelefonIII", i.telefonIII),
                    new XElement("EMailAdres", i.EMailAdres),
                    new XElement("WebSite", i.Website),
                    new XElement("Aciklama", i.Aciklama)
                    ))));
                Doc.Save(@"D:\TelefonRehberiDB\DataVerXML.xml");
                sonuc = 1;
            }
            catch (Exception)
            {
                throw;
            }
            return sonuc;
        }
        public int CSVDataVer()
        {
            int sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlar = DLL.RehberKayitlariGetir();
                StreamWriter SW = new StreamWriter(@"d:\TelefonRehberiDB\DataVerCSV.csv");
                CsvHelper.CsvWriter write = new CsvHelper.CsvWriter(SW);
                write.WriteHeader(typeof(RehberKayit));
                foreach (var item in Kayitlar)
                {
                    write.WriteRecord(item);
                }
                SW.Close();
                sonuc = 1;
            }
            catch (Exception)
            {
                throw;
            }
            return sonuc;
        }
        public int JSonDataVer()
        {
            int sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlar = DLL.RehberKayitlariGetir();
                string JSonText = Newtonsoft.Json.JsonConvert.SerializeObject(Kayitlar);
                File.WriteAllText(@"d:\TelefonRehberiDB\DataVerJSON.json", JSonText);
                sonuc = 1;
            }
            catch (Exception)
            {
                throw;
            }
            return sonuc;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Entities;

namespace Udemy.Core
{
    public class DatabaseLogicLayer
    {
        List<RehberKayit> Kayitlarim;
        public DatabaseLogicLayer()
        {
            Kayitlarim = new List<RehberKayit>();
            VeritabaniKontrol();
        }

        private void VeritabaniKontrol()
        {
            bool klasorKontrol = Directory.Exists(@"d:\TelefonRehberiDB\"); // klasör varlığı kontrol
            if (!klasorKontrol)
            {
                //Eğer böyle bir dosya d de yoksa...
                Directory.CreateDirectory(@"d:\TelefonRehberiDB\"); // klasor olusturma

                Kullanici Demo = new Kullanici();
                Demo.id = Guid.NewGuid();
                Demo.kullaniciAdi = "Demo";
                Demo.sifre = "Demo";

                string JsonKullaniciText = Newtonsoft.Json.JsonConvert.SerializeObject(Demo);
                File.WriteAllText(@"d:\TelefonRehberiDB\kullanici.json", JsonKullaniciText);

                // Önce demoyu json formatına çevirdim. Sonra kullanici.json 'a yazdım.
            }
        }

        public int YeniKayit(RehberKayit k)
        {
            int sonuc = 0;
            try
            {
                RehberKayitlariGetir(); //class seviyesinde oluşturmuş oldugum datamı doldurdum.(Varsa)
                                        // yoksa zaten bellekte hiç bir değeri yoktu. O şekilde yeni    
                                        // değer eklenmek üzere bekliyor.
                Kayitlarim.Add(k); // koleksiyona değeri ekledik.
                JsonDBGuncelle(); // varsa üzerine yazdı. yoksa yeni json oluşturdu.
                sonuc = 1;
            }
            catch (Exception)
            {
                sonuc = 0; // hata alırsam sonucun degeri = 0
            }
            return sonuc;
        }

        public int KayitGuncelle(RehberKayit k)
        {
            int sonuc = 0;
            try
            {
                RehberKayitlariGetir();
                int Index = Kayitlarim.FindIndex(i => i.id == k.id); // knın id si ile eslesen kaydımın index degerini getir.
                if (Index > -1)
                {
                    Kayitlarim[Index].isim = k.isim;
                    Kayitlarim[Index].soyisim = k.soyisim;
                    Kayitlarim[Index].telefon1 = k.telefon1;
                    Kayitlarim[Index].telefonII = k.telefonII;
                    Kayitlarim[Index].telefonIII = k.telefonIII;
                    Kayitlarim[Index].EMailAdres = k.EMailAdres;
                    Kayitlarim[Index].Website = k.Website;
                    Kayitlarim[Index].Aciklama = k.Aciklama;
                    Kayitlarim[Index].Adres = k.Adres;
                }
                JsonDBGuncelle();
                sonuc = 1;
            }

            catch (Exception)
            {
                throw;
            }
            return sonuc;
        }

        public int KayitSil(Guid ID)
        {
            int sonuc = 0;
            try
            {
                RehberKayitlariGetir();
                RehberKayit silinecekDeger = Kayitlarim.Find(i => i.id == ID);
                if (silinecekDeger != null)
                {
                    Kayitlarim.Remove(silinecekDeger);
                }
                JsonDBGuncelle();
                sonuc = 1;
            }
            catch (Exception)
            {
                throw;
            }
            return sonuc;
        }
        public List<RehberKayit> RehberKayitlariGetir()
        {
            if (File.Exists(@"D:\TelefonRehberiDB\Rehber.json"))
            {
                string JSonDbText = File.ReadAllText(@"D:\TelefonRehberiDB\Rehber.json");
                Kayitlarim = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RehberKayit>>(JSonDbText);
                //.json formatındaki text'i okudu. sonra JsonDbText'e atadı. sonra da onu deseriliaze 
                //işlemiyle rehberkayit listesine çevirip kayitlarim'a atadı.
                // GLOBAL OLARAK TANIMLADIĞIM KAYİTLARIM LİSTESİNİ YENİDEN GÜNCELLİYOR VE ONU DÖNDÜRÜYOR.
            } 
            return Kayitlarim;
        }
        public int KullaniciKontrol(Kullanici kullanici)
        {
            int kullaniciSonuc = 0;
            if (File.Exists(@"d:\TelefonRehberiDB\kullanici.json"))
            {
                string JsonKullaniciText = File.ReadAllText(@"d:\TelefonRehberiDB\kullanici.json");
                List<Kullanici> Kullanicilar = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(JsonKullaniciText);
                kullaniciSonuc = Kullanicilar.FindAll(I => I.kullaniciAdi == kullanici.kullaniciAdi && I.sifre == kullanici.sifre).ToList().Count();
            } 
            return kullaniciSonuc;
        }
        #region Yardimci Metotlar
        private void JsonDBGuncelle()
        {
            if (Kayitlarim != null && Kayitlarim.Count > 0)
            {
                string JsonDB = Newtonsoft.Json.JsonConvert.SerializeObject(Kayitlarim);
                File.WriteAllText(@"d:\TelefonRehberiDB\Rehber.json", JsonDB);
            }
        }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.Entities;

namespace Udemy.WFUI
{
    public partial class AnaForm : Form
    {
        Udemy.BLL.BusinessLogicLayer BLL;
        public AnaForm()
        {
            InitializeComponent();
            BLL = new BLL.BusinessLogicLayer();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            int Sonuc = BLL.YeniKayit(Guid.NewGuid(), txtIsim.Text, txtSoyisim.Text, txtTelefon1.Text, txtTelefon2.Text,
                txtTelefon3.Text, txtAdres.Text, txtEMail.Text, txtWebSite.Text, txtAciklama.Text);

            if (Sonuc > 0)
            {
                MessageBox.Show("Kaydiniz basarili bir sekilde eklendi");
                doldur();
            }
            else if (Sonuc == -100)
            {
                MessageBox.Show("Eksik parametre hatasi.Lütfen Isim Soyisim Telefon1 Alanlarını doldurunuz");
            }
            else
            {
                MessageBox.Show("Kayit ekleme isleminde hata olustu!");
            }
        }

        private void doldur()
        {
            List<RehberKayit> RehberKayitlarim = BLL.RehberKayitlariGetir();
            if (RehberKayitlarim != null && RehberKayitlarim.Count > 0)
            {
                lstListe.DataSource = RehberKayitlarim;
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void lstListe_DoubleClick(object sender, EventArgs e)
        {
            ListBox L = (ListBox)sender;
            RehberKayit SecilenDeger = (RehberKayit)L.SelectedItem; // burada databese gitmek daha uzun olur. O yüzden böyle yaptım.
            txtIsim.Text = SecilenDeger.isim;
            txtSoyisim.Text = SecilenDeger.soyisim;
            txtTelefon1.Text = SecilenDeger.telefon1;
            txtTelefon2.Text = SecilenDeger.telefonII;
            txtTelefon3.Text = SecilenDeger.telefonIII;
            txtEMail.Text = SecilenDeger.EMailAdres;
            txtWebSite.Text = SecilenDeger.Website;
            txtAdres.Text = SecilenDeger.Adres;
            txtAciklama.Text = SecilenDeger.Aciklama;
            grpBoxKayit.Text = "Rehber Kayit Güncelleme";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem != null)
            {
                // ((RehberKayit)lstListe.SelectedItem).id -> kısa kullanım
                RehberKayit K = (RehberKayit)lstListe.SelectedItem;
                int sonuc = BLL.KayitGuncelle(K.id, txtIsim.Text, txtSoyisim.Text, txtTelefon1.Text, txtTelefon2.Text, txtTelefon3.Text,
                    txtAdres.Text, txtEMail.Text, txtWebSite.Text, txtAciklama.Text);
                if (sonuc>0)
                {
                    MessageBox.Show("Kaydınız basarılı bir sekilde guncellendi.");
                    doldur();
                }
                else if (sonuc == -100)
                {
                    MessageBox.Show("Eksik parametre hatasi!");
                }
                else
                {
                    MessageBox.Show("Kayit guncelleme isleminde hata olustu!");
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Guid SilenecekID = ((RehberKayit)lstListe.SelectedItem).id;
            int sonuc = BLL.KayitSil(SilenecekID);
            if (sonuc > 0)
            {
                MessageBox.Show("Kaydınız basarılı bir sekilde silindi.");
                doldur();
            }
            else
            {
                MessageBox.Show("Kayit silme isleminde hata olustu!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc = BLL.XMLDataVer();
            if (sonuc>0)
            {
                lblDurum.Text = "Durum Açıklaması : XML Data verme " +"\n"+ "işlemi tamamlandı";
            }
            else
            {
                lblDurum.Text = "Durum Açıklaması : Hata Oluştu";
            }
        }

        private void btnCsvVer_Click(object sender, EventArgs e)
        {
            int sonuc = BLL.CSVDataVer();
            if (sonuc > 0)
            {
                lblDurum.Text = "Durum Açıklaması : CSV Data verme " + "\n" + "işlemi tamamlandı";
            }
            else
            {
                lblDurum.Text = "Durum Açıklaması : Hata Oluştu";
            }
        }

        private void btnJsonVer_Click(object sender, EventArgs e)
        {
            int sonuc =  BLL.JSonDataVer();
            if (sonuc>0)
            {
                lblDurum.Text = "Durum Açıklaması : JSON Data verme " + "\n" + "işlemi tamamlandı";
            }
            else
            {
                lblDurum.Text = "Durum Açıklaması : Hata Oluştu";
            }
        }
    }
}

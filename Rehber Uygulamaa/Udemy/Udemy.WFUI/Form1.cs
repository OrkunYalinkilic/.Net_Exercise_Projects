using System;
using System.Windows.Forms;

namespace Udemy.WFUI
{
    public partial class Form1 : Form
    {
        Udemy.BLL.BusinessLogicLayer BLL;
        // senin ellerinde bi yerde
        public Form1()
        {
            InitializeComponent();
            BLL = new BLL.BusinessLogicLayer();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            int sonuc = BLL.KullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text); 
            if (sonuc > 0)
            {
                AnaForm form = new AnaForm();
                form.Show();
            }
            else if (sonuc == -100)
            {
                MessageBox.Show("Form Alanlarini eksiksiz olarak doldurunuz.");
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı");
            }
        }
    }
}

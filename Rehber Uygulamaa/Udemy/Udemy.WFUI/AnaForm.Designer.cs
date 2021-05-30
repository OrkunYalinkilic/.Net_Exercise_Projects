namespace Udemy.WFUI
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBoxKayit = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefon1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefon2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWebSite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXmlVer = new System.Windows.Forms.Button();
            this.btnCsvVer = new System.Windows.Forms.Button();
            this.btnJsonVer = new System.Windows.Forms.Button();
            this.btnXmlAl = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpBoxKayit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstListe);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 708);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rehber Liste";
            // 
            // grpBoxKayit
            // 
            this.grpBoxKayit.Controls.Add(this.btnSil);
            this.grpBoxKayit.Controls.Add(this.btnGuncelle);
            this.grpBoxKayit.Controls.Add(this.btnYeniKayit);
            this.grpBoxKayit.Controls.Add(this.tabControl1);
            this.grpBoxKayit.Location = new System.Drawing.Point(404, 19);
            this.grpBoxKayit.Name = "grpBoxKayit";
            this.grpBoxKayit.Size = new System.Drawing.Size(867, 515);
            this.grpBoxKayit.TabIndex = 3;
            this.grpBoxKayit.TabStop = false;
            this.grpBoxKayit.Text = "Yeni Rehber Kaydı";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(855, 383);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtAdres);
            this.tabPage1.Controls.Add(this.txtWebSite);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtEMail);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtTelefon3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtTelefon2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtTelefon1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtSoyisim);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtIsim);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(847, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kişisel Bilgiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtAciklama);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(847, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Açıklama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(116, 40);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(310, 26);
            this.txtIsim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(116, 75);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(310, 26);
            this.txtSoyisim.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // txtTelefon1
            // 
            this.txtTelefon1.Location = new System.Drawing.Point(116, 112);
            this.txtTelefon1.Name = "txtTelefon1";
            this.txtTelefon1.Size = new System.Drawing.Size(310, 26);
            this.txtTelefon1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefon I";
            // 
            // txtTelefon2
            // 
            this.txtTelefon2.Location = new System.Drawing.Point(116, 150);
            this.txtTelefon2.Name = "txtTelefon2";
            this.txtTelefon2.Size = new System.Drawing.Size(310, 26);
            this.txtTelefon2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefon II";
            // 
            // txtTelefon3
            // 
            this.txtTelefon3.Location = new System.Drawing.Point(116, 186);
            this.txtTelefon3.Name = "txtTelefon3";
            this.txtTelefon3.Size = new System.Drawing.Size(310, 26);
            this.txtTelefon3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefon III";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(116, 224);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(310, 26);
            this.txtEMail.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "EMail Adres";
            // 
            // txtWebSite
            // 
            this.txtWebSite.Location = new System.Drawing.Point(116, 264);
            this.txtWebSite.Name = "txtWebSite";
            this.txtWebSite.Size = new System.Drawing.Size(310, 26);
            this.txtWebSite.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Web Site";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(458, 76);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(353, 214);
            this.txtAdres.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Adres";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(6, 20);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(827, 304);
            this.txtAciklama.TabIndex = 0;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(10, 410);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(847, 42);
            this.btnYeniKayit.TabIndex = 2;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(10, 458);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(411, 42);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDurum);
            this.groupBox3.Controls.Add(this.btnXmlAl);
            this.groupBox3.Controls.Add(this.btnCsvVer);
            this.groupBox3.Controls.Add(this.btnJsonVer);
            this.groupBox3.Controls.Add(this.btnXmlVer);
            this.groupBox3.Location = new System.Drawing.Point(404, 540);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(857, 187);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // btnXmlVer
            // 
            this.btnXmlVer.Location = new System.Drawing.Point(31, 49);
            this.btnXmlVer.Name = "btnXmlVer";
            this.btnXmlVer.Size = new System.Drawing.Size(121, 100);
            this.btnXmlVer.TabIndex = 0;
            this.btnXmlVer.Text = "XML VER";
            this.btnXmlVer.UseVisualStyleBackColor = true;
            this.btnXmlVer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCsvVer
            // 
            this.btnCsvVer.Location = new System.Drawing.Point(158, 49);
            this.btnCsvVer.Name = "btnCsvVer";
            this.btnCsvVer.Size = new System.Drawing.Size(121, 100);
            this.btnCsvVer.TabIndex = 0;
            this.btnCsvVer.Text = "CSV  VER";
            this.btnCsvVer.UseVisualStyleBackColor = true;
            this.btnCsvVer.Click += new System.EventHandler(this.btnCsvVer_Click);
            // 
            // btnJsonVer
            // 
            this.btnJsonVer.Location = new System.Drawing.Point(285, 49);
            this.btnJsonVer.Name = "btnJsonVer";
            this.btnJsonVer.Size = new System.Drawing.Size(121, 100);
            this.btnJsonVer.TabIndex = 0;
            this.btnJsonVer.Text = "JSON VER";
            this.btnJsonVer.UseVisualStyleBackColor = true;
            this.btnJsonVer.Click += new System.EventHandler(this.btnJsonVer_Click);
            // 
            // btnXmlAl
            // 
            this.btnXmlAl.Location = new System.Drawing.Point(412, 49);
            this.btnXmlAl.Name = "btnXmlAl";
            this.btnXmlAl.Size = new System.Drawing.Size(121, 100);
            this.btnXmlAl.TabIndex = 0;
            this.btnXmlAl.Text = "XML AL";
            this.btnXmlAl.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(485, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = " ";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(539, 84);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(207, 27);
            this.lblDurum.TabIndex = 1;
            this.lblDurum.Text = "Durum : Beklemede";
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 20;
            this.lstListe.Location = new System.Drawing.Point(6, 34);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(374, 664);
            this.lstListe.TabIndex = 0;
            this.lstListe.DoubleClick += new System.EventHandler(this.lstListe_DoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(427, 458);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(427, 42);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1288, 739);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxKayit);
            this.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpBoxKayit.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBoxKayit;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtWebSite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefon3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefon1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnXmlAl;
        private System.Windows.Forms.Button btnCsvVer;
        private System.Windows.Forms.Button btnJsonVer;
        private System.Windows.Forms.Button btnXmlVer;
        private System.Windows.Forms.Button btnSil;
    }
}
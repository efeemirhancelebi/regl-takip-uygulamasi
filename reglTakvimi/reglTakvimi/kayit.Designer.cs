namespace reglTakvimi
{
    partial class kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayit));
            lblTitle2 = new Label();
            lblTitle = new Label();
            lblAd = new Label();
            lblDogum = new Label();
            lblSoyad = new Label();
            lblMail = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtMail = new TextBox();
            dateDogum = new DateTimePicker();
            gboxCins = new GroupBox();
            radioNull = new RadioButton();
            radioKadin = new RadioButton();
            radioErkek = new RadioButton();
            btnKayit = new Button();
            lblSifre = new Label();
            txtSifre = new TextBox();
            gboxCins.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle2
            // 
            lblTitle2.AutoSize = true;
            lblTitle2.BackColor = Color.Transparent;
            lblTitle2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle2.Location = new Point(225, 19);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(123, 25);
            lblTitle2.TabIndex = 3;
            lblTitle2.Text = "Kayıt Sistemi";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(6, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(229, 45);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Regl Takvimi |";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.BackColor = Color.Transparent;
            lblAd.Location = new Point(68, 76);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(25, 15);
            lblAd.TabIndex = 4;
            lblAd.Text = "Ad:";
            // 
            // lblDogum
            // 
            lblDogum.AutoSize = true;
            lblDogum.BackColor = Color.Transparent;
            lblDogum.Location = new Point(12, 192);
            lblDogum.Name = "lblDogum";
            lblDogum.Size = new Size(81, 15);
            lblDogum.TabIndex = 5;
            lblDogum.Text = "Doğum Tarihi:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.BackColor = Color.Transparent;
            lblSoyad.Location = new Point(51, 105);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(42, 15);
            lblSoyad.TabIndex = 7;
            lblSoyad.Text = "Soyad:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.BackColor = Color.Transparent;
            lblMail.Location = new Point(43, 134);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(50, 15);
            lblMail.TabIndex = 8;
            lblMail.Text = "E-posta:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(99, 76);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(238, 23);
            txtAd.TabIndex = 10;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(99, 105);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(238, 23);
            txtSoyad.TabIndex = 11;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(99, 134);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(238, 23);
            txtMail.TabIndex = 12;
            // 
            // dateDogum
            // 
            dateDogum.Location = new Point(99, 192);
            dateDogum.Name = "dateDogum";
            dateDogum.Size = new Size(238, 23);
            dateDogum.TabIndex = 13;
            // 
            // gboxCins
            // 
            gboxCins.BackColor = Color.Transparent;
            gboxCins.Controls.Add(radioNull);
            gboxCins.Controls.Add(radioKadin);
            gboxCins.Controls.Add(radioErkek);
            gboxCins.Location = new Point(50, 221);
            gboxCins.Name = "gboxCins";
            gboxCins.Size = new Size(287, 40);
            gboxCins.TabIndex = 14;
            gboxCins.TabStop = false;
            gboxCins.Text = "Cinsiyet";
            // 
            // radioNull
            // 
            radioNull.AutoSize = true;
            radioNull.Location = new Point(126, 13);
            radioNull.Name = "radioNull";
            radioNull.Size = new Size(148, 19);
            radioNull.TabIndex = 2;
            radioNull.TabStop = true;
            radioNull.Text = "Belirtmek istemiyorum.";
            radioNull.UseVisualStyleBackColor = true;
            // 
            // radioKadin
            // 
            radioKadin.AutoSize = true;
            radioKadin.Location = new Point(65, 13);
            radioKadin.Name = "radioKadin";
            radioKadin.Size = new Size(55, 19);
            radioKadin.TabIndex = 1;
            radioKadin.TabStop = true;
            radioKadin.Text = "Kadın";
            radioKadin.UseVisualStyleBackColor = true;
            // 
            // radioErkek
            // 
            radioErkek.AutoSize = true;
            radioErkek.Location = new Point(6, 13);
            radioErkek.Name = "radioErkek";
            radioErkek.Size = new Size(53, 19);
            radioErkek.TabIndex = 0;
            radioErkek.TabStop = true;
            radioErkek.Text = "Erkek";
            radioErkek.UseVisualStyleBackColor = true;
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(12, 267);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(325, 35);
            btnKayit.TabIndex = 15;
            btnKayit.Text = "Kayıt işlemlerini tamamla!";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.BackColor = Color.Transparent;
            lblSifre.Location = new Point(55, 163);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(33, 15);
            lblSifre.TabIndex = 16;
            lblSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(99, 163);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(238, 23);
            txtSifre.TabIndex = 17;
            // 
            // kayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(349, 311);
            Controls.Add(txtSifre);
            Controls.Add(lblSifre);
            Controls.Add(btnKayit);
            Controls.Add(gboxCins);
            Controls.Add(dateDogum);
            Controls.Add(txtMail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblMail);
            Controls.Add(lblSoyad);
            Controls.Add(lblDogum);
            Controls.Add(lblAd);
            Controls.Add(lblTitle2);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "kayit";
            Text = "Kayıt İşlemleri";
            FormClosing += kayit_FormClosing;
            gboxCins.ResumeLayout(false);
            gboxCins.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle2;
        private Label lblTitle;
        private Label lblAd;
        private Label lblDogum;
        private Label lblSoyad;
        private Label lblMail;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtMail;
        private DateTimePicker dateDogum;
        private GroupBox gboxCins;
        private RadioButton radioKadin;
        private RadioButton radioErkek;
        private RadioButton radioNull;
        private Button btnKayit;
        private Label lblSifre;
        private TextBox txtSifre;
    }
}
namespace reglTakvimi
{
    partial class giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            lblTitle = new Label();
            lblTitle2 = new Label();
            lblMail = new Label();
            lblSifre = new Label();
            txtMail = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            btnKayit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(6, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(229, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Regl Takvimi |";
            // 
            // lblTitle2
            // 
            lblTitle2.AutoSize = true;
            lblTitle2.BackColor = Color.Transparent;
            lblTitle2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle2.Location = new Point(225, 19);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(50, 25);
            lblTitle2.TabIndex = 1;
            lblTitle2.Text = "Giriş";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.BackColor = Color.Transparent;
            lblMail.Location = new Point(12, 76);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(84, 15);
            lblMail.TabIndex = 2;
            lblMail.Text = "E-posta adresi:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.BackColor = Color.Transparent;
            lblSifre.Location = new Point(12, 140);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(33, 15);
            lblSifre.TabIndex = 3;
            lblSifre.Text = "Şifre:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(12, 94);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(260, 23);
            txtMail.TabIndex = 4;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(12, 158);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(260, 23);
            txtSifre.TabIndex = 5;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(12, 187);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(260, 35);
            btnGiris.TabIndex = 6;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(12, 228);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(260, 45);
            btnKayit.TabIndex = 7;
            btnKayit.Text = "Eğer hesabınız yok ise kayıt olarak uygulamayı kullanmaya başlayın!";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(284, 286);
            Controls.Add(btnKayit);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtMail);
            Controls.Add(lblSifre);
            Controls.Add(lblMail);
            Controls.Add(lblTitle2);
            Controls.Add(lblTitle);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(300, 325);
            MinimumSize = new Size(300, 325);
            Name = "giris";
            Text = "Regl Takvimi";
            FormClosing += giris_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTitle2;
        private Label lblMail;
        private Label lblSifre;
        private TextBox txtMail;
        private TextBox txtSifre;
        private Button btnGiris;
        private Button btnKayit;
    }
}

namespace reglTakvimi
{
    partial class uygulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uygulama));
            lblTitle2 = new Label();
            lblTitle = new Label();
            calendar = new MonthCalendar();
            lblTarih = new Label();
            btnReglGir = new Button();
            rtxtNotEkle = new RichTextBox();
            clistSemptom = new CheckedListBox();
            rtxtSemptomlar = new RichTextBox();
            btnReglGor = new Button();
            rtxtNot = new RichTextBox();
            cboxRegl = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle2
            // 
            lblTitle2.AutoSize = true;
            lblTitle2.BackColor = Color.Transparent;
            lblTitle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitle2.Location = new Point(225, 19);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(134, 42);
            lblTitle2.TabIndex = 5;
            lblTitle2.Text = "Aylık Regl\r\nTakip Uygulaması\r\n";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(6, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(229, 45);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Regl Takvimi |";
            // 
            // calendar
            // 
            calendar.Location = new Point(12, 100);
            calendar.Name = "calendar";
            calendar.TabIndex = 6;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(12, 76);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(56, 15);
            lblTarih.TabIndex = 7;
            lblTarih.Text = "Tarih Seç:";
            // 
            // btnReglGir
            // 
            btnReglGir.Location = new Point(251, 458);
            btnReglGir.Name = "btnReglGir";
            btnReglGir.Size = new Size(121, 35);
            btnReglGir.TabIndex = 9;
            btnReglGir.Text = "Regl Gir";
            btnReglGir.UseVisualStyleBackColor = true;
            btnReglGir.Click += btnReglGir_Click;
            // 
            // rtxtNotEkle
            // 
            rtxtNotEkle.Location = new Point(251, 290);
            rtxtNotEkle.Name = "rtxtNotEkle";
            rtxtNotEkle.Size = new Size(121, 162);
            rtxtNotEkle.TabIndex = 10;
            rtxtNotEkle.Text = "Not ekle (opsiyonel): ";
            rtxtNotEkle.TextChanged += rtxtNotEkle_TextChanged_1;
            // 
            // clistSemptom
            // 
            clistSemptom.FormattingEnabled = true;
            clistSemptom.Items.AddRange(new object[] { "Açlık", "Adet öncesi sendromu", "Ağrılar", "Akıntı / Damlama", "Aşerme", "Baş ağrısı", "Baş dönmesi", "Boyun ağrısı", "Gaz sancısı" });
            clistSemptom.Location = new Point(251, 100);
            clistSemptom.Name = "clistSemptom";
            clistSemptom.Size = new Size(121, 184);
            clistSemptom.TabIndex = 11;
            clistSemptom.SelectedIndexChanged += clistSemptom_SelectedIndexChanged;
            // 
            // rtxtSemptomlar
            // 
            rtxtSemptomlar.Location = new Point(12, 344);
            rtxtSemptomlar.Name = "rtxtSemptomlar";
            rtxtSemptomlar.Size = new Size(227, 108);
            rtxtSemptomlar.TabIndex = 12;
            rtxtSemptomlar.Text = "Seçtiğin tarihteki regl semptomların:";
            // 
            // btnReglGor
            // 
            btnReglGor.Location = new Point(12, 303);
            btnReglGor.Name = "btnReglGor";
            btnReglGor.Size = new Size(227, 35);
            btnReglGor.TabIndex = 13;
            btnReglGor.Text = "Seçtiğin Tarihteki Regl Döngünü Gör";
            btnReglGor.UseVisualStyleBackColor = true;
            btnReglGor.Click += btnReglGor_Click;
            // 
            // rtxtNot
            // 
            rtxtNot.Location = new Point(12, 458);
            rtxtNot.Name = "rtxtNot";
            rtxtNot.Size = new Size(223, 67);
            rtxtNot.TabIndex = 14;
            rtxtNot.Text = "Regl döngüne ait yazdığın not:";
            // 
            // cboxRegl
            // 
            cboxRegl.FormattingEnabled = true;
            cboxRegl.Location = new Point(12, 274);
            cboxRegl.Name = "cboxRegl";
            cboxRegl.Size = new Size(227, 23);
            cboxRegl.TabIndex = 15;
            cboxRegl.Text = "Önceki Regl Dönemlerin:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 76);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 16;
            label1.Text = "Semptomları Seç:";
            // 
            // uygulama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(384, 536);
            Controls.Add(label1);
            Controls.Add(cboxRegl);
            Controls.Add(rtxtSemptomlar);
            Controls.Add(rtxtNot);
            Controls.Add(btnReglGor);
            Controls.Add(clistSemptom);
            Controls.Add(rtxtNotEkle);
            Controls.Add(btnReglGir);
            Controls.Add(lblTarih);
            Controls.Add(calendar);
            Controls.Add(lblTitle2);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "uygulama";
            Text = "Regl Takvimi";
            FormClosing += uygulama_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle2;
        private Label lblTitle;
        private MonthCalendar calendar;
        private Label lblTarih;
        private Button btnReglGir;
        private RichTextBox rtxtNotEkle;
        private CheckedListBox clistSemptom;
        private RichTextBox rtxtSemptomlar;
        private Button btnReglGor;
        private RichTextBox rtxtNot;
        private ComboBox cboxRegl;
        private Label label1;
    }
}
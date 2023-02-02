namespace BurgerKing_Siparis_Uygulamasi
{
    partial class Siparis_Olustur
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMenuler = new System.Windows.Forms.ComboBox();
            this.groupBoxBoyutlar = new System.Windows.Forms.GroupBox();
            this.radioButtonBuyuk = new System.Windows.Forms.RadioButton();
            this.radioButtonOrta = new System.Windows.Forms.RadioButton();
            this.radioButtonKucuk = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.buttonSiparisEkle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMasraf = new System.Windows.Forms.Label();
            this.buttonSiparisiTamamla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxBoyutlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BurgerKing_Siparis_Uygulamasi.Properties.Resources.burger;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 122);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÜ SEÇİN";
            // 
            // comboBoxMenuler
            // 
            this.comboBoxMenuler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMenuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxMenuler.FormattingEnabled = true;
            this.comboBoxMenuler.Location = new System.Drawing.Point(14, 174);
            this.comboBoxMenuler.Name = "comboBoxMenuler";
            this.comboBoxMenuler.Size = new System.Drawing.Size(218, 28);
            this.comboBoxMenuler.TabIndex = 2;
            // 
            // groupBoxBoyutlar
            // 
            this.groupBoxBoyutlar.Controls.Add(this.radioButtonBuyuk);
            this.groupBoxBoyutlar.Controls.Add(this.radioButtonOrta);
            this.groupBoxBoyutlar.Controls.Add(this.radioButtonKucuk);
            this.groupBoxBoyutlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxBoyutlar.Location = new System.Drawing.Point(14, 225);
            this.groupBoxBoyutlar.Name = "groupBoxBoyutlar";
            this.groupBoxBoyutlar.Size = new System.Drawing.Size(218, 78);
            this.groupBoxBoyutlar.TabIndex = 3;
            this.groupBoxBoyutlar.TabStop = false;
            this.groupBoxBoyutlar.Text = "BOYUT SEÇİNİZ";
            // 
            // radioButtonBuyuk
            // 
            this.radioButtonBuyuk.AutoSize = true;
            this.radioButtonBuyuk.Location = new System.Drawing.Point(135, 41);
            this.radioButtonBuyuk.Name = "radioButtonBuyuk";
            this.radioButtonBuyuk.Size = new System.Drawing.Size(70, 20);
            this.radioButtonBuyuk.TabIndex = 2;
            this.radioButtonBuyuk.TabStop = true;
            this.radioButtonBuyuk.Text = "Büyük";
            this.radioButtonBuyuk.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrta
            // 
            this.radioButtonOrta.AutoSize = true;
            this.radioButtonOrta.Location = new System.Drawing.Point(76, 41);
            this.radioButtonOrta.Name = "radioButtonOrta";
            this.radioButtonOrta.Size = new System.Drawing.Size(57, 20);
            this.radioButtonOrta.TabIndex = 1;
            this.radioButtonOrta.TabStop = true;
            this.radioButtonOrta.Text = "Orta";
            this.radioButtonOrta.UseVisualStyleBackColor = true;
            // 
            // radioButtonKucuk
            // 
            this.radioButtonKucuk.AutoSize = true;
            this.radioButtonKucuk.Location = new System.Drawing.Point(6, 41);
            this.radioButtonKucuk.Name = "radioButtonKucuk";
            this.radioButtonKucuk.Size = new System.Drawing.Size(69, 20);
            this.radioButtonKucuk.TabIndex = 0;
            this.radioButtonKucuk.TabStop = true;
            this.radioButtonKucuk.Text = "Küçük";
            this.radioButtonKucuk.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 355);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(233, 215);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "MALZEME SEÇİN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 583);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "ADET :";
            // 
            // numericUpDownAdet
            // 
            this.numericUpDownAdet.Location = new System.Drawing.Point(112, 581);
            this.numericUpDownAdet.Name = "numericUpDownAdet";
            this.numericUpDownAdet.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownAdet.TabIndex = 7;
            // 
            // buttonSiparisEkle
            // 
            this.buttonSiparisEkle.Location = new System.Drawing.Point(14, 622);
            this.buttonSiparisEkle.Name = "buttonSiparisEkle";
            this.buttonSiparisEkle.Size = new System.Drawing.Size(218, 66);
            this.buttonSiparisEkle.TabIndex = 8;
            this.buttonSiparisEkle.Text = "SİPARİŞ EKLE";
            this.buttonSiparisEkle.UseVisualStyleBackColor = true;
            this.buttonSiparisEkle.Click += new System.EventHandler(this.buttonSiparisEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(253, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(708, 579);
            this.listBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "TOPLAM TUTAR";
            // 
            // labelMasraf
            // 
            this.labelMasraf.AutoSize = true;
            this.labelMasraf.ForeColor = System.Drawing.Color.Red;
            this.labelMasraf.Location = new System.Drawing.Point(439, 600);
            this.labelMasraf.Name = "labelMasraf";
            this.labelMasraf.Size = new System.Drawing.Size(0, 25);
            this.labelMasraf.TabIndex = 11;
            // 
            // buttonSiparisiTamamla
            // 
            this.buttonSiparisiTamamla.Location = new System.Drawing.Point(703, 600);
            this.buttonSiparisiTamamla.Name = "buttonSiparisiTamamla";
            this.buttonSiparisiTamamla.Size = new System.Drawing.Size(258, 88);
            this.buttonSiparisiTamamla.TabIndex = 12;
            this.buttonSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.buttonSiparisiTamamla.UseVisualStyleBackColor = true;
            this.buttonSiparisiTamamla.Click += new System.EventHandler(this.buttonSiparisiTamamla_Click);
            // 
            // Siparis_Olustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 700);
            this.Controls.Add(this.buttonSiparisiTamamla);
            this.Controls.Add(this.labelMasraf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonSiparisEkle);
            this.Controls.Add(this.numericUpDownAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBoxBoyutlar);
            this.Controls.Add(this.comboBoxMenuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Siparis_Olustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparis_Olustur";
            this.Load += new System.EventHandler(this.Siparis_Olustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxBoyutlar.ResumeLayout(false);
            this.groupBoxBoyutlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMenuler;
        private System.Windows.Forms.GroupBox groupBoxBoyutlar;
        private System.Windows.Forms.RadioButton radioButtonBuyuk;
        private System.Windows.Forms.RadioButton radioButtonOrta;
        private System.Windows.Forms.RadioButton radioButtonKucuk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownAdet;
        private System.Windows.Forms.Button buttonSiparisEkle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMasraf;
        private System.Windows.Forms.Button buttonSiparisiTamamla;
    }
}
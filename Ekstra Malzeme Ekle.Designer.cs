namespace BurgerKing_Siparis_Uygulamasi
{
    partial class Ekstra_Malzeme_Ekle
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
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownEkstraFiyat = new System.Windows.Forms.NumericUpDown();
            this.textBoxEkstra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkstraFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numericUpDownEkstraFiyat);
            this.groupBox1.Controls.Add(this.textBoxEkstra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 81);
            this.button1.TabIndex = 4;
            this.button1.Text = "EKSTRA MALZEME EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownEkstraFiyat
            // 
            this.numericUpDownEkstraFiyat.DecimalPlaces = 2;
            this.numericUpDownEkstraFiyat.Location = new System.Drawing.Point(287, 145);
            this.numericUpDownEkstraFiyat.Name = "numericUpDownEkstraFiyat";
            this.numericUpDownEkstraFiyat.Size = new System.Drawing.Size(193, 30);
            this.numericUpDownEkstraFiyat.TabIndex = 3;
            this.numericUpDownEkstraFiyat.ThousandsSeparator = true;
            // 
            // textBoxEkstra
            // 
            this.textBoxEkstra.Location = new System.Drawing.Point(287, 96);
            this.textBoxEkstra.Name = "textBoxEkstra";
            this.textBoxEkstra.Size = new System.Drawing.Size(193, 30);
            this.textBoxEkstra.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı :";
            // 
            // Ekstra_Malzeme_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 350);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Ekstra_Malzeme_Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekstra_Malzeme_Ekle";
            this.Load += new System.EventHandler(this.Ekstra_Malzeme_Ekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkstraFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownEkstraFiyat;
        private System.Windows.Forms.TextBox textBoxEkstra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
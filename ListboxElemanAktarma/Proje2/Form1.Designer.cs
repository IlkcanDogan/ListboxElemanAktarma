namespace Proje2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.clbGazeteler = new System.Windows.Forms.CheckedListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSayi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbGazeteler
            // 
            this.clbGazeteler.FormattingEnabled = true;
            this.clbGazeteler.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.clbGazeteler.Location = new System.Drawing.Point(12, 22);
            this.clbGazeteler.Name = "clbGazeteler";
            this.clbGazeteler.Size = new System.Drawing.Size(104, 229);
            this.clbGazeteler.TabIndex = 0;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(132, 104);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(75, 23);
            this.btnAktar.TabIndex = 2;
            this.btnAktar.Text = "Aktar>>";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Location = new System.Drawing.Point(222, 22);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(111, 225);
            this.lbListe.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eleman Sayısı :";
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Location = new System.Drawing.Point(300, 6);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(16, 13);
            this.lblSayi.TabIndex = 5;
            this.lblSayi.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 317);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.clbGazeteler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbGazeteler;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSayi;
    }
}


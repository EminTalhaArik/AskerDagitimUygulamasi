
namespace AskerDagitimUygulamasi
{
    partial class frm_anaSayfa
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
            this.gbx_veriGirisi = new System.Windows.Forms.GroupBox();
            this.btn_sehirEkle = new System.Windows.Forms.Button();
            this.tbx_askerEkle = new System.Windows.Forms.TextBox();
            this.btn_askerEkle = new System.Windows.Forms.Button();
            this.lbx_sehirler = new System.Windows.Forms.ListBox();
            this.tbx_sehirEkle = new System.Windows.Forms.TextBox();
            this.lbx_askerler = new System.Windows.Forms.ListBox();
            this.gbx_sonuclar = new System.Windows.Forms.GroupBox();
            this.btn_dagitimYap = new System.Windows.Forms.Button();
            this.lbx_eslestirmeler = new System.Windows.Forms.ListBox();
            this.gbx_veriGirisi.SuspendLayout();
            this.gbx_sonuclar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_veriGirisi
            // 
            this.gbx_veriGirisi.Controls.Add(this.btn_sehirEkle);
            this.gbx_veriGirisi.Controls.Add(this.tbx_askerEkle);
            this.gbx_veriGirisi.Controls.Add(this.btn_askerEkle);
            this.gbx_veriGirisi.Controls.Add(this.lbx_sehirler);
            this.gbx_veriGirisi.Controls.Add(this.tbx_sehirEkle);
            this.gbx_veriGirisi.Controls.Add(this.lbx_askerler);
            this.gbx_veriGirisi.Location = new System.Drawing.Point(12, 12);
            this.gbx_veriGirisi.Name = "gbx_veriGirisi";
            this.gbx_veriGirisi.Size = new System.Drawing.Size(439, 498);
            this.gbx_veriGirisi.TabIndex = 0;
            this.gbx_veriGirisi.TabStop = false;
            this.gbx_veriGirisi.Text = "Veri Girişi";
            // 
            // btn_sehirEkle
            // 
            this.btn_sehirEkle.Location = new System.Drawing.Point(227, 436);
            this.btn_sehirEkle.Name = "btn_sehirEkle";
            this.btn_sehirEkle.Size = new System.Drawing.Size(206, 36);
            this.btn_sehirEkle.TabIndex = 3;
            this.btn_sehirEkle.Text = "Şehir Ekle";
            this.btn_sehirEkle.UseVisualStyleBackColor = true;
            this.btn_sehirEkle.Click += new System.EventHandler(this.btn_sehirEkle_Click);
            // 
            // tbx_askerEkle
            // 
            this.tbx_askerEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_askerEkle.Location = new System.Drawing.Point(6, 403);
            this.tbx_askerEkle.Name = "tbx_askerEkle";
            this.tbx_askerEkle.Size = new System.Drawing.Size(206, 27);
            this.tbx_askerEkle.TabIndex = 2;
            // 
            // btn_askerEkle
            // 
            this.btn_askerEkle.Location = new System.Drawing.Point(6, 436);
            this.btn_askerEkle.Name = "btn_askerEkle";
            this.btn_askerEkle.Size = new System.Drawing.Size(206, 36);
            this.btn_askerEkle.TabIndex = 2;
            this.btn_askerEkle.Text = "Asker Ekle";
            this.btn_askerEkle.UseVisualStyleBackColor = true;
            this.btn_askerEkle.Click += new System.EventHandler(this.btn_askerEkle_Click);
            // 
            // lbx_sehirler
            // 
            this.lbx_sehirler.FormattingEnabled = true;
            this.lbx_sehirler.ItemHeight = 16;
            this.lbx_sehirler.Location = new System.Drawing.Point(227, 21);
            this.lbx_sehirler.Name = "lbx_sehirler";
            this.lbx_sehirler.Size = new System.Drawing.Size(206, 356);
            this.lbx_sehirler.TabIndex = 1;
            // 
            // tbx_sehirEkle
            // 
            this.tbx_sehirEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_sehirEkle.Location = new System.Drawing.Point(227, 403);
            this.tbx_sehirEkle.Name = "tbx_sehirEkle";
            this.tbx_sehirEkle.Size = new System.Drawing.Size(206, 27);
            this.tbx_sehirEkle.TabIndex = 1;
            // 
            // lbx_askerler
            // 
            this.lbx_askerler.FormattingEnabled = true;
            this.lbx_askerler.ItemHeight = 16;
            this.lbx_askerler.Location = new System.Drawing.Point(6, 21);
            this.lbx_askerler.Name = "lbx_askerler";
            this.lbx_askerler.Size = new System.Drawing.Size(206, 356);
            this.lbx_askerler.TabIndex = 0;
            // 
            // gbx_sonuclar
            // 
            this.gbx_sonuclar.Controls.Add(this.btn_dagitimYap);
            this.gbx_sonuclar.Controls.Add(this.lbx_eslestirmeler);
            this.gbx_sonuclar.Location = new System.Drawing.Point(457, 12);
            this.gbx_sonuclar.Name = "gbx_sonuclar";
            this.gbx_sonuclar.Size = new System.Drawing.Size(331, 498);
            this.gbx_sonuclar.TabIndex = 4;
            this.gbx_sonuclar.TabStop = false;
            this.gbx_sonuclar.Text = "Sonuçlar";
            // 
            // btn_dagitimYap
            // 
            this.btn_dagitimYap.Location = new System.Drawing.Point(6, 421);
            this.btn_dagitimYap.Name = "btn_dagitimYap";
            this.btn_dagitimYap.Size = new System.Drawing.Size(319, 36);
            this.btn_dagitimYap.TabIndex = 4;
            this.btn_dagitimYap.Text = "Dağıtım Yap";
            this.btn_dagitimYap.UseVisualStyleBackColor = true;
            this.btn_dagitimYap.Click += new System.EventHandler(this.btn_dagitimYap_Click);
            // 
            // lbx_eslestirmeler
            // 
            this.lbx_eslestirmeler.FormattingEnabled = true;
            this.lbx_eslestirmeler.ItemHeight = 16;
            this.lbx_eslestirmeler.Location = new System.Drawing.Point(6, 21);
            this.lbx_eslestirmeler.Name = "lbx_eslestirmeler";
            this.lbx_eslestirmeler.Size = new System.Drawing.Size(319, 372);
            this.lbx_eslestirmeler.TabIndex = 4;
            // 
            // frm_anaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.gbx_sonuclar);
            this.Controls.Add(this.gbx_veriGirisi);
            this.Name = "frm_anaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frm_anaSayfa_Load);
            this.gbx_veriGirisi.ResumeLayout(false);
            this.gbx_veriGirisi.PerformLayout();
            this.gbx_sonuclar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_veriGirisi;
        private System.Windows.Forms.Button btn_askerEkle;
        private System.Windows.Forms.TextBox tbx_sehirEkle;
        private System.Windows.Forms.ListBox lbx_askerler;
        private System.Windows.Forms.GroupBox gbx_sonuclar;
        private System.Windows.Forms.ListBox lbx_sehirler;
        private System.Windows.Forms.Button btn_sehirEkle;
        private System.Windows.Forms.TextBox tbx_askerEkle;
        private System.Windows.Forms.Button btn_dagitimYap;
        private System.Windows.Forms.ListBox lbx_eslestirmeler;
    }
}


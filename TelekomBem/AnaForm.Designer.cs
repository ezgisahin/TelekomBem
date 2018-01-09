namespace TelekomBem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnBilgiGiris = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbBilgi = new System.Windows.Forms.GroupBox();
            this.btnFirmaListe = new System.Windows.Forms.Button();
            this.btnFirmaKarti = new System.Windows.Forms.Button();
            this.gbUrun = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMarkaGiris = new System.Windows.Forms.Button();
            this.btnTurGiris = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbBilgi.SuspendLayout();
            this.gbUrun.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnUrun);
            this.panel1.Controls.Add(this.btnBilgiGiris);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 91);
            this.panel1.TabIndex = 0;
            // 
            // btnUrun
            // 
            this.btnUrun.Location = new System.Drawing.Point(158, 12);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(126, 70);
            this.btnUrun.TabIndex = 2;
            this.btnUrun.Text = "Ürün Giriş İşlemleri";
            this.btnUrun.UseVisualStyleBackColor = true;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnBilgiGiris
            // 
            this.btnBilgiGiris.Location = new System.Drawing.Point(12, 12);
            this.btnBilgiGiris.Name = "btnBilgiGiris";
            this.btnBilgiGiris.Size = new System.Drawing.Size(120, 70);
            this.btnBilgiGiris.TabIndex = 1;
            this.btnBilgiGiris.Text = "Bilgi Giriş İşlemleri";
            this.btnBilgiGiris.UseVisualStyleBackColor = true;
            this.btnBilgiGiris.Click += new System.EventHandler(this.btnBilgiGiris_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Location = new System.Drawing.Point(809, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(145, 70);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Programı Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.gbBilgi);
            this.panel2.Controls.Add(this.gbUrun);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 482);
            this.panel2.TabIndex = 1;
            // 
            // gbBilgi
            // 
            this.gbBilgi.BackColor = System.Drawing.Color.PapayaWhip;
            this.gbBilgi.Controls.Add(this.btnFirmaListe);
            this.gbBilgi.Controls.Add(this.btnFirmaKarti);
            this.gbBilgi.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbBilgi.Location = new System.Drawing.Point(136, 0);
            this.gbBilgi.Name = "gbBilgi";
            this.gbBilgi.Size = new System.Drawing.Size(132, 482);
            this.gbBilgi.TabIndex = 0;
            this.gbBilgi.TabStop = false;
            this.gbBilgi.Text = "Bilgi Giriş İşlmeleri";
            // 
            // btnFirmaListe
            // 
            this.btnFirmaListe.Location = new System.Drawing.Point(7, 50);
            this.btnFirmaListe.Name = "btnFirmaListe";
            this.btnFirmaListe.Size = new System.Drawing.Size(75, 23);
            this.btnFirmaListe.TabIndex = 1;
            this.btnFirmaListe.Text = "Firma Listesi";
            this.btnFirmaListe.UseVisualStyleBackColor = true;
            this.btnFirmaListe.Click += new System.EventHandler(this.btnFirmaListe_Click);
            // 
            // btnFirmaKarti
            // 
            this.btnFirmaKarti.Location = new System.Drawing.Point(7, 20);
            this.btnFirmaKarti.Name = "btnFirmaKarti";
            this.btnFirmaKarti.Size = new System.Drawing.Size(75, 23);
            this.btnFirmaKarti.TabIndex = 0;
            this.btnFirmaKarti.Text = "Firma Kartı";
            this.btnFirmaKarti.UseVisualStyleBackColor = true;
            this.btnFirmaKarti.Click += new System.EventHandler(this.btnFirmaKarti_Click);
            // 
            // gbUrun
            // 
            this.gbUrun.BackColor = System.Drawing.Color.DarkOrange;
            this.gbUrun.Controls.Add(this.button3);
            this.gbUrun.Controls.Add(this.btnMarkaGiris);
            this.gbUrun.Controls.Add(this.btnTurGiris);
            this.gbUrun.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbUrun.Location = new System.Drawing.Point(0, 0);
            this.gbUrun.Name = "gbUrun";
            this.gbUrun.Size = new System.Drawing.Size(136, 482);
            this.gbUrun.TabIndex = 1;
            this.gbUrun.TabStop = false;
            this.gbUrun.Text = "Ürün Giriş İşlemleri";
            this.gbUrun.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnMarkaGiris
            // 
            this.btnMarkaGiris.Location = new System.Drawing.Point(7, 79);
            this.btnMarkaGiris.Name = "btnMarkaGiris";
            this.btnMarkaGiris.Size = new System.Drawing.Size(112, 58);
            this.btnMarkaGiris.TabIndex = 1;
            this.btnMarkaGiris.Text = "Marka";
            this.btnMarkaGiris.UseVisualStyleBackColor = true;
            this.btnMarkaGiris.Click += new System.EventHandler(this.btnMarkaGiris_Click);
            // 
            // btnTurGiris
            // 
            this.btnTurGiris.Location = new System.Drawing.Point(7, 20);
            this.btnTurGiris.Name = "btnTurGiris";
            this.btnTurGiris.Size = new System.Drawing.Size(112, 53);
            this.btnTurGiris.TabIndex = 0;
            this.btnTurGiris.Text = "Tür";
            this.btnTurGiris.UseVisualStyleBackColor = true;
            this.btnTurGiris.Click += new System.EventHandler(this.btnTurGiris_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 573);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbBilgi.ResumeLayout(false);
            this.gbUrun.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnBilgiGiris;
        private System.Windows.Forms.GroupBox gbUrun;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMarkaGiris;
        private System.Windows.Forms.Button btnTurGiris;
        private System.Windows.Forms.GroupBox gbBilgi;
        private System.Windows.Forms.Button btnFirmaListe;
        private System.Windows.Forms.Button btnFirmaKarti;
    }
}


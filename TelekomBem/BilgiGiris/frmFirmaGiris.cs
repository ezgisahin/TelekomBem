using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelekomBem.Model;

namespace TelekomBem.BilgiGiris
{
    public partial class frmFirmaGiris : Form
    {
        DAL.TelekomContext DB = new DAL.TelekomContext();
        Fonksiyonlar.Formlar F = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar M = new Fonksiyonlar.Mesajlar();

        bool Edit = false;
        int firmaId = -1;

        public frmFirmaGiris()
        {
            InitializeComponent();
        }

        private void frmFirmaGiris_Load(object sender,EventArgs e)
        {
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            Temizle();
        }

        void Temizle()
        {
            foreach(Control CT in splitContainer1.Panel1.Controls)
                if(CT is System.Windows.Forms.TextBox)
                {
                    CT.Text = "";
                }
            firmaId = -1;
        }
        void YeniKaydet()
        {
            Firma frm = new Firma();
            frm.Adres = txtAdres.Text;
            frm.Email = txtEmail.Text;
            frm.FirmaAdi = txtFirma.Text;
            frm.Tel = txtTel.Text;
            frm.Vd = txtVd.Text;
            frm.Vn = txtVn.Text;
            DB.Firmalar.Add(frm);
            DB.SaveChanges();

            M.YeniKaydet("Yeni Kayıt Oluşturuldu");
            Temizle();
        }

        void Guncelle()
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && firmaId > 0 && M.Guncelle() == DialogResult.Yes)
                Guncelle();
            else if (firmaId < 0) YeniKaydet();Temizle();
          
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            var btnFADI = new Button();
            btnFADI.Size = new Size(25, txtFirma.ClientSize.Height + 2);
            btnFADI.Location = new Point(txtFirma.ClientSize.Width - btnFADI.Width, -1);
            btnFADI.Cursor = Cursors.Default;
            //btnFADI.Image = Properties.Resources.arrow_1176;
            txtFirma.Controls.Add(btnFADI);
            // Send EM_SETMARGINS to prevent text from disappearing underneath the button
            SendMessage(txtFirma.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnFADI.Width << 16));
            btnFADI.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            base.OnLoad(e);

            btnFADI.Click += btnFADI_Click;


        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void btnFADI_Click(object sender, EventArgs e)
        {
            int ID = F.FirmaListesi(true);
            if (ID > 0)
            {
                FirmaAC(ID);

            }
            AnaForm.Aktarma = -1;
        }
        public void FirmaAC(int ID)
        {
            try
            {
                Edit = true;
                firmaId = ID;
                Firma frm = DB.Firmalar.First(s => s.FirmaId == firmaId);
                txtAdres.Text = frm.Adres;
                txtEmail.Text = frm.Email;
                txtFirma.Text = frm.FirmaAdi;
                txtTel.Text = frm.Tel;
                txtVd.Text = frm.Vd;
                txtVn.Text = frm.Vn;
            }
            catch (Exception e)
            {

                M.Hata(e);
            }
        }
    }
}

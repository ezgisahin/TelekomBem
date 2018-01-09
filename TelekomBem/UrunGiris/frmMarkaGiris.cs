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

namespace TelekomBem.UrunGiris
{
    public partial class frmMarkaGiris : Form
    {
        DAL.TelekomContext DB = new DAL.TelekomContext();
        Fonksiyonlar.Mesajlar M = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar F = new Fonksiyonlar.Formlar();

        public bool Secim = false;
        int SecimID = -1;
        public int TurID = -1;
        int MarkaID = -1;
        bool Edit = false;

        public frmMarkaGiris()
        {
            InitializeComponent();
        }

        private void frmMarkaGiris_Load(object sender, EventArgs e)
        {
            Temizle();
            if(TurID > 0)
            {
                Tur tur = DB.Turler.Where(s => s.Id == TurID).First();
                txtTur.Text = tur.TAdi;
                txtTur.Enabled = false;
            }
            Listele();
        }

        void Temizle()
        {
            txtTur.Clear();
            txtMarka.Clear();
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = from s in DB.Markalar
                      where s.TID == TurID
                      select s;
            foreach(var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.MAdi;
                Liste.Rows[i].Cells[2].Value = k.Turler.TAdi;
                txtTur.Text = k.Turler.TAdi;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        void YeniKaydet()
        {
            try
            {
                Marka mrk = new Marka();
                mrk.MAdi = txtMarka.Text;
                mrk.TID = TurID;
                DB.Markalar.Add(mrk);
                DB.SaveChanges();
                M.YeniKaydet("Marka kaydı yapıldı..");
                Temizle();
            }
            catch (Exception e)
            {
                M.Hata(e);
            }
        }
        void Guncelle()
        {
            try
            {
                Marka mrk = DB.Markalar.First(s => s.Id == SecimID);
                mrk.MAdi = txtMarka.Text;
                mrk.TID = TurID;
                DB.SaveChanges();
                M.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                M.Hata(e);
            }
        }
        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = (int)Liste.CurrentRow.Cells[0].Value;
                txtMarka.Text = Liste.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception e)
            {
                Edit = false;
                SecimID = -1;
            }
        }
        void Sil()
        {
            try
            {
                DB.Markalar.Remove(DB.Markalar.First(s => s.Id == SecimID));
                DB.SaveChanges();
                Temizle();
            }
            catch (Exception e)
            {
                M.Hata(e);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && M.Guncelle() == DialogResult.Yes) Guncelle();
            else if (SecimID < 0) YeniKaydet(); Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && M.Sil() == DialogResult.Yes) Sil(); Temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            var btnTADI = new Button();
            btnTADI.Size = new Size(25, txtTur.ClientSize.Height + 2);
            btnTADI.Location = new Point(txtTur.ClientSize.Width - btnTADI.Width, -1);
            btnTADI.Cursor = Cursors.Default;
            //btnFADI.Image = Properties.Resources.arrow_1176;
            txtTur.Controls.Add(btnTADI);
            // Send EM_SETMARGINS to prevent text from disappearing underneath the button
            SendMessage(txtTur.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnTADI.Width << 16));
            btnTADI.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            base.OnLoad(e);

            btnTADI.Click += btnTADI_Click;


        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void btnTADI_Click(object sender, EventArgs e)
        {
            int ID = F.TurListesi(true);
            if (ID > 0)
            {
                TurAC(ID);

            }
            AnaForm.Aktarma = -1;
        }
        public void TurAC(int ID)
        {
            try
            {
                Edit = true;
                TurID = ID;
                Tur frm = DB.Turler.First(s => s.Id == TurID);
                txtTur.Text = frm.TAdi;
                Listele();
                
            }
            catch (Exception e)
            {

                M.Hata(e);
            }
        }

        private void Liste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Sec();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}

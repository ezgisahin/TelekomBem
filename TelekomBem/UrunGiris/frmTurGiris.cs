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
    public partial class frmTurGiris : Form
    {
        DAL.TelekomContext DB = new DAL.TelekomContext();
        Fonksiyonlar.Mesajlar M = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        int SecimId = -1;
        bool Edit = false;

        public frmTurGiris()
        {
            InitializeComponent();
        }

        private void frmTurGiris_Load(object sender, EventArgs e)
        {
            Temizle();
            Listele();
        }

        void Temizle()
        {
            txtTur.Text = "";//txtTur.Clear();Alternatif kullanım;
            Edit = false;
            SecimId = -1;
            Listele();
        }

        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in DB.Turler
                       select s).ToList();
            foreach(var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.TAdi;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        void YeniKaydet()
        {
            try
            {
                Tur tur = new Tur();
                tur.TAdi = txtTur.Text;
                DB.Turler.Add(tur);
                DB.SaveChanges();
                M.YeniKaydet("Tür girişi yapıldı.");
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
                Tur tur = DB.Turler.First(s => s.Id == SecimId);
                tur.TAdi = txtTur.Text;
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
                SecimId = (int)Liste.CurrentRow.Cells[0].Value;
                txtTur.Text = Liste.CurrentRow.Cells["tadi"].Value.ToString();
            }
            catch (Exception e)
            {
                Edit = false;
                SecimId = -1;
            }
        }

        void Sil()
        {
            try
            {
                DB.Turler.Remove(DB.Turler.First(s => s.Id == SecimId));
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
            if (Edit && SecimId > 0 && M.Guncelle() == DialogResult.Yes) Guncelle();
            else if (SecimId < 0) YeniKaydet();Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Edit && SecimId > 0 && M.Sil()==DialogResult.Yes)Sil();Temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Liste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Sec();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimId > 0)
            {
                AnaForm.Aktarma = SecimId;
                this.Close();
            }
        }
    }
}

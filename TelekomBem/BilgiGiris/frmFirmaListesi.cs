using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelekomBem.BilgiGiris
{
    public partial class frmFirmaListesi : Form
    {
        DAL.TelekomContext DB = new DAL.TelekomContext();
        Fonksiyonlar.Formlar F = new Fonksiyonlar.Formlar();

        int SecimID = -1;
        public bool Secim = false;

        public frmFirmaListesi()
        {
            InitializeComponent();
        }

        private void frmFirmaListesi_Load(object sender, EventArgs e)
        {
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            Listele();
        }

        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in DB.Firmalar select s).ToList();
            foreach(var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.FirmaId;
                Liste.Rows[i].Cells[1].Value = k.FirmaAdi;
                Liste.Rows[i].Cells[2].Value = k.Tel;
                Liste.Rows[i].Cells[3].Value = k.Email;
                i++;

            }
            Liste.AllowUserToAddRows = false;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
                //int a = (int)Liste.CurrentRow.Cells[0].Value; Alternatif kullanımı;
            }
            catch (Exception)
            {
                SecimID = -1;
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelekomBem
{
    public partial class AnaForm : Form
    {
        Fonksiyonlar.Formlar F = new Fonksiyonlar.Formlar();
        public static int Aktarma = -1;

        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Program Kapatılsın mı?","Programdan Çıkış Yapıyorsunuz!!!",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes) Application.ExitThread();
        }

        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            gbBilgi.Visible = true;
            gbUrun.Visible = false;
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            gbBilgi.Visible = false;
            gbUrun.Visible = true;
        }

        private void btnFirmaKarti_Click(object sender, EventArgs e)
        {
            F.FirmaGiris();
        }

        private void btnFirmaListe_Click(object sender, EventArgs e)
        {
            F.FirmaListesi();
        }

        private void btnTurGiris_Click(object sender, EventArgs e)
        {
            F.TurGiris();
        }

        private void btnMarkaGiris_Click(object sender, EventArgs e)
        {
            F.MarkaGiris();
        }
    }
}

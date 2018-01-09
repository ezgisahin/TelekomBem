using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelekomBem.Fonksiyonlar
{
    class Formlar
    {
        #region Bilgi Giriş
        public void FirmaGiris(bool AC = false, int firmaID = -1)
        {
            BilgiGiris.frmFirmaGiris frm = new BilgiGiris.frmFirmaGiris();
            frm.MdiParent = Application.OpenForms["AnaForm"] as AnaForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        
        public int FirmaListesi(bool Secim = false)
        {
            BilgiGiris.frmFirmaListesi frmlst = new BilgiGiris.frmFirmaListesi();
            if (Secim)
            {
                frmlst.Secim = Secim;
                frmlst.ShowDialog();
            }
            else
            {
                frmlst.MdiParent = AnaForm.ActiveForm;
                frmlst.Show();
            }
            return AnaForm.Aktarma;
        }
        #endregion
        #region Ürün Giriş
        //TurGiris

        public void TurGiris(bool AC = false, int TID = -1)
        {
            UrunGiris.frmTurGiris frm = new UrunGiris.frmTurGiris();
            frm.MdiParent = Application.OpenForms["AnaForm"] as AnaForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        public void MarkaGiris(bool AC = false, int MID = -1)
        {
            UrunGiris.frmMarkaGiris frm = new UrunGiris.frmMarkaGiris();
            frm.MdiParent = Application.OpenForms["AnaForm"] as AnaForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        public int TurListesi(bool Secim = false)
        {
            UrunGiris.frmTurGiris tur = new UrunGiris.frmTurGiris();
            if (Secim)
            {
                tur.Secim = Secim;
                tur.ShowDialog();
            }
            return AnaForm.Aktarma;
        }
        #endregion



    }
}

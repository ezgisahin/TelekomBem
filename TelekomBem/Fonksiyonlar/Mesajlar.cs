using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelekomBem.Fonksiyonlar
{
    class Mesajlar
    {
        public void YeniKaydet(string Mesaj)
        {
            MessageBox.Show(Mesaj, "Yeni kayıt girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili kayıt güncellenectir\n Güncelleme işlemini oanylıyormusunuz?", "Güncelleme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Kayit()
        {
            return MessageBox.Show("Aynı kaydı tekrardan kaydetmek istediğinize eminmisiniz?", "Kayıt Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Tüm kayıt kalıcı olarak silinecektir.\n Silme işlemini onaylıyormusunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        public void Guncelle(bool Guncelleme)
        {
            MessageBox.Show("Kayıt Güncellenmiştir.", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Sill(bool Silme)
        {
            MessageBox.Show("Kayıt Silinmiştir.", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Hata(Exception Hata)
        {
            MessageBox.Show(Hata.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

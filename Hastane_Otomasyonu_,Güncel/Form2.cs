using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu__Güncel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var username = tbxKullaniciAdi.Text;
            var password = tbxSifre.Text;
            var errorMessage = "";
            var isError = false;

            if (string.IsNullOrEmpty(username))
            {
                errorMessage += "kullanıcı adını boş geçemezsiniz  ";
                isError = true;
            }
            if (string.IsNullOrEmpty(password))
            {
                errorMessage += "\n Şifreyi boş geçemezsiniz";
                isError = true;
            }
            if (isError)
            {
                MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool loginState = Login(username, password);
            if (loginState)
            {
                //// MessageBox.Show("başarılı");
                Form4 form4 = new Form4();
                form4.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public bool Login(string username, string password) //login olup olmadığını test etmek için kullanılır.
        {
            HastaneOtomasyonuGüncelEntities context = new HastaneOtomasyonuGüncelEntities();
            var user = (from PersonelGirisi in context.PersonelGirisi where PersonelGirisi.PersonelKullaniciAdi == username && PersonelGirisi.PersonelSifre == password select PersonelGirisi).FirstOrDefault();
            if (user != null)
                return true;
            else
                return false;
        }
    }
    
}

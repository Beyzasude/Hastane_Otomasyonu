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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static string gonderilecekVeri;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            var username = tbxTCKN.Text;
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
                gonderilecekVeri = tbxTCKN.Text;
                //// MessageBox.Show("başarılı");
                Form6 form6 = new Form6();
                form6.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public bool Login(string username, string password) //login olup olmadığını test etmek için kullanılır.
        {
            HastaneOtomasyonuGüncelEntities context = new HastaneOtomasyonuGüncelEntities();
            var user = (from DoktorBilgileri in context.DoktorBilgileri where DoktorBilgileri.TCKN == username && DoktorBilgileri.DoktorSifre== password select DoktorBilgileri).FirstOrDefault();
            
            if (user != null)
                return true;
            else
                return false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbxTCKN_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

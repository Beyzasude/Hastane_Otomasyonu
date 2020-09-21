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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        HastaneOtomasyonuGüncelEntities context = new HastaneOtomasyonuGüncelEntities();


        private void cbxKanGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxKanGrubu.Text = "Seçiniz...";
        }

        private void tbxKaydet_Click(object sender, EventArgs e)
        {
            HastaBilgileri hastaBilgileri = new HastaBilgileri();
            hastaBilgileri.TCKN = tbxTCKN.Text;
            hastaBilgileri.HastaAdi = tbxHastaAdi.Text;
            hastaBilgileri.HastaSoyadi = tbxHastaSoyadi.Text;
            hastaBilgileri.HastaYas = Convert.ToInt32(tbxHastaYas.Text);
            hastaBilgileri.HastaKanGrubu = cbxKanGrubu.Text;
            hastaBilgileri.HastaCinsiyet = cbxCinsiyet.Text;
            hastaBilgileri.HastaMedeniHal = cbxMedeniHal.Text;
            hastaBilgileri.HastaTelefonNumarasi = tbxTelefonNumarasi.Text;
            hastaBilgileri.HastaDogumTarihi = dtDogumTarihi.CustomFormat;
            hastaBilgileri.HastaAdres = tbxAdres.Text;
            context.HastaBilgileri.Add(hastaBilgileri);
            context.SaveChanges();
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    List<HastaBilgileri> list = context.HastaBilgileri.ToList();
        //    dataGridView1.DataSource = list;
        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        public  int poliklinik1;
        private void Kaydet_Click(object sender, EventArgs e)
        {
            HastaIslemleri hastaIslemleri = new HastaIslemleri();
            hastaIslemleri.HastaId = tbxHastaId.Text;
            hastaIslemleri.PoliklinikId = Convert.ToInt32(cbxPoliklinik.SelectedValue);
            hastaIslemleri.DoktorId = Convert.ToInt32(cbxDoktor.SelectedValue);
            hastaIslemleri.DosyaNo = Convert.ToInt32(tbxDosyaNo.Text);
            hastaIslemleri.SevkTarihi = dtSevkTarihi.Value;
            poliklinik1 = Convert.ToInt32(cbxPoliklinik.SelectedValue);

            try
            {
                context.HastaIslemleri.Add(hastaIslemleri);
                context.SaveChanges();
                MessageBox.Show("Kayıt başarılı");
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnTaburcuEt_Click(object sender, EventArgs e)
        {

            string ID = tbxTaburcuHastaTCKN.Text;
            //var Taburcu = context.HastaIslemleri.Where(x => x.HastaId == ID).FirstOrDefault();
            var Taburcu = (from HastaIslemleri in context.HastaIslemleri where HastaIslemleri.HastaId == ID select HastaIslemleri).FirstOrDefault();
            Taburcu.OdemeSekli = tbxOdemeSekli.Text;
            Taburcu.ToplamTutar = Convert.ToInt32(tbxToplamTutar.Text);
            Taburcu.CıkısTarihi = dtCikisTarihi.Value;
            //context.HastaIslemleri.Add(Taburcu); eğer burayı eklersen 2 tane kayıt açıyor.
            context.SaveChanges();
            MessageBox.Show("Kayıt başarılı");

        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'hastaneOtomasyonuGüncelDataSet.DoktorBilgileri' table. You can move, or remove it, as needed.
            //this.doktorBilgileriTableAdapter.Fill(this.hastaneOtomasyonuGüncelDataSet.DoktorBilgileri);
            List<DoktorBilgileri> Doktor = context.DoktorBilgileri.Where(x=>x.PoliklinikId==poliklinik1).ToList();
            Doktor.Insert(0, new DoktorBilgileri() { Id = -1, DoktorAdi = "Seçiniz..." });
            cbxDoktor.DataSource = Doktor;
            cbxDoktor.DisplayMember = "DoktorAdi";
            cbxDoktor.ValueMember = "Id";
            cbxDoktor.SelectedIndex = 0;


            // TODO: This line of code loads data into the 'hastaneOtomasyonuGüncelDataSet.Poliklinikler' table. You can move, or remove it, as needed.
            //this.polikliniklerTableAdapter.Fill(this.hastaneOtomasyonuGüncelDataSet.Poliklinikler);
            var poliklinik = context.Poliklinikler.ToList();
            poliklinik.Insert(0, new Poliklinikler() { Id = -1, PoliklinikAdi = "Seçiniz..." });
            cbxPoliklinik.DataSource = poliklinik;
            cbxPoliklinik.DisplayMember = "PoliklinikAdi";
            cbxPoliklinik.ValueMember = "Id";
            cbxPoliklinik.SelectedIndex = 0;

        }

        private void cbxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void tbxTCKN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                HastaBilgileri hasta = context.HastaBilgileri.Where(x => x.TCKN == tbxTCKN.Text).FirstOrDefault();
                if (hasta != null)
                {
                    tbxHastaAdi.Text = hasta.HastaAdi;
                }
                else
                    MessageBox.Show("Hasta bulunamadı !");

            }
        }
    }
}

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
    public partial class Form6 : Form
    {
        HastaneOtomasyonuGüncelEntities context = new HastaneOtomasyonuGüncelEntities();
   
        public Form6()
        {

            InitializeComponent();
            var tc = Form3.gonderilecekVeri;
            var doktor = context.DoktorBilgileri.Where(p => p.TCKN == tc).FirstOrDefault();
            dataGridView1.AutoGenerateColumns = false;
            List<HastaIslemleri> list = context.HastaIslemleri.Where(w => w.DoktorId == doktor.Id).ToList();
            dataGridView1.DataSource = list;
            dataGridView1.Refresh();

            dataGridView2.AutoGenerateColumns = false;
            List<Recete> list2 = context.Recete.Where(w => w.DoktorId == doktor.Id).ToList();
            dataGridView2.DataSource = list2;
            dataGridView2.Refresh();
          


            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            //Kolon Başlığı
            dgvBtn.HeaderText = "Detay";
            // Butonun Text
            dgvBtn.Text = "Detay Getir";
            // Butonda Text Kullanılmasını aktifleştirme
            dgvBtn.UseColumnTextForButtonValue = true;
            // Buton çerçeve rengi
            dgvBtn.DefaultCellStyle.BackColor = Color.Blue;
            // Buton seçiliykenki çerçeve rengi
            dgvBtn.DefaultCellStyle.SelectionBackColor = Color.Red;
            // Butonun genişiliği
            dgvBtn.Width = 70;
            // DataGridView e ekleme
            dataGridView2.Columns.Add(dgvBtn);

         

        }

       

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
            if (column.DataPropertyName.Contains("."))
            {
                object data = dataGridView1.Rows[e.RowIndex].DataBoundItem;
                string[] properties = column.DataPropertyName.Split('.');
                for (int i = 0; i < properties.Length && data != null; i++)
                    data = data.GetType().GetProperty(properties[i]).GetValue(data);
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
            }
        }

        private void tbxTCKNArama_TextChanged(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = context.HastaIslemleri.Where(p => p.HastaBilgileri.TCKN.Contains(tbxTCKNArama.Text)).ToList();
            dataGridView1.DataSource = context.HastaIslemleri.Where(p => p.HastaBilgileri.HastaAdi.Contains(tbxTCKNArama.Text)).ToList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            var ilac = context.Ilac.ToList();
            ilac.Insert(0, new Ilac() { Id = -1, IlacAdi = "Seçiniz..." });
            cbxIlacAdi.DataSource = ilac;
            cbxIlacAdi.DisplayMember = "IlacAdi";
            cbxIlacAdi.ValueMember = "Id";
            cbxIlacAdi.SelectedIndex = 0;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Recete recete = new Recete();
            recete.HastaTCKN = tbxHastaTCKN.Text;
            recete.ReceteTarihi = dtReceteTarihi.Value;
            var doktor = context.HastaIslemleri.Where(w => w.HastaId == recete.HastaTCKN).FirstOrDefault();
            recete.DoktorId = doktor.DoktorId;
            context.Recete.Add(recete);
            context.SaveChanges();

            if(recete.Id > 0)
            {
                if(ilacAddList != null)
                {
                    foreach (ReceteIlac item in ilacAddList)
                    {
                        item.ReceteId = recete.Id;
                        context.ReceteIlac.Add(item);
                        context.SaveChanges();
                    }
                }
            }

            ilacAddList.Clear();
            dtReceteTarihi.Text = DateTime.Now.ToString();

            tbxHastaTCKN.Clear();
            listBox1.ClearSelected();




        }
        public static List<ReceteIlac> ilacAddList = new List<ReceteIlac>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxIlacAdi.SelectedIndex > 0)
            {
                ilacAddList.Add(new ReceteIlac()
                {
                    IlacId = Convert.ToInt32(cbxIlacAdi.SelectedValue),
                    KutuAdedi = Convert.ToInt32(tbxKutuAdedi.Text),
                    Doz = Convert.ToInt32(tbxIlacDozu.Text)
                });

                listBox1.Items.Add(cbxIlacAdi.Text);

                cbxIlacAdi.SelectedIndex = 0;
                tbxKutuAdedi.Text = string.Empty;
                tbxIlacDozu.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Seçim Yapınız!");
            }

            //var ilacList = context.Ilac.ToList();
            //var list =cbxIlacAdi.Text;

            //ReceteIlac receteIlac = new ReceteIlac();
            //var ilac = ilacList.Where(w => w.IlacAdi == list).FirstOrDefault();
            //receteIlac.IlacId = ilac.Id;
            ////listBox1.DataSource = ilac;
            ////listBox1.DisplayMember = "IlaAdi";
            ////listBox1.ValueMember = "Id";
            //listBox1.Items.Add(ilac.IlacAdi);
            //receteIlac.ReceteId = ReturnReceteId;
            //context.ReceteIlac.Add(receteIlac);
            //context.SaveChanges();


            //var ilacList = context.Ilac.ToList();
            //var list = cbxIlacAdi.Items;
            //foreach(var item in list)
            //{
            //    ReceteIlac receteIlac = new ReceteIlac();
            //    var ilac = ilacList.Where(w => w.IlacAdi == item).ToList();
            //    receteIlac.IlacId = 
            //
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ilacAddList.Remove(ilacAddList[listBox1.SelectedIndex]);

            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = dataGridView2.Columns[e.ColumnIndex];
            if (column.DataPropertyName.Contains("."))
            {
                object data = dataGridView2.Rows[e.RowIndex].DataBoundItem;
                string[] properties = column.DataPropertyName.Split('.');
                for (int i = 0; i < properties.Length && data != null; i++)
                    data = data.GetType().GetProperty(properties[i]).GetValue(data);
                dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
            }
        }
       
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns[7].Index)
            {
               int receteNumarasi = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[4].Value);
             Form7 form7 = new Form7(receteNumarasi);
                form7.ShowDialog();
            }   
        }
      //  public static int receteNumarasi;
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            //receteNumarasi = dataGridView2.CurrentRow.Cells[4].value;
        }
    }
}

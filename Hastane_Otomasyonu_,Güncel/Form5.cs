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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            List<HastaIslemleri> list = context.HastaIslemleri.ToList();
            //HastaTaburcu hastaTaburcu = context.HastaTaburcu.Where(w => w.Id == 1).FirstOrDefault();
            //List<Poliklinikler> poliList = context.Polikilinler.ToList();
            dataGridView1.DataSource = list;
            dataGridView1.Refresh();
        }
        HastaneOtomasyonuGüncelEntities context = new HastaneOtomasyonuGüncelEntities(); 

       

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneOtomasyonuGüncelDataSet.HastaIslemleri' table. You can move, or remove it, as needed.
            //this.hastaIslemleriTableAdapter.Fill(this.hastaneOtomasyonuGüncelDataSet.HastaIslemleri);
            // TODO: This line of code loads data into the 'hastaneOtomasyonuGüncelDataSet.HastaBilgileri' table. You can move, or remove it, as needed.
            //  this.hastaBilgileriTableAdapter.Fill(this.hastaneOtomasyonuGüncelDataSet.HastaBilgileri);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void tbxHastaAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.HastaIslemleri.Where(p => p.HastaBilgileri.TCKN.Contains(tbxHastaAra.Text)).ToList();
            dataGridView1.DataSource = context.HastaIslemleri.Where(p => p.HastaBilgileri.HastaAdi.Contains(tbxHastaAra.Text)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            //}
            //else
            //{
            //    MessageBox.Show("Lüffen silinecek satırı seçin.");
            //}
            string TC = tbxKayıtSilGüncelle.Text;
            var kayitSill = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var kayitSil1 = context.HastaIslemleri.Where(p => p.HastaBilgileri.TCKN == TC).FirstOrDefault();
            var kayitSil2 = context.HastaBilgileri.Where(p => p.TCKN == TC).FirstOrDefault();
            context.HastaIslemleri.Remove(kayitSil1);
            context.HastaBilgileri.Remove(kayitSil2);
            context.SaveChanges();
            MessageBox.Show("Silindi");
        }

        
    }
}

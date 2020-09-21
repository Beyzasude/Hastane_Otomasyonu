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
    public partial class Form7 : Form
    {
        HastaneOtomasyonuGüncelEntities context = new HastaneOtomasyonuGüncelEntities();
       
        public Form7(int receteNumarasi)
        {
            InitializeComponent();  
            var Id = receteNumarasi;
            List<ReceteIlac> receteIlac = context.ReceteIlac.Where(w => w.ReceteId == Id).ToList();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = receteIlac;
            dataGridView1.Refresh();
        }

        private void Form7_Load(object sender, EventArgs e)
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
    }
}

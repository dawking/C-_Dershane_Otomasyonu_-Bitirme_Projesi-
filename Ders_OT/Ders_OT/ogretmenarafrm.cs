using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dershane_Otomasyonu
{
    public partial class ogretmenarafrm : Form
    {
        public ogretmenarafrm()
        {
            InitializeComponent();
        }

        private void ogretmenarafrm_Load(object sender, EventArgs e)
        {

            dgyenile();

        }

        public void dgyenile() {

            this.ogretmenkayitTableAdapter.Fill(this.dershaneDataSet11.ogretmenkayit);
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dataGridView2.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dataGridView2.Rows[i].DefaultCellStyle = renk;
            }
            dataGridView2.Refresh();

        }

        private void ismegorearatxt_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView2.DataSource;
            bs.Filter = string.Format("ad like '%{0}%'", ismegorearatxt.Text.Trim().Replace("'", "''"));
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dataGridView2.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dataGridView2.Rows[i].DefaultCellStyle = renk;
            }
            dataGridView2.Refresh();
        }

        private void soyismegorearatxt_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView2.DataSource;
            bs.Filter = string.Format("soyad like '%{0}%'", soyismegorearatxt.Text.Trim().Replace("'", "''"));
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dataGridView2.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dataGridView2.Rows[i].DefaultCellStyle = renk;
            }
            dataGridView2.Refresh();
        }

        private void tcyegorearatxt_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView2.DataSource;
            bs.Filter = string.Format("tcno like '%{0}%'", tcyegorearatxt.Text.Trim().Replace("'", "''"));
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dataGridView2.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dataGridView2.Rows[i].DefaultCellStyle = renk;
            }
            dataGridView2.Refresh();
        }

      
    }
}

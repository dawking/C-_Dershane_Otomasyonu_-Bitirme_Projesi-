using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dershane_Otomasyonu
{
    public partial class ograrafrm : Form
    {
        public int ozelnum;
        public ograrafrm()
        {
            InitializeComponent();

        }



        private void ograrafrm_Load(object sender, EventArgs e)
        {


        }

        private void ograrafrm_Load_1(object sender, EventArgs e)
        {
            dgyenile();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dataGridView1.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }
        public void dgyenile() {

            this.ogrencikayitTableAdapter.Fill(this.dershaneDataSet.ogrencikayit);
        }

        private void ogrgizlechk_CheckedChanged(object sender, EventArgs e)
        {

            if (ogrgizlechk.Checked)
            {
                for (int i = 1; i < 11; i++)
                {
                    dataGridView1.Columns[i].Visible = false;
                }


            }
            else
            {
                for (int i = 0; i < 11; i++)
                {
                    dataGridView1.Columns[i].Visible = true;
                }
            }

        }

        private void veligizlechk_CheckedChanged(object sender, EventArgs e)
        {
            if (veligizlechk.Checked)
            {
                for (int i = 11; i < 17; i++)
                {
                    dataGridView1.Columns[i].Visible = false;
                }


            }
            else
            {
                for (int i = 11; i < 17; i++)
                {
                    dataGridView1.Columns[i].Visible = true;
                }
            }
        }

        private void ismegorearatxt_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("ad like '%{0}%'", ismegorearatxt.Text.Trim().Replace("'", "''"));
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dataGridView1.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
            dataGridView1.Refresh();
        }

        private void soyismegorearatxt_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("soyad like '%{0}%'", soyismegorearatxt.Text.Trim().Replace("'", "''"));
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dataGridView1.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
            dataGridView1.Refresh();
        }

        private void tcyegorearatxt_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("tcno like '%{0}%'", tcyegorearatxt.Text.Trim().Replace("'", "''"));
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dataGridView1.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ogrduzenlefrm ogrduzenle = new ogrduzenlefrm();
            ogrduzenle.ogrnumtxt.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ogrduzenle.txtAd.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ogrduzenle.txtSoyad.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ogrduzenle.txtTc.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ogrduzenle.txtCep.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ogrduzenle.txtDtarihi.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ogrduzenle.txtAdres.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            ogrduzenle.txtEposta.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            ogrduzenle.txtOkuladi.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            ogrduzenle.txtSinifi.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            ogrduzenle.txtAlani.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            ogrduzenle.txtVeliad.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            ogrduzenle.txtVelisoyad.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            ogrduzenle.txtVelitc.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            ogrduzenle.txtveliCep.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            ogrduzenle.txtVeliadres.Text = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
            ogrduzenle.txtVelieposta.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();

            ogrduzenle.Show();


        }



        private void button2_Click_1(object sender, EventArgs e)
        {

        }


        public void yenile(){

            ograrafrm obj = (ograrafrm)Application.OpenForms["ograrafrm"];
            obj.Close();

            ograrafrm yeni = new ograrafrm();
            yeni.Show();



        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ogrduzenlefrm duzenle = new ogrduzenlefrm();
            duzenle.Show();
            this.Dispose(false);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ogrgizlechk_CheckStateChanged(object sender, EventArgs e)
        {
            if (ogrgizlechk.CheckState==CheckState.Checked)
            {
                veligizlechk.CheckState = CheckState.Unchecked;
            }
            else
            {
                veligizlechk.CheckState = CheckState.Checked;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex==-1)
            {
                return;
            }
            ozelnum = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtozelnum.Text = ozelnum.ToString();
        }
    }
}

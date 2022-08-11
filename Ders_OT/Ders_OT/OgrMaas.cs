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
    public partial class OgrMaas : Form
    {
        public int ogrno;
        public SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
        public OgrMaas()
        {
            InitializeComponent();
        }

        private void OgrMaas_Load(object sender, EventArgs e)
        {
            
            con.Open();
            DataTable dt = new DataTable();
            string sqlogr = "Select o.OgretmenNum as [Ö.Num], o.ad +' '+o.soyad as [Adı Soyadı], o.tcno as [TC] from ogretmenkayit o";


            SqlDataAdapter da = new SqlDataAdapter(sqlogr, con);
            da.Fill(dt);
            dgogretmen.DataSource = dt;
            for (int i = 0; i < dgogretmen.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dgogretmen.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dgogretmen.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void dgogretmen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = dgogretmen.Rows[e.RowIndex];
            ogrno = Convert.ToInt32(dgogretmen.Rows[e.RowIndex].Cells[1].Value);
            int ogrnokontrol = ogrno;

            

            dgogretmen.Refresh();
            if (e.ColumnIndex == 0 )
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                    string maas = "insert into OgrMaas (OgretmenNum,OgrMaas,Aciklama) values(@OgretmenNum,@OgrMaas,@Aciklama)";
                    SqlCommand maascmd = new SqlCommand(maas, con);
                    maascmd.Parameters.AddWithValue("@OgretmenNum", ogrno);
                    maascmd.Parameters.AddWithValue("@OgrMaas", Convert.ToInt32(txtMiktar.Value));
                    maascmd.Parameters.AddWithValue("@Aciklama", txtaciklama.Text.ToString());
                    maascmd.ExecuteNonQuery();
  
               

                maasdoldur();
            }
            con.Close();
        }
        private void dgmaaslar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void maasdoldur() {


            string sqlmaas = "Select m.OgrMaas as [Ödenen(TL)], m.Aciklama as [Açıklama] from OgrMaas m where m.OgretmenNum='" + ogrno + "'";
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(sqlmaas, con);
            da2.Fill(dt2);
            dgmaaslar.DataSource = dt2;
            dgmaaslar.RowHeadersVisible = false;
            for (int i = 0; i < dgmaaslar.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dgmaaslar.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dgmaaslar.Rows[i].DefaultCellStyle = renk;
            }

        }

        private void dgogretmen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = dgogretmen.Rows[e.RowIndex];
            ogrno = Convert.ToInt32(dgogretmen.Rows[e.RowIndex].Cells[1].Value);
            maasdoldur();

        }

        private void ismegorearatxt_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgogretmen.DataSource;
            bs.Filter = string.Format("[Adı Soyadı] like '%{0}%'", ismegorearatxt.Text.Trim().Replace("'", "''"));

            for (int i = 0; i < dgogretmen.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dgogretmen.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dgogretmen.Rows[i].DefaultCellStyle = renk;
            }
            dgogretmen.Refresh();
        }

        private void tcyegorearatxt_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgogretmen.DataSource;
            bs.Filter = string.Format("[TC] like '%{0}%'", tcyegorearatxt.Text.Trim().Replace("'", "''"));

            for (int i = 0; i < dgogretmen.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dgogretmen.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dgogretmen.Rows[i].DefaultCellStyle = renk;
            }
            dgogretmen.Refresh();
        }

        private void dgogretmen_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dgogretmen.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dgogretmen.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dgogretmen.Rows[i].DefaultCellStyle = renk;
            }
            dgogretmen.Refresh();
        }

        private void dgmaaslar_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dgmaaslar.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dgmaaslar.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dgmaaslar.Rows[i].DefaultCellStyle = renk;
            }
        }
    }
}

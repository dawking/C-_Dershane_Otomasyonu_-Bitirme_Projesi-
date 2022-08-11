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
    public partial class devamsızlikekle : Form
    {

        public string no;
        public int ogrID;

        public devamsızlikekle()
        {
            InitializeComponent();
        }

        private void devamsızlikekle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dershaneDataSet5.Devamsizlik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.devamsizlikTableAdapter.Fill(this.dershaneDataSet5.Devamsizlik);
           
            this.ogrencikayitTableAdapter.Fill(this.dershaneDataSet.ogrencikayit);
            gridogrsec.RowHeadersVisible = false;
            griddvmszlk.RowHeadersVisible = false;
            griddvmszlk.Visible = false;
        }

        private void gridogrsec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            griddvmszlk.Visible = true;
            no = gridogrsec.Rows[e.RowIndex].Cells[0].Value.ToString();
            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
            string ogridsecim = "select ogrID from ogrencikayit where ogrnum='" + no + "'";
            con.Open();
            SqlCommand ogridcmd = new SqlCommand(ogridsecim, con);

            SqlDataReader cek = ogridcmd.ExecuteReader();
            cek.Read();
            ogrID = Convert.ToInt32(cek["ogrID"]);
            cek.Close();
            con.Close();


           
            BindingSource bs = new BindingSource();
            bs.DataSource = griddvmszlk.DataSource;
            bs.Filter = string.Format("ogrNum = {0}", ogrID.ToString().Trim().Replace("'", "''"));
            griddvmszlk.Refresh();



            this.devamsizlikTableAdapter.Fill(this.dershaneDataSet5.Devamsizlik);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int gun = 1;

            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand command = new SqlCommand("SELECT * From Devamsizlik WHERE ogrNum='" + ogrID + "'", con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())

            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string gelenveri = Convert.ToString(dr["tdvmszlk"]);
                gelenveri = gelenveri.Substring(0, gelenveri.Length - 4);
                cmd.CommandText = "update Devamsizlik set tdvmszlk='" + ((Convert.ToDouble(gelenveri) + gun) + " Gün") + "'WHERE ogrNum='" + ogrID + "'";
                dr.Close();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                dr.Close();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Devamsizlik (ogrNum, tdvmszlk) values (@ogrNum, @tdvmszlk)";
                cmd.Parameters.AddWithValue("@tdvmszlk", gun+" Gün");
                cmd.Parameters.AddWithValue("@ogrNum", ogrID);

                cmd.ExecuteNonQuery();
                con.Close();

            }
            this.devamsizlikTableAdapter.Fill(this.dershaneDataSet5.Devamsizlik);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            double gun = 0.5;
            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand command = new SqlCommand("SELECT * From Devamsizlik WHERE ogrNum='" + ogrID + "'", con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())

            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string gelenveri = Convert.ToString(dr["tdvmszlk"]);
                gelenveri = gelenveri.Substring(0, gelenveri.Length - 4);
                cmd.CommandText = "update Devamsizlik set tdvmszlk='" + ((Convert.ToDouble(gelenveri) + gun) + " Gün") + "'WHERE ogrNum='" + ogrID + "'";
                dr.Close();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                dr.Close();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Devamsizlik (ogrNum, tdvmszlk) values (@ogrNum, @tdvmszlk)";
                cmd.Parameters.AddWithValue("@tdvmszlk", gun + " Gün");
                cmd.Parameters.AddWithValue("@ogrNum", ogrID);

                cmd.ExecuteNonQuery();
                con.Close();

            }
            this.devamsizlikTableAdapter.Fill(this.dershaneDataSet5.Devamsizlik);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int gun = 1;

            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand command = new SqlCommand("SELECT * From Devamsizlik WHERE ogrNum='" + ogrID + "'", con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
               
            {
                
               
                

                     SqlCommand cmd = new SqlCommand();
                  cmd.Connection = con;
                  string gelenveri = Convert.ToString(dr["tdvmszlk"]);
                   gelenveri = gelenveri.Substring(0, gelenveri.Length - 4);
                if (Convert.ToDouble(gelenveri) > 0)
                {
                    cmd.CommandText = "update Devamsizlik set tdvmszlk='" + ((Convert.ToDouble(gelenveri) - gun) + " Gün") + "'WHERE ogrNum='" + ogrID + "'";
                    dr.Close();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                }


            }
            this.devamsizlikTableAdapter.Fill(this.dershaneDataSet5.Devamsizlik);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            double gun = 0.5;
            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand command = new SqlCommand("SELECT * From Devamsizlik WHERE ogrNum='" + ogrID + "'", con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())

            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string gelenveri = Convert.ToString(dr["tdvmszlk"]);
                gelenveri = gelenveri.Substring(0, gelenveri.Length - 4);
                if (Convert.ToDouble(gelenveri) >0)
                {
                    cmd.CommandText = "update Devamsizlik set tdvmszlk='" + ((Convert.ToDouble(gelenveri) - gun) + " Gün") + "'WHERE ogrNum='" + ogrID + "'";
                     dr.Close();
                      cmd.ExecuteNonQuery();
                     con.Close();
                   
                }
               
        
            
            }

            this.devamsizlikTableAdapter.Fill(this.dershaneDataSet5.Devamsizlik);
        }


    }
}

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
    public partial class grupeklefrm : Form
    {
        public grupeklefrm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          


            if (textBox1.Text=="")
            {
                MessageBox.Show("Grup İsmi Boş Olamaz");
            }
         else
           {

            
            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand command = new SqlCommand("SELECT * From Gruplar WHERE GrupAdi='" + textBox1.Text + "'", con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {

                if (textBox1.Text == dr["GrupAdi"].ToString())
                { 
                    dr.Close();
                    con.Close();
                    MessageBox.Show("Grup Mevcut!!!!");
                    
                }

            }

            else
            {
                    dr.Close();
                    string kayit = "INSERT INTO Gruplar(GrupAdi) values (@GrupAdi)";
                    SqlCommand komut = new SqlCommand(kayit, con);

                    komut.Parameters.AddWithValue("@GrupAdi", textBox1.Text);
                    komut.ExecuteNonQuery();
                    con.Close();
                MessageBox.Show("Grup Oluşturuldu!");
                if (Application.OpenForms.OfType<Ogrkayitfrm>().Any())
                {
                    Ogrkayitfrm ara = (Ogrkayitfrm)Application.OpenForms["Ogrkayitfrm"];
                    ara.comboboxdoldur();
                }
                this.Close();

            }
           }


        }
    }
}

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
    public partial class sifredegistirfrm : Form
    {
        public sifredegistirfrm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=dershane;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * From yetkiligiris WHERE kadi='" + txtKullaniciAdi.Text + "' and sifre='" + txtEskisifre.Text + "'", con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                
                if (txtKullaniciAdi.Text==dr["kadi"].ToString() && txtEskisifre.Text==dr["sifre"].ToString())
                {
                    dr.Close();
                    
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                    if (txtYeniSifre.Text==txtYenisifreOnay.Text)
                    {
                        cmd.CommandText = "update yetkiligiris set sifre='" + txtYeniSifre.Text + "'WHERE kadi='" + txtKullaniciAdi.Text +"'";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Şifre Güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("Yeni şifreler uyuşmuyor");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Giriş bilgilerinizi kontrol ediniz");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız veya şifreniz uyuşmuyor");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sifredegistirfrm_Load(object sender, EventArgs e)
        {

        }
    }
}


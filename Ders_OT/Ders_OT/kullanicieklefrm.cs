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
    public partial class kullanicieklefrm : Form
    {
        public kullanicieklefrm()
        {
            InitializeComponent();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * From yetkiligiris where kadi='" +txtAdminKadi.Text+ "' and sifre='"+ txtAdminSifre.Text + "'",con);
            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {

                if (txtAdminKadi.Text==dr["kadi"].ToString() && txtAdminSifre.Text==dr["sifre"].ToString())
                {

                    dr.Close();

                    string kayit = "insert into yetkiligiris (kadi,sifre) values(@kadi, @sifre)";
                    SqlCommand komut = new SqlCommand(kayit, con);
                    komut.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@sifre", txtSifreBelirle.Text);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Yeni Yetkili Kayıt Kayıt İşlemi Tamamlanmıştır");


                    con.Close();
                }
                else
                {
                    MessageBox.Show("Giriş Bilgilerinizi Kontrol Ediniz!");
                    con.Close();
                }




            }

            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifreniz Uyuşmuyor");
                con.Close();
            }






        }

        private void txtKullaniciAdi_MouseClick(object sender, MouseEventArgs e)
        {
            txtKullaniciAdi.Text = "";
        }
    }
}

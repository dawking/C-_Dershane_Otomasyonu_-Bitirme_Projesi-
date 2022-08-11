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

    
    public partial class ogretmenkayitfrm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
        public ogretmenkayitfrm()
        {
            InitializeComponent();
        }

        private void ogretmenkayitfrm_Load(object sender, EventArgs e)
        {
           

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {

            try
            {

           
            
            if (con.State==ConnectionState.Closed)
                con.Open();
                
                string kayit = "INSERT INTO ogretmenkayit(ad,soyad,tcno,cep,dtarihi,brans,mezunoldugubolum,adres) values (@ad,@soyad,@tcno,@cep,@dtarihi,@brans,@mezunoldugubolum,@adres)";
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@tcno", txtTc.Text);
                komut.Parameters.AddWithValue("@cep", txtCep.Text);
                komut.Parameters.AddWithValue("@dtarihi", txtDtarihi.Text);
                komut.Parameters.AddWithValue("@brans", txtBrans.Text);
                komut.Parameters.AddWithValue("@mezunoldugubolum", txtMezun.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut.ExecuteNonQuery();
                con.Close();
                if (Application.OpenForms.OfType<ogretmenarafrm>().Any())
                {
                    ogretmenarafrm ara = (ogretmenarafrm)Application.OpenForms["ogretmenarafrm"];
                    ara.dgyenile();
                }
                MessageBox.Show("Öğretmen Kayıt İşlemi Başarı İle Gerçekleşti.");
            }
                catch (Exception hata)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            
           
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            {
               ogretmenkayitfrm yeni = new ogretmenkayitfrm();
               yeni.Show();
                this.Dispose(false);
            }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

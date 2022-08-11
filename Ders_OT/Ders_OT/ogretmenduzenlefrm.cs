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
    public partial class ogretmenduzenlefrm : Form
    {
        public ogretmenduzenlefrm()
        {
            InitializeComponent();
        }

        void numaracek()
        {
            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
            con.Open();
            SqlCommand cek = new SqlCommand("select * from ogretmenkayit", con);
            SqlDataReader oku = cek.ExecuteReader();
            while (oku.Read())
            {

                comboBox1.Items.Add(oku["OgretmenNum"]);

            }
            con.Close();
            oku.Close();
        }

        private void ogretmenduzenlefrm_Load(object sender, EventArgs e)
        {
            numaracek();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
                con.Open();
                string sql = "Select * from ogretmenkayit where OgretmenNum=@OgretmenNum";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@OgretmenNum", comboBox1.SelectedItem);
                SqlDataReader sonuc = cmd.ExecuteReader();
                while (sonuc.Read())
                {
                    txtAd.Text = sonuc["ad"].ToString();
                    txtSoyad.Text = sonuc["soyad"].ToString();
                    txtTc.Text = sonuc["tcno"].ToString();
                    txtCep.Text = sonuc["cep"].ToString();
                    txtDtarihi.Text = sonuc["dtarihi"].ToString();
                    txtAdres.Text = sonuc["adres"].ToString();
                    txtBrans.Text = sonuc["brans"].ToString();
                    txtMezun.Text = sonuc["mezunoldugubolum"].ToString();

                }

                con.Close();
                sonuc.Close();
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == comboBox1.SelectedIndex + 1)
            {
                MessageBox.Show("Son Öğretmeni Görüntülüyorsunuz!");
            }
            else
            {
                comboBox1.SelectedIndex += 1;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("En Başa Döndünüz!");
            }
            else
            {
                comboBox1.SelectedIndex -= 1;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");

            string sil = "DELETE FROM ogretmenkayit " + "WHERE OgretmenNum= '" + comboBox1.Text + "' ";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sil, baglanti);


            komut.ExecuteNonQuery();
            baglanti.Close();
            ogretmenduzenlefrm yeni = new ogretmenduzenlefrm();
           
            yeni.Show();
            MessageBox.Show("Kayıt başarıyla silindi");
            this.Dispose(false);
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=dershane;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update ogretmenkayit set ad='" + txtAd.Text + "', soyad ='" + txtSoyad.Text + "', tcno ='" + txtTc.Text + "' , cep ='" + txtCep.Text + "' , dtarihi ='" + txtDtarihi.Text + "', brans ='" + txtBrans.Text + "', mezunoldugubolum ='" + txtMezun.Text + "', adres ='" + txtAdres.Text + "'  WHERE OgretmenNum='" + comboBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            if (Application.OpenForms.OfType<ogretmenarafrm>().Any())
            {
                ogretmenarafrm ara = (ogretmenarafrm)Application.OpenForms["ogretmenarafrm"];
                ara.dgyenile();
            }

            MessageBox.Show("Kayıt Başarı İle Güncellendi!", "UYARI");
        }
    }
}

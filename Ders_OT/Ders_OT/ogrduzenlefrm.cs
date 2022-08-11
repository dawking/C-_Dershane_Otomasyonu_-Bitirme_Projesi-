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
    public partial class ogrduzenlefrm : Form
    {
        public int ogrid;
        public int grupid;
        public int ozelnumara;
        public int alanid;
        public int duzeyid;
      public  SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");

        public ogrduzenlefrm()
        {
            InitializeComponent();
        }

        private void ogrduzenlefrm_Load(object sender, EventArgs e)
        {
            numaracek();
            if (comboBox1.Items.Count != 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {

                MessageBox.Show("Kayıtlı Öğrenci Bulunamadı");
                this.Close();
            }
            con.Open();
            SqlCommand command2 = new SqlCommand("SELECT * From Gruplar", con);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                txtGrup.Items.Add(dr2["GrupAdi"]);
            }
            dr2.Close();
            
            SqlCommand cmdogridcek = new SqlCommand("select ogrID from ogrencikayit where ogrnum='" + Convert.ToInt32(comboBox1.Text) + "'",con);

            SqlDataReader ogridcek = cmdogridcek.ExecuteReader();
           
            ogridcek.Read();
            ogrid = Convert.ToInt32(ogridcek["ogrID"]);
            ogridcek.Close();
            con.Close();
            if (Application.OpenForms.OfType<ograrafrm>().Any())
            {
                ograrafrm ara = (ograrafrm)Application.OpenForms["ograrafrm"];
                ozelnumara = Convert.ToInt32(ara.txtozelnum.Text);
                comboBox1.Text = ozelnumara.ToString();
            }
            
        }


        void numaracek() {
            
            con.Open();
            SqlCommand cek = new SqlCommand("select * from ogrencikayit", con);
            SqlDataReader oku = cek.ExecuteReader();
            while (oku.Read()) {

                comboBox1.Items.Add(oku["ogrnum"]);

            }
            con.Close();
            oku.Close();

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
            con.Open();
            string sql = "Select * from ogrencikayit where ogrnum=@ogrnum";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ogrnum", comboBox1.SelectedItem);
            SqlDataReader sonuc = cmd.ExecuteReader();
            while (sonuc.Read())
            {
                txtAd.Text = sonuc["ad"].ToString();
                txtSoyad.Text = sonuc["soyad"].ToString();
                txtTc.Text = sonuc["tcno"].ToString();
                txtCep.Text = sonuc["ceptel"].ToString();
                txtDtarihi.Text = sonuc["dtarihi"].ToString();
                txtEposta.Text = sonuc["ogreposta"].ToString();
                txtAdres.Text = sonuc["adres"].ToString();
                txtOkuladi.Text = sonuc["okuladi"].ToString();
                txtSinifi.Text = sonuc["sinifi"].ToString();
                txtAlani.Text = sonuc["alani"].ToString();
                txtVeliad.Text = sonuc["veliadi"].ToString();
                txtVelisoyad.Text = sonuc["velisoyadi"].ToString();
                txtVelitc.Text = sonuc["velitc"].ToString();
                txtveliCep.Text = sonuc["velicep"].ToString();
                txtVeliadres.Text = sonuc["veliadres"].ToString();
                txtveliDtarihi.Text = sonuc["velidtarihi"].ToString();
                txtVelieposta.Text = sonuc["velieposta"].ToString();
                
              
            }

            con.Close();
            sonuc.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {


            if (comboBox1.Items.Count == comboBox1.SelectedIndex + 1)
            {
                MessageBox.Show("Son Öğrenciyi Görüntülüyorsunuz!");
            }
            else
            {
                comboBox1.SelectedIndex += 1;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex==0)
            {
                MessageBox.Show("En Başa Döndünüz!");
            }
            else
            {
                comboBox1.SelectedIndex -= 1;
            }
               
            
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=dershane;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update ogrencikayit set ad='" + txtAd.Text + "', soyad ='" + txtSoyad.Text + "', tcno ='" + txtTc.Text + "' , ceptel ='" + txtCep.Text + "' , dtarihi ='" + txtDtarihi.Text + "' , ogreposta ='" + txtEposta.Text + "' , adres ='" + txtAdres.Text + "' , okuladi ='" + txtOkuladi.Text + "' , sinifi ='" + txtSinifi.SelectedItem + "' , alani ='" + txtAlani.SelectedItem + "' , veliadi ='" + txtVeliad.Text + "' , velisoyadi ='" + txtVelisoyad.Text + "' , velitc ='" + txtVelitc.Text + "' , velicep ='" + txtveliCep.Text + "' , veliadres ='" + txtVeliadres.Text + "' , velidtarihi ='" + txtveliDtarihi.Text + "' , velieposta ='" + txtVelieposta.Text + "'  WHERE ogrnum='" + comboBox1.Text + "'";
            cmd.ExecuteNonQuery();


            if (Application.OpenForms.OfType<ograrafrm>().Any())
            {
                ograrafrm ara = (ograrafrm)Application.OpenForms["ograrafrm"];
                ara.dgyenile();
            }
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (txtGrup.SelectedIndex!=-1)
            {

           
                  string grupidal = "select GrupID from Gruplar where GrupAdi='"+txtGrup.Text+"'";
            
                 SqlCommand grupidalcmd = new SqlCommand(grupidal, con);
                 SqlDataReader grupidoku = grupidalcmd.ExecuteReader();
                   grupidoku.Read();
                 grupid = Convert.ToInt32(grupidoku["GrupID"]);
                 grupidoku.Close();

                  string ogrgrupguncelle = "update siniflar set GrupID='" + grupid + "' where ogrnum='" + ogrid + "'";
                     SqlCommand ogrgrupguncellecmd = new SqlCommand(ogrgrupguncelle, con);
                  ogrgrupguncellecmd.ExecuteNonQuery();
            }

            string alanidal = "select alanlarID from alanlar where Alanlar='" + txtAlani.SelectedText + "'";
            string duzeyidal = "select dID from Duzeyler where duzeyler='" + txtSinifi.SelectedText + "'";
            SqlCommand alanadialcmd = new SqlCommand(alanidal, con);
            SqlDataReader alanidoku = alanadialcmd.ExecuteReader();
            alanidoku.Read();
            alanid = Convert.ToInt32(alanidoku["alanlarID"]);
            alanidoku.Close();

            SqlCommand duzeyadialcmd = new SqlCommand(duzeyidal, con);
            SqlDataReader duzeyoku = duzeyadialcmd.ExecuteReader();
            duzeyoku.Read();
            duzeyid = Convert.ToInt32(duzeyoku["dID"]);
            duzeyoku.Close();
            string gruptaduzeyalanguncelle = "update siniflar set DuzeyID='" + duzeyid + "', AlanID='" + alanid + "' where ogrnum='" + ogrid + "'";
            SqlCommand gruptaduzeyalanguncellecmd = new SqlCommand(gruptaduzeyalanguncelle, con);
            gruptaduzeyalanguncellecmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(comboBox1.Text + " Numaralı Öğrencinin Kaydı Güncellendi!");

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
           SqlConnection baglanti = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");

            string sil = "DELETE FROM ogrencikayit " + "WHERE ogrnum= '" + comboBox1.Text + "' ";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sil, baglanti);
           

            komut.ExecuteNonQuery();
            baglanti.Close();
            ogrduzenlefrm yeni = new ogrduzenlefrm();
            yeni.Show();
            MessageBox.Show("Kayıt başarıyla silindi");
            this.Dispose(false);
            
            

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ograrafrm arama = new ograrafrm();
            arama.Show();
            this.Dispose(false);
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Ogrkayitfrm kayit = new Ogrkayitfrm();
            kayit.Show();
            this.Dispose(false);
        }
    }
}

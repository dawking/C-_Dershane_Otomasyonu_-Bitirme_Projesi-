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
    public partial class Ogrkayitfrm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True;MultipleActiveResultSets=true");
        public Ogrkayitfrm()
        {
            InitializeComponent();
        }
        public int sonogrnum;
        public bool sayac = false;

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            
            try
            {



                if (con.State == ConnectionState.Closed)
                    con.Open();

                string kayit = "INSERT INTO ogrencikayit(ogrnum,ad,soyad,tcno,ceptel,dtarihi,adres,okuladi,sinifi,alani,veliadi,velisoyadi,velitc,velicep,ogreposta,veliadres,velidtarihi,velieposta) values (@ogrnum,@ad,@soyad,@tcno,@ceptel,@dtarihi,@adres,@okuladi,@sinifi,@alani,@veliadi,@velisoyadi,@velitc,@velicep,@ogreposta,@veliadres,@velidtarihi,@velieposta)";
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@ogrnum", Convert.ToInt32(txtogrnum.Text));
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@tcno", txtTc.Text);
                komut.Parameters.AddWithValue("@ceptel", txtCep.Text);
                komut.Parameters.AddWithValue("@dtarihi", txtDtarihi.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@okuladi", txtOkuladi.Text);
                komut.Parameters.AddWithValue("@sinifi", txtSinifi.Text);
                komut.Parameters.AddWithValue("@alani", txtAlani.Text);
                komut.Parameters.AddWithValue("@veliadi", txtVeliad.Text);
                komut.Parameters.AddWithValue("@velisoyadi", txtVelisoyad.Text);
                komut.Parameters.AddWithValue("@velitc", txtVelitc.Text);
                komut.Parameters.AddWithValue("@velicep", txtveliCep.Text);
                komut.Parameters.AddWithValue("@ogreposta", txtEposta.Text);
                komut.Parameters.AddWithValue("@veliadres", txtVeliadres.Text);
                komut.Parameters.AddWithValue("@velidtarihi", txtveliDtarihi.Text);
                komut.Parameters.AddWithValue("@velieposta", txtVelieposta.Text);
                

                komut.ExecuteNonQuery();




                string sinifagrupekle = "select * from Gruplar where GrupAdi='"+ txtGrup.Text +"'";
                SqlCommand sinifagrupeklecmd = new SqlCommand(sinifagrupekle, con);
                SqlDataReader drgrupidoku = sinifagrupeklecmd.ExecuteReader();
                drgrupidoku.Read();
                int grupid = Convert.ToInt32(drgrupidoku["GrupID"]);
                drgrupidoku.Close();


                string sinifduzeyekle = "select * from Duzeyler where duzeyler='"+ txtSinifi.Text +"'";
                SqlCommand sinifduzeyeklecmd = new SqlCommand(sinifduzeyekle, con);
                SqlDataReader drduzeyidoku = sinifduzeyeklecmd.ExecuteReader();
                drduzeyidoku.Read();
                int duzeyid = Convert.ToInt32(drduzeyidoku["dID"]);
                drduzeyidoku.Close();


                string sinifalanekle = "select * from alanlar where Alanlar='"+ txtAlani.Text.ToString() +"'";
                SqlCommand sinifalaneklecmd = new SqlCommand(sinifalanekle, con);
                SqlDataReader drsinifalanekle = sinifalaneklecmd.ExecuteReader();
                drsinifalanekle.Read();
                int alanid = Convert.ToInt32(drsinifalanekle["alanlarID"]);
                drsinifalanekle.Close();



                
               
               

                   

                SqlCommand cmdokul = new SqlCommand("select okulAdi from Okullar", con);
                SqlDataReader drokul = cmdokul.ExecuteReader();
                if (drokul.Read())
                {
                       
                    if (txtOkuladi.Text != drokul["okulAdi"].ToString())
                    {
                            drokul.Close();


                        string kayit4 = "INSERT INTO Okullar(okulAdi) values (@okulAdi)";
                        SqlCommand komut3 = new SqlCommand(kayit4, con);
                        komut3.Parameters.AddWithValue("@okulAdi", txtOkuladi.Text);
                        komut3.ExecuteNonQuery();

                    }
                    else
                    {
                        drokul.Close();

                    }
                    
                 
                }
                //else
                //{
                //    drokul.Close();

                //    string kayit4 = "INSERT INTO Okullar(okulAdi) values (@okulAdi)";
                //    SqlCommand komut3 = new SqlCommand(kayit4, con);
                //    komut3.Parameters.AddWithValue("@okulAdi", txtOkuladi.Text);
                //    komut3.ExecuteNonQuery();
                //}

                string sinifaogrnumekle = "insert into siniflar(ogrnum) select ogrID from ogrencikayit where ogrnum='"+Convert.ToInt32(txtogrnum.Text) +"'";
                SqlCommand yeterartikcmd = new SqlCommand(sinifaogrnumekle, con);
                yeterartikcmd.Parameters.AddWithValue("@ogrnum", Convert.ToInt32(txtogrnum.Text));
                yeterartikcmd.ExecuteNonQuery();

                string ogIDsec = "select ogrID from ogrencikayit where ogrnum='" + Convert.ToInt32(txtogrnum.Text) + "'";
                SqlCommand sonundaoldu = new SqlCommand(ogIDsec, con);
                SqlDataReader idokunolur = sonundaoldu.ExecuteReader();
                idokunolur.Read();
                int ogrID =Convert.ToInt32(idokunolur["ogrID"]);
                idokunolur.Close();

                string grubakayit2 = "update siniflar set GrupID='"+grupid+"', DuzeyID='"+duzeyid+"', AlanID='"+alanid+"' where ogrnum ='"+ogrID+"'";
                SqlCommand grubakayit2cmd = new SqlCommand(grubakayit2, con);
                grubakayit2cmd.ExecuteNonQuery();
                con.Close();


                if (Application.OpenForms.OfType<ograrafrm>().Any())
                {
                    ograrafrm ara = (ograrafrm)Application.OpenForms["ograrafrm"];
                    ara.dgyenile();
                }

                MessageBox.Show("Öğrenci Kayıt İşlemi Başarı İle Gerçekleşti");
               
            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
            txtAd.Text = null;
            txtAdres.Text = null;
            txtAlani.Text = null;
            txtCep.Text = null;
            txtDtarihi.Text = null;
            txtEposta.Text = null;
            txtGrup.Text = null;
            txtogrnum.Text = null;
            txtOkuladi.Text = null;
            txtSinifi.Text = null;
            txtSoyad.Text = null;
            txtVeliad.Text = null;
            txtVeliadres.Text = null;
            txtveliDtarihi.Text = null;
            txtVelitc.Text = null;
            txtVelisoyad.Text = null;
            txtTc.Text = null;
            txtSinifi.Text = null;
            txtVelieposta.Text = null;
            txtveliCep.Text = null;
            txtOkuladi.Items.Clear();

            ogrnumdoldur();
            okuladidoldur();
            sayac = false;

        }
         public void ogrnumdoldur() {
            int degisken=0;
            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True;MultipleActiveResultSets=true");
            int sayac = 0;
            con.Open();
            SqlCommand command2 = new SqlCommand("SELECT ogrID From ogrencikayit", con);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                degisken = Convert.ToInt32(dr2["ogrID"]) + 1;
                sayac += 1;
            }
            
            txtogrnum.Text = degisken.ToString();
            dr2.Close();
            con.Close();
           
        }
        private void Ogrkayitfrm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True;MultipleActiveResultSets=true");
            ogrnumdoldur();
            txtAlani.Items.Clear();
            txtSinifi.Items.Clear();
            txtOkuladi.Items.Clear();

            con.Open();
            SqlCommand command = new SqlCommand("SELECT * From Alanlar", con);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtAlani.Items.Add(dr["Alanlar"]);
            }
            dr.Close();

            
            comboboxdoldur();
            

            SqlCommand command3 = new SqlCommand("SELECT duzeyler From Duzeyler order by dID asc", con);
            SqlDataReader dr3 = command3.ExecuteReader();
           
            while (dr3.Read())
            {
                txtSinifi.Items.Add(dr3["duzeyler"]);
            }
            dr3.Close();

            okuladidoldur();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            grupeklefrm ekle = new grupeklefrm();
            ekle.ShowDialog();
        }
       public void comboboxdoldur() {
            txtGrup.Items.Clear(); 
            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
            con.Open();
            SqlCommand command2 = new SqlCommand("SELECT * From Gruplar", con);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                txtGrup.Items.Add(dr2["GrupAdi"]);
            }
            dr2.Close();
        }
        void okuladidoldur() {

            con.Open();
            SqlCommand cmdokul = new SqlCommand("SELECT okulAdi from Okullar", con);
            SqlDataReader drokul = cmdokul.ExecuteReader();

            while (drokul.Read())
            {
                txtOkuladi.Items.Add(drokul["okulAdi"]);
            }
            drokul.Close();
            con.Close();

        }

    
       
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtAlani_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
       
                TaksitEKlefrm taksitekle = new TaksitEKlefrm();
                taksitekle.Show();
               
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            txtogrnum.BackColor = Color.LightGoldenrodYellow;
        }
    }
}

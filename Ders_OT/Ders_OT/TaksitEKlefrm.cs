using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dershane_Otomasyonu
{
    public partial class TaksitEKlefrm : Form
    {

        public int num;
        public SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
        public TaksitEKlefrm()
        {
            InitializeComponent();
        }
      
        private void TaksitEKlefrm_Load(object sender, EventArgs e)
        {

            txtToplamtutar.Text = 0.ToString(); ;
            txtPesinat.Text = 0.ToString();
            if (Application.OpenForms.OfType<Ogrkayitfrm>().Any())
            {
                Ogrkayitfrm ara = (Ogrkayitfrm)Application.OpenForms["Ogrkayitfrm"];
                num = Convert.ToInt32(ara.txtogrnum.Text);
            }
            string sqlstring = "select ogrID from ogrencikayit where ogrnum='"+num+"'";
            con.Open();
            SqlCommand idcekcmd = new SqlCommand(sqlstring, con);
            SqlDataReader idoku = idcekcmd.ExecuteReader();
            if (idoku.Read())
            {

                num =Convert.ToInt32(idoku["ogrID"]);
                idoku.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("Öğrenci Kaydını Tamamlamadınız!");
                idoku.Close();
                con.Close();
                this.Close();
            }

            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            double ttutar = Double.Parse(txtToplamtutar.Text, System.Globalization.NumberStyles.Currency);
            double pesinat = Double.Parse(txtPesinat.Text, System.Globalization.NumberStyles.Currency);
            double taksit = ((ttutar - Convert.ToDouble(pesinat)) / Convert.ToDouble(numAdet.Value));
            taksit = Math.Round(taksit, 2);
            double toplamborc = taksit * Convert.ToDouble(numAdet.Value);
            toplamborc = Math.Round(toplamborc, 2);


            con.Open();
            DateTime vadetarihi = dtimeIlkTaksit.Value.Date;
            
            for (int i = 0; i < numAdet.Value; i++)
            {
                string sqlkayitstring = "insert into Taksitler (OgrID, Taksit, Vade, Odendi) values(@OgrID, @Taksit, @Vade, @Odendi)";
                SqlCommand taksitkaydet = new SqlCommand(sqlkayitstring, con);
                taksitkaydet.Parameters.AddWithValue("@OgrID", num);
                taksitkaydet.Parameters.AddWithValue("@Taksit", taksit);
                taksitkaydet.Parameters.AddWithValue("@Vade", Convert.ToString(vadetarihi).Substring(0,10));
                taksitkaydet.Parameters.AddWithValue("@Odendi", "H");
            
                vadetarihi = vadetarihi.AddMonths(1);
                taksitkaydet.ExecuteNonQuery();

            }
            string sqltaksitmiktarikayit = "insert into TaksitMiktarlari (OgrID, Taksitmiktari) values(@OgrID, @Taksitmiktari)";
            string sqltoplamborckayit = "insert into KalanBorc (OgrID, KalanBorc) values(@OgrID, @KalanBorc)";
            SqlCommand kalanborckaydet = new SqlCommand(sqltoplamborckayit, con);
           
            kalanborckaydet.Parameters.AddWithValue("@OgrID", num);
            kalanborckaydet.Parameters.AddWithValue("@KalanBorc", toplamborc);
            kalanborckaydet.ExecuteNonQuery();
            SqlCommand sqltaksitmiktarikayitcmd = new SqlCommand(sqltaksitmiktarikayit, con);
            sqltaksitmiktarikayitcmd.Parameters.AddWithValue("@OgrID", num);
            sqltaksitmiktarikayitcmd.Parameters.AddWithValue("@Taksitmiktari", taksit);
            sqltaksitmiktarikayitcmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Taksit Yapılandırıldı!!!");
            this.Close();
                
        }

       
        private void txtToplamtutar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar)) //Eğer harf girildiyse iptal et
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13) //Enter tuşuna basıldımı
            {

              
                txtToplamtutar.Text = string.Format("{0:c}", double.Parse(txtToplamtutar.Text));
                
            }
        }

        private void txtPesinat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) 
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13) 
            {

             
               txtPesinat.Text = string.Format("{0:c}", double.Parse(txtPesinat.Text));

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtToplamtutar_Leave(object sender, EventArgs e)
        {
            txtToplamtutar.Text = string.Format("{0:c}", double.Parse(txtToplamtutar.Text));
        }

        private void txtPesinat_Leave(object sender, EventArgs e)
        {
            txtPesinat.Text = string.Format("{0:c}", double.Parse(txtPesinat.Text));
        }
    }
}

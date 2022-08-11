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
    public partial class GelirGiderfrm : Form
    {

        public SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
        public string durum = "E";
        public int gelirpara;
        public int giderpara;
        public GelirGiderfrm()
        {
            InitializeComponent();
        }

     
        private void GelirGiderfrm_Load(object sender, EventArgs e)
        {
            con.Open();
            string gelir = "select Taksit from Taksitler where Odendi='"+durum+"'";
            SqlCommand gelircmd = new SqlCommand(gelir, con);
            SqlDataReader geliroku = gelircmd.ExecuteReader();
            while (geliroku.Read())
            {
               gelirpara +=Convert.ToInt32(geliroku["Taksit"]);

            }
            geliroku.Close();

            string gider = "select OgrMaas from OgrMaas";
            SqlCommand gidercmd = new SqlCommand(gider, con);
            SqlDataReader gideroku = gidercmd.ExecuteReader();
            while (gideroku.Read())
            {
                giderpara += Convert.ToInt32(gideroku["OgrMaas"]);

            }
            gideroku.Close();
            if (giderpara>gelirpara)
            {
                txtgider.ForeColor = Color.Red;
                txtgelir.ForeColor = Color.Red;
            }
            else
            {
                txtgider.ForeColor = Color.DarkSeaGreen;
                txtgelir.ForeColor = Color.DarkSeaGreen;
            }
            txtgider.Text = giderpara.ToString() + " TL";
            txtgelir.Text = gelirpara.ToString() + " TL";

        }
    }
}

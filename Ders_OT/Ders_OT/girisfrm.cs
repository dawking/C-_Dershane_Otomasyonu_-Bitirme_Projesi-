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
    public partial class girisfrm : Form
    {
        public girisfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anamenufrm frm = new anamenufrm();
            frm.Show();
            this.Hide();
        }

       

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {

            if (txtSifre.Text!="")
            {
                pictureBox2.Image = Image.FromFile("unlock_40px.png");
            }
            else
            {
                pictureBox2.Image = Image.FromFile("lock_40px.png");
            }
            
        }

    

        private void btnGiris_Click(object sender, EventArgs e)
        {

            
           SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=dershane;Integrated Security=True");
           con.Open();
           SqlCommand command = new SqlCommand("SELECT * From yetkiligiris WHERE kadi='"+ txtKullaniciAdi.Text +"' and sifre='"+ txtSifre.Text +"'", con);
           SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                anamenufrm frm = new anamenufrm();
                frm.Show();
                this.Hide();
            }
            else
            {   
                con.Close();
                txtKullaniciAdi.ForeColor = Color.Red;
                txtKullaniciAdi.Text = "Hatalı Giriş";
                txtSifre.Text = "";
             
            }
           


            
        }
        
        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "";
            txtKullaniciAdi.ForeColor = Color.Black;
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            txtSifre.Text = "";
        }

        private void girisfrm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSıfreDegistir_Click(object sender, EventArgs e)
        {
            sifredegistirfrm degisimfrm = new sifredegistirfrm();
            degisimfrm.Show();
        }

        private void txtKullaniciAdi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnKullaniciekle_Click(object sender, EventArgs e)
        {
            kullanicieklefrm ekle = new kullanicieklefrm();
            ekle.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

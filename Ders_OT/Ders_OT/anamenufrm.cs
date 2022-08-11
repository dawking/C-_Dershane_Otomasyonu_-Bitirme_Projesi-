using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dershane_Otomasyonu
{
    public partial class anamenufrm : Form
    {
        public anamenufrm()
        {
            InitializeComponent();
        }

       

     

       

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Image.FromFile("ogrenci2.jpg");
            Cursor.Current = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("ogrenci.jpg");
            
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Image.FromFile("ogretmen2.jpg");
            Cursor.Current = Cursors.Hand;
        }

     
        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("ogretmen.jpg");

        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Image.FromFile("muhasebe2.jpg");
            Cursor.Current = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile("muhasebe.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ogrislemlerifrm frmogrenci = new ogrislemlerifrm();
            frmogrenci.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ogretmenislemlerifrm ogrtmenfrm = new ogretmenislemlerifrm();
            ogrtmenfrm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            muhasebeislemfrm muhasebefrm = new muhasebeislemfrm();
            muhasebefrm.Show();
            this.Hide();
        }

        private void anamenufrm_Load(object sender, EventArgs e)
        {
            
        }
    }
}

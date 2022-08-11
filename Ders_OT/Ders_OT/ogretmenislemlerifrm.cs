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
    public partial class ogretmenislemlerifrm : Form
    {
        public ogretmenislemlerifrm()
        {
            InitializeComponent();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            anamenufrm menu = new anamenufrm();
            menu.Show();
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ogretmenkayitfrm kayit = new ogretmenkayitfrm();
            kayit.Show();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ogretmenduzenlefrm duzenle = new ogretmenduzenlefrm();
            duzenle.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ogretmenarafrm ara = new ogretmenarafrm();
            ara.Show();
        }
    }
}

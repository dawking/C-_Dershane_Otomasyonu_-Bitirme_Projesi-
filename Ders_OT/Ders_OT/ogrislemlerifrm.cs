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
    public partial class ogrislemlerifrm : Form
    {
        
        public ogrislemlerifrm()
        {
            InitializeComponent();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            anamenufrm anamenu = new anamenufrm();
            anamenu.Show();
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Ogrkayitfrm kayit = new Ogrkayitfrm();
            kayit.Show();
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ograrafrm duzenle = new ograrafrm();
            duzenle.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            ogrduzenlefrm ara = new ogrduzenlefrm();
            ara.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            devamsızlikekle ekle = new devamsızlikekle();
            ekle.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            siniffrm siniflar = new siniffrm();
            siniflar.Show();
        }
    }
}

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
    public partial class muhasebeislemfrm : Form
    {
        public muhasebeislemfrm()
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
            taksitodefrm taksitode = new taksitodefrm();
            taksitode.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OgrMaas maas = new OgrMaas();
            maas.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            GelirGiderfrm gg = new GelirGiderfrm();
            gg.Show();
        }
    }
}

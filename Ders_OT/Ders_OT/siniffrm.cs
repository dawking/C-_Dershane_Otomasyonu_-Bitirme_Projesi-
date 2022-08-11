using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dershane_Otomasyonu
{
    public partial class siniffrm : Form
    {
        public siniffrm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
        private void siniffrm_Load(object sender, EventArgs e)
        {
            

            dgyenile();
            cbdoldur();

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            
        }

        void dgyenile() {

            DataTable dt = new DataTable();
            string sql = "Select o.ogrnum as [Ö.Num], o.ad +' '+o.soyad as [Adı Soyadı], g.GrupAdi as [Grubu],d.Duzeyler as [Sınıf],a.alanlar as [Alanı] from ogrencikayit o join Siniflar s on s.ogrnum=o.ogrID join Gruplar g on g.GrupID=s.GrupID join Duzeyler d on d.dID=s.DuzeyID join Alanlar a on a.alanlarID=s.AlanID ";

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dataGridView1.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }

        }

        void cbdoldur() {

            SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
            con.Open();
            SqlCommand command2 = new SqlCommand("SELECT * From Gruplar", con);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                txtGrup.Items.Add(dr2["GrupAdi"]);
            }
            dr2.Close();

            SqlCommand command3 = new SqlCommand("select * from alanlar", con);
            SqlDataReader alancek = command3.ExecuteReader();
            while (alancek.Read())
            {
                txtAlan.Items.Add(alancek["Alanlar"]);
            }
            alancek.Close();

            SqlCommand command4 = new SqlCommand("select * from Duzeyler", con);
            SqlDataReader duzeycek = command4.ExecuteReader();
            while (duzeycek.Read())
                { 

                 txtDuzey.Items.Add(duzeycek["Duzeyler"]);
                    
                }
            duzeycek.Close();
        }

        private void txtGrup_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void txtGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("Grubu like '%{0}%'", txtGrup.Text);
            dataGridView1.Refresh();
            txtDuzey.Text = null;
            txtAlan.Text = null;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dataGridView1.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Sınıf Silinsin mi? (Sınıfa kayıtlı öğrencilerin sınıf bilgileri silincektir!)", "UYARI!", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
                con.Open();
                //string idal = "select GrupID from Gruplar where GrupAdi='" + txtGrup.SelectedItem.ToString() + "'";
                //SqlCommand idalcmd = new SqlCommand(idal, con);

                //SqlDataReader idoku = idalcmd.ExecuteReader();
                //int gID = Convert.ToInt32(idoku["GrupID"]);

                SqlCommand sinifsil = new SqlCommand("DELETE FROM Gruplar WHERE GrupAdi='"+txtGrup.Text+"'",con);
                sinifsil.ExecuteNonQuery();

                dgyenile();
                con.Close();
                txtGrup.Text = null;

                txtGrup.Items.Clear();
                txtAlan.Items.Clear();
                txtDuzey.Items.Clear();
                cbdoldur();
                txtGrup.SelectedIndex = 0;
            }
        }

        private void txtAlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("Alanı like '%{0}%' and Grubu like '%{1}%' ", txtAlan.Text, txtGrup.Text);
            dataGridView1.Refresh();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dataGridView1.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void txtDuzey_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("Alanı like '%{0}%' and Grubu like '%{1}%' and Sınıf like '%{2}%' ", txtAlan.Text, txtGrup.Text, txtDuzey.Text);
            dataGridView1.Refresh();
            txtAlan.Text = null;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dataGridView1.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }
    }
}

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
    
    public partial class taksitodefrm : Form
    {
        public bool txt; 
       
       
        
        public SqlConnection con = new SqlConnection(@"Data Source =MERIC-DREAM-PC\SQLEXPRESS01;Initial Catalog=Dershane;Integrated Security=True");
        public int ogrno;
       
        
        public taksitodefrm()
        {
            InitializeComponent();
        }

        private void taksitodefrm_Load(object sender, EventArgs e)
        {
            dgogrsec.RowHeadersVisible = false;
            con.Open();
            DataTable dt = new DataTable();
            string sqlogr = "Select o.ogrID as [Ö.Num], o.ad +' '+o.soyad as [Adı Soyadı], o.tcno as [TC] from ogrencikayit o";
           

            SqlDataAdapter da = new SqlDataAdapter(sqlogr, con);
            da.Fill(dt);
            dgogrsec.DataSource = dt;
            for (int i = 0; i < dgogrsec.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dgogrsec.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dgogrsec.Rows[i].DefaultCellStyle = renk;
            }

        }

        private void dgogrsec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
            

            if (e.RowIndex == -1) 
            {
                return;

            }
            DataGridViewRow row = dgogrsec.Rows[e.RowIndex];
            ogrno =Convert.ToInt32(dgogrsec.Rows[e.RowIndex].Cells[0].Value);
            int ogrnokontrol = ogrno;


            tksitdoldur();

            dgtaksitler.Visible = true;
            tksitdoldur();
          
           
        }

        private void ismegorearatxt_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgogrsec.DataSource;
            bs.Filter = string.Format("[Adı Soyadı] like '%{0}%'", ismegorearatxt.Text.Trim().Replace("'", "''"));
           
            for (int i = 0; i < dgogrsec.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dgogrsec.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dgogrsec.Rows[i].DefaultCellStyle = renk;
            }
            dgogrsec.Refresh();
        }

        private void tcyegorearatxt_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgogrsec.DataSource;
            bs.Filter = string.Format("[TC] like '%{0}%'", tcyegorearatxt.Text.Trim().Replace("'", "''"));
            
            for (int i = 0; i < dgogrsec.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dgogrsec.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                dgogrsec.Rows[i].DefaultCellStyle = renk;
            }
            dgogrsec.Refresh();
        }

       

        private void dgtaksitler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
           
  

        }
           
        void tksitdoldur() {

            
            string sqltaksit = "Select t.OgrId as [Ö.Num], t.Taksit as [Taksit], t.Vade as [Vade], t.Odendi as [Ödendi], k.KalanBorc as [Kalan Borç] from Taksitler t join KalanBorc k on k.OgrID=t.OgrId where t.OgrId='" + ogrno + "'";
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(sqltaksit, con);
            da2.Fill(dt2);
            dgtaksitler.DataSource = dt2;


            for (int i = 0; i < dgtaksitler.Rows.Count; i++)
            {
               
                
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dgtaksitler.Rows[i].Index % 2) == 0)
                {
                    renk.BackColor = Color.DarkGray;

                }
                else
                {
                    renk.BackColor = Color.LightGray;

                }
                if (dgtaksitler.Rows[i].Cells["Ödendi"].Value.ToString()=="E")
                {
                    renk.BackColor = Color.Yellow;
                }
                
                dgtaksitler.Rows[i].DefaultCellStyle = renk;
            }
            //dgtaksitler.Refresh();
            
            con.Close();
        }

        private void dgtaksitler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int taksit = Convert.ToInt32(dgtaksitler.CurrentRow.Cells["Taksit"].Value);
            if (e.ColumnIndex==0)
            {
                
                int kalanborc = Convert.ToInt32(dgtaksitler.CurrentRow.Cells["Kalan Borç"].Value);
                string getdate = dgtaksitler.CurrentRow.Cells["Vade"].Value.ToString();

                string Durum = "E";
                string Durum2 = "H";

                if (dgtaksitler.CurrentRow.Cells["Ödendi"].Value.ToString()!=Durum)
                {

                
                     
                     
  
                     int kalanborc2 = kalanborc - taksit;
                      
                      tksitdoldur();
                      if (con.State == ConnectionState.Open)
                      {
                             con.Close();
                       }

                        con.Open();

                       string kalanborcdus = "update KalanBorc set Kalanborc='" + kalanborc2 + "' where OgrID='" + ogrno + "'";
                       SqlCommand borccmd = new SqlCommand(kalanborcdus, con);
                       borccmd.ExecuteNonQuery();
                      string odemedurumuguncelle = "update Taksitler set Odendi='" + Durum + "' where Vade='" + getdate + "'";
                        SqlCommand odemedurumuguncellecmd = new SqlCommand(odemedurumuguncelle, con);
                        odemedurumuguncellecmd.ExecuteNonQuery();
                          tksitdoldur();
                    
                          //dgtaksitler.Refresh();

                    
                          dgtaksitler.CurrentRow.Cells[0].Value = "Geri Al";

                }
                else
                {
                    con.Open();
                    SqlCommand taksitmikcmd = new SqlCommand("select Taksitmiktari from TaksitMiktarlari where OgrID='"+ogrno+"'",con);
                    SqlDataReader miktaroku = taksitmikcmd.ExecuteReader();
                    miktaroku.Read();
                    int miktar = Convert.ToInt32(miktaroku["Taksitmiktari"].ToString());
                    miktaroku.Close();
                    SqlCommand kalanborcokucmd = new SqlCommand("select KalanBorc from Kalanborc where OgrID='" + ogrno + "'", con);
                    SqlDataReader kalanborcoku = kalanborcokucmd.ExecuteReader();
                    kalanborcoku.Read();
                    int kalanborc5 = Convert.ToInt32(kalanborcoku["KalanBorc"].ToString());
                    kalanborcoku.Close();
                    DialogResult Uyari = new DialogResult();
                    Uyari = MessageBox.Show("Ödeme Gerı Alınsın Mı?", "Uyarı", MessageBoxButtons.YesNo);
                    if (Uyari == DialogResult.Yes)
                    {
                        string odemedurumuguncelle = "update Taksitler set Odendi='" + Durum2  + "', Taksit='" +miktar+ "' where Vade='" + getdate + "'";
                        string kalanborcguncelle = "update KalanBorc set Kalanborc='"+ (miktar+kalanborc5) + "' where OgrID='" + ogrno + "'";
                        SqlCommand odemedurumuguncellecmd = new SqlCommand(odemedurumuguncelle, con);
                        SqlCommand kalanborcguncellecmd = new SqlCommand(kalanborcguncelle, con);
                        odemedurumuguncellecmd.ExecuteNonQuery();
                        kalanborcguncellecmd.ExecuteNonQuery();
                        

                        }
                        tksitdoldur();
                        
                        //dgtaksitler.Refresh();
                        con.Close();
                    }
                   
                }

                con.Close();
            }
        
    

        private void dgtaksitler_SelectionChanged(object sender, EventArgs e)
        {
            

        }      
    }
  }

            
        
    

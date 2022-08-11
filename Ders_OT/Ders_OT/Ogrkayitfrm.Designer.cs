namespace Dershane_Otomasyonu
{
    partial class Ogrkayitfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrkayitfrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.txtTc = new System.Windows.Forms.MaskedTextBox();
            this.txtDtarihi = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtogrnum = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtVeliadres = new System.Windows.Forms.RichTextBox();
            this.txtVelitc = new System.Windows.Forms.MaskedTextBox();
            this.txtveliDtarihi = new System.Windows.Forms.MaskedTextBox();
            this.txtveliCep = new System.Windows.Forms.MaskedTextBox();
            this.txtVelisoyad = new System.Windows.Forms.TextBox();
            this.txtVelieposta = new System.Windows.Forms.TextBox();
            this.txtVeliad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtOkuladi = new System.Windows.Forms.ComboBox();
            this.txtSinifi = new System.Windows.Forms.ComboBox();
            this.txtAlani = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtGrup = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnKayıt = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ekle = new DevExpress.XtraEditors.SimpleButton();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.txtDtarihi);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtEposta);
            this.groupBox1.Controls.Add(this.txtogrnum);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 357);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.Silver;
            this.txtAdres.Location = new System.Drawing.Point(122, 276);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(143, 66);
            this.txtAdres.TabIndex = 7;
            this.txtAdres.Text = "";
            // 
            // txtTc
            // 
            this.txtTc.BackColor = System.Drawing.Color.Silver;
            this.txtTc.Location = new System.Drawing.Point(122, 131);
            this.txtTc.Mask = "00000000000";
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(143, 26);
            this.txtTc.TabIndex = 3;
            this.txtTc.ValidatingType = typeof(int);
            // 
            // txtDtarihi
            // 
            this.txtDtarihi.BackColor = System.Drawing.Color.Silver;
            this.txtDtarihi.Location = new System.Drawing.Point(122, 201);
            this.txtDtarihi.Mask = "00/00/0000";
            this.txtDtarihi.Name = "txtDtarihi";
            this.txtDtarihi.Size = new System.Drawing.Size(143, 26);
            this.txtDtarihi.TabIndex = 5;
            this.txtDtarihi.ValidatingType = typeof(System.DateTime);
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.Silver;
            this.txtCep.Location = new System.Drawing.Point(122, 166);
            this.txtCep.Mask = "(000) 000-0000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(143, 26);
            this.txtCep.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.Silver;
            this.txtSoyad.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(122, 95);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(143, 26);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtEposta
            // 
            this.txtEposta.BackColor = System.Drawing.Color.Silver;
            this.txtEposta.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.Location = new System.Drawing.Point(122, 233);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(143, 26);
            this.txtEposta.TabIndex = 6;
            // 
            // txtogrnum
            // 
            this.txtogrnum.BackColor = System.Drawing.Color.Silver;
            this.txtogrnum.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrnum.Location = new System.Drawing.Point(122, 25);
            this.txtogrnum.Name = "txtogrnum";
            this.txtogrnum.ReadOnly = true;
            this.txtogrnum.Size = new System.Drawing.Size(143, 26);
            this.txtogrnum.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.Silver;
            this.txtAd.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(122, 60);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(143, 26);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(266, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "(gg.aa.yyyy)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(16, 276);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 18);
            this.label19.TabIndex = 0;
            this.label19.Text = "Adres:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(16, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "E posta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cep Tel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtVeliadres);
            this.groupBox3.Controls.Add(this.txtVelitc);
            this.groupBox3.Controls.Add(this.txtveliDtarihi);
            this.groupBox3.Controls.Add(this.txtveliCep);
            this.groupBox3.Controls.Add(this.txtVelisoyad);
            this.groupBox3.Controls.Add(this.txtVelieposta);
            this.groupBox3.Controls.Add(this.txtVeliad);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(388, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 368);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Veli Bilgileri";
            // 
            // txtVeliadres
            // 
            this.txtVeliadres.BackColor = System.Drawing.Color.Silver;
            this.txtVeliadres.Location = new System.Drawing.Point(115, 273);
            this.txtVeliadres.Name = "txtVeliadres";
            this.txtVeliadres.Size = new System.Drawing.Size(143, 66);
            this.txtVeliadres.TabIndex = 17;
            this.txtVeliadres.Text = "";
            // 
            // txtVelitc
            // 
            this.txtVelitc.BackColor = System.Drawing.Color.Silver;
            this.txtVelitc.Location = new System.Drawing.Point(115, 128);
            this.txtVelitc.Mask = "00000000000";
            this.txtVelitc.Name = "txtVelitc";
            this.txtVelitc.Size = new System.Drawing.Size(143, 26);
            this.txtVelitc.TabIndex = 13;
            // 
            // txtveliDtarihi
            // 
            this.txtveliDtarihi.BackColor = System.Drawing.Color.Silver;
            this.txtveliDtarihi.Location = new System.Drawing.Point(115, 198);
            this.txtveliDtarihi.Mask = "00/00/0000";
            this.txtveliDtarihi.Name = "txtveliDtarihi";
            this.txtveliDtarihi.Size = new System.Drawing.Size(143, 26);
            this.txtveliDtarihi.TabIndex = 15;
            this.txtveliDtarihi.ValidatingType = typeof(System.DateTime);
            // 
            // txtveliCep
            // 
            this.txtveliCep.BackColor = System.Drawing.Color.Silver;
            this.txtveliCep.Location = new System.Drawing.Point(115, 163);
            this.txtveliCep.Mask = "(000) 000-0000";
            this.txtveliCep.Name = "txtveliCep";
            this.txtveliCep.Size = new System.Drawing.Size(143, 26);
            this.txtveliCep.TabIndex = 14;
            // 
            // txtVelisoyad
            // 
            this.txtVelisoyad.BackColor = System.Drawing.Color.Silver;
            this.txtVelisoyad.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVelisoyad.Location = new System.Drawing.Point(115, 92);
            this.txtVelisoyad.Name = "txtVelisoyad";
            this.txtVelisoyad.Size = new System.Drawing.Size(143, 26);
            this.txtVelisoyad.TabIndex = 12;
            // 
            // txtVelieposta
            // 
            this.txtVelieposta.BackColor = System.Drawing.Color.Silver;
            this.txtVelieposta.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVelieposta.Location = new System.Drawing.Point(115, 230);
            this.txtVelieposta.Name = "txtVelieposta";
            this.txtVelieposta.Size = new System.Drawing.Size(143, 26);
            this.txtVelieposta.TabIndex = 16;
            // 
            // txtVeliad
            // 
            this.txtVeliad.BackColor = System.Drawing.Color.Silver;
            this.txtVeliad.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeliad.Location = new System.Drawing.Point(115, 57);
            this.txtVeliad.Name = "txtVeliad";
            this.txtVeliad.Size = new System.Drawing.Size(143, 26);
            this.txtVeliad.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(264, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "(gg.aa.yyyy)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(9, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "E posta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(9, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Adres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cep Tel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "TC No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(9, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Soyadı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(9, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Adı:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtOkuladi);
            this.groupBox4.Controls.Add(this.txtSinifi);
            this.groupBox4.Controls.Add(this.txtAlani);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(8, 375);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(362, 143);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Okul Bilgileri";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txtOkuladi
            // 
            this.txtOkuladi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOkuladi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtOkuladi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtOkuladi.FormattingEnabled = true;
            this.txtOkuladi.Location = new System.Drawing.Point(122, 32);
            this.txtOkuladi.Name = "txtOkuladi";
            this.txtOkuladi.Size = new System.Drawing.Size(143, 26);
            this.txtOkuladi.TabIndex = 12;
            // 
            // txtSinifi
            // 
            this.txtSinifi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSinifi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtSinifi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSinifi.FormattingEnabled = true;
            this.txtSinifi.Location = new System.Drawing.Point(122, 67);
            this.txtSinifi.Name = "txtSinifi";
            this.txtSinifi.Size = new System.Drawing.Size(143, 26);
            this.txtSinifi.TabIndex = 12;
            // 
            // txtAlani
            // 
            this.txtAlani.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAlani.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAlani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAlani.FormattingEnabled = true;
            this.txtAlani.Location = new System.Drawing.Point(122, 102);
            this.txtAlani.Name = "txtAlani";
            this.txtAlani.Size = new System.Drawing.Size(143, 26);
            this.txtAlani.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(16, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "Sınıfı:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(16, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Alani:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(16, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 18);
            this.label18.TabIndex = 0;
            this.label18.Text = "Okul Adı:";
            // 
            // txtGrup
            // 
            this.txtGrup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGrup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtGrup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGrup.FormattingEnabled = true;
            this.txtGrup.Location = new System.Drawing.Point(122, 21);
            this.txtGrup.Name = "txtGrup";
            this.txtGrup.Size = new System.Drawing.Size(143, 26);
            this.txtGrup.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(16, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 18);
            this.label20.TabIndex = 0;
            this.label20.Text = "Grubu:";
            // 
            // btnKayıt
            // 
            this.btnKayıt.Appearance.BackColor = System.Drawing.Color.Gray;
            this.btnKayıt.Appearance.Font = new System.Drawing.Font("Arial", 10.13913F, System.Drawing.FontStyle.Bold);
            this.btnKayıt.Appearance.Options.UseBackColor = true;
            this.btnKayıt.Appearance.Options.UseFont = true;
            this.btnKayıt.ImageOptions.Image = global::Dershane_Otomasyonu.Properties.Resources.checkmark_42px;
            this.btnKayıt.Location = new System.Drawing.Point(404, 400);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(292, 77);
            this.btnKayıt.TabIndex = 18;
            this.btnKayıt.Text = "Kaydı Tamamla";
            this.btnKayıt.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.Gray;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Arial", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton3.Location = new System.Drawing.Point(553, 483);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(143, 76);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Taksit Planı Oluştur";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.BackColor = System.Drawing.Color.Gray;
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Arial", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseBackColor = true;
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnTemizle.Location = new System.Drawing.Point(404, 483);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(143, 76);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Yeni Kayıt";
            this.btnTemizle.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGrup);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.ekle);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.01739F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 524);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 67);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dershane Bilgisi";
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(281, 24);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(36, 21);
            this.ekle.TabIndex = 11;
            this.ekle.Text = "...";
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(16, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 18);
            this.label21.TabIndex = 0;
            this.label21.Text = "Ö.Num:";
            // 
            // Ogrkayitfrm
            // 
            this.AcceptButton = this.btnKayıt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(752, 621);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ogrkayitfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Ogrkayitfrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtTc;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.MaskedTextBox txtDtarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox txtVelitc;
        private System.Windows.Forms.MaskedTextBox txtveliDtarihi;
        private System.Windows.Forms.MaskedTextBox txtveliCep;
        private System.Windows.Forms.TextBox txtVelisoyad;
        private System.Windows.Forms.TextBox txtVeliad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox txtVeliadres;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.SimpleButton btnKayıt;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtVelieposta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox txtAlani;
        private System.Windows.Forms.ComboBox txtGrup;
        private System.Windows.Forms.ComboBox txtSinifi;
        private System.Windows.Forms.ComboBox txtOkuladi;
        public System.Windows.Forms.TextBox txtogrnum;
        public System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton ekle;
        private System.Windows.Forms.Label label21;
    }
}
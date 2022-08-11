namespace Dershane_Otomasyonu
{
    partial class ograrafrm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ograrafrm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceptelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrepostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okuladiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velisoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velitcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velicepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliepostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencikayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet = new Dershane_Otomasyonu.dershaneDataSet();
            this.ogrencikayitTableAdapter = new Dershane_Otomasyonu.dershaneDataSetTableAdapters.ogrencikayitTableAdapter();
            this.ogrgizlechk = new System.Windows.Forms.CheckBox();
            this.veligizlechk = new System.Windows.Forms.CheckBox();
            this.ismegorearatxt = new System.Windows.Forms.TextBox();
            this.soyismegorearatxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcyegorearatxt = new System.Windows.Forms.TextBox();
            this.txtozelnum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencikayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.13913F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrnumDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.tcnoDataGridViewTextBoxColumn,
            this.ceptelDataGridViewTextBoxColumn,
            this.dtarihiDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.ogrepostaDataGridViewTextBoxColumn,
            this.okuladiDataGridViewTextBoxColumn,
            this.sinifiDataGridViewTextBoxColumn,
            this.alaniDataGridViewTextBoxColumn,
            this.veliadiDataGridViewTextBoxColumn,
            this.velisoyadiDataGridViewTextBoxColumn,
            this.velitcDataGridViewTextBoxColumn,
            this.velicepDataGridViewTextBoxColumn,
            this.veliadresDataGridViewTextBoxColumn,
            this.veliepostaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrencikayitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(199, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1187, 668);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogrnumDataGridViewTextBoxColumn
            // 
            this.ogrnumDataGridViewTextBoxColumn.DataPropertyName = "ogrnum";
            this.ogrnumDataGridViewTextBoxColumn.HeaderText = "Öğrenci Numarası";
            this.ogrnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrnumDataGridViewTextBoxColumn.Name = "ogrnumDataGridViewTextBoxColumn";
            this.ogrnumDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrnumDataGridViewTextBoxColumn.Width = 120;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            this.adDataGridViewTextBoxColumn.Width = 120;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.soyadDataGridViewTextBoxColumn.Width = 120;
            // 
            // tcnoDataGridViewTextBoxColumn
            // 
            this.tcnoDataGridViewTextBoxColumn.DataPropertyName = "tcno";
            this.tcnoDataGridViewTextBoxColumn.HeaderText = "Tc No";
            this.tcnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcnoDataGridViewTextBoxColumn.Name = "tcnoDataGridViewTextBoxColumn";
            this.tcnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tcnoDataGridViewTextBoxColumn.Width = 120;
            // 
            // ceptelDataGridViewTextBoxColumn
            // 
            this.ceptelDataGridViewTextBoxColumn.DataPropertyName = "ceptel";
            this.ceptelDataGridViewTextBoxColumn.HeaderText = "Cep Telefonu";
            this.ceptelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ceptelDataGridViewTextBoxColumn.Name = "ceptelDataGridViewTextBoxColumn";
            this.ceptelDataGridViewTextBoxColumn.ReadOnly = true;
            this.ceptelDataGridViewTextBoxColumn.Width = 120;
            // 
            // dtarihiDataGridViewTextBoxColumn
            // 
            this.dtarihiDataGridViewTextBoxColumn.DataPropertyName = "dtarihi";
            this.dtarihiDataGridViewTextBoxColumn.HeaderText = "Doğrum Tarihi";
            this.dtarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtarihiDataGridViewTextBoxColumn.Name = "dtarihiDataGridViewTextBoxColumn";
            this.dtarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtarihiDataGridViewTextBoxColumn.Width = 120;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adresi";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresDataGridViewTextBoxColumn.Width = 120;
            // 
            // ogrepostaDataGridViewTextBoxColumn
            // 
            this.ogrepostaDataGridViewTextBoxColumn.DataPropertyName = "ogreposta";
            this.ogrepostaDataGridViewTextBoxColumn.HeaderText = "Öğrenci E-Posta";
            this.ogrepostaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrepostaDataGridViewTextBoxColumn.Name = "ogrepostaDataGridViewTextBoxColumn";
            this.ogrepostaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrepostaDataGridViewTextBoxColumn.Width = 120;
            // 
            // okuladiDataGridViewTextBoxColumn
            // 
            this.okuladiDataGridViewTextBoxColumn.DataPropertyName = "okuladi";
            this.okuladiDataGridViewTextBoxColumn.HeaderText = "Okul Adı";
            this.okuladiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.okuladiDataGridViewTextBoxColumn.Name = "okuladiDataGridViewTextBoxColumn";
            this.okuladiDataGridViewTextBoxColumn.ReadOnly = true;
            this.okuladiDataGridViewTextBoxColumn.Width = 120;
            // 
            // sinifiDataGridViewTextBoxColumn
            // 
            this.sinifiDataGridViewTextBoxColumn.DataPropertyName = "sinifi";
            this.sinifiDataGridViewTextBoxColumn.HeaderText = "Sınıfı";
            this.sinifiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sinifiDataGridViewTextBoxColumn.Name = "sinifiDataGridViewTextBoxColumn";
            this.sinifiDataGridViewTextBoxColumn.ReadOnly = true;
            this.sinifiDataGridViewTextBoxColumn.Width = 120;
            // 
            // alaniDataGridViewTextBoxColumn
            // 
            this.alaniDataGridViewTextBoxColumn.DataPropertyName = "alani";
            this.alaniDataGridViewTextBoxColumn.HeaderText = "Alanı";
            this.alaniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alaniDataGridViewTextBoxColumn.Name = "alaniDataGridViewTextBoxColumn";
            this.alaniDataGridViewTextBoxColumn.ReadOnly = true;
            this.alaniDataGridViewTextBoxColumn.Width = 120;
            // 
            // veliadiDataGridViewTextBoxColumn
            // 
            this.veliadiDataGridViewTextBoxColumn.DataPropertyName = "veliadi";
            this.veliadiDataGridViewTextBoxColumn.HeaderText = "Veli Adı";
            this.veliadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veliadiDataGridViewTextBoxColumn.Name = "veliadiDataGridViewTextBoxColumn";
            this.veliadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.veliadiDataGridViewTextBoxColumn.Width = 120;
            // 
            // velisoyadiDataGridViewTextBoxColumn
            // 
            this.velisoyadiDataGridViewTextBoxColumn.DataPropertyName = "velisoyadi";
            this.velisoyadiDataGridViewTextBoxColumn.HeaderText = "Veli Soyadı";
            this.velisoyadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.velisoyadiDataGridViewTextBoxColumn.Name = "velisoyadiDataGridViewTextBoxColumn";
            this.velisoyadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.velisoyadiDataGridViewTextBoxColumn.Width = 120;
            // 
            // velitcDataGridViewTextBoxColumn
            // 
            this.velitcDataGridViewTextBoxColumn.DataPropertyName = "velitc";
            this.velitcDataGridViewTextBoxColumn.HeaderText = "Veli Tc";
            this.velitcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.velitcDataGridViewTextBoxColumn.Name = "velitcDataGridViewTextBoxColumn";
            this.velitcDataGridViewTextBoxColumn.ReadOnly = true;
            this.velitcDataGridViewTextBoxColumn.Width = 120;
            // 
            // velicepDataGridViewTextBoxColumn
            // 
            this.velicepDataGridViewTextBoxColumn.DataPropertyName = "velicep";
            this.velicepDataGridViewTextBoxColumn.HeaderText = "Veli Cep Telefonu";
            this.velicepDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.velicepDataGridViewTextBoxColumn.Name = "velicepDataGridViewTextBoxColumn";
            this.velicepDataGridViewTextBoxColumn.ReadOnly = true;
            this.velicepDataGridViewTextBoxColumn.Width = 120;
            // 
            // veliadresDataGridViewTextBoxColumn
            // 
            this.veliadresDataGridViewTextBoxColumn.DataPropertyName = "veliadres";
            this.veliadresDataGridViewTextBoxColumn.HeaderText = "Veli Adresi";
            this.veliadresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veliadresDataGridViewTextBoxColumn.Name = "veliadresDataGridViewTextBoxColumn";
            this.veliadresDataGridViewTextBoxColumn.ReadOnly = true;
            this.veliadresDataGridViewTextBoxColumn.Width = 120;
            // 
            // veliepostaDataGridViewTextBoxColumn
            // 
            this.veliepostaDataGridViewTextBoxColumn.DataPropertyName = "velieposta";
            this.veliepostaDataGridViewTextBoxColumn.HeaderText = "Veli E-Posta";
            this.veliepostaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veliepostaDataGridViewTextBoxColumn.Name = "veliepostaDataGridViewTextBoxColumn";
            this.veliepostaDataGridViewTextBoxColumn.ReadOnly = true;
            this.veliepostaDataGridViewTextBoxColumn.Width = 120;
            // 
            // ogrencikayitBindingSource
            // 
            this.ogrencikayitBindingSource.DataMember = "ogrencikayit";
            this.ogrencikayitBindingSource.DataSource = this.dershaneDataSet;
            // 
            // dershaneDataSet
            // 
            this.dershaneDataSet.DataSetName = "dershaneDataSet";
            this.dershaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrencikayitTableAdapter
            // 
            this.ogrencikayitTableAdapter.ClearBeforeFill = true;
            // 
            // ogrgizlechk
            // 
            this.ogrgizlechk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ogrgizlechk.AutoSize = true;
            this.ogrgizlechk.Location = new System.Drawing.Point(15, 232);
            this.ogrgizlechk.MaximumSize = new System.Drawing.Size(1366, 768);
            this.ogrgizlechk.Name = "ogrgizlechk";
            this.ogrgizlechk.Size = new System.Drawing.Size(168, 24);
            this.ogrgizlechk.TabIndex = 1;
            this.ogrgizlechk.Text = "Öğrenci Bilgilerini Gizle";
            this.ogrgizlechk.UseVisualStyleBackColor = true;
            this.ogrgizlechk.CheckedChanged += new System.EventHandler(this.ogrgizlechk_CheckedChanged);
            this.ogrgizlechk.CheckStateChanged += new System.EventHandler(this.ogrgizlechk_CheckStateChanged);
            // 
            // veligizlechk
            // 
            this.veligizlechk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.veligizlechk.AutoSize = true;
            this.veligizlechk.Location = new System.Drawing.Point(15, 262);
            this.veligizlechk.MaximumSize = new System.Drawing.Size(1366, 768);
            this.veligizlechk.Name = "veligizlechk";
            this.veligizlechk.Size = new System.Drawing.Size(144, 24);
            this.veligizlechk.TabIndex = 1;
            this.veligizlechk.Text = "Veli Bilgilerini Gizle";
            this.veligizlechk.UseVisualStyleBackColor = true;
            this.veligizlechk.CheckedChanged += new System.EventHandler(this.veligizlechk_CheckedChanged);
            // 
            // ismegorearatxt
            // 
            this.ismegorearatxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ismegorearatxt.Font = new System.Drawing.Font("Arial Narrow", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ismegorearatxt.Location = new System.Drawing.Point(18, 61);
            this.ismegorearatxt.Name = "ismegorearatxt";
            this.ismegorearatxt.Size = new System.Drawing.Size(137, 26);
            this.ismegorearatxt.TabIndex = 2;
            this.ismegorearatxt.TextChanged += new System.EventHandler(this.ismegorearatxt_TextChanged);
            // 
            // soyismegorearatxt
            // 
            this.soyismegorearatxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.soyismegorearatxt.Font = new System.Drawing.Font("Arial Narrow", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyismegorearatxt.Location = new System.Drawing.Point(19, 122);
            this.soyismegorearatxt.Name = "soyismegorearatxt";
            this.soyismegorearatxt.Size = new System.Drawing.Size(137, 26);
            this.soyismegorearatxt.TabIndex = 2;
            this.soyismegorearatxt.TextChanged += new System.EventHandler(this.soyismegorearatxt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ogrgizlechk);
            this.groupBox1.Controls.Add(this.veligizlechk);
            this.groupBox1.Controls.Add(this.tcyegorearatxt);
            this.groupBox1.Controls.Add(this.soyismegorearatxt);
            this.groupBox1.Controls.Add(this.ismegorearatxt);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 668);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(18, 305);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(144, 52);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Öğrenci Düzenle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "TC No ya Göre Ara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyisme Göre Ara:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "İsme Göre Ara:";
            // 
            // tcyegorearatxt
            // 
            this.tcyegorearatxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tcyegorearatxt.Font = new System.Drawing.Font("Arial Narrow", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcyegorearatxt.Location = new System.Drawing.Point(19, 183);
            this.tcyegorearatxt.Name = "tcyegorearatxt";
            this.tcyegorearatxt.Size = new System.Drawing.Size(137, 26);
            this.tcyegorearatxt.TabIndex = 2;
            this.tcyegorearatxt.TextChanged += new System.EventHandler(this.tcyegorearatxt_TextChanged);
            // 
            // txtozelnum
            // 
            this.txtozelnum.Location = new System.Drawing.Point(354, 395);
            this.txtozelnum.Name = "txtozelnum";
            this.txtozelnum.Size = new System.Drawing.Size(100, 22);
            this.txtozelnum.TabIndex = 4;
            // 
            // ograrafrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(68)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1387, 669);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtozelnum);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ograrafrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ara";
            this.Load += new System.EventHandler(this.ograrafrm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencikayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ogrgizlechk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceptelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrepostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okuladiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velisoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velitcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velicepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliepostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox veligizlechk;
        private System.Windows.Forms.TextBox ismegorearatxt;
        private System.Windows.Forms.TextBox soyismegorearatxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tcyegorearatxt;
        public System.Windows.Forms.DataGridView dataGridView1;
        public dershaneDataSetTableAdapters.ogrencikayitTableAdapter ogrencikayitTableAdapter;
        public dershaneDataSet dershaneDataSet;
        public System.Windows.Forms.BindingSource ogrencikayitBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public System.Windows.Forms.TextBox txtozelnum;
    }
}
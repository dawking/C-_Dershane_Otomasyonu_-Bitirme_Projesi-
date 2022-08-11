namespace Dershane_Otomasyonu
{
    partial class devamsızlikekle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridogrsec = new System.Windows.Forms.DataGridView();
            this.ogrnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceptelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velicepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencikayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet = new Dershane_Otomasyonu.dershaneDataSet();
            this.ogrencikayitTableAdapter = new Dershane_Otomasyonu.dershaneDataSetTableAdapters.ogrencikayitTableAdapter();
            this.griddvmszlk = new System.Windows.Forms.DataGridView();
            this.dvmszIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrNumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdvmszlkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devamsizlikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dershaneDataSet5 = new Dershane_Otomasyonu.dershaneDataSet5();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.devamsizlikTableAdapter = new Dershane_Otomasyonu.dershaneDataSet5TableAdapters.DevamsizlikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridogrsec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencikayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddvmszlk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devamsizlikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // gridogrsec
            // 
            this.gridogrsec.AllowUserToAddRows = false;
            this.gridogrsec.AutoGenerateColumns = false;
            this.gridogrsec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridogrsec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gridogrsec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridogrsec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrnumDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.ceptelDataGridViewTextBoxColumn,
            this.veliadiDataGridViewTextBoxColumn,
            this.velicepDataGridViewTextBoxColumn});
            this.gridogrsec.DataSource = this.ogrencikayitBindingSource;
            this.gridogrsec.Location = new System.Drawing.Point(2, 3);
            this.gridogrsec.Name = "gridogrsec";
            this.gridogrsec.RowHeadersWidth = 60;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridogrsec.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridogrsec.RowTemplate.Height = 24;
            this.gridogrsec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridogrsec.Size = new System.Drawing.Size(733, 471);
            this.gridogrsec.TabIndex = 0;
            this.gridogrsec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridogrsec_CellClick);
            // 
            // ogrnumDataGridViewTextBoxColumn
            // 
            this.ogrnumDataGridViewTextBoxColumn.DataPropertyName = "ogrnum";
            this.ogrnumDataGridViewTextBoxColumn.HeaderText = "ogrnum";
            this.ogrnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrnumDataGridViewTextBoxColumn.Name = "ogrnumDataGridViewTextBoxColumn";
            this.ogrnumDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrnumDataGridViewTextBoxColumn.Width = 120;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 120;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 120;
            // 
            // ceptelDataGridViewTextBoxColumn
            // 
            this.ceptelDataGridViewTextBoxColumn.DataPropertyName = "ceptel";
            this.ceptelDataGridViewTextBoxColumn.HeaderText = "ceptel";
            this.ceptelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ceptelDataGridViewTextBoxColumn.Name = "ceptelDataGridViewTextBoxColumn";
            this.ceptelDataGridViewTextBoxColumn.Width = 120;
            // 
            // veliadiDataGridViewTextBoxColumn
            // 
            this.veliadiDataGridViewTextBoxColumn.DataPropertyName = "veliadi";
            this.veliadiDataGridViewTextBoxColumn.HeaderText = "veliadi";
            this.veliadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veliadiDataGridViewTextBoxColumn.Name = "veliadiDataGridViewTextBoxColumn";
            this.veliadiDataGridViewTextBoxColumn.Width = 120;
            // 
            // velicepDataGridViewTextBoxColumn
            // 
            this.velicepDataGridViewTextBoxColumn.DataPropertyName = "velicep";
            this.velicepDataGridViewTextBoxColumn.HeaderText = "velicep";
            this.velicepDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.velicepDataGridViewTextBoxColumn.Name = "velicepDataGridViewTextBoxColumn";
            this.velicepDataGridViewTextBoxColumn.Width = 120;
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
            // griddvmszlk
            // 
            this.griddvmszlk.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.griddvmszlk.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.griddvmszlk.AutoGenerateColumns = false;
            this.griddvmszlk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.griddvmszlk.BackgroundColor = System.Drawing.Color.White;
            this.griddvmszlk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddvmszlk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvmszIDDataGridViewTextBoxColumn,
            this.ogrNumDataGridViewTextBoxColumn1,
            this.tdvmszlkDataGridViewTextBoxColumn});
            this.griddvmszlk.DataSource = this.devamsizlikBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.griddvmszlk.DefaultCellStyle = dataGridViewCellStyle3;
            this.griddvmszlk.Location = new System.Drawing.Point(741, 3);
            this.griddvmszlk.Name = "griddvmszlk";
            this.griddvmszlk.RowHeadersWidth = 100;
            this.griddvmszlk.RowTemplate.Height = 24;
            this.griddvmszlk.Size = new System.Drawing.Size(190, 118);
            this.griddvmszlk.TabIndex = 1;
            this.griddvmszlk.Tag = "";
            // 
            // dvmszIDDataGridViewTextBoxColumn
            // 
            this.dvmszIDDataGridViewTextBoxColumn.DataPropertyName = "dvmszID";
            this.dvmszIDDataGridViewTextBoxColumn.HeaderText = "dvmszID";
            this.dvmszIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dvmszIDDataGridViewTextBoxColumn.Name = "dvmszIDDataGridViewTextBoxColumn";
            this.dvmszIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dvmszIDDataGridViewTextBoxColumn.Visible = false;
            this.dvmszIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // ogrNumDataGridViewTextBoxColumn1
            // 
            this.ogrNumDataGridViewTextBoxColumn1.DataPropertyName = "ogrNum";
            this.ogrNumDataGridViewTextBoxColumn1.HeaderText = "ogrNum";
            this.ogrNumDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ogrNumDataGridViewTextBoxColumn1.Name = "ogrNumDataGridViewTextBoxColumn1";
            this.ogrNumDataGridViewTextBoxColumn1.Visible = false;
            this.ogrNumDataGridViewTextBoxColumn1.Width = 87;
            // 
            // tdvmszlkDataGridViewTextBoxColumn
            // 
            this.tdvmszlkDataGridViewTextBoxColumn.DataPropertyName = "tdvmszlk";
            this.tdvmszlkDataGridViewTextBoxColumn.HeaderText = "Toplam Devamsızlık";
            this.tdvmszlkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tdvmszlkDataGridViewTextBoxColumn.Name = "tdvmszlkDataGridViewTextBoxColumn";
            this.tdvmszlkDataGridViewTextBoxColumn.Width = 148;
            // 
            // devamsizlikBindingSource
            // 
            this.devamsizlikBindingSource.DataMember = "Devamsizlik";
            this.devamsizlikBindingSource.DataSource = this.dershaneDataSet5;
            // 
            // dershaneDataSet5
            // 
            this.dershaneDataSet5.DataSetName = "dershaneDataSet5";
            this.dershaneDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(741, 140);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(181, 54);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Tam Gün Devamsızlık İşle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(741, 210);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(181, 54);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Yarım Gün Devamsızlık İşle";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(741, 360);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(181, 54);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Tam Gün Devamsızlık Sil";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(741, 420);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(181, 54);
            this.simpleButton4.TabIndex = 2;
            this.simpleButton4.Text = "Yarım Gün Devamsızlık Sil";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // devamsizlikTableAdapter
            // 
            this.devamsizlikTableAdapter.ClearBeforeFill = true;
            // 
            // devamsızlikekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(940, 620);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.griddvmszlk);
            this.Controls.Add(this.gridogrsec);
            this.Name = "devamsızlikekle";
            this.Text = "devamsızlikekle";
            this.Load += new System.EventHandler(this.devamsızlikekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridogrsec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencikayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddvmszlk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devamsizlikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridogrsec;
        private dershaneDataSet dershaneDataSet;
        private System.Windows.Forms.BindingSource ogrencikayitBindingSource;
        private dershaneDataSetTableAdapters.ogrencikayitTableAdapter ogrencikayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceptelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velicepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView griddvmszlk;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private dershaneDataSet5 dershaneDataSet5;
        private System.Windows.Forms.BindingSource devamsizlikBindingSource;
        private dershaneDataSet5TableAdapters.DevamsizlikTableAdapter devamsizlikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvmszIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdvmszlkDataGridViewTextBoxColumn;
    }
}
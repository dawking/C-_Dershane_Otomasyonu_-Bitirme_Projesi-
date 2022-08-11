namespace Dershane_Otomasyonu
{
    partial class OgrMaas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblmiktar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcyegorearatxt = new System.Windows.Forms.TextBox();
            this.ismegorearatxt = new System.Windows.Forms.TextBox();
            this.dgogretmen = new System.Windows.Forms.DataGridView();
            this.islem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgmaaslar = new System.Windows.Forms.DataGridView();
            this.txtaciklama = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgogretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmaaslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.txtaciklama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblmiktar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tcyegorearatxt);
            this.groupBox1.Controls.Add(this.ismegorearatxt);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 566);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre ve Miktar";
            // 
            // lblmiktar
            // 
            this.lblmiktar.AutoSize = true;
            this.lblmiktar.Font = new System.Drawing.Font("Arial", 9.017391F);
            this.lblmiktar.ForeColor = System.Drawing.Color.White;
            this.lblmiktar.Location = new System.Drawing.Point(9, 242);
            this.lblmiktar.Name = "lblmiktar";
            this.lblmiktar.Size = new System.Drawing.Size(169, 17);
            this.lblmiktar.TabIndex = 3;
            this.lblmiktar.Text = "Ödenecek Miktarı Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.017391F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "TC No ya Göre Ara:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.017391F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "İsme Göre Ara:";
            // 
            // tcyegorearatxt
            // 
            this.tcyegorearatxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tcyegorearatxt.Font = new System.Drawing.Font("Arial Narrow", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcyegorearatxt.Location = new System.Drawing.Point(11, 135);
            this.tcyegorearatxt.Name = "tcyegorearatxt";
            this.tcyegorearatxt.Size = new System.Drawing.Size(137, 26);
            this.tcyegorearatxt.TabIndex = 2;
            this.tcyegorearatxt.TextChanged += new System.EventHandler(this.tcyegorearatxt_TextChanged);
            // 
            // ismegorearatxt
            // 
            this.ismegorearatxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ismegorearatxt.Font = new System.Drawing.Font("Arial Narrow", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ismegorearatxt.Location = new System.Drawing.Point(11, 61);
            this.ismegorearatxt.Name = "ismegorearatxt";
            this.ismegorearatxt.Size = new System.Drawing.Size(137, 26);
            this.ismegorearatxt.TabIndex = 2;
            this.ismegorearatxt.TextChanged += new System.EventHandler(this.ismegorearatxt_TextChanged);
            // 
            // dgogretmen
            // 
            this.dgogretmen.AllowUserToAddRows = false;
            this.dgogretmen.AllowUserToDeleteRows = false;
            this.dgogretmen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgogretmen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgogretmen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.dgogretmen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgogretmen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgogretmen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgogretmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgogretmen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.islem});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgogretmen.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgogretmen.Location = new System.Drawing.Point(185, 3);
            this.dgogretmen.MultiSelect = false;
            this.dgogretmen.Name = "dgogretmen";
            this.dgogretmen.ReadOnly = true;
            this.dgogretmen.RowHeadersWidth = 49;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgogretmen.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgogretmen.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgogretmen.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgogretmen.RowTemplate.Height = 24;
            this.dgogretmen.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgogretmen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgogretmen.Size = new System.Drawing.Size(501, 566);
            this.dgogretmen.TabIndex = 5;
            this.dgogretmen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgogretmen_CellClick);
            this.dgogretmen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgogretmen_CellContentClick);
            this.dgogretmen.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgogretmen_ColumnHeaderMouseClick);
            // 
            // islem
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.islem.DefaultCellStyle = dataGridViewCellStyle2;
            this.islem.HeaderText = "İşlem";
            this.islem.MinimumWidth = 6;
            this.islem.Name = "islem";
            this.islem.ReadOnly = true;
            this.islem.Text = "Öde";
            this.islem.UseColumnTextForButtonValue = true;
            // 
            // dgmaaslar
            // 
            this.dgmaaslar.AllowUserToAddRows = false;
            this.dgmaaslar.AllowUserToDeleteRows = false;
            this.dgmaaslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgmaaslar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgmaaslar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.dgmaaslar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgmaaslar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgmaaslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgmaaslar.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgmaaslar.Location = new System.Drawing.Point(685, 3);
            this.dgmaaslar.MultiSelect = false;
            this.dgmaaslar.Name = "dgmaaslar";
            this.dgmaaslar.RowHeadersWidth = 49;
            this.dgmaaslar.RowTemplate.Height = 24;
            this.dgmaaslar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgmaaslar.Size = new System.Drawing.Size(517, 566);
            this.dgmaaslar.TabIndex = 7;
            this.dgmaaslar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmaaslar_CellContentClick);
            this.dgmaaslar.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgmaaslar_ColumnHeaderMouseClick);
            // 
            // txtaciklama
            // 
            this.txtaciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtaciklama.Location = new System.Drawing.Point(13, 325);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(137, 65);
            this.txtaciklama.TabIndex = 4;
            this.txtaciklama.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.017391F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama Giriniz:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMiktar.Location = new System.Drawing.Point(13, 263);
            this.txtMiktar.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtMiktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(120, 26);
            this.txtMiktar.TabIndex = 5;
            this.txtMiktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OgrMaas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1202, 571);
            this.Controls.Add(this.dgmaaslar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgogretmen);
            this.Name = "OgrMaas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Maaş Öde";
            this.Load += new System.EventHandler(this.OgrMaas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgogretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmaaslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tcyegorearatxt;
        private System.Windows.Forms.TextBox ismegorearatxt;
        private System.Windows.Forms.DataGridView dgogretmen;
        private System.Windows.Forms.Label lblmiktar;
        private System.Windows.Forms.DataGridViewButtonColumn islem;
        private System.Windows.Forms.DataGridView dgmaaslar;
        private System.Windows.Forms.RichTextBox txtaciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtMiktar;
    }
}
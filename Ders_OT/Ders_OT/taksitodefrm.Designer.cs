namespace Dershane_Otomasyonu
{
    partial class taksitodefrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgogrsec = new System.Windows.Forms.DataGridView();
            this.dgtaksitler = new System.Windows.Forms.DataGridView();
            this.Ode = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ismegorearatxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tcyegorearatxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgogrsec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtaksitler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgogrsec
            // 
            this.dgogrsec.AllowUserToAddRows = false;
            this.dgogrsec.AllowUserToDeleteRows = false;
            this.dgogrsec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgogrsec.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgogrsec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.dgogrsec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgogrsec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgogrsec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgogrsec.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgogrsec.Location = new System.Drawing.Point(189, 6);
            this.dgogrsec.Name = "dgogrsec";
            this.dgogrsec.RowHeadersWidth = 49;
            this.dgogrsec.RowTemplate.Height = 24;
            this.dgogrsec.Size = new System.Drawing.Size(315, 566);
            this.dgogrsec.TabIndex = 0;
            this.dgogrsec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgogrsec_CellContentClick);
            // 
            // dgtaksitler
            // 
            this.dgtaksitler.AllowUserToAddRows = false;
            this.dgtaksitler.AllowUserToDeleteRows = false;
            this.dgtaksitler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtaksitler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.dgtaksitler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgtaksitler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtaksitler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ode});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtaksitler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgtaksitler.Location = new System.Drawing.Point(503, 6);
            this.dgtaksitler.Name = "dgtaksitler";
            this.dgtaksitler.ReadOnly = true;
            this.dgtaksitler.RowHeadersWidth = 49;
            this.dgtaksitler.RowTemplate.Height = 24;
            this.dgtaksitler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtaksitler.Size = new System.Drawing.Size(666, 566);
            this.dgtaksitler.TabIndex = 1;
            this.dgtaksitler.Visible = false;
            this.dgtaksitler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtaksitler_CellClick);
            this.dgtaksitler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtaksitler_CellContentClick);
            this.dgtaksitler.SelectionChanged += new System.EventHandler(this.dgtaksitler_SelectionChanged);
            // 
            // Ode
            // 
            this.Ode.HeaderText = "İşlem";
            this.Ode.MinimumWidth = 6;
            this.Ode.Name = "Ode";
            this.Ode.ReadOnly = true;
            this.Ode.Text = "Öde";
            this.Ode.UseColumnTextForButtonValue = true;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tcyegorearatxt);
            this.groupBox1.Controls.Add(this.ismegorearatxt);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 566);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "TC No ya Göre Ara:";
            // 
            // tcyegorearatxt
            // 
            this.tcyegorearatxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tcyegorearatxt.Font = new System.Drawing.Font("Arial Narrow", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcyegorearatxt.Location = new System.Drawing.Point(18, 135);
            this.tcyegorearatxt.Name = "tcyegorearatxt";
            this.tcyegorearatxt.Size = new System.Drawing.Size(137, 26);
            this.tcyegorearatxt.TabIndex = 2;
            this.tcyegorearatxt.TextChanged += new System.EventHandler(this.tcyegorearatxt_TextChanged);
            // 
            // taksitodefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1175, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgtaksitler);
            this.Controls.Add(this.dgogrsec);
            this.Name = "taksitodefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taksit Öde";
            this.Load += new System.EventHandler(this.taksitodefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgogrsec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtaksitler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgogrsec;
        private System.Windows.Forms.DataGridView dgtaksitler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ismegorearatxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tcyegorearatxt;
        private System.Windows.Forms.DataGridViewButtonColumn Ode;
    }
}
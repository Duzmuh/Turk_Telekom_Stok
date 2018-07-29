namespace Turk_Telekom_Stok
{
    partial class frmAnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaMenu));
            this.btnStokGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.gridAnaMenu = new System.Windows.Forms.DataGridView();
            this.btnStokCikis = new System.Windows.Forms.Button();
            this.btnGÇTakip = new System.Windows.Forms.Button();
            this.gridBildirim = new System.Windows.Forms.DataGridView();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnHakkinda = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gridAdKod = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGosDat = new System.Windows.Forms.ComboBox();
            this.dtPic = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnaMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBildirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdKod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStokGiris
            // 
            this.btnStokGiris.BackColor = System.Drawing.Color.OliveDrab;
            this.btnStokGiris.Location = new System.Drawing.Point(32, 38);
            this.btnStokGiris.Name = "btnStokGiris";
            this.btnStokGiris.Size = new System.Drawing.Size(80, 80);
            this.btnStokGiris.TabIndex = 0;
            this.btnStokGiris.Text = "STOK GİRİŞ";
            this.btnStokGiris.UseVisualStyleBackColor = false;
            this.btnStokGiris.Click += new System.EventHandler(this.btnStokGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÜKENMEK ÜZERE OLAN ÜRÜNLER";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(370, 39);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(200, 20);
            this.txtAra.TabIndex = 2;
            this.txtAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gridAnaMenu
            // 
            this.gridAnaMenu.AllowUserToAddRows = false;
            this.gridAnaMenu.AllowUserToDeleteRows = false;
            this.gridAnaMenu.AllowUserToResizeColumns = false;
            this.gridAnaMenu.AllowUserToResizeRows = false;
            this.gridAnaMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAnaMenu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridAnaMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAnaMenu.Location = new System.Drawing.Point(244, 114);
            this.gridAnaMenu.MultiSelect = false;
            this.gridAnaMenu.Name = "gridAnaMenu";
            this.gridAnaMenu.ReadOnly = true;
            this.gridAnaMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAnaMenu.Size = new System.Drawing.Size(928, 535);
            this.gridAnaMenu.TabIndex = 3;
            // 
            // btnStokCikis
            // 
            this.btnStokCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStokCikis.Location = new System.Drawing.Point(118, 53);
            this.btnStokCikis.Name = "btnStokCikis";
            this.btnStokCikis.Size = new System.Drawing.Size(80, 80);
            this.btnStokCikis.TabIndex = 4;
            this.btnStokCikis.Text = "STOK ÇIKIŞ";
            this.btnStokCikis.UseVisualStyleBackColor = false;
            this.btnStokCikis.Click += new System.EventHandler(this.btnStokCikis_Click);
            // 
            // btnGÇTakip
            // 
            this.btnGÇTakip.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGÇTakip.Location = new System.Drawing.Point(14, 124);
            this.btnGÇTakip.Name = "btnGÇTakip";
            this.btnGÇTakip.Size = new System.Drawing.Size(80, 80);
            this.btnGÇTakip.TabIndex = 5;
            this.btnGÇTakip.Text = "AYARLAR";
            this.btnGÇTakip.UseVisualStyleBackColor = false;
            this.btnGÇTakip.Click += new System.EventHandler(this.btnGÇTakip_Click);
            // 
            // gridBildirim
            // 
            this.gridBildirim.AllowUserToAddRows = false;
            this.gridBildirim.AllowUserToDeleteRows = false;
            this.gridBildirim.AllowUserToResizeColumns = false;
            this.gridBildirim.AllowUserToResizeRows = false;
            this.gridBildirim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBildirim.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridBildirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBildirim.Location = new System.Drawing.Point(12, 481);
            this.gridBildirim.MultiSelect = false;
            this.gridBildirim.Name = "gridBildirim";
            this.gridBildirim.ReadOnly = true;
            this.gridBildirim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBildirim.Size = new System.Drawing.Size(219, 168);
            this.gridBildirim.TabIndex = 6;
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.Gold;
            this.btnRapor.Location = new System.Drawing.Point(100, 139);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(80, 80);
            this.btnRapor.TabIndex = 7;
            this.btnRapor.Text = "RAPORLA";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.Location = new System.Drawing.Point(985, 48);
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Size = new System.Drawing.Size(80, 60);
            this.btnHakkinda.TabIndex = 8;
            this.btnHakkinda.Text = "HAKKINDA";
            this.btnHakkinda.UseVisualStyleBackColor = true;
            this.btnHakkinda.Click += new System.EventHandler(this.btnHakkinda_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(203, 413);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(28, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Visible = false;
            // 
            // gridAdKod
            // 
            this.gridAdKod.AllowUserToAddRows = false;
            this.gridAdKod.AllowUserToDeleteRows = false;
            this.gridAdKod.AllowUserToResizeColumns = false;
            this.gridAdKod.AllowUserToResizeRows = false;
            this.gridAdKod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAdKod.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridAdKod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAdKod.Location = new System.Drawing.Point(12, 266);
            this.gridAdKod.MultiSelect = false;
            this.gridAdKod.Name = "gridAdKod";
            this.gridAdKod.ReadOnly = true;
            this.gridAdKod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAdKod.Size = new System.Drawing.Size(219, 168);
            this.gridAdKod.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ÜRÜN ADLARINA AİT ÜRÜN KODLARI";
            // 
            // cmbGosDat
            // 
            this.cmbGosDat.FormattingEnabled = true;
            this.cmbGosDat.Items.AddRange(new object[] {
            "Stok Giriş Kayıtları",
            "Stok Çıkış Kayıtları"});
            this.cmbGosDat.Location = new System.Drawing.Point(370, 12);
            this.cmbGosDat.Name = "cmbGosDat";
            this.cmbGosDat.Size = new System.Drawing.Size(200, 21);
            this.cmbGosDat.TabIndex = 16;
            this.cmbGosDat.Text = "Stok Giriş Kayıtları";
            this.cmbGosDat.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dtPic
            // 
            this.dtPic.Location = new System.Drawing.Point(370, 66);
            this.dtPic.Name = "dtPic";
            this.dtPic.Size = new System.Drawing.Size(200, 20);
            this.dtPic.TabIndex = 17;
            this.dtPic.ValueChanged += new System.EventHandler(this.dtPic_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Gösterilen Kayıtlar : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Stok Koduna Göre Ara : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tarihe Göre Ara : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1071, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 101);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(680, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(385, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "KUDO TÜRK TELEKOM STOK TAKİP";
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPic);
            this.Controls.Add(this.cmbGosDat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridAdKod);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnHakkinda);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.gridBildirim);
            this.Controls.Add(this.btnGÇTakip);
            this.Controls.Add(this.btnStokCikis);
            this.Controls.Add(this.gridAnaMenu);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStokGiris);
            this.Name = "frmAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Türk Telekom Stok";
            this.Load += new System.EventHandler(this.frmAnaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAnaMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBildirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdKod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStokGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridView gridAnaMenu;
        private System.Windows.Forms.Button btnStokCikis;
        private System.Windows.Forms.Button btnGÇTakip;
        private System.Windows.Forms.DataGridView gridBildirim;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnHakkinda;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView gridAdKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGosDat;
        private System.Windows.Forms.DateTimePicker dtPic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}


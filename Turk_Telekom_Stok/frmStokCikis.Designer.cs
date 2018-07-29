namespace Turk_Telekom_Stok
{
    partial class frmStokCikis
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
            this.gridStokCikis = new System.Windows.Forms.DataGridView();
            this.grbStokCikis = new System.Windows.Forms.GroupBox();
            this.lblCikisBildirim = new System.Windows.Forms.Label();
            this.txtCikisMusteri = new System.Windows.Forms.TextBox();
            this.txtCikisMiktar = new System.Windows.Forms.TextBox();
            this.txtCikisTipi = new System.Windows.Forms.ComboBox();
            this.txtCikisKodu = new System.Windows.Forms.ComboBox();
            this.txtCikisTarih = new System.Windows.Forms.DateTimePicker();
            this.txtCikisAciklama = new System.Windows.Forms.RichTextBox();
            this.txtCikisAdi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCikisExcel = new System.Windows.Forms.Button();
            this.btnCikisSil = new System.Windows.Forms.Button();
            this.btnCikisEkle = new System.Windows.Forms.Button();
            this.btnCikisGuncelle = new System.Windows.Forms.Button();
            this.btnCikisİptal = new System.Windows.Forms.Button();
            this.btnCikisAnaMenu = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gridAdKod = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokCikis)).BeginInit();
            this.grbStokCikis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdKod)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStokCikis
            // 
            this.gridStokCikis.AllowUserToAddRows = false;
            this.gridStokCikis.AllowUserToDeleteRows = false;
            this.gridStokCikis.AllowUserToResizeColumns = false;
            this.gridStokCikis.AllowUserToResizeRows = false;
            this.gridStokCikis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStokCikis.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridStokCikis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStokCikis.Location = new System.Drawing.Point(424, 12);
            this.gridStokCikis.MultiSelect = false;
            this.gridStokCikis.Name = "gridStokCikis";
            this.gridStokCikis.ReadOnly = true;
            this.gridStokCikis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStokCikis.Size = new System.Drawing.Size(748, 637);
            this.gridStokCikis.TabIndex = 30;
            this.gridStokCikis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStokCikis_CellClick);
            // 
            // grbStokCikis
            // 
            this.grbStokCikis.Controls.Add(this.lblCikisBildirim);
            this.grbStokCikis.Controls.Add(this.txtCikisMusteri);
            this.grbStokCikis.Controls.Add(this.txtCikisMiktar);
            this.grbStokCikis.Controls.Add(this.txtCikisTipi);
            this.grbStokCikis.Controls.Add(this.txtCikisKodu);
            this.grbStokCikis.Controls.Add(this.txtCikisTarih);
            this.grbStokCikis.Controls.Add(this.txtCikisAciklama);
            this.grbStokCikis.Controls.Add(this.txtCikisAdi);
            this.grbStokCikis.Controls.Add(this.label8);
            this.grbStokCikis.Controls.Add(this.label1);
            this.grbStokCikis.Controls.Add(this.label7);
            this.grbStokCikis.Controls.Add(this.label2);
            this.grbStokCikis.Controls.Add(this.label3);
            this.grbStokCikis.Controls.Add(this.label5);
            this.grbStokCikis.Controls.Add(this.label4);
            this.grbStokCikis.Controls.Add(this.btnCikisExcel);
            this.grbStokCikis.Controls.Add(this.btnCikisSil);
            this.grbStokCikis.Controls.Add(this.btnCikisEkle);
            this.grbStokCikis.Controls.Add(this.btnCikisGuncelle);
            this.grbStokCikis.Controls.Add(this.btnCikisİptal);
            this.grbStokCikis.Location = new System.Drawing.Point(12, 12);
            this.grbStokCikis.Name = "grbStokCikis";
            this.grbStokCikis.Size = new System.Drawing.Size(389, 344);
            this.grbStokCikis.TabIndex = 0;
            this.grbStokCikis.TabStop = false;
            this.grbStokCikis.Text = "Stok Çıkış Bilgilerini Girin";
            // 
            // lblCikisBildirim
            // 
            this.lblCikisBildirim.AutoSize = true;
            this.lblCikisBildirim.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCikisBildirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikisBildirim.ForeColor = System.Drawing.Color.Red;
            this.lblCikisBildirim.Location = new System.Drawing.Point(10, 303);
            this.lblCikisBildirim.Name = "lblCikisBildirim";
            this.lblCikisBildirim.Size = new System.Drawing.Size(0, 15);
            this.lblCikisBildirim.TabIndex = 26;
            // 
            // txtCikisMusteri
            // 
            this.txtCikisMusteri.Location = new System.Drawing.Point(152, 127);
            this.txtCikisMusteri.Name = "txtCikisMusteri";
            this.txtCikisMusteri.Size = new System.Drawing.Size(218, 20);
            this.txtCikisMusteri.TabIndex = 4;
            // 
            // txtCikisMiktar
            // 
            this.txtCikisMiktar.Location = new System.Drawing.Point(152, 101);
            this.txtCikisMiktar.Name = "txtCikisMiktar";
            this.txtCikisMiktar.Size = new System.Drawing.Size(218, 20);
            this.txtCikisMiktar.TabIndex = 3;
            // 
            // txtCikisTipi
            // 
            this.txtCikisTipi.FormattingEnabled = true;
            this.txtCikisTipi.Items.AddRange(new object[] {
            "Metre",
            "Adet"});
            this.txtCikisTipi.Location = new System.Drawing.Point(152, 47);
            this.txtCikisTipi.Name = "txtCikisTipi";
            this.txtCikisTipi.Size = new System.Drawing.Size(218, 21);
            this.txtCikisTipi.TabIndex = 39;
            // 
            // txtCikisKodu
            // 
            this.txtCikisKodu.FormattingEnabled = true;
            this.txtCikisKodu.Location = new System.Drawing.Point(152, 74);
            this.txtCikisKodu.Name = "txtCikisKodu";
            this.txtCikisKodu.Size = new System.Drawing.Size(218, 21);
            this.txtCikisKodu.TabIndex = 2;
            // 
            // txtCikisTarih
            // 
            this.txtCikisTarih.Location = new System.Drawing.Point(152, 153);
            this.txtCikisTarih.Name = "txtCikisTarih";
            this.txtCikisTarih.Size = new System.Drawing.Size(218, 20);
            this.txtCikisTarih.TabIndex = 5;
            // 
            // txtCikisAciklama
            // 
            this.txtCikisAciklama.Location = new System.Drawing.Point(152, 179);
            this.txtCikisAciklama.Name = "txtCikisAciklama";
            this.txtCikisAciklama.Size = new System.Drawing.Size(218, 41);
            this.txtCikisAciklama.TabIndex = 6;
            this.txtCikisAciklama.Text = "";
            // 
            // txtCikisAdi
            // 
            this.txtCikisAdi.FormattingEnabled = true;
            this.txtCikisAdi.Location = new System.Drawing.Point(152, 20);
            this.txtCikisAdi.Name = "txtCikisAdi";
            this.txtCikisAdi.Size = new System.Drawing.Size(218, 21);
            this.txtCikisAdi.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Proje - Müşteri Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Stok Adı : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Stok Kodu : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Stok Tipi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kullanılan Miktar : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Açıklama : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Çıkış Tarihi : ";
            // 
            // btnCikisExcel
            // 
            this.btnCikisExcel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCikisExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisExcel.Location = new System.Drawing.Point(225, 253);
            this.btnCikisExcel.Name = "btnCikisExcel";
            this.btnCikisExcel.Size = new System.Drawing.Size(67, 37);
            this.btnCikisExcel.TabIndex = 10;
            this.btnCikisExcel.Text = "Excele Kaydet";
            this.btnCikisExcel.UseVisualStyleBackColor = false;
            this.btnCikisExcel.Click += new System.EventHandler(this.btnCikisExcel_Click);
            // 
            // btnCikisSil
            // 
            this.btnCikisSil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCikisSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisSil.Location = new System.Drawing.Point(152, 253);
            this.btnCikisSil.Name = "btnCikisSil";
            this.btnCikisSil.Size = new System.Drawing.Size(67, 37);
            this.btnCikisSil.TabIndex = 9;
            this.btnCikisSil.Text = "Stok Sil";
            this.btnCikisSil.UseVisualStyleBackColor = false;
            this.btnCikisSil.Click += new System.EventHandler(this.btnCikisSil_Click);
            // 
            // btnCikisEkle
            // 
            this.btnCikisEkle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCikisEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisEkle.Location = new System.Drawing.Point(6, 253);
            this.btnCikisEkle.Name = "btnCikisEkle";
            this.btnCikisEkle.Size = new System.Drawing.Size(67, 37);
            this.btnCikisEkle.TabIndex = 7;
            this.btnCikisEkle.Text = "Stok Ekle";
            this.btnCikisEkle.UseVisualStyleBackColor = false;
            this.btnCikisEkle.Click += new System.EventHandler(this.btnCikisEkle_Click);
            // 
            // btnCikisGuncelle
            // 
            this.btnCikisGuncelle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCikisGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisGuncelle.Location = new System.Drawing.Point(79, 253);
            this.btnCikisGuncelle.Name = "btnCikisGuncelle";
            this.btnCikisGuncelle.Size = new System.Drawing.Size(67, 37);
            this.btnCikisGuncelle.TabIndex = 8;
            this.btnCikisGuncelle.Text = "Stok Güncelle";
            this.btnCikisGuncelle.UseVisualStyleBackColor = false;
            this.btnCikisGuncelle.Click += new System.EventHandler(this.btnCikisGuncelle_Click);
            // 
            // btnCikisİptal
            // 
            this.btnCikisİptal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCikisİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisİptal.Location = new System.Drawing.Point(298, 253);
            this.btnCikisİptal.Name = "btnCikisİptal";
            this.btnCikisİptal.Size = new System.Drawing.Size(67, 37);
            this.btnCikisİptal.TabIndex = 11;
            this.btnCikisİptal.Text = "İptal";
            this.btnCikisİptal.UseVisualStyleBackColor = false;
            this.btnCikisİptal.Click += new System.EventHandler(this.btnCikisİptal_Click);
            // 
            // btnCikisAnaMenu
            // 
            this.btnCikisAnaMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCikisAnaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisAnaMenu.Location = new System.Drawing.Point(12, 589);
            this.btnCikisAnaMenu.Name = "btnCikisAnaMenu";
            this.btnCikisAnaMenu.Size = new System.Drawing.Size(80, 60);
            this.btnCikisAnaMenu.TabIndex = 14;
            this.btnCikisAnaMenu.Text = "Ana Menü";
            this.btnCikisAnaMenu.UseVisualStyleBackColor = false;
            this.btnCikisAnaMenu.Click += new System.EventHandler(this.btnCikisAnaMenu_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(387, 611);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(13, 21);
            this.comboBox1.TabIndex = 26;
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
            this.gridAdKod.Location = new System.Drawing.Point(12, 394);
            this.gridAdKod.MultiSelect = false;
            this.gridAdKod.Name = "gridAdKod";
            this.gridAdKod.ReadOnly = true;
            this.gridAdKod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAdKod.Size = new System.Drawing.Size(231, 168);
            this.gridAdKod.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "ÜRÜN ADLARINA AİT ÜRÜN KODLARI";
            // 
            // frmStokCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridAdKod);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCikisAnaMenu);
            this.Controls.Add(this.grbStokCikis);
            this.Controls.Add(this.gridStokCikis);
            this.Name = "frmStokCikis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Çıkışı";
            this.Load += new System.EventHandler(this.frmStokCikis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStokCikis)).EndInit();
            this.grbStokCikis.ResumeLayout(false);
            this.grbStokCikis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdKod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridStokCikis;
        private System.Windows.Forms.GroupBox grbStokCikis;
        private System.Windows.Forms.Button btnCikisAnaMenu;
        private System.Windows.Forms.Button btnCikisSil;
        private System.Windows.Forms.Button btnCikisGuncelle;
        private System.Windows.Forms.Button btnCikisExcel;
        private System.Windows.Forms.Button btnCikisİptal;
        private System.Windows.Forms.Button btnCikisEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtCikisAdi;
        private System.Windows.Forms.TextBox txtCikisMusteri;
        private System.Windows.Forms.TextBox txtCikisMiktar;
        private System.Windows.Forms.ComboBox txtCikisTipi;
        private System.Windows.Forms.ComboBox txtCikisKodu;
        private System.Windows.Forms.DateTimePicker txtCikisTarih;
        private System.Windows.Forms.RichTextBox txtCikisAciklama;
        private System.Windows.Forms.Label lblCikisBildirim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView gridAdKod;
        private System.Windows.Forms.Label label6;
    }
}
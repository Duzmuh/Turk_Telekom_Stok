namespace Turk_Telekom_Stok
{
    partial class frmStokGiris
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
            this.gridStokGiris = new System.Windows.Forms.DataGridView();
            this.btnGirisEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStokGrsMiktar = new System.Windows.Forms.TextBox();
            this.txtStokGrsTarih = new System.Windows.Forms.DateTimePicker();
            this.txtStokGrsAdi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGirisBildirim = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbStokGiris = new System.Windows.Forms.GroupBox();
            this.btnGirisSil = new System.Windows.Forms.Button();
            this.btnGirisGuncelle = new System.Windows.Forms.Button();
            this.btnGirisExcel = new System.Windows.Forms.Button();
            this.btnGirisIptal = new System.Windows.Forms.Button();
            this.txtStokGrsAciklama = new System.Windows.Forms.RichTextBox();
            this.txtStokGrsKodu = new System.Windows.Forms.ComboBox();
            this.txtStokGrsTipi = new System.Windows.Forms.ComboBox();
            this.btnGirisAnaMenu = new System.Windows.Forms.Button();
            this._cmbbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokGiris)).BeginInit();
            this.grbStokGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridStokGiris
            // 
            this.gridStokGiris.AllowUserToAddRows = false;
            this.gridStokGiris.AllowUserToDeleteRows = false;
            this.gridStokGiris.AllowUserToResizeColumns = false;
            this.gridStokGiris.AllowUserToResizeRows = false;
            this.gridStokGiris.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStokGiris.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridStokGiris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStokGiris.Location = new System.Drawing.Point(424, 12);
            this.gridStokGiris.MultiSelect = false;
            this.gridStokGiris.Name = "gridStokGiris";
            this.gridStokGiris.ReadOnly = true;
            this.gridStokGiris.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStokGiris.Size = new System.Drawing.Size(748, 637);
            this.gridStokGiris.TabIndex = 30;
            this.gridStokGiris.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStokGiris_CellClick);
            // 
            // btnGirisEkle
            // 
            this.btnGirisEkle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGirisEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisEkle.Location = new System.Drawing.Point(6, 239);
            this.btnGirisEkle.Name = "btnGirisEkle";
            this.btnGirisEkle.Size = new System.Drawing.Size(67, 37);
            this.btnGirisEkle.TabIndex = 6;
            this.btnGirisEkle.Text = "Stok Ekle";
            this.btnGirisEkle.UseVisualStyleBackColor = false;
            this.btnGirisEkle.Click += new System.EventHandler(this.btnGirisEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stok Adı : ";
            // 
            // txtStokGrsMiktar
            // 
            this.txtStokGrsMiktar.Location = new System.Drawing.Point(94, 107);
            this.txtStokGrsMiktar.Name = "txtStokGrsMiktar";
            this.txtStokGrsMiktar.Size = new System.Drawing.Size(283, 20);
            this.txtStokGrsMiktar.TabIndex = 3;
            // 
            // txtStokGrsTarih
            // 
            this.txtStokGrsTarih.Location = new System.Drawing.Point(94, 133);
            this.txtStokGrsTarih.Name = "txtStokGrsTarih";
            this.txtStokGrsTarih.Size = new System.Drawing.Size(283, 20);
            this.txtStokGrsTarih.TabIndex = 4;
            // 
            // txtStokGrsAdi
            // 
            this.txtStokGrsAdi.FormattingEnabled = true;
            this.txtStokGrsAdi.Location = new System.Drawing.Point(94, 26);
            this.txtStokGrsAdi.Name = "txtStokGrsAdi";
            this.txtStokGrsAdi.Size = new System.Drawing.Size(283, 21);
            this.txtStokGrsAdi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stok Tipi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stok Miktar : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giriş Tarihi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Açıklama : ";
            // 
            // lblGirisBildirim
            // 
            this.lblGirisBildirim.AutoSize = true;
            this.lblGirisBildirim.BackColor = System.Drawing.Color.SteelBlue;
            this.lblGirisBildirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisBildirim.ForeColor = System.Drawing.Color.Red;
            this.lblGirisBildirim.Location = new System.Drawing.Point(6, 302);
            this.lblGirisBildirim.Name = "lblGirisBildirim";
            this.lblGirisBildirim.Size = new System.Drawing.Size(0, 15);
            this.lblGirisBildirim.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Stok Kodu : ";
            // 
            // grbStokGiris
            // 
            this.grbStokGiris.Controls.Add(this.btnGirisSil);
            this.grbStokGiris.Controls.Add(this.lblGirisBildirim);
            this.grbStokGiris.Controls.Add(this.btnGirisGuncelle);
            this.grbStokGiris.Controls.Add(this.btnGirisExcel);
            this.grbStokGiris.Controls.Add(this.btnGirisIptal);
            this.grbStokGiris.Controls.Add(this.txtStokGrsAciklama);
            this.grbStokGiris.Controls.Add(this.txtStokGrsKodu);
            this.grbStokGiris.Controls.Add(this.btnGirisEkle);
            this.grbStokGiris.Controls.Add(this.txtStokGrsTipi);
            this.grbStokGiris.Controls.Add(this.txtStokGrsTarih);
            this.grbStokGiris.Controls.Add(this.label1);
            this.grbStokGiris.Controls.Add(this.label7);
            this.grbStokGiris.Controls.Add(this.txtStokGrsAdi);
            this.grbStokGiris.Controls.Add(this.label2);
            this.grbStokGiris.Controls.Add(this.label3);
            this.grbStokGiris.Controls.Add(this.txtStokGrsMiktar);
            this.grbStokGiris.Controls.Add(this.label5);
            this.grbStokGiris.Controls.Add(this.label4);
            this.grbStokGiris.Location = new System.Drawing.Point(12, 12);
            this.grbStokGiris.Name = "grbStokGiris";
            this.grbStokGiris.Size = new System.Drawing.Size(390, 337);
            this.grbStokGiris.TabIndex = 0;
            this.grbStokGiris.TabStop = false;
            this.grbStokGiris.Text = "Stok Bilgilerini Girin";
            // 
            // btnGirisSil
            // 
            this.btnGirisSil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGirisSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisSil.Location = new System.Drawing.Point(158, 239);
            this.btnGirisSil.Name = "btnGirisSil";
            this.btnGirisSil.Size = new System.Drawing.Size(67, 37);
            this.btnGirisSil.TabIndex = 8;
            this.btnGirisSil.Text = "Stok Sil";
            this.btnGirisSil.UseVisualStyleBackColor = false;
            this.btnGirisSil.Click += new System.EventHandler(this.btnGirisSil_Click);
            // 
            // btnGirisGuncelle
            // 
            this.btnGirisGuncelle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGirisGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisGuncelle.Location = new System.Drawing.Point(82, 239);
            this.btnGirisGuncelle.Name = "btnGirisGuncelle";
            this.btnGirisGuncelle.Size = new System.Drawing.Size(67, 37);
            this.btnGirisGuncelle.TabIndex = 7;
            this.btnGirisGuncelle.Text = "Stok Güncelle";
            this.btnGirisGuncelle.UseVisualStyleBackColor = false;
            this.btnGirisGuncelle.Click += new System.EventHandler(this.btnGirisGuncelle_Click);
            // 
            // btnGirisExcel
            // 
            this.btnGirisExcel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGirisExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisExcel.Location = new System.Drawing.Point(234, 239);
            this.btnGirisExcel.Name = "btnGirisExcel";
            this.btnGirisExcel.Size = new System.Drawing.Size(67, 37);
            this.btnGirisExcel.TabIndex = 9;
            this.btnGirisExcel.Text = "Excele Kaydet";
            this.btnGirisExcel.UseVisualStyleBackColor = false;
            this.btnGirisExcel.Click += new System.EventHandler(this.btnGirisExcel_Click);
            // 
            // btnGirisIptal
            // 
            this.btnGirisIptal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGirisIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisIptal.Location = new System.Drawing.Point(310, 239);
            this.btnGirisIptal.Name = "btnGirisIptal";
            this.btnGirisIptal.Size = new System.Drawing.Size(67, 37);
            this.btnGirisIptal.TabIndex = 10;
            this.btnGirisIptal.Text = "İptal";
            this.btnGirisIptal.UseVisualStyleBackColor = false;
            this.btnGirisIptal.Click += new System.EventHandler(this.btnGirisIptal_Click);
            // 
            // txtStokGrsAciklama
            // 
            this.txtStokGrsAciklama.Location = new System.Drawing.Point(94, 159);
            this.txtStokGrsAciklama.Name = "txtStokGrsAciklama";
            this.txtStokGrsAciklama.Size = new System.Drawing.Size(283, 56);
            this.txtStokGrsAciklama.TabIndex = 5;
            this.txtStokGrsAciklama.Text = "";
            // 
            // txtStokGrsKodu
            // 
            this.txtStokGrsKodu.FormattingEnabled = true;
            this.txtStokGrsKodu.Location = new System.Drawing.Point(94, 80);
            this.txtStokGrsKodu.Name = "txtStokGrsKodu";
            this.txtStokGrsKodu.Size = new System.Drawing.Size(283, 21);
            this.txtStokGrsKodu.TabIndex = 2;
            // 
            // txtStokGrsTipi
            // 
            this.txtStokGrsTipi.FormattingEnabled = true;
            this.txtStokGrsTipi.Items.AddRange(new object[] {
            "Metre",
            "Adet"});
            this.txtStokGrsTipi.Location = new System.Drawing.Point(94, 53);
            this.txtStokGrsTipi.Name = "txtStokGrsTipi";
            this.txtStokGrsTipi.Size = new System.Drawing.Size(283, 21);
            this.txtStokGrsTipi.TabIndex = 1;
            // 
            // btnGirisAnaMenu
            // 
            this.btnGirisAnaMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGirisAnaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisAnaMenu.Location = new System.Drawing.Point(12, 589);
            this.btnGirisAnaMenu.Name = "btnGirisAnaMenu";
            this.btnGirisAnaMenu.Size = new System.Drawing.Size(80, 60);
            this.btnGirisAnaMenu.TabIndex = 11;
            this.btnGirisAnaMenu.Text = "Ana Menü";
            this.btnGirisAnaMenu.UseVisualStyleBackColor = false;
            this.btnGirisAnaMenu.Click += new System.EventHandler(this.btnGirisAnaMenu_Click);
            // 
            // _cmbbx
            // 
            this._cmbbx.FormattingEnabled = true;
            this._cmbbx.Location = new System.Drawing.Point(379, 610);
            this._cmbbx.Name = "_cmbbx";
            this._cmbbx.Size = new System.Drawing.Size(10, 21);
            this._cmbbx.TabIndex = 32;
            this._cmbbx.Visible = false;
            // 
            // frmStokGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this._cmbbx);
            this.Controls.Add(this.btnGirisAnaMenu);
            this.Controls.Add(this.grbStokGiris);
            this.Controls.Add(this.gridStokGiris);
            this.Name = "frmStokGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Girişi";
            this.Load += new System.EventHandler(this.frmStokGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStokGiris)).EndInit();
            this.grbStokGiris.ResumeLayout(false);
            this.grbStokGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridStokGiris;
        private System.Windows.Forms.Button btnGirisEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStokGrsMiktar;
        private System.Windows.Forms.DateTimePicker txtStokGrsTarih;
        private System.Windows.Forms.ComboBox txtStokGrsAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGirisBildirim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbStokGiris;
        private System.Windows.Forms.RichTextBox txtStokGrsAciklama;
        private System.Windows.Forms.ComboBox txtStokGrsKodu;
        private System.Windows.Forms.ComboBox txtStokGrsTipi;
        private System.Windows.Forms.Button btnGirisSil;
        private System.Windows.Forms.Button btnGirisGuncelle;
        private System.Windows.Forms.Button btnGirisExcel;
        private System.Windows.Forms.Button btnGirisIptal;
        private System.Windows.Forms.Button btnGirisAnaMenu;
        private System.Windows.Forms.ComboBox _cmbbx;
    }
}
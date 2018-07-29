namespace Turk_Telekom_Stok
{
    partial class Ayarlar
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grida = new System.Windows.Forms.DataGridView();
            this.btnAyarKulSil = new System.Windows.Forms.Button();
            this.txtAyarSifre = new System.Windows.Forms.TextBox();
            this.txtAyarKadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAyarKulKaydet = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grida);
            this.groupBox2.Controls.Add(this.btnAyarKulSil);
            this.groupBox2.Controls.Add(this.txtAyarSifre);
            this.groupBox2.Controls.Add(this.txtAyarKadi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAyarKulKaydet);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 280);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Bilgileri";
            // 
            // grida
            // 
            this.grida.AllowUserToAddRows = false;
            this.grida.AllowUserToDeleteRows = false;
            this.grida.AllowUserToResizeColumns = false;
            this.grida.AllowUserToResizeRows = false;
            this.grida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grida.Location = new System.Drawing.Point(6, 98);
            this.grida.MultiSelect = false;
            this.grida.Name = "grida";
            this.grida.ReadOnly = true;
            this.grida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grida.Size = new System.Drawing.Size(280, 176);
            this.grida.TabIndex = 27;
            // 
            // btnAyarKulSil
            // 
            this.btnAyarKulSil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAyarKulSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarKulSil.Location = new System.Drawing.Point(219, 53);
            this.btnAyarKulSil.Name = "btnAyarKulSil";
            this.btnAyarKulSil.Size = new System.Drawing.Size(67, 28);
            this.btnAyarKulSil.TabIndex = 29;
            this.btnAyarKulSil.Text = "Sil";
            this.btnAyarKulSil.UseVisualStyleBackColor = false;
            this.btnAyarKulSil.Click += new System.EventHandler(this.btnAyarKulSil_Click);
            // 
            // txtAyarSifre
            // 
            this.txtAyarSifre.Location = new System.Drawing.Point(113, 58);
            this.txtAyarSifre.Name = "txtAyarSifre";
            this.txtAyarSifre.Size = new System.Drawing.Size(100, 20);
            this.txtAyarSifre.TabIndex = 28;
            // 
            // txtAyarKadi
            // 
            this.txtAyarKadi.Location = new System.Drawing.Point(113, 24);
            this.txtAyarKadi.Name = "txtAyarKadi";
            this.txtAyarKadi.Size = new System.Drawing.Size(100, 20);
            this.txtAyarKadi.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Şifre : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Kullanıcı Adı : ";
            // 
            // btnAyarKulKaydet
            // 
            this.btnAyarKulKaydet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAyarKulKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarKulKaydet.Location = new System.Drawing.Point(219, 19);
            this.btnAyarKulKaydet.Name = "btnAyarKulKaydet";
            this.btnAyarKulKaydet.Size = new System.Drawing.Size(67, 28);
            this.btnAyarKulKaydet.TabIndex = 23;
            this.btnAyarKulKaydet.Text = "Kaydet";
            this.btnAyarKulKaydet.UseVisualStyleBackColor = false;
            this.btnAyarKulKaydet.Click += new System.EventHandler(this.btnAyarKulKaydet_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAnaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaMenu.Location = new System.Drawing.Point(12, 298);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(80, 60);
            this.btnAnaMenu.TabIndex = 26;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 371);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.groupBox2);
            this.Name = "Ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAyarlar";
            this.Load += new System.EventHandler(this.frmAyarlar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAyarKulSil;
        private System.Windows.Forms.TextBox txtAyarSifre;
        private System.Windows.Forms.TextBox txtAyarKadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAyarKulKaydet;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.DataGridView grida;
    }
}
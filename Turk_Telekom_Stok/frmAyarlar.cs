using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turk_Telekom_Stok
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        public void _tabloAdiDegis() {
            grida.Columns[0].HeaderText = "KAYIT NUMARASI";
            grida.Columns[1].HeaderText = "KULLANICI ADI";
            grida.Columns[2].HeaderText = "ŞİFRE";
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            frmAnaMenu _ana = new frmAnaMenu();
            _ana.Show();
            this.Hide();

        }

  

        private void btnAyarKulKaydet_Click(object sender, EventArgs e)
        {
            AyarlarIslem _kulEk = new AyarlarIslem();
            string kadi = txtAyarKadi.Text;
            string sifre = txtAyarSifre.Text;
            _kulEk._kullaniciEkle(kadi, sifre);
            _tabloAdiDegis();
            grida.Refresh();
            _kulEk.ayarVd(grida);
        }

        private void btnAyarKulSil_Click(object sender, EventArgs e)
        {


            AyarlarIslem _kulSil = new AyarlarIslem();
            int kimlik = Int32.Parse(grida.CurrentRow.Cells[0].Value.ToString());
            _kulSil.kulSil(kimlik);
            _tabloAdiDegis();
            grida.Refresh();
            _kulSil.ayarVd(grida);

        }



        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            btnAyarKulSil.Enabled = false;
            AyarlarIslem _ayark = new AyarlarIslem();
            _ayark.ayarVd(grida);
            _tabloAdiDegis();
            grida.Refresh();
        }

        private void grida_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            kod _stk = new kod();
            _stk._stokkodu();
        }*/




    }
}

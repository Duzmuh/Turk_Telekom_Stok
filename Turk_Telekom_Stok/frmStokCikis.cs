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
    public partial class frmStokCikis : Form
    {
        public frmStokCikis()
        {
            InitializeComponent();
        }
        private void frmStokCikis_Load(object sender, EventArgs e)
        {
            anaMenuBild _bldAdKod = new anaMenuBild();
            _bldAdKod._bldAdKod(gridAdKod);

            StokCikisIslem _sc = new StokCikisIslem();
            _sc.stokAdiList(txtCikisAdi);

            _sc.stokKoduList(txtCikisKodu);

            btnCikisEkle.Enabled = true;
            btnCikisExcel.Enabled = true;
            btnCikisGuncelle.Enabled = false;
            btnCikisSil.Enabled = false;

            StokCikisIslem _scvd = new StokCikisIslem();
            _scvd.cikisVeriDoldur(gridStokCikis);
            _tabloAdiDegis();
            gridStokCikis.Refresh();



        }

        public void _tabloAdiDegis()
        {
            gridStokCikis.Columns[0].HeaderText = "KAYIT NUMARASI";
            gridStokCikis.Columns[1].HeaderText = "STOK ADI";
            gridStokCikis.Columns[2].HeaderText = "STOK TİPİ";
            gridStokCikis.Columns[3].HeaderText = "STOK KODU";
            gridStokCikis.Columns[4].HeaderText = "KULLANILAN MİKTAR";
            gridStokCikis.Columns[5].HeaderText = "PROJE - MÜŞTERİ";
            gridStokCikis.Columns[6].HeaderText = "TARİH";
            gridStokCikis.Columns[7].HeaderText = "AÇIKLAMA";
            gridStokCikis.Sort(gridStokCikis.Columns[0], ListSortDirection.Descending);

            gridAdKod.Columns[0].HeaderText = "STOK KODU";
            gridAdKod.Columns[1].HeaderText = "STOK ADI";
        }
        private void ClearAll(Control ctl)
        {
            foreach (Control c in ctl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedItem = null;

                }

            }
        }

        private void btnCikisEkle_Click(object sender, EventArgs e)
        {
            try{


                StokCikisIslem _scekle = new StokCikisIslem();
                string stokKodu = txtCikisKodu.Text;
                int miktarr = Int32.Parse(txtCikisMiktar.Text);
                _scekle.stokDus(miktarr, stokKodu, comboBox1, lblCikisBildirim);

                if(lblCikisBildirim.Text!= txtCikisAdi.Text +"  İsimli Ürün Stokta Yeterli Miktarda Bulunmamaktadır.")
                {

                StokCikisIslem _stokCikis = new StokCikisIslem();

                string adi = txtCikisAdi.Text;
                string tipi = txtCikisTipi.Text;
                string kodu = txtCikisKodu.Text;
                int miktar = Int32.Parse(txtCikisMiktar.Text);
                string musteri = txtCikisMusteri.Text;
                string tarih = txtCikisTarih.Text;
                string aciklama = txtCikisAciklama.Text;

                _stokCikis._stokCikis(adi, tipi, kodu, miktar,musteri, tarih, aciklama);
                lblCikisBildirim.Text += "\n"+txtCikisAdi.Text+"  İsimli Ürünün Stok Düşümü yapıldı.";

                StokCikisIslem _scveriDoldur = new StokCikisIslem();
                _scveriDoldur.cikisVeriDoldur(gridStokCikis);
                gridStokCikis.Refresh();
                ClearAll(this.grbStokCikis);
                _tabloAdiDegis();
            }

            }
            catch { lblCikisBildirim.Text = "Lütfen Bilgileri Kontrol Ediniz."; }
        }


        private void btnCikisGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                lblCikisBildirim.Text = gridStokCikis.CurrentRow.Cells[1].Value.ToString() + "  İsimli Ürünün  " + gridStokCikis.CurrentRow.Cells[0].Value.ToString() + "  Numaralı Stok Kaydı Güncellendi.";
                StokCikisIslem _scGuncelle = new StokCikisIslem();

                string adi = txtCikisAdi.Text;
                string tipi = txtCikisTipi.Text;
                string kodu = txtCikisKodu.Text;
                int miktar = Int32.Parse(txtCikisMiktar.Text);
                string musteri = txtCikisMusteri.Text;
                string tarih = txtCikisTarih.Text;
                string aciklama = txtCikisAciklama.Text;
                int kimlik = Int32.Parse(gridStokCikis.CurrentRow.Cells[0].Value.ToString());
                _scGuncelle.CikisStokGuncelle(adi, tipi, kodu, miktar,musteri, tarih, aciklama, kimlik);


                StokCikisIslem _scvDoldur = new StokCikisIslem();
                _scvDoldur.cikisVeriDoldur(gridStokCikis);

                gridStokCikis.Refresh();
                _tabloAdiDegis();
                ClearAll(this.grbStokCikis);


            }
            catch { lblCikisBildirim.Text = "Lütfen Bilgileri Kontrol Ediniz."; }
        }

        private void btnCikisSil_Click(object sender, EventArgs e)
        {
            lblCikisBildirim.Text = gridStokCikis.CurrentRow.Cells[1].Value.ToString() + "  İsimli Ürünün  " + gridStokCikis.CurrentRow.Cells[0].Value.ToString() + "  Numaralı Stok Kaydı Silindi.";
            StokGirisIslem _stokSil = new StokGirisIslem();
            int kimlik = Int32.Parse(gridStokCikis.CurrentRow.Cells[0].Value.ToString());
            _stokSil.girisStokSil(kimlik);

            StokGirisIslem vdGiris = new StokGirisIslem();
            vdGiris.girisVeriDoldur(gridStokCikis);
            gridStokCikis.Refresh();
            ClearAll(this.grbStokCikis);
            _tabloAdiDegis();
        }

        private void btnCikisExcel_Click(object sender, EventArgs e)
        {
            try
            {

                StokCikisIslem _scexcel = new StokCikisIslem();
                _scexcel.cikisExcel(gridStokCikis);
            }
            catch { lblCikisBildirim.Text = "İşlem İptal Edildi"; }
        }

        private void btnCikisİptal_Click(object sender, EventArgs e)
        {
            ClearAll(this.grbStokCikis);
            lblCikisBildirim.Text = "İşlem İptal Edildi";
            btnCikisEkle.Enabled = true;
            btnCikisExcel.Enabled = true;
            btnCikisGuncelle.Enabled = false;
            btnCikisSil.Enabled = false;

        }

        private void gridStokCikis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCikisAdi.Text = gridStokCikis.CurrentRow.Cells[1].Value.ToString();
            txtCikisTipi.Text = gridStokCikis.CurrentRow.Cells[2].Value.ToString();
            txtCikisKodu.Text = gridStokCikis.CurrentRow.Cells[3].Value.ToString();
            txtCikisMiktar.Text = gridStokCikis.CurrentRow.Cells[4].Value.ToString();
            txtCikisMusteri.Text = gridStokCikis.CurrentRow.Cells[5].Value.ToString();
            txtCikisTarih.Text = gridStokCikis.CurrentRow.Cells[6].Value.ToString();
            txtCikisAciklama.Text = gridStokCikis.CurrentRow.Cells[7].Value.ToString();

            btnCikisEkle.Enabled = false;
            btnCikisExcel.Enabled = true;
            btnCikisGuncelle.Enabled = true;
            btnCikisSil.Enabled = true;

        }

        private void btnCikisAnaMenu_Click(object sender, EventArgs e)
        {
            frmAnaMenu _ana = new frmAnaMenu();
            _ana.Show();
            this.Hide();

        }









    }
}

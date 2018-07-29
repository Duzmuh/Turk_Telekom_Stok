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
    public partial class frmStokGiris : Form
    {
        public frmStokGiris()
        {
            InitializeComponent();
        }

        public void _tabloAdiDegis()
        {
            gridStokGiris.Columns[0].HeaderText = "KAYIT NUMARASI";
            gridStokGiris.Columns[1].HeaderText = "STOK ADI";
            gridStokGiris.Columns[2].HeaderText = "STOK TİPİ";
            gridStokGiris.Columns[3].HeaderText = "STOK KODU";
            gridStokGiris.Columns[4].HeaderText = "STOK MİKTARI";
            gridStokGiris.Columns[5].HeaderText = "KAYIT TARİHİ";
            gridStokGiris.Columns[6].HeaderText = "AÇIKLAMA";
            gridStokGiris.Sort(gridStokGiris.Columns[0], ListSortDirection.Descending);
        }

        private void btnGirisAnaMenu_Click(object sender, EventArgs e)
        {
            frmAnaMenu anamenu = new frmAnaMenu();
            anamenu.Show();
            this.Hide();

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

        private void btnGirisEkle_Click(object sender, EventArgs e)
        {

           // try{



                lblGirisBildirim.Text = txtStokGrsAdi.Text+ "  İsimli Ürünün Stok Giriş Kaydı Oluşturuldu.";

                kodes _kds = new kodes();
                string a = txtStokGrsAdi.Text;
                string k = txtStokGrsKodu.Text;
              
                _kds._kodEsle(a, k,_cmbbx);

                StokGirisIslem _ekle = new StokGirisIslem();
                string adi = txtStokGrsAdi.Text;
                string tipi = txtStokGrsTipi.Text;
                string kodu = txtStokGrsKodu.Text;
                int miktar = Int32.Parse(txtStokGrsMiktar.Text);
                string tarih = txtStokGrsTarih.Text;
                string aciklama = txtStokGrsAciklama.Text;

                _ekle._stokEkle(adi, tipi, kodu, miktar, tarih, aciklama);

              

                StokGirisIslem _girisVD = new StokGirisIslem();

                
                
                _girisVD.girisVeriDoldur(gridStokGiris);
                gridStokGiris.Refresh();
                ClearAll(this.grbStokGiris);
                _tabloAdiDegis();



          //}
            //catch { lblGirisBildirim.Text = "Lütfen Bilgileri Kontrol Ediniz."; }

        }

        private void btnGirisGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                lblGirisBildirim.Text =gridStokGiris.CurrentRow.Cells[1].Value.ToString() + "  İsimli Ürünün  " +gridStokGiris.CurrentRow.Cells[0].Value.ToString() + "  Numaralı Stok Kaydı Güncellendi.";
                StokGirisIslem _guncelle = new StokGirisIslem();
                string adi = txtStokGrsAdi.Text;
                string tipi = txtStokGrsTipi.Text;
                string kodu = txtStokGrsKodu.Text;
                int miktar = Int32.Parse(txtStokGrsMiktar.Text);
                string tarih = txtStokGrsTarih.Text;
                string aciklama = txtStokGrsAciklama.Text;
                int kimlik = Int32.Parse(gridStokGiris.CurrentRow.Cells[0].Value.ToString());
                _guncelle.girisStokGuncelle(adi, tipi, kodu, miktar, tarih, aciklama, kimlik);

                StokGirisIslem _vtGirisDoldr = new StokGirisIslem();
                _vtGirisDoldr.girisVeriDoldur(gridStokGiris);
                gridStokGiris.Refresh();
                ClearAll(this.grbStokGiris);
                _tabloAdiDegis();


            }
            catch { lblGirisBildirim.Text = "Lütfen Bilgileri Kontrol Ediniz."; }

        }

        private void btnGirisSil_Click(object sender, EventArgs e)
        {

            lblGirisBildirim.Text = gridStokGiris.CurrentRow.Cells[1].Value.ToString()+ "  İsimli Ürünün  "+ gridStokGiris.CurrentRow.Cells[0].Value.ToString()+ "  Numaralı Stok Kaydı Silindi.";
            StokGirisIslem _stokSil = new StokGirisIslem();
            int kimlik = Int32.Parse(gridStokGiris.CurrentRow.Cells[0].Value.ToString());
            _stokSil.girisStokSil(kimlik);

            StokGirisIslem vdGiris = new StokGirisIslem();
            vdGiris.girisVeriDoldur(gridStokGiris);
            gridStokGiris.Refresh();
            ClearAll(this.grbStokGiris);
            _tabloAdiDegis();






        }

        private void btnGirisExcel_Click(object sender, EventArgs e)
        {
            try
            {
                StokGirisIslem _stokGirisExcel = new StokGirisIslem();
                _stokGirisExcel.girisExcel(gridStokGiris);
            }
            catch { lblGirisBildirim.Text = "İşlem İptal Edildi"; }



        }

        private void btnGirisIptal_Click(object sender, EventArgs e)
        {

            ClearAll(this.grbStokGiris);
            lblGirisBildirim.Text = "İşlem İptal Edildi.";

            btnGirisEkle.Enabled = true;
            btnGirisExcel.Enabled = true;
            btnGirisGuncelle.Enabled = false;
            btnGirisIptal.Enabled = false;
            btnGirisSil.Enabled = false;

        }

        private void gridStokGiris_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStokGrsAdi.Text = gridStokGiris.CurrentRow.Cells[1].Value.ToString();
            txtStokGrsTipi.Text = gridStokGiris.CurrentRow.Cells[2].Value.ToString();
            txtStokGrsKodu.Text = gridStokGiris.CurrentRow.Cells[3].Value.ToString();
            txtStokGrsMiktar.Text = gridStokGiris.CurrentRow.Cells[4].Value.ToString();
            txtStokGrsTarih.Text = gridStokGiris.CurrentRow.Cells[5].Value.ToString();
            txtStokGrsAciklama.Text = gridStokGiris.CurrentRow.Cells[6].Value.ToString();

            btnGirisEkle.Enabled = false;
            btnGirisExcel.Enabled = true;
            btnGirisGuncelle.Enabled = true;
            btnGirisIptal.Enabled = true;
            btnGirisSil.Enabled = true;
        }

        private void frmStokGiris_Load(object sender, EventArgs e)
        {
            btnGirisEkle.Enabled = true;
            btnGirisExcel.Enabled = true;
            btnGirisGuncelle.Enabled = false;
            btnGirisIptal.Enabled = false;
            btnGirisSil.Enabled = false;

            StokCikisIslem _stkk = new StokCikisIslem();
            _stkk.stokAdiList(txtStokGrsAdi);
            _stkk.stokKoduList(txtStokGrsKodu);

            StokGirisIslem vdGiris = new StokGirisIslem();
            vdGiris.girisVeriDoldur(gridStokGiris);
            _tabloAdiDegis();
            gridStokGiris.Refresh();





        }




    }
}

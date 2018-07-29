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
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }

        public void _tabloAdiDegisC()
        {
            gridAnaMenu.Columns[0].HeaderText = "KAYIT NUMARASI";
            gridAnaMenu.Columns[1].HeaderText = "STOK ADI";
            gridAnaMenu.Columns[2].HeaderText = "STOK TİPİ";
            gridAnaMenu.Columns[3].HeaderText = "STOK KODU";
            gridAnaMenu.Columns[4].HeaderText = "KULLANILAN MİKTAR";
            gridAnaMenu.Columns[5].HeaderText = "PROJE - MÜŞTERİ";
            gridAnaMenu.Columns[6].HeaderText = "TARİH";
            gridAnaMenu.Columns[7].HeaderText = "AÇIKLAMA";
            gridAnaMenu.Sort(gridAnaMenu.Columns[0], ListSortDirection.Descending);

            gridAdKod.Columns[0].HeaderText = "STOK KODU";
            gridAdKod.Columns[1].HeaderText = "STOK ADI";


            gridBildirim.Columns[0].HeaderText = "STOK ADI";
        }

        public void _tabloAdiDegisG()
        {
            gridAnaMenu.Columns[0].HeaderText = "KAYIT NUMARASI";
            gridAnaMenu.Columns[1].HeaderText = "STOK ADI";
            gridAnaMenu.Columns[2].HeaderText = "STOK TİPİ";
            gridAnaMenu.Columns[3].HeaderText = "STOK KODU";
            gridAnaMenu.Columns[4].HeaderText = "STOK MİKTARI";
            gridAnaMenu.Columns[5].HeaderText = "KAYIT TARİHİ";
            gridAnaMenu.Columns[6].HeaderText = "AÇIKLAMA";
            gridAnaMenu.Sort(gridAnaMenu.Columns[0], ListSortDirection.Descending);

            gridAdKod.Columns[0].HeaderText = "STOK KODU";
            gridAdKod.Columns[1].HeaderText = "STOK ADI";

            
             gridBildirim.Columns[0].HeaderText = "STOK ADI";
        }

        

        private void btnStokGiris_Click(object sender, EventArgs e)
        {
            frmStokGiris stokGiris = new frmStokGiris();
            stokGiris.Show();
            this.Hide();
        }

        private void btnStokCikis_Click(object sender, EventArgs e)
        {
            frmStokCikis stokCikis = new frmStokCikis();
            stokCikis.Show();
            this.Hide();

        }

        private void btnGÇTakip_Click(object sender, EventArgs e)
        {
            Ayarlar _ayar = new Ayarlar();
            _ayar.Show();
            this.Hide();

        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            frmHakkinda _hk = new frmHakkinda();
            _hk.Show();
            this.Hide();

        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            try
            {

                StokCikisIslem _scexcel = new StokCikisIslem();
                _scexcel.cikisExcel(gridAnaMenu);
            }
            catch {}
        }

        private void frmAnaMenu_Load(object sender, EventArgs e)
        {

            StokGirisIslem vdGiris = new StokGirisIslem();
            vdGiris.girisVeriDoldur(gridAnaMenu);

            anaMenuBild _bild = new anaMenuBild();
            _bild._bildirim(gridBildirim);

            anaMenuBild _bldAdKod = new anaMenuBild();
            _bldAdKod._bldAdKod(gridAdKod);
            _tabloAdiDegisG();

            
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string _kriter = "stokKodu";
            string _veriTabani1 = "";

            if (cmbGosDat.Text == "Stok Giriş Kayıtları")
            {

                _veriTabani1 = "Giris";

            }

            else if (cmbGosDat.Text == "Stok Çıkış Kayıtları")
            {
                _veriTabani1 = "cikis";


            }

            else {}

            anaMenuBild _mbAra = new anaMenuBild();
            _mbAra._aracKayitAra(txtAra, gridAnaMenu, _kriter, _veriTabani1);
            
            
            }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGosDat.Text=="Stok Giriş Kayıtları"){

                gridAnaMenu.Refresh();
                StokGirisIslem _sgı = new StokGirisIslem();
                _sgı.girisVeriDoldur(gridAnaMenu);
                _tabloAdiDegisG();

            
            }

            else if(cmbGosDat.Text=="Stok Çıkış Kayıtları"){
                 gridAnaMenu.Refresh();
                 StokCikisIslem _sgc = new StokCikisIslem();
                 _sgc.cikisVeriDoldur(gridAnaMenu);
                 _tabloAdiDegisC();

            
            }
            
            
            




        }

        private void dtPic_ValueChanged(object sender, EventArgs e)
        {
            string _kriter = "tarih";
            string _veriTabani1 = "";

            if (cmbGosDat.Text == "Stok Giriş Kayıtları") {

                _veriTabani1 = "Giris";
            
            }

            else if (cmbGosDat.Text == "Stok Çıkış Kayıtları")
            {
                _veriTabani1 = "cikis";


            }

            else {}

            anaMenuBild _mbAra = new anaMenuBild();
            _mbAra._kayitAraDt(dtPic,gridAnaMenu,_kriter,_veriTabani1);


        }




    }
}

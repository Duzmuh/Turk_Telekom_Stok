using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


namespace Turk_Telekom_Stok
{

    class kod {

        public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=AppFiles\\ttStok.accdb");
        public static OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from kodu", baglanti);
        public OleDbCommand komut = new OleDbCommand();
        public DataSet verikumesi = new DataSet();


        public void _stokkodu()
        {
            komut = new OleDbCommand();
            baglanti.Close();
            baglanti.Open();
            komut.Connection = baglanti;

            string _stkkd = "";
            int t=0;

                 for (char _ch = 'A'; _ch <= 'Z'; _ch++)
                 {
                     for (int i = 1; i <= 100; i++)
                     {
                         _stkkd = _ch + "" + i;
                         komut.CommandText="insert into kodu (stokKod,dolu) values('"+_stkkd+"','"+t+"')";
                             komut.ExecuteNonQuery();

                     }
                 }
                baglanti.Close();
        }
        
    
    
    }

    class StokCikisIslem {
        public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=AppFiles\\ttStok.accdb");
        public static OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from cikis", baglanti);
        public OleDbCommand komut = new OleDbCommand();
        public DataSet verikumesi = new DataSet();

        public string WriteMe(string _Text)
        {
            return "'" + _Text + "'";
        }

        public void _stokCikis(string adi, string tipi, string kodu, int miktar, string musteri, string tarih, string aciklama)
        {
            komut = new OleDbCommand();
            baglanti.Close();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "insert into cikis (stokAdi,stokTipi,stokKodu,stokMiktar,stokMusteri,tarih,aciklama) values ('"
                + adi + "','" + tipi + "','" + kodu + "','" + miktar + "','" + musteri +"','"+ tarih + "','" + aciklama + "')";
            komut.ExecuteNonQuery();
            baglanti.Close();


        }


        public void cikisVeriDoldur(DataGridView gridStokCikis)
        {
            baglanti.Close();
            gridStokCikis.DataSource = null;
            gridStokCikis.Rows.Clear();
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=AppFiles\\ttStok.accdb");
            baglanti.Open();
            adaptor.Fill(verikumesi, "cikis");
            gridStokCikis.DataSource = verikumesi.Tables["cikis"];
            baglanti.Close();
        }

        public void stokAdiList(ComboBox _cmb) {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=AppFiles\\ttStok.accdb");
            OleDbCommand cmd = new OleDbCommand("select distinct stokAdi from Giris",baglanti);
            baglanti.Open();
            OleDbDataReader _dr = cmd.ExecuteReader();
            while (_dr.Read())
            {
                _cmb.Items.Add(_dr["stokAdi"]);
            }
            baglanti.Close();
        }

        public void stokKoduList(ComboBox _combo) {
            
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=AppFiles\\ttStok.accdb");
            OleDbCommand cmd = new OleDbCommand("select distinct stokKod from kodu where dolu =0", baglanti);
            baglanti.Open();
            OleDbDataReader _dr = cmd.ExecuteReader();
            
            while (_dr.Read())
            {
                
                _combo.Items.Add(_dr["stokKod"]);
            }
            baglanti.Close();
        
        
        
        }

        public void stokDus(int miktarr, string stokKodu, System.Windows.Forms.ComboBox _cmb, System.Windows.Forms.Label _lbluyari) {

            int _toplamSayi = 0;
            komut = new OleDbCommand();
            baglanti.Close();
            baglanti.Open();

            OleDbCommand _cmd = new OleDbCommand(" select distinct stokMiktar from Giris where stokKodu ='" + stokKodu + "'", baglanti);
            OleDbDataReader _read = _cmd.ExecuteReader();

            while (_read.Read())
            {
                _cmb.Items.Add(_read["stokMiktar"]);
            }
            _toplamSayi = Int32.Parse(_cmb.Items[0].ToString());
            _toplamSayi = _toplamSayi - miktarr;

            if (_toplamSayi < 0)
            {
                _lbluyari.Text = stokKodu + "  Kodlu Parça Stokta Yeterli Miktarda Bulunmamaktadır.";
                _cmb.Items.Clear();

            }
            else
            {
                _lbluyari.Text = stokKodu + "  Kodlu Üründen  " + _toplamSayi + " Adet Kaldı.";
                komut.Connection = baglanti;
                komut.CommandText = "update Giris set stokMiktar =" + _toplamSayi + " where stokKodu ='" + stokKodu + "'";
                komut.ExecuteNonQuery();
                _cmb.Items.Clear();
                baglanti.Close();
                _read.Close();
            }


        }

        public void CikisStokGuncelle(string adi, string tipi, string kodu, int miktar, string musteri, string tarih, string aciklama, int kimlik)
        {
            komut = new OleDbCommand();
            baglanti.Close();
            baglanti.Open();
            komut.Connection = baglanti;
            if (kimlik != -1)
            {
                komut.CommandText = "update cikis set " + "stokAdi =" + WriteMe(adi) + ",stokTipi=" + WriteMe(tipi) + ",stokKodu=" + WriteMe(kodu) + ",stokMiktar=" + miktar +",stokMusteri="+ WriteMe(musteri) + ",tarih=" + WriteMe(tarih) + ",aciklama=" + WriteMe(aciklama) + "where Kimlik =" + kimlik;
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
        }

        public void stokCikisSil(int kimlik) {
            komut = new OleDbCommand();
            baglanti.Close();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from cikis where Kimlik=" + kimlik + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
        
        
        }

        public void cikisExcel(DataGridView gridStokCikis) {

            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < gridStokCikis.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = gridStokCikis.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < gridStokCikis.Rows.Count; i++)
            {
                for (int j = 0; j < gridStokCikis.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = gridStokCikis[j, i].Value == null ? "" : gridStokCikis[j, i].Value;
                    myRange.Select();


                }
            }
        
        }

    
    
    
    }
    class anaMenuBild
    {
        public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=AppFiles\\ttStok.accdb");
        public static OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from Giris", baglanti);
        public OleDbCommand komut = new OleDbCommand();
        public OleDbCommand _com = new OleDbCommand();
        public DataSet verikumesi = new DataSet();

        public void _aracKayitAra(System.Windows.Forms.TextBox text, DataGridView dataGrid, String strAranacakKriter, String _veriTabani)
        {

            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=AppFiles\\ttStok.accdb");
            adaptor = new OleDbDataAdapter("Select *from " + _veriTabani + " where " + strAranacakKriter + " like '%" + text.Text + "%'", baglanti);
            verikumesi = new DataSet();
            baglanti.Open();
            adaptor.Fill(verikumesi, strAranacakKriter);
            dataGrid.DataSource = verikumesi.Tables[strAranacakKriter];
            baglanti.Close();
        }

        public void _kayitAraDt(System.Windows.Forms.DateTimePicker text, DataGridView dataGrid, String strAranacakKriter, String _veriTabani)
        {

            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=AppFiles\\ttStok.accdb");
            adaptor = new OleDbDataAdapter("Select *from " + _veriTabani + " where " + strAranacakKriter + " like '" + text.Text + "%'", baglanti);
            verikumesi = new DataSet();
            baglanti.Open();
            adaptor.Fill(verikumesi, strAranacakKriter);
            dataGrid.DataSource = verikumesi.Tables[strAranacakKriter];
            baglanti.Close();
        }

        public void _bldAdKod(DataGridView _gridAdKod) {

            baglanti.Close();
            _gridAdKod.DataSource = null;
            _gridAdKod.Rows.Clear();
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=AppFiles\\ttStok.accdb");

            baglanti.Open();
            adaptor = new OleDbDataAdapter(" select distinct stokKod,pAdi from kodu where dolu = 1 ", baglanti);
            adaptor.Fill(verikumesi, "kodu");
            _gridAdKod.DataSource = verikumesi.Tables["kodu"];

            baglanti.Close();
        
        
        
        }
        public void _bildirim(DataGridView _gridBild)
        {

            baglanti.Close();
            _gridBild.DataSource = null;
            _gridBild.Rows.Clear();
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=AppFiles\\ttStok.accdb");

            baglanti.Open();
            adaptor = new OleDbDataAdapter(" select distinct stokAdi from Giris where stokMiktar < 40 ", baglanti);
            adaptor.Fill(verikumesi, "Giris");
            _gridBild.DataSource = verikumesi.Tables["Giris"];

            baglanti.Close();





           /* int metresi = 0;
            int adedi = 0;
            baglanti.Close();
            _gridBild.DataSource = null;
            _gridBild.Rows.Clear();
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=AppFiles\\ttStok.accdb");

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand ("select distinct metre from min where kimlik =1",baglanti);
            OleDbDataReader _read = komut.ExecuteReader();
            while (_read.Read()){
                _cmb.Items.Add(_read["metre"]);
            }
            metresi = Int32.Parse(_cmb.Items[0].ToString());
            _cmb.Items.Clear();
            baglanti.Close();


            baglanti.Open();

            OleDbCommand _com = new OleDbCommand("select distinct adet from min where kimlik =1", baglanti);
            OleDbDataReader _rd = _com.ExecuteReader();
            while (_rd.Read())
            {
                _cmb.Items.Add(_rd["adet"]);
            }
            adedi = Int32.Parse(_cmb.Items[0].ToString());
            _cmb.Items.Clear();
            baglanti.Close();

            baglanti.Open();
            adaptor = new OleDbDataAdapter("select distinct stokMiktar from Giris where stokTipi = metre and stokMiktar <'"+metresi+"'",baglanti);
            adaptor.Fill(verikumesi,"Giris");
            _gridBild.DataSource = verikumesi.Tables["Giris"];

            baglanti.Close();*/



        }



    }
    class kodes {

        public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=AppFiles\\ttStok.accdb");
        public static OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from kodu", baglanti);
        public OleDbCommand komut = new OleDbCommand();
        public DataSet verikumesi = new DataSet();


        public void _kodEsle(string a, string k,System.Windows.Forms.ComboBox _cmbbx)
        {
            int kimlik = 0;
            int t = 1;
            baglanti.Close();
            baglanti.Open();

            OleDbCommand _komt = new OleDbCommand("select distinct kimlik from kodu where stokKod ='"+k+"'",baglanti);
            OleDbDataReader _read = _komt.ExecuteReader();
            while (_read.Read()) {
                _cmbbx.Items.Add(_read["kimlik"]);
            }
            kimlik = Int32.Parse(_cmbbx.Items[0].ToString());
            baglanti.Close();
            

           
            baglanti.Close();
            baglanti.Open();
            

            OleDbCommand _cmd = new OleDbCommand("delete from kodu where kimlik =" + kimlik + "",baglanti);
            _cmd.ExecuteNonQuery();
            baglanti.Close();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "insert into kodu(stokKod,pAdi,dolu) values ('" + k + "','" + a + "','" + t + "')";
            komut.ExecuteNonQuery();
            baglanti.Close();


        }
    
    
    }

    class StokGirisIslem {

        public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=AppFiles\\ttStok.accdb");
        public static OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from Giris", baglanti);
        public OleDbCommand komut = new OleDbCommand();
        public DataSet verikumesi = new DataSet();

        public string WriteMe(string _Text)
        {
            return "'" + _Text + "'";
        }

        public void _stokEkle(string adi, string tipi, string kodu, int miktar, string tarih, string aciklama)
        {
            komut = new OleDbCommand();
            baglanti.Close();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "insert into Giris (stokAdi,stokTipi,stokKodu,stokMiktar,tarih,aciklama) values ('"
                + adi + "','" + tipi + "','" + kodu + "','" + miktar + "','" + tarih + "','" + aciklama + "')";
            komut.ExecuteNonQuery();
            baglanti.Close();
        
        
        }



        public void girisVeriDoldur(DataGridView gridStokGiris)
        {
            baglanti.Close();
            gridStokGiris.DataSource = null;
            gridStokGiris.Rows.Clear();
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=AppFiles\\ttStok.accdb");
            baglanti.Open();
            adaptor.Fill(verikumesi, "Giris");
            gridStokGiris.DataSource = verikumesi.Tables["Giris"];
            baglanti.Close();
        }


        public void girisStokGuncelle(string adi, string tipi, string kodu, int miktar, string tarih, string aciklama, int kimlik) 
        {
            komut = new OleDbCommand();
            baglanti.Close();
            baglanti.Open();
            komut.Connection = baglanti;
            if (kimlik != -1) {
                komut.CommandText = "update Giris set " + "stokAdi =" + WriteMe(adi) + ",stokTipi=" + WriteMe(tipi) + ",stokKodu=" + WriteMe(kodu) + ",stokMiktar=" + miktar + ",tarih=" + WriteMe(tarih) + ",aciklama=" + WriteMe(aciklama) + "where Kimlik =" + kimlik;
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
        }

        public void girisStokSil(int kimlik)
        {
            komut = new OleDbCommand();
            baglanti.Close();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from Giris where kimlik =" + kimlik + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
        }


        public void girisExcel(DataGridView gridStokGiris)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < gridStokGiris.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = gridStokGiris.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < gridStokGiris.Rows.Count; i++)
            {
                for (int j = 0; j < gridStokGiris.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = gridStokGiris[j, i].Value == null ? "" : gridStokGiris[j, i].Value;
                    myRange.Select();


                }
            }
        
        
        }
    
    
    }


    class AyarlarIslem {

        public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=AppFiles\\ttStok.accdb");
        public static OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from kullanici", baglanti);
        public OleDbCommand komut = new OleDbCommand();
        public DataSet verikumesi = new DataSet();

        public void _minValue(int metre,int adet) {
            komut = new OleDbCommand();
            baglanti.Close();
            baglanti.Open();

            komut.Connection = baglanti;
            komut.CommandText = "insert into min(metre,adet) values ('"+metre+"','"+adet+"') where Kimlik =1";
            komut.ExecuteNonQuery();
            baglanti.Close();

        
        
        }


        public void _kullaniciEkle(string kadi , string sifre) {
            komut = new OleDbCommand();
            baglanti.Close();
            baglanti.Open();

            komut.Connection = baglanti;
            komut.CommandText = "insert into kullanici(kadi,sifre) values ('" + kadi + "','" + sifre + "')";
            komut.ExecuteNonQuery();
            baglanti.Close();
        
        }

        public void kulSil(int kimlik){
              komut = new OleDbCommand();
            baglanti.Close();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from kullanici where kimlik =" + kimlik + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
    
    }

        public void ayarVd(DataGridView grida) {
            baglanti.Close();
            grida.DataSource = null;
            grida.Rows.Clear();
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=AppFiles\\ttStok.accdb");
            baglanti.Open();
            adaptor.Fill(verikumesi, "kullanici");
            grida.DataSource = verikumesi.Tables["kullanici"];
            baglanti.Close();
        
        }
    
    
    }



}

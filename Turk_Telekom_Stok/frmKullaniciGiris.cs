using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Turk_Telekom_Stok
{
    public partial class frmKullaniciGiris : Form
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=AppFiles\\ttStok.accdb");
        public static OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from kullanici", baglanti);
        public OleDbCommand komut = new OleDbCommand();
        public DataSet verikumesi = new DataSet();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Open();
            string _kullanici = "select * from kullanici where kAdi=@kadi and sifre =@sifre";
            OleDbParameter _Kparameter = new OleDbParameter("@kadi", txtKullaniciAdi.Text);
            OleDbParameter _Sparameter = new OleDbParameter("@sifre", txtSifre.Text);
            OleDbCommand _cmd = new OleDbCommand(_kullanici, baglanti);
            _cmd.Parameters.Add(_Kparameter);
            _cmd.Parameters.Add(_Sparameter);
            System.Data.DataTable _dt = new System.Data.DataTable();
            OleDbDataAdapter _da = new OleDbDataAdapter(_cmd);
            _da.Fill(_dt);
            if (_dt.Rows.Count > 0)
            {

                frmAnaMenu _anaMenu = new frmAnaMenu();
                _anaMenu.Show();
                this.Hide();


            }


            else if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {

                lblUyarı.Text = "Kullanıcı adı veya şifre eksik";
            }
            else
            {
                lblUyarı.Text = "Kullanıcı adı veya şifre yanlış";


            }

            baglanti.Close();
            

        }





        private void btnİptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

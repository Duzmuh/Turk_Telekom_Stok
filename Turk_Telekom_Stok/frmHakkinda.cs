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
    public partial class frmHakkinda : Form
    {
        public frmHakkinda()
        {
            InitializeComponent();
        }

        private void frmHakkinda_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisAnaMenu_Click(object sender, EventArgs e)
        {
            frmAnaMenu _ana = new frmAnaMenu();
            _ana.Show();
            this.Hide();
        }
    }
}

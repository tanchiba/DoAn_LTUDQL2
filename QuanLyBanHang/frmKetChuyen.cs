using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmKetChuyen : Form
    {
        public frmKetChuyen()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmKetChuyen_1 frmKC = new frmKetChuyen_1();
            frmKC.ShowDialog();
            
           
        }
    }
}

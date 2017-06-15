using DTO;
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
    public partial class frmThongTin : Form
    {
        public frmThongTin()
        {
            InitializeComponent();
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            List<SYS_CompanyDTO> ht = BUS.SYS_CompanyBUS.getDS();
            
        }

        private void spbtnDongY_Click(object sender, EventArgs e)
        {

        }

        private void spbtnKetThuc_Click(object sender, EventArgs e)
        {

        }
    }
}

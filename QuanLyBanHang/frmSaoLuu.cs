using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmSaoLuu : Form
    {
        public frmSaoLuu()
        {
            InitializeComponent();
        }

        private void frmSaoLuu_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(QuanLyBanHang.Properties.Settings.Default.QuanLyBanHangConnectionString);

        private void btDuongdan_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK) { tbDuongDan.Text = folder.SelectedPath; }
        }

        private void spbtnThucHien_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            try
            {
                if (tbDuongDan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đường dẫn");
                }
                else
                {

                    string cmd = "BACKUP DATABASE  [" + database + "] TO DISK= '" + tbDuongDan.Text + "\\" + tbTen.Text + "" + "-" + DateTime.Now.ToString("yyyy-mm-dd--HH-mm-ss") + ".bak'";
                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("database backup done!");
                    }


                }
            }
            catch
            {

            }
        }

        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

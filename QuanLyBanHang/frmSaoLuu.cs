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

        SqlConnection con = new SqlConnection("Data Source=E6420-PC\\SQLEXPRES;Initial Catalog=QuanLyBanHang;Integrated Security=True");

        private void btDuongdan_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK) { tbDuongDan.Text = folder.SelectedPath; }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThucHien_Click(object sender, EventArgs e)
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
                MessageBox.Show("backup failed!");
            }
        }
    }
}

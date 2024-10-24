using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangNhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DNvalid(string dn)
        {
        }
        private void Passvalid(string pass)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DN.Text == "admin" && Pass.Text == "1234")
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai");
            }    
        }
        

        private void DN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

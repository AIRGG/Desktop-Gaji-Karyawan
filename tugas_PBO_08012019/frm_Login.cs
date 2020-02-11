using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_PBO_08012019
{
    public partial class frm_Login : Form
    {
        Lib lib = new Lib();
        public frm_Login()
        {
            InitializeComponent();
            btnLogin.BackgroundImage = imageList1.Images[0];
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnOff.BackgroundImage = imageList1.Images[1];
            btnOff.BackgroundImageLayout = ImageLayout.Center;
            txusername.Focus();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txusername.Focus();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(txusername.Text == "" || txpassword.Text == "") { MessageBox.Show("Isi Semua!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            string sql = $"SELECT * FROM admin WHERE username='{txusername.Text}' AND password='{txpassword.Text}' AND status=1 AND lvl=1";
            DataTable dt = lib.selectData(sql);
            if(dt.Rows.Count == 1)
            {
                this.Hide();
                new frm_NavigasiAdmin().ShowDialog();
            }
            else
            {
                MessageBox.Show("Gagal Login, Username or Password Salah!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txusername.Focus();
            }
            
        }

        private void Txpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnLogin.PerformClick();
            }
        }

        private void BtnOff_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

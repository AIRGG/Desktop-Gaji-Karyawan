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
    public partial class frm_NavigasiAdmin : Form
    {
        public frm_NavigasiAdmin()
        {
            InitializeComponent();
            btnKaryawan.BackgroundImage = imageList1.Images[0];
            btnKaryawan.BackgroundImageLayout = ImageLayout.Center;
            btnLogout.BackgroundImage = imageList1.Images[1];
            btnLogout.BackgroundImageLayout = ImageLayout.Center;
            btnToGajiKaryawan.BackgroundImage = imageList1.Images[2];
            btnToGajiKaryawan.BackgroundImageLayout = ImageLayout.Center;
            btnJabatan.BackgroundImage = imageList1.Images[3];
            btnJabatan.BackgroundImageLayout = ImageLayout.Center;
        }

        private void BtnToGajiKaryawan_Click(object sender, EventArgs e)
        {
            new frm_KaryawanGaji().ShowDialog();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frm_Login().Show();
        }

        private void BtnJabatan_Click(object sender, EventArgs e)
        {
            new frm_Jabatan().ShowDialog();
        }

        private void BtnKaryawan_Click(object sender, EventArgs e)
        {
            new frm_Karyawan().ShowDialog();
        }
    }
}

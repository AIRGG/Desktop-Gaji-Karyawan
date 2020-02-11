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
    public partial class frm_Jabatan : Form
    {
        Lib lib = new Lib();
        string id_jabatan = "";
        public frm_Jabatan()
        {
            InitializeComponent();
            btnLogout.BackgroundImage = imageList1.Images[0];
            btnLogout.BackgroundImageLayout = ImageLayout.Center;
        }



        //-- All Proses GET DATA --\\
        void getJabatan()
        {
            string sql = "SELECT * FROM jabatan WHERE stsjbtn=1";
            DGVJabatan.DataSource = lib.selectData(sql);
            DGVJabatan.Columns["id_jabatan"].Visible = false;
            DGVJabatan.Columns["stsjbtn"].Visible = false;
        }

        //-- All Proses CHANGE SOMETHING --\\
        private void Frm_Jabatan_Load(object sender, EventArgs e)
        {
            getJabatan();
            txnamajbtn.Focus();
        }
        private void DGVJabatan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectOne();
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            txnamajbtn.Focus();
        }


        //-- All SUPPORT PROSES --\\
        void btnAll(Boolean satu = true, Boolean dua = false)
        {
            btnAdd.Enabled = satu;
            btnEdit.Enabled = dua;
            btnDelete.Enabled = dua;
        }
        void clearAll()
        {
            txnamajbtn.Text = "";
            txjmlgajipokok.Text = "";
            txupahlembur.Text = "";
            btnAll();
            getJabatan();
        }
        void selectOne()
        {
            int x = DGVJabatan.CurrentRow.Index;
            if (x == -1) return;
            var tmp = DGVJabatan.Rows[x];

            id_jabatan = tmp.Cells["id_jabatan"].Value.ToString();
            txnamajbtn.Text = tmp.Cells["nama_jabatan"].Value.ToString();
            txjmlgajipokok.Text = tmp.Cells["jml_gaji_pokok"].Value.ToString();
            txupahlembur.Text = tmp.Cells["upah_lembur"].Value.ToString();

            btnAll(false, true);
        }

        //-- All PROSES CRUD --\\
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            prosesCRUD("add");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            prosesCRUD("edit");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            prosesCRUD("delete");
        }
        Boolean validasiDulu(string[] arrnya)
        {
            for (var i = 0; i < arrnya.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(arrnya[i]))
                {
                    return false;
                }
            }
            return true;
        }

        void prosesCRUD(string which)
        {
            string nama = txnamajbtn.Text;
            string jmlgajipkok = txjmlgajipokok.Text;
            string upahlembur = txupahlembur.Text;

            string sql = "";
            if (validasiDulu(new string[] { nama, jmlgajipkok, upahlembur}))
            {
                switch (which)
                {
                    case "add":
                        sql = $"INSERT INTO jabatan (id_jabatan, nama_jabatan, jml_gaji_pokok, upah_lembur, stsjbtn) VALUES (NULL, '{nama}', '{jmlgajipkok}', '{upahlembur}', 1)";
                        if (lib.execute(sql))
                        {
                            MessageBox.Show("Success Add", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClear.PerformClick();
                        }
                        break;

                    case "edit":
                        sql = $"UPDATE jabatan SET nama_jabatan = '{nama}', jml_gaji_pokok = '{jmlgajipkok}', upah_lembur = '{upahlembur}' WHERE jabatan.id_jabatan = '{id_jabatan}'";
                        if (lib.execute(sql))
                        {
                            MessageBox.Show("Success Edit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClear.PerformClick();
                        }
                        break;

                    case "delete":
                        if (MessageBox.Show("Yakin??", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sql = $"UPDATE jabatan SET stsjbtn=0 WHERE id_jabatan='{id_jabatan}'";
                            if (lib.execute(sql))
                            {
                                MessageBox.Show("Success Delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnClear.PerformClick();
                            }
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Isi Semua Yang Kosong!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

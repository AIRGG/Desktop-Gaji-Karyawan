using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_PBO_08012019
{
    public partial class frm_Karyawan : Form
    {
        Lib lib = new Lib();
        string id_jabatan = "";
        string id_karyawan = "";
        public frm_Karyawan()
        {
            InitializeComponent();
            btnLogout.BackgroundImage = imageList1.Images[0];
            btnLogout.BackgroundImageLayout = ImageLayout.Center;
        }

        //-- All Proses GET DATA --\\
        void getDataJabatan()
        {
            string sql = "SELECT * FROM jabatan WHERE stsjbtn=1";
            cbjabatan.DataSource = lib.selectData(sql);
            cbjabatan.DisplayMember = "nama_jabatan";
            cbjabatan.ValueMember = "id_jabatan";
        }
        void getDataGajiKaryawan()
        {
            string sql = @"SELECT * FROM karyawan NATURAL JOIN jabatan WHERE sts=1 AND stsjbtn=1 AND lvl=3";
            DGVKaryawan.DataSource = lib.selectData(sql);
            for (var i = 0; i < DGVKaryawan.RowCount; i++)
            {
                var tmp = DGVKaryawan.Rows[i];
                string jk = tmp.Cells["jenis_kelamin"].Value.ToString();
                string status = tmp.Cells["status"].Value.ToString();
                string tgllahir = tmp.Cells["tanggal_lahir"].Value.ToString();
                tmp.Cells["jenis_kelamin"].Value = (jk == "L") ? "Laki-Laki" : "Perempuan";
                tmp.Cells["status"].Value = (status == "M") ? "Menikah" : "Lajang";
                String[] arrbln = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
                tmp.Cells["tanggal_lahir"].Value = $"{tgllahir.Substring(0, 2)} {arrbln[int.Parse(tgllahir.Substring(2, 2)) - 1]} {tgllahir.Substring(4, 4)}";
            }
            DGVKaryawan.Columns["id_jabatan"].Visible = false;
            DGVKaryawan.Columns["id_karyawan"].Visible = false;
            DGVKaryawan.Columns["lvl"].Visible = false;
            DGVKaryawan.Columns["sts"].Visible = false;
            DGVKaryawan.Columns["stsjbtn"].Visible = false;
        }

        //-- All CHANGE SOMETHING --\\
        private void Frm_Karyawan_Load(object sender, EventArgs e)
        {
            getDataJabatan();
            clearAll();
            txnama.Focus();
        }
        private void DGVKaryawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectOne();
        }
        private void Rdlajang_CheckedChanged(object sender, EventArgs e)
        {
            txjmlanak.Text = "0";
            txjmlanak.Enabled = false;
        }

        private void Rdmenikah_CheckedChanged(object sender, EventArgs e)
        {
            txjmlanak.Enabled = true;
            txjmlanak.Focus();
            txjmlanak.SelectAll();
        }

        private void Txjmlanak_TextChanged(object sender, EventArgs e)
        {
            txjmlanak.Text = (txjmlanak.Text == "") ? "0" : txjmlanak.Text;
            if (!Regex.IsMatch(txjmlanak.Text, @"^\d+$")) return;
            txjmlanak.Text = (txjmlanak.Text.Length > 2) ? txjmlanak.Text.Substring(0, 2) : txjmlanak.Text;
            txjmlanak.SelectAll();
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            txnama.Focus();
        }




        //-- All Proses SUPPORT PROSES --\\
        void btnAll(Boolean satu = true, Boolean dua = false)
        {
            btnAdd.Enabled = satu;
            btnEdit.Enabled = dua;
            btnDelete.Enabled = dua;
        }
        void selectOne()
        {
            int e = DGVKaryawan.CurrentRow.Index;
            if (e == -1) return;
            var tmp = DGVKaryawan.Rows[e];

            id_jabatan = tmp.Cells["id_jabatan"].Value.ToString();
            id_karyawan = tmp.Cells["id_karyawan"].Value.ToString();

            string nama = tmp.Cells["nama_karyawan"].Value.ToString();
            string tempatlahir = tmp.Cells["tempat_lahir"].Value.ToString();
            string nohp = tmp.Cells["no_hp"].Value.ToString();
            string alamat = tmp.Cells["alamat"].Value.ToString();
            string username = tmp.Cells["username"].Value.ToString();
            string password = tmp.Cells["password"].Value.ToString();
            string jeniskelamin = tmp.Cells["jenis_kelamin"].Value.ToString();
            string[] tanggallahir = tmp.Cells["tanggal_lahir"].Value.ToString().Split(' ');
            string jabatan = tmp.Cells["nama_jabatan"].Value.ToString();
            string status = tmp.Cells["status"].Value.ToString();
            string jmlanak = tmp.Cells["jml_anak"].Value.ToString();

            String[] arrbln = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
            string tmpbulan = (Array.FindIndex(arrbln, a => a.Contains(tanggallahir[1])) + 1).ToString();
            var tanggallahirbaru = $"{tanggallahir[0].ToString()}-{((tmpbulan.Length == 1) ? $"0{tmpbulan}" : tmpbulan)}-{tanggallahir[2]}";

            txnama.Text = nama;
            txtempatlahir.Text = tempatlahir;
            txnohp.Text = nohp;
            txalamat.Text = alamat;
            txusername.Text = username;
            txpassword.Text = password;
            txjmlanak.Text = jmlanak;

            txtanggallahir.Value = DateTime.ParseExact(tanggallahirbaru, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            if (jeniskelamin == "Laki-Laki") rdlaki.Checked = true; else rdperempuan.Checked = true;
            if (status == "Menikah") rdmenikah.Checked = true; else rdlajang.Checked = true;
            cbjabatan.SelectedValue = id_jabatan;
            cbjabatan.Text = jabatan;

            btnAll(false, true);
        }
        void clearAll()
        {

            rdlaki.Checked = true;
            rdperempuan.Checked = false;
            rdlajang.Checked = true;
            rdmenikah.Checked = false;
            txjmlanak.Enabled = false;

            cbjabatan.SelectedIndex = 0;
            cbjabatan.Text = "";

            txnama.Text = "";
            txnohp.Text = "";
            txtempatlahir.Text = "";
            txalamat.Text = "";
            txusername.Text = "";
            txpassword.Text = "";
            txtanggallahir.Value = DateTime.Now;
            txjmlanak.Text = "0";

            btnAll();
            getDataGajiKaryawan();
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
        Boolean cekAkunNya(string usernya, string passnya)
        {
            string sql = $"SELECT * FROM karyawan WHERE username='{usernya}' AND password='{passnya}' AND sts=1";
            DataTable isi = lib.selectData(sql);
            if (isi.Rows.Count != 0) return false;
            else return true;
        }



        //-- All Proses CRUD --\\
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
        void prosesCRUD(string which)
        {
            string nama = txnama.Text;
            string namajabatan = cbjabatan.Text;
            string tempatlahir = txtempatlahir.Text;
            string nohp = txnohp.Text;
            string alamat = txalamat.Text;
            string username = txusername.Text;
            string password = txpassword.Text;
            string jeniskelamin = (rdlaki.Checked) ? "L" : "P";
            string tanggallahir = txtanggallahir.Value.ToString("ddMMyyyy");
            string idjbtn = cbjabatan.SelectedValue.ToString();
            string jabatan = cbjabatan.Text;
            string status = (rdmenikah.Checked) ? "M" : "N";
            string jmlanak = txjmlanak.Text;

            string sql = "";
            if (validasiDulu(new string[] { nama, tempatlahir, nohp, alamat, username, password }))
            {
                switch (which)
                {
                    case "add":
                        if (!cekAkunNya(username, password)) { MessageBox.Show("Username Sudah dipakai, pilih yang lain!"); return; };
                        sql = $"INSERT INTO karyawan (id_karyawan, id_jabatan, nama_karyawan, alamat, no_hp, tempat_lahir, tanggal_lahir, jenis_kelamin, status, jml_anak, username, password, lvl, sts) " +
                            $"VALUES (NULL, '{idjbtn}', '{nama}', '{alamat}', '{nohp}', '{tempatlahir}', '{tanggallahir}', '{jeniskelamin}', '{status}', '{jmlanak}', '{username}', '{password}', '3', '1')";
                        if (lib.execute(sql))
                        {
                            MessageBox.Show("Success Add", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClear.PerformClick();
                        }
                        break;

                    case "edit":
                        string tmp= $"SELECT * FROM karyawan WHERE username='{username}' AND password='{password}' AND sts=1";
                        DataTable isi = lib.selectData(tmp);
                        if (isi.Rows.Count == 0 || isi.Rows[0]["id_karyawan"].ToString() == id_karyawan)
                        {
                            sql = $"UPDATE karyawan SET " +
                            $"id_jabatan = '{idjbtn}', nama_karyawan = '{nama}', alamat = '{alamat}', no_hp = '{nohp}', tempat_lahir = '{tempatlahir}', tanggal_lahir = '{tanggallahir}', jenis_kelamin = '{jeniskelamin}', status = '{status}', jml_anak = '{jmlanak}', username = '{username}', password = '{password}', sts = '1' " +
                            $"WHERE karyawan.id_karyawan = '{id_karyawan}'";
                            if (lib.execute(sql))
                            {
                                MessageBox.Show("Success Edit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnClear.PerformClick();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username Sudah dipakai, pilih yang lain!");
                        }

                        break;

                    case "delete":
                        if (MessageBox.Show("Yakin??", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sql = $"UPDATE karyawan SET sts=0 WHERE id_karyawan='{id_karyawan}'";
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

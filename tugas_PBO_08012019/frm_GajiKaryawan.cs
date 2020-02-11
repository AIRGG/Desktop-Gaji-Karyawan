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
    public partial class frm_GajiKaryawan : Form
    {
        Lib lib = new Lib();
        string id_jabatan = "";
        string id_karyawan = "";
        string id_gaji = "";
        public frm_GajiKaryawan()
        {
            InitializeComponent();
            btnLogout.BackgroundImage = imageList1.Images[0];
            btnLogout.BackgroundImageLayout = ImageLayout.Center;
        }

        //-- ALL PROSES GET DATA --\\
        void getDataJabatan()
        {
            string sql = "SELECT * FROM jabatan";
            cbjabatan.DataSource = lib.selectData(sql);
            cbjabatan.DisplayMember = "nama_jabatan";
            cbjabatan.ValueMember = "id_jabatan";
        }
        void getDataGajiKaryawan()
        {
            string sql = @"SELECT 
                        nama_karyawan, nama_jabatan, no_hp, tempat_lahir, tanggal_lahir, jenis_kelamin, status, jml_anak, alamat,
                        id_jabatan, id_karyawan, id_gaji,
                        jml_gaji_pokok, gajiKotor, jml_tunjangan, pajak, upah_lembur, jml_lembur, gajiBersih,
                        username, password, lvl, sts, bulan, tahun
                        FROM gaji NATURAL JOIN karyawan NATURAL JOIN jabatan WHERE sts=1 AND lvl=3";
            dgvGajikaryawan.DataSource = lib.selectData(sql);
            for (var i = 0; i < dgvGajikaryawan.RowCount; i++)
            {
                var tmp = dgvGajikaryawan.Rows[i];
                string jk = tmp.Cells["jenis_kelamin"].Value.ToString();
                string status = tmp.Cells["status"].Value.ToString();
                string tgllahir = tmp.Cells["tanggal_lahir"].Value.ToString();
                tmp.Cells["jenis_kelamin"].Value = (jk == "L") ? "Laki-Laki" : "Perempuan";
                tmp.Cells["status"].Value = (status == "M") ? "Menikah" : "Lajang";
                String[] arrbln = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
                tmp.Cells["tanggal_lahir"].Value = $"{tgllahir.Substring(0, 2)} {arrbln[int.Parse(tgllahir.Substring(2, 2)) - 1]} {tgllahir.Substring(4, 4)}";
            }
            dgvGajikaryawan.Columns["id_jabatan"].Visible = false;
            dgvGajikaryawan.Columns["id_karyawan"].Visible = false;
            dgvGajikaryawan.Columns["id_gaji"].Visible = false;
            dgvGajikaryawan.Columns["lvl"].Visible = false;
            dgvGajikaryawan.Columns["sts"].Visible = false;
        }

        //-- ALL CHANGE SOMETHING --\\
        private void Frm_GajiKaryawan_Load(object sender, EventArgs e)
        {
            getDataJabatan();
            clearAll();
            //Cbjabatan_SelectedIndexChanged(cbjabatan, new EventArgs());
            jmlAll();
            txnama.Focus();
        }
        private void Rdlajang_CheckedChanged(object sender, EventArgs e)
        {
            txjmlanak.Enabled = false;
            txjmlanak.Text = "0";
            jmlAll();
        }
        private void Rdmenikah_CheckedChanged(object sender, EventArgs e)
        {
            txjmlanak.Enabled = true;
            lblTunjanganIstri.Text = (int.Parse(lblGajiPokok.Text) * 0.20).ToString();
            txjmlanak.Focus();
            txjmlanak.SelectAll();
            jmlAll();
        }
        private void Txjmlanak_TextChanged(object sender, EventArgs e)
        {
            txjmlanak.Text = (txjmlanak.Text == "") ? "0" : txjmlanak.Text;
            if (!Regex.IsMatch(txjmlanak.Text, @"^\d+$")) return;
            txjmlanak.Text = (txjmlanak.Text.Length > 2) ? txjmlanak.Text.Substring(0, 2) : txjmlanak.Text;
            txjmlanak.SelectAll();

            lblTunjanganAnak.Text = (int.Parse(txjmlanak.Text) > 1) ? (int.Parse(lblGajiPokok.Text) * 0.30).ToString() : (int.Parse(txjmlanak.Text) < 1) ? "0" : (int.Parse(lblGajiPokok.Text) * 0.15).ToString();
            jmlAll();
        }

        private void Txjamlembur_TextChanged(object sender, EventArgs e)
        {
            txjamlembur.Text = (txjamlembur.Text == "") ? "0" : txjamlembur.Text;
            if (!Regex.IsMatch(txjamlembur.Text, @"^\d+$")) return;
            txjamlembur.Text = (txjamlembur.Text.Length > 2) ? txjamlembur.Text.Substring(0, 2) : txjamlembur.Text;
            txjamlembur.SelectAll();

            lblGajiLembur.Text = (int.Parse(lblGajiPokok.Text) * int.Parse(txjamlembur.Text)).ToString();
            jmlAll();
        }

        private void Cbjabatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(cbjabatan.SelectedValue.ToString(), @"^\d+$")) return;
                string sql = $"SELECT jml_gaji_pokok, upah_lembur FROM jabatan WHERE id_jabatan='{cbjabatan.SelectedValue}'";
                DataTable dt = lib.selectData(sql);
                lblGajiPokok.Text = dt.Rows[0]["jml_gaji_pokok"].ToString();
                lblUpahLembur.Text = dt.Rows[0]["upah_lembur"].ToString();
                txjamlembur.Focus();
                txjamlembur.SelectAll();
                jmlAll();
            }
            catch (Exception ex) {
            }
        }

        private void DgvGajikaryawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var tmp = dgvGajikaryawan.Rows[e.RowIndex];

            id_jabatan = tmp.Cells["id_jabatan"].Value.ToString();
            id_karyawan = tmp.Cells["id_karyawan"].Value.ToString();
            id_gaji = tmp.Cells["id_gaji"].Value.ToString();

            string nama = tmp.Cells["nama_karyawan"].Value.ToString();
            string tempatlahir = tmp.Cells["tempat_lahir"].Value.ToString();
            string nohp = tmp.Cells["no_hp"].Value.ToString();
            string alamat = tmp.Cells["alamat"].Value.ToString();
            string username = tmp.Cells["username"].Value.ToString();
            string password = tmp.Cells["password"].Value.ToString();
            string jeniskelamin = tmp.Cells["jenis_kelamin"].Value.ToString();
            string[] tanggallahir = tmp.Cells["tanggal_lahir"].Value.ToString().Split(' ');
            string jabatan = tmp.Cells["nama_jabatan"].Value.ToString();
            string jamlembur = tmp.Cells["jml_lembur"].Value.ToString();
            string status = tmp.Cells["status"].Value.ToString();
            string jmlanak = tmp.Cells["jml_anak"].Value.ToString();

            string gajipokok = tmp.Cells["jml_gaji_pokok"].Value.ToString();
            string tunjanganistri = (status == "Menikah")?(int.Parse(gajipokok) * 0.20).ToString():"0";
            string tunjangananak = (int.Parse(tmp.Cells["jml_tunjangan"].Value.ToString())-int.Parse(tunjanganistri)).ToString();
            string gajikotor = (int.Parse(gajipokok)+int.Parse(tunjangananak)+int.Parse(tunjanganistri)).ToString();
            string pajak = (int.Parse(gajikotor) * 0.10).ToString();
            string upahlembur = tmp.Cells["upah_lembur"].Value.ToString();
            string gajilembur = (int.Parse(upahlembur)*int.Parse(jamlembur)).ToString();
            string gajibersih = ((int.Parse(gajikotor)-int.Parse(pajak))+int.Parse(gajilembur)).ToString();

            String[] arrbln =  { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
            string tmpbulan = (Array.FindIndex(arrbln, a => a.Contains(tanggallahir[1])) + 1).ToString();
            var tanggallahirbaru = $"{tanggallahir[0].ToString()}-{((tmpbulan.Length == 1)? $"0{tmpbulan}" :tmpbulan )}-{tanggallahir[2]}";

            txnama.Text = nama;
            txtempatlahir.Text = tempatlahir;
            txnohp.Text = nohp;
            txalamat.Text = alamat;
            txusername.Text = username;
            txpassword.Text = password;
            txjamlembur.Text = jamlembur;
            txjmlanak.Text = jmlanak;

            txtanggallahir.Value = DateTime.ParseExact(tanggallahirbaru, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            if (jeniskelamin == "Laki-Laki") rdlaki.Checked = true; else rdperempuan.Checked = true;
            if (status == "Menikah") rdmenikah.Checked = true; else rdlajang.Checked = true;
            cbjabatan.SelectedValue = id_jabatan;
            cbjabatan.Text = jabatan;

            lblGajiPokok.Text = gajipokok;
            lblTunjanganIstri.Text = tunjanganistri;
            lblTunjanganAnak.Text = tunjangananak;
            lblGajiKotor.Text = gajikotor;
            lblPajak.Text = pajak;
            lblUpahLembur.Text = upahlembur;
            lblGajiLembur.Text = gajilembur;
            lblGajiBersih.Text = toRP(gajibersih);

            btnAll(false, true);

        }



        //-- ALL SUPPORT PROSES --\\
        void jmlAll()
        {
            lblGajiKotor.Text = (int.Parse(lblGajiPokok.Text) + int.Parse(lblTunjanganAnak.Text) + int.Parse(lblTunjanganIstri.Text)).ToString();
            lblPajak.Text = (int.Parse(lblGajiKotor.Text) * 0.10).ToString();
            lblGajiLembur.Text = (int.Parse(lblUpahLembur.Text) * int.Parse(txjamlembur.Text)).ToString();
            lblGajiBersih.Text = toRP(((int.Parse(lblGajiKotor.Text) - int.Parse(lblPajak.Text)) + int.Parse(lblGajiLembur.Text)).ToString());
        }
        string toRP(string strnya)
        {
            CultureInfo negara = new CultureInfo("id-ID");
            return decimal.Parse(strnya).ToString("C", negara);
        }

        void btnAll(Boolean satu = true, Boolean dua = false)
        {
            btnAdd.Enabled = satu;
            btnEdit.Enabled = dua;
            btnDelete.Enabled = dua;
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
            txjamlembur.Text = "0";

            lblGajiPokok.Text = "0";
            lblGajiBersih.Text = toRP("0");
            lblGajiKotor.Text = "0";
            lblGajiLembur.Text = "0";
            lblUpahLembur.Text = "0";
            lblPajak.Text = "0";
            lblTunjanganAnak.Text = "0";
            lblTunjanganIstri.Text = "0";

            btnAll();
            getDataGajiKaryawan();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            txnama.Focus();
        }


        //-- ALL PROSES CRUD --\\
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
        Boolean cekAkunNya(string usernya, string passnya)
        {
            string sql = $"SELECT * FROM karyawan WHERE username='{usernya}' AND password='{passnya}'";
            DataTable isi = lib.selectData(sql);
            if (isi.Rows.Count != 0) return false;
            else return true;
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
            string jamlembur = txjamlembur.Text;
            string status = (rdmenikah.Checked) ? "M" : "N";
            string jmlanak = txjmlanak.Text;

            string gajipokok = lblGajiPokok.Text;
            string tunjanganistri = lblTunjanganIstri.Text;
            string tunjangananak = lblTunjanganAnak.Text;
            string jmltunjangan = (int.Parse(tunjangananak) + int.Parse(tunjanganistri)).ToString();
            string gajikotor = lblGajiKotor.Text;
            string pajak = lblPajak.Text;
            string upahlembur = lblUpahLembur.Text;
            string gajilembur = lblGajiLembur.Text;
            string gajibersih = ((int.Parse(gajikotor) - int.Parse(pajak)) + int.Parse(gajilembur)).ToString();

            string sql = "";
            if (validasiDulu(new string[] { nama, tempatlahir, nohp, alamat, username, password }))
            {
                switch (which)
                {
                    case "add":
                        if (!cekAkunNya(username, password)) return;
                        sql = $"INSERT INTO karyawan (id_karyawan, id_jabatan, nama_karyawan, alamat, no_hp, tempat_lahir, tanggal_lahir, jenis_kelamin, status, jml_anak, username, password, lvl, sts) " +
                            $"VALUES (NULL, '{idjbtn}', '{nama}', '{alamat}', '{nohp}', '{tempatlahir}', '{tanggallahir}', '{jeniskelamin}', '{status}', '{jmlanak}', '{username}', '{password}', '3', '1')";
                        if (lib.execute(sql))
                        {
                            sql = $"SELECT * FROM karyawan ORDER BY id_karyawan DESC LIMIT 1";
                            string idkar = lib.selectData(sql).Rows[0]["id_karyawan"].ToString();
                            sql = $"INSERT INTO `gaji` (`id_gaji`, `id_karyawan`, `gajiKotor`, `jml_lembur`, `pajak`, `jml_tunjangan`, `gajiBersih`, `bulan`, `tahun`) " +
                                  $"VALUES (NULL, '{idkar}', '{gajikotor}', '{jamlembur}', '{pajak}', '{jmltunjangan}', '{gajibersih}', '{DateTime.Now.Month}', '{DateTime.Now.Year}')";
                            if (lib.execute(sql))
                            {
                                MessageBox.Show("Success Add", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnClear.PerformClick();
                            }
                        }
                        break;

                    case "edit":
                        sql = $"UPDATE karyawan SET " +
                            $"id_jabatan = '{idjbtn}', nama_karyawan = '{nama}', alamat = '{alamat}', no_hp = '{nohp}', tempat_lahir = '{tempatlahir}', tanggal_lahir = '{tanggallahir}', jenis_kelamin = '{jeniskelamin}', status = '{status}', jml_anak = '{jmlanak}', username = '{username}', password = '{password}', sts = '1' " +
                            $"WHERE karyawan.id_karyawan = '{id_karyawan}'";
                        if (lib.execute(sql))
                        {
                            sql = $"UPDATE gaji SET " +
                                $"id_karyawan = '{id_karyawan}', gajiKotor = '{gajikotor}', jml_lembur = '{jamlembur}', pajak = '{pajak}', jml_tunjangan = '{jmltunjangan}', gajiBersih = '{gajibersih}', bulan = '{DateTime.Now.Month}', tahun = '{DateTime.Now.Year}' " +
                                $"WHERE gaji.id_gaji = '{id_gaji}'";
                            if (lib.execute(sql))
                            {
                                MessageBox.Show("Success Edit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnClear.PerformClick();
                            }
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

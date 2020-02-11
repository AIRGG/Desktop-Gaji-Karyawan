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
    public partial class frm_KaryawanGaji : Form
    {
        Lib lib = new Lib();
        string id_jabatan = "";
        string id_karyawan = "";
        string id_gaji = "";
        string rpt = "";
        public frm_KaryawanGaji()
        {
            InitializeComponent();
            btnLogout.BackgroundImage = imageList1.Images[0];
            btnLogout.BackgroundImageLayout = ImageLayout.Center;
        }

        //-- All PORSES GET DATA --\\
        void getBulanTahun()
        {
            int thnnow = int.Parse(DateTime.Now.ToString("yyyy"));
            int mundur = thnnow - 3;
            int maju = thnnow + 3;
            for(var i = mundur; i <= maju; i++)
            {
                cbtahun.Items.Add(i.ToString());
            }
            for(var i = 1; i <= 12; i++)
            {
                cbbulan.Items.Add(i.ToString());
            }
        }
        void getDataKaryawan()
        {
            string sql = @"SELECT * FROM karyawan NATURAL JOIN jabatan WHERE sts=1 AND stsjbtn=1 AND lvl=3";
            cbkaryawan.DataSource = lib.selectData(sql);
            cbkaryawan.DisplayMember = "nama_karyawan";
            cbkaryawan.ValueMember = "id_karyawan";
        }
        void getDataGajiKaryawan(Boolean apa = false)
        {
            string sql = "";
            string v = txsearch.Text;
            sql = @"SELECT 
                    nama_karyawan, nama_jabatan, no_hp, tempat_lahir, tanggal_lahir, jenis_kelamin, status, jml_anak, alamat,
                    id_jabatan, id_karyawan, id_gaji,
                    jml_gaji_pokok, gajiKotor, jml_tunjangan, pajak, upah_lembur, jml_lembur, gajiBersih,
                    username, password, lvl, sts, bulan, tahun
                    FROM gaji NATURAL JOIN karyawan NATURAL JOIN jabatan WHERE stsjbtn=1 AND sts=1 AND stsgaji=1 AND lvl=3 ";
            if (apa) sql += $" AND (nama_karyawan LIKE '%{v}%' OR nama_jabatan LIKE '%{v}%') ";
            rpt = sql;
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




        //-- All PROSES CHANGE SOMETHING --\\
        private void Frm_KaryawanGaji_Load(object sender, EventArgs e)
        {
            getDataKaryawan();
            getDataGajiKaryawan();
            getBulanTahun();
            clearAll();
            someAll(false);
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
        private void Txsearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txsearch.Text))
            {
                getDataGajiKaryawan(true);
            }
            else
            {
                getDataGajiKaryawan();
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void Cbkaryawan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                someAll(true);
                txjamlembur.Focus();
                string sql = $"SELECT * FROM karyawan NATURAL JOIN jabatan WHERE sts=1 AND stsjbtn=1 AND lvl=3 AND id_karyawan='{cbkaryawan.SelectedValue.ToString()}'";
                DataTable dt = lib.selectData(sql);
                var x = dt.Rows[0];
                txnama.Text = x["nama_karyawan"].ToString();
                txtempatlahir.Text = x["tempat_lahir"].ToString();
                txnohp.Text = x["no_hp"].ToString();
                txalamat.Text = x["alamat"].ToString();
                txjeniskelamin.Text = (x["jenis_kelamin"].ToString() == "L")? "Laki-Laki":"Perempuan";
                txjabatan.Text = x["nama_jabatan"].ToString();
                txjmlanak.Text = x["jml_anak"].ToString();
                txstatus.Text = (x["status"].ToString() == "M")? "Menikah" : "Lajang";

                string tmptgllahir = x["tanggal_lahir"].ToString();
                String[] arrbln = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
                txtanggallahir.Text = $"{tmptgllahir.Substring(0, 2)} {arrbln[int.Parse(tmptgllahir.Substring(2, 2)) - 1]} {tmptgllahir.Substring(4, 4)}";

                lblGajiPokok.Text = x["jml_gaji_pokok"].ToString();
                lblUpahLembur.Text = x["upah_lembur"].ToString();
                lblTunjanganIstri.Text = (x["status"].ToString() == "M")? (int.Parse(lblGajiPokok.Text) * 0.20).ToString() : "0";
                lblTunjanganAnak.Text = (x["status"].ToString() == "M") ? (int.Parse(txjmlanak.Text) > 1) ? (int.Parse(lblGajiPokok.Text) * 0.30).ToString() : (int.Parse(txjmlanak.Text) < 1) ? "0" : (int.Parse(lblGajiPokok.Text) * 0.15).ToString() : "0";
                jmlAll();
                txjamlembur.Focus();
                txjamlembur.SelectAll();
            }
            catch(Exception ex)
            {

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
            string tmpptahun = tmp.Cells["tahun"].Value.ToString();
            string tmppbulan = tmp.Cells["bulan"].Value.ToString();

            string gajipokok = tmp.Cells["jml_gaji_pokok"].Value.ToString();
            string tunjanganistri = (status == "Menikah") ? (int.Parse(gajipokok) * 0.20).ToString() : "0";
            string tunjangananak = (int.Parse(tmp.Cells["jml_tunjangan"].Value.ToString()) - int.Parse(tunjanganistri)).ToString();
            string upahlembur = tmp.Cells["upah_lembur"].Value.ToString();
            string gajilembur = (int.Parse(upahlembur) * int.Parse(jamlembur)).ToString();
            string gajikotor = (int.Parse(gajipokok) + int.Parse(tunjangananak) + int.Parse(tunjanganistri) + int.Parse(gajilembur)).ToString();
            string pajak = (int.Parse(gajikotor) * 0.10).ToString();
            string gajibersih = ((int.Parse(gajikotor) - int.Parse(pajak))).ToString();

            String[] arrbln = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
            string tmpbulan = (Array.FindIndex(arrbln, a => a.Contains(tanggallahir[1])) + 1).ToString();
            var tanggallahirbaru = $"{tanggallahir[0].ToString()}-{((tmpbulan.Length == 1) ? $"0{tmpbulan}" : tmpbulan)}-{tanggallahir[2]}";

            txnama.Text = nama;
            txtempatlahir.Text = tempatlahir;
            txnohp.Text = nohp;
            txalamat.Text = alamat;
            txjabatan.Text = jabatan;
            txjamlembur.Text = jamlembur;
            txjmlanak.Text = jmlanak;
            txtanggallahir.Text = DateTime.ParseExact(tanggallahirbaru, "dd-MM-yyyy", CultureInfo.InvariantCulture).ToString();
            txjeniskelamin.Text = jeniskelamin;
            txstatus.Text = status;

            cbkaryawan.SelectedValue = id_karyawan;
            cbkaryawan.Text = nama;
            cbtahun.Text = tmpptahun;
            cbbulan.Text = tmppbulan;


            lblGajiPokok.Text = gajipokok;
            lblTunjanganIstri.Text = tunjanganistri;
            lblTunjanganAnak.Text = tunjangananak;
            lblGajiKotor.Text = gajikotor;
            lblPajak.Text = pajak;
            lblUpahLembur.Text = upahlembur;
            lblGajiLembur.Text = gajilembur;
            lblGajiBersih.Text = toRP(gajibersih);

            btnAll(false, true);
            someAll(true);
            txjamlembur.Focus();
            txjamlembur.SelectAll();
        }


        //-- All PROSES SUPPORT --\\
        void jmlAll()
        {
            lblGajiLembur.Text = (int.Parse(lblUpahLembur.Text) * int.Parse(txjamlembur.Text)).ToString();
            lblGajiKotor.Text = (int.Parse(lblGajiPokok.Text) + int.Parse(lblTunjanganAnak.Text) + int.Parse(lblTunjanganIstri.Text) +int.Parse(lblGajiLembur.Text)).ToString();
            lblPajak.Text = (int.Parse(lblGajiKotor.Text) * 0.10).ToString();
            lblGajiBersih.Text = toRP(((int.Parse(lblGajiKotor.Text) - int.Parse(lblPajak.Text)).ToString()));
        }
        void btnAll(Boolean satu = true, Boolean dua = false)
        {
            btnAdd.Enabled = satu;
            btnEdit.Enabled = dua;
            btnDelete.Enabled = dua;
        }
        void someAll(Boolean apa)
        {
            txjamlembur.Enabled = apa;
            cbbulan.Enabled = apa;
            cbtahun.Enabled = apa;
        }
        string toRP(string strnya)
        {
            CultureInfo negara = new CultureInfo("id-ID");
            return decimal.Parse(strnya).ToString("C", negara);
        }
        void clearAll()
        {
            txjamlembur.Enabled = false;
            cbbulan.Enabled = false;
            cbtahun.Enabled = false;

            cbkaryawan.Text = "";
            cbbulan.Text = "";
            cbtahun.Text = "";

            txnama.Text = "";
            txnohp.Text = "";
            txtempatlahir.Text = "";
            txalamat.Text = "";
            txtanggallahir.Text = "";
            txjeniskelamin.Text = "";
            txjabatan.Text = "";
            txjmlanak.Text = "";
            txstatus.Text = "";
            txjamlembur.Text = "";

            lblGajiPokok.Text = "0";
            lblGajiBersih.Text = toRP("0");
            lblGajiKotor.Text = "0";
            lblGajiLembur.Text = "0";
            lblUpahLembur.Text = "0";
            lblPajak.Text = "0";
            lblTunjanganAnak.Text = "0";
            lblTunjanganIstri.Text = "0";

            btnAll();
            someAll(false);
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
        Boolean cekDuluDatanya(string idny, string bln, string thn)
        {
            string sql = $"SELECT * FROM gaji WHERE id_karyawan={idny} AND bulan={bln} AND tahun={thn} AND stsgaji=1";
            if (lib.selectData(sql).Rows.Count == 1) return false;
            else return true;
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
        void prosesCRUD(string which)
        {
            id_karyawan = cbkaryawan.SelectedValue.ToString();
            string nama = txnama.Text;
            string namajabatan = txjabatan.Text;
            string tempatlahir = txtempatlahir.Text;
            string nohp = txnohp.Text;
            string alamat = txalamat.Text;
            string jeniskelamin = (txjeniskelamin.Text == "Laki-Laki")? "L":"P";
            string idjbtn = id_jabatan;
            string jamlembur = txjamlembur.Text;
            string jmlanak = txjmlanak.Text;
            string bulan = cbbulan.Text;
            string tahun = cbtahun.Text;

            string gajipokok = lblGajiPokok.Text;
            string tunjanganistri = lblTunjanganIstri.Text;
            string tunjangananak = lblTunjanganAnak.Text;
            string gajilembur = lblGajiLembur.Text;
            string jmltunjangan = (int.Parse(tunjangananak) + int.Parse(tunjanganistri) + int.Parse(gajilembur)).ToString();
            string gajikotor = lblGajiKotor.Text;
            string pajak = lblPajak.Text;
            string upahlembur = lblUpahLembur.Text;
            string gajibersih = ((int.Parse(gajikotor) - int.Parse(pajak))).ToString();

            string sql = "";
            if (validasiDulu(new string[] { nama, tempatlahir, nohp, alamat, bulan, tahun}))
            {
                switch (which)
                {
                    case "add":
                        if(cekDuluDatanya(id_karyawan, bulan, tahun))
                        {
                            sql = $"INSERT INTO `gaji` (`id_gaji`, `id_karyawan`, `gajiKotor`, `jml_lembur`, `pajak`, `jml_tunjangan`, `gajiBersih`, `bulan`, `tahun`, stsgaji) " +
                                  $"VALUES (NULL, '{id_karyawan}', '{gajikotor}', '{jamlembur}', '{pajak}', '{jmltunjangan}', '{gajibersih}', '{bulan}', '{tahun}', 1)";
                            if (lib.execute(sql))
                            {
                                MessageBox.Show("Success Add", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnClear.PerformClick();
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Data untuk Karyawan {nama}, Bulan {bulan}, dan Tahun {tahun} Sudah Ada", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;

                    case "edit":
                        sql = $"UPDATE gaji SET " +
                            $"id_karyawan = '{id_karyawan}', gajiKotor = '{gajikotor}', jml_lembur = '{jamlembur}', pajak = '{pajak}', jml_tunjangan = '{jmltunjangan}', gajiBersih = '{gajibersih}', bulan = '{bulan}', tahun = '{tahun}' " +
                            $"WHERE gaji.id_gaji = '{id_gaji}'";
                        if (lib.execute(sql))
                        {
                            MessageBox.Show("Success Edit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClear.PerformClick();
                        }
                        break;

                    case "delete":
                        if (MessageBox.Show("Yakin??", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sql = $"UPDATE gaji SET stsgaji=0 WHERE id_gaji='{id_gaji}'";
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

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            new frm_ReportKaryawanGaji(rpt).ShowDialog();
        }
    }
}

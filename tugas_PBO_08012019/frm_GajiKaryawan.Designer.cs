namespace tugas_PBO_08012019
{
    partial class frm_GajiKaryawan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GajiKaryawan));
            this.dgvGajikaryawan = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txnama = new System.Windows.Forms.TextBox();
            this.txtempatlahir = new System.Windows.Forms.TextBox();
            this.txnohp = new System.Windows.Forms.TextBox();
            this.txalamat = new System.Windows.Forms.TextBox();
            this.rdlaki = new System.Windows.Forms.RadioButton();
            this.rdperempuan = new System.Windows.Forms.RadioButton();
            this.txtanggallahir = new System.Windows.Forms.DateTimePicker();
            this.rdmenikah = new System.Windows.Forms.RadioButton();
            this.rdlajang = new System.Windows.Forms.RadioButton();
            this.txjmlanak = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbjabatan = new System.Windows.Forms.ComboBox();
            this.txjamlembur = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblGajiBersih = new System.Windows.Forms.Label();
            this.lblGajiPokok = new System.Windows.Forms.Label();
            this.lblTunjanganIstri = new System.Windows.Forms.Label();
            this.lblTunjanganAnak = new System.Windows.Forms.Label();
            this.lblGajiKotor = new System.Windows.Forms.Label();
            this.lblPajak = new System.Windows.Forms.Label();
            this.lblGajiLembur = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblUpahLembur = new System.Windows.Forms.Label();
            this.txusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txpassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGajikaryawan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGajikaryawan
            // 
            this.dgvGajikaryawan.AllowUserToAddRows = false;
            this.dgvGajikaryawan.AllowUserToDeleteRows = false;
            this.dgvGajikaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGajikaryawan.Location = new System.Drawing.Point(8, 8);
            this.dgvGajikaryawan.Name = "dgvGajikaryawan";
            this.dgvGajikaryawan.ReadOnly = true;
            this.dgvGajikaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGajikaryawan.Size = new System.Drawing.Size(728, 192);
            this.dgvGajikaryawan.TabIndex = 1;
            this.dgvGajikaryawan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGajikaryawan_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tempat Lahir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "No HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 576);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tanggal Lahir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 648);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Status";
            // 
            // txnama
            // 
            this.txnama.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.txnama.Location = new System.Drawing.Point(32, 384);
            this.txnama.Name = "txnama";
            this.txnama.Size = new System.Drawing.Size(192, 25);
            this.txnama.TabIndex = 0;
            // 
            // txtempatlahir
            // 
            this.txtempatlahir.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.txtempatlahir.Location = new System.Drawing.Point(32, 456);
            this.txtempatlahir.Name = "txtempatlahir";
            this.txtempatlahir.Size = new System.Drawing.Size(192, 25);
            this.txtempatlahir.TabIndex = 1;
            // 
            // txnohp
            // 
            this.txnohp.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.txnohp.Location = new System.Drawing.Point(32, 528);
            this.txnohp.Name = "txnohp";
            this.txnohp.Size = new System.Drawing.Size(192, 25);
            this.txnohp.TabIndex = 2;
            // 
            // txalamat
            // 
            this.txalamat.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.txalamat.Location = new System.Drawing.Point(32, 600);
            this.txalamat.Multiline = true;
            this.txalamat.Name = "txalamat";
            this.txalamat.Size = new System.Drawing.Size(192, 64);
            this.txalamat.TabIndex = 3;
            // 
            // rdlaki
            // 
            this.rdlaki.AutoSize = true;
            this.rdlaki.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdlaki.Location = new System.Drawing.Point(8, 8);
            this.rdlaki.Name = "rdlaki";
            this.rdlaki.Size = new System.Drawing.Size(82, 22);
            this.rdlaki.TabIndex = 14;
            this.rdlaki.TabStop = true;
            this.rdlaki.Text = "Laki-Laki";
            this.rdlaki.UseVisualStyleBackColor = true;
            // 
            // rdperempuan
            // 
            this.rdperempuan.AutoSize = true;
            this.rdperempuan.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdperempuan.Location = new System.Drawing.Point(112, 8);
            this.rdperempuan.Name = "rdperempuan";
            this.rdperempuan.Size = new System.Drawing.Size(101, 22);
            this.rdperempuan.TabIndex = 15;
            this.rdperempuan.TabStop = true;
            this.rdperempuan.Text = "Perempuan";
            this.rdperempuan.UseVisualStyleBackColor = true;
            // 
            // txtanggallahir
            // 
            this.txtanggallahir.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanggallahir.Location = new System.Drawing.Point(248, 456);
            this.txtanggallahir.Name = "txtanggallahir";
            this.txtanggallahir.Size = new System.Drawing.Size(200, 26);
            this.txtanggallahir.TabIndex = 16;
            // 
            // rdmenikah
            // 
            this.rdmenikah.AutoSize = true;
            this.rdmenikah.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdmenikah.Location = new System.Drawing.Point(112, 8);
            this.rdmenikah.Name = "rdmenikah";
            this.rdmenikah.Size = new System.Drawing.Size(81, 22);
            this.rdmenikah.TabIndex = 18;
            this.rdmenikah.TabStop = true;
            this.rdmenikah.Text = "Menikah";
            this.rdmenikah.UseVisualStyleBackColor = true;
            this.rdmenikah.CheckedChanged += new System.EventHandler(this.Rdmenikah_CheckedChanged);
            // 
            // rdlajang
            // 
            this.rdlajang.AutoSize = true;
            this.rdlajang.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdlajang.Location = new System.Drawing.Point(8, 8);
            this.rdlajang.Name = "rdlajang";
            this.rdlajang.Size = new System.Drawing.Size(69, 22);
            this.rdlajang.TabIndex = 17;
            this.rdlajang.TabStop = true;
            this.rdlajang.Text = "Lajang";
            this.rdlajang.UseVisualStyleBackColor = true;
            this.rdlajang.CheckedChanged += new System.EventHandler(this.Rdlajang_CheckedChanged);
            // 
            // txjmlanak
            // 
            this.txjmlanak.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.txjmlanak.Location = new System.Drawing.Point(248, 744);
            this.txjmlanak.Name = "txjmlanak";
            this.txjmlanak.Size = new System.Drawing.Size(104, 25);
            this.txjmlanak.TabIndex = 20;
            this.txjmlanak.Text = "0";
            this.txjmlanak.TextChanged += new System.EventHandler(this.Txjmlanak_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(248, 720);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Jumlah Anak";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(248, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Jabatan";
            // 
            // cbjabatan
            // 
            this.cbjabatan.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.cbjabatan.FormattingEnabled = true;
            this.cbjabatan.Location = new System.Drawing.Point(248, 528);
            this.cbjabatan.Name = "cbjabatan";
            this.cbjabatan.Size = new System.Drawing.Size(184, 26);
            this.cbjabatan.TabIndex = 23;
            this.cbjabatan.SelectedIndexChanged += new System.EventHandler(this.Cbjabatan_SelectedIndexChanged);
            // 
            // txjamlembur
            // 
            this.txjamlembur.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.txjamlembur.Location = new System.Drawing.Point(248, 600);
            this.txjamlembur.Name = "txjamlembur";
            this.txjamlembur.Size = new System.Drawing.Size(120, 25);
            this.txjamlembur.TabIndex = 25;
            this.txjamlembur.Text = "0";
            this.txjamlembur.TextChanged += new System.EventHandler(this.Txjamlembur_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(248, 576);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Jam Lembur";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(504, 520);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "Gaji Pokok";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(504, 552);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 19);
            this.label13.TabIndex = 26;
            this.label13.Text = "Tunjangan Istri";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(504, 584);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 19);
            this.label14.TabIndex = 26;
            this.label14.Text = "Tunjangan Anak";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(504, 648);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 19);
            this.label15.TabIndex = 26;
            this.label15.Text = "Pajak 10 %";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(504, 712);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 19);
            this.label16.TabIndex = 26;
            this.label16.Text = "Gaji Lembur";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(504, 616);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 19);
            this.label17.TabIndex = 26;
            this.label17.Text = "Gaji Kotor";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(352, 789);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 29);
            this.label18.TabIndex = 27;
            this.label18.Text = "Gaji Bersih";
            // 
            // lblGajiBersih
            // 
            this.lblGajiBersih.AutoSize = true;
            this.lblGajiBersih.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold);
            this.lblGajiBersih.Location = new System.Drawing.Point(512, 784);
            this.lblGajiBersih.Name = "lblGajiBersih";
            this.lblGajiBersih.Size = new System.Drawing.Size(30, 33);
            this.lblGajiBersih.TabIndex = 27;
            this.lblGajiBersih.Text = "0";
            // 
            // lblGajiPokok
            // 
            this.lblGajiPokok.AutoSize = true;
            this.lblGajiPokok.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGajiPokok.Location = new System.Drawing.Point(648, 520);
            this.lblGajiPokok.Name = "lblGajiPokok";
            this.lblGajiPokok.Size = new System.Drawing.Size(16, 18);
            this.lblGajiPokok.TabIndex = 26;
            this.lblGajiPokok.Text = "0";
            // 
            // lblTunjanganIstri
            // 
            this.lblTunjanganIstri.AutoSize = true;
            this.lblTunjanganIstri.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTunjanganIstri.Location = new System.Drawing.Point(648, 552);
            this.lblTunjanganIstri.Name = "lblTunjanganIstri";
            this.lblTunjanganIstri.Size = new System.Drawing.Size(16, 18);
            this.lblTunjanganIstri.TabIndex = 26;
            this.lblTunjanganIstri.Text = "0";
            // 
            // lblTunjanganAnak
            // 
            this.lblTunjanganAnak.AutoSize = true;
            this.lblTunjanganAnak.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTunjanganAnak.Location = new System.Drawing.Point(648, 584);
            this.lblTunjanganAnak.Name = "lblTunjanganAnak";
            this.lblTunjanganAnak.Size = new System.Drawing.Size(16, 18);
            this.lblTunjanganAnak.TabIndex = 26;
            this.lblTunjanganAnak.Text = "0";
            // 
            // lblGajiKotor
            // 
            this.lblGajiKotor.AutoSize = true;
            this.lblGajiKotor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGajiKotor.Location = new System.Drawing.Point(648, 616);
            this.lblGajiKotor.Name = "lblGajiKotor";
            this.lblGajiKotor.Size = new System.Drawing.Size(16, 18);
            this.lblGajiKotor.TabIndex = 26;
            this.lblGajiKotor.Text = "0";
            // 
            // lblPajak
            // 
            this.lblPajak.AutoSize = true;
            this.lblPajak.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPajak.Location = new System.Drawing.Point(648, 648);
            this.lblPajak.Name = "lblPajak";
            this.lblPajak.Size = new System.Drawing.Size(16, 18);
            this.lblPajak.TabIndex = 26;
            this.lblPajak.Text = "0";
            // 
            // lblGajiLembur
            // 
            this.lblGajiLembur.AutoSize = true;
            this.lblGajiLembur.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGajiLembur.Location = new System.Drawing.Point(648, 712);
            this.lblGajiLembur.Name = "lblGajiLembur";
            this.lblGajiLembur.Size = new System.Drawing.Size(16, 18);
            this.lblGajiLembur.TabIndex = 26;
            this.lblGajiLembur.Text = "0";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(592, 456);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 40);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnEdit.Location = new System.Drawing.Point(592, 416);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 40);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(504, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 56);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(504, 416);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 80);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdlaki);
            this.panel1.Controls.Add(this.rdperempuan);
            this.panel1.Location = new System.Drawing.Point(248, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 40);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdlajang);
            this.panel2.Controls.Add(this.rdmenikah);
            this.panel2.Location = new System.Drawing.Point(248, 672);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 40);
            this.panel2.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(504, 680);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 19);
            this.label19.TabIndex = 26;
            this.label19.Text = "Upah Lembur";
            // 
            // lblUpahLembur
            // 
            this.lblUpahLembur.AutoSize = true;
            this.lblUpahLembur.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUpahLembur.Location = new System.Drawing.Point(648, 680);
            this.lblUpahLembur.Name = "lblUpahLembur";
            this.lblUpahLembur.Size = new System.Drawing.Size(16, 18);
            this.lblUpahLembur.TabIndex = 40;
            this.lblUpahLembur.Text = "0";
            // 
            // txusername
            // 
            this.txusername.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.txusername.Location = new System.Drawing.Point(16, 48);
            this.txusername.Name = "txusername";
            this.txusername.Size = new System.Drawing.Size(192, 25);
            this.txusername.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Username";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(16, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 19);
            this.label20.TabIndex = 43;
            this.label20.Text = "Password";
            // 
            // txpassword
            // 
            this.txpassword.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.txpassword.Location = new System.Drawing.Point(16, 112);
            this.txpassword.Name = "txpassword";
            this.txpassword.Size = new System.Drawing.Size(192, 25);
            this.txpassword.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txpassword);
            this.groupBox1.Controls.Add(this.txusername);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(16, 680);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 152);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Roboto Medium", 28F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(192, 264);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(481, 46);
            this.label21.TabIndex = 3;
            this.label21.Text = "PENGGAJIAN KARYAWAN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tugas_PBO_08012019.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(32, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(680, 208);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(48, 48);
            this.btnLogout.TabIndex = 45;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logout.png");
            // 
            // frm_GajiKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(744, 847);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUpahLembur);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblGajiBersih);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblGajiLembur);
            this.Controls.Add(this.lblPajak);
            this.Controls.Add(this.lblGajiKotor);
            this.Controls.Add(this.lblTunjanganAnak);
            this.Controls.Add(this.lblTunjanganIstri);
            this.Controls.Add(this.lblGajiPokok);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txjamlembur);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbjabatan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txjmlanak);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtanggallahir);
            this.Controls.Add(this.txalamat);
            this.Controls.Add(this.txnohp);
            this.Controls.Add(this.txtempatlahir);
            this.Controls.Add(this.txnama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvGajikaryawan);
            this.Name = "frm_GajiKaryawan";
            this.Text = "Gaji Karyawan";
            this.Load += new System.EventHandler(this.Frm_GajiKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGajikaryawan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGajikaryawan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txnama;
        private System.Windows.Forms.TextBox txtempatlahir;
        private System.Windows.Forms.TextBox txnohp;
        private System.Windows.Forms.TextBox txalamat;
        private System.Windows.Forms.RadioButton rdlaki;
        private System.Windows.Forms.RadioButton rdperempuan;
        private System.Windows.Forms.DateTimePicker txtanggallahir;
        private System.Windows.Forms.RadioButton rdmenikah;
        private System.Windows.Forms.RadioButton rdlajang;
        private System.Windows.Forms.TextBox txjmlanak;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbjabatan;
        private System.Windows.Forms.TextBox txjamlembur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblGajiBersih;
        private System.Windows.Forms.Label lblGajiPokok;
        private System.Windows.Forms.Label lblTunjanganIstri;
        private System.Windows.Forms.Label lblTunjanganAnak;
        private System.Windows.Forms.Label lblGajiKotor;
        private System.Windows.Forms.Label lblPajak;
        private System.Windows.Forms.Label lblGajiLembur;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblUpahLembur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txpassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ImageList imageList1;
    }
}


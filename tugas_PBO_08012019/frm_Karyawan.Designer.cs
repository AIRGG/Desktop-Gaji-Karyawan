namespace tugas_PBO_08012019
{
    partial class frm_Karyawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Karyawan));
            this.DGVKaryawan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txpassword = new System.Windows.Forms.TextBox();
            this.txusername = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txalamat = new System.Windows.Forms.TextBox();
            this.txnohp = new System.Windows.Forms.TextBox();
            this.txtempatlahir = new System.Windows.Forms.TextBox();
            this.txnama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdlajang = new System.Windows.Forms.RadioButton();
            this.rdmenikah = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdlaki = new System.Windows.Forms.RadioButton();
            this.rdperempuan = new System.Windows.Forms.RadioButton();
            this.cbjabatan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txjmlanak = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtanggallahir = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKaryawan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVKaryawan
            // 
            this.DGVKaryawan.AllowUserToAddRows = false;
            this.DGVKaryawan.AllowUserToDeleteRows = false;
            this.DGVKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVKaryawan.Location = new System.Drawing.Point(8, 8);
            this.DGVKaryawan.Name = "DGVKaryawan";
            this.DGVKaryawan.ReadOnly = true;
            this.DGVKaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVKaryawan.Size = new System.Drawing.Size(704, 192);
            this.DGVKaryawan.TabIndex = 0;
            this.DGVKaryawan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVKaryawan_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txpassword);
            this.groupBox1.Controls.Add(this.txusername);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(480, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 152);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
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
            // txpassword
            // 
            this.txpassword.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.txpassword.Location = new System.Drawing.Point(16, 112);
            this.txpassword.Name = "txpassword";
            this.txpassword.Size = new System.Drawing.Size(192, 25);
            this.txpassword.TabIndex = 5;
            // 
            // txusername
            // 
            this.txusername.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.txusername.Location = new System.Drawing.Point(16, 48);
            this.txusername.Name = "txusername";
            this.txusername.Size = new System.Drawing.Size(192, 25);
            this.txusername.TabIndex = 4;
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
            // txalamat
            // 
            this.txalamat.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.txalamat.Location = new System.Drawing.Point(16, 600);
            this.txalamat.Multiline = true;
            this.txalamat.Name = "txalamat";
            this.txalamat.Size = new System.Drawing.Size(192, 64);
            this.txalamat.TabIndex = 48;
            // 
            // txnohp
            // 
            this.txnohp.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.txnohp.Location = new System.Drawing.Point(16, 528);
            this.txnohp.Name = "txnohp";
            this.txnohp.Size = new System.Drawing.Size(192, 25);
            this.txnohp.TabIndex = 47;
            // 
            // txtempatlahir
            // 
            this.txtempatlahir.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.txtempatlahir.Location = new System.Drawing.Point(16, 456);
            this.txtempatlahir.Name = "txtempatlahir";
            this.txtempatlahir.Size = new System.Drawing.Size(192, 25);
            this.txtempatlahir.TabIndex = 46;
            // 
            // txnama
            // 
            this.txnama.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.txnama.Location = new System.Drawing.Point(16, 384);
            this.txnama.Name = "txnama";
            this.txnama.Size = new System.Drawing.Size(192, 25);
            this.txnama.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 576);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "No HP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 50;
            this.label7.Text = "Tempat Lahir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nama";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdlajang);
            this.panel2.Controls.Add(this.rdmenikah);
            this.panel2.Location = new System.Drawing.Point(232, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 40);
            this.panel2.TabIndex = 63;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.rdlaki);
            this.panel1.Controls.Add(this.rdperempuan);
            this.panel1.Location = new System.Drawing.Point(232, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 40);
            this.panel1.TabIndex = 62;
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
            // cbjabatan
            // 
            this.cbjabatan.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.cbjabatan.FormattingEnabled = true;
            this.cbjabatan.Location = new System.Drawing.Point(232, 528);
            this.cbjabatan.Name = "cbjabatan";
            this.cbjabatan.Size = new System.Drawing.Size(184, 26);
            this.cbjabatan.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(232, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 60;
            this.label10.Text = "Jabatan";
            // 
            // txjmlanak
            // 
            this.txjmlanak.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.txjmlanak.Location = new System.Drawing.Point(232, 672);
            this.txjmlanak.Name = "txjmlanak";
            this.txjmlanak.Size = new System.Drawing.Size(104, 25);
            this.txjmlanak.TabIndex = 59;
            this.txjmlanak.Text = "0";
            this.txjmlanak.TextChanged += new System.EventHandler(this.Txjmlanak_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(232, 648);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 58;
            this.label9.Text = "Jumlah Anak";
            // 
            // txtanggallahir
            // 
            this.txtanggallahir.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanggallahir.Location = new System.Drawing.Point(232, 456);
            this.txtanggallahir.Name = "txtanggallahir";
            this.txtanggallahir.Size = new System.Drawing.Size(200, 26);
            this.txtanggallahir.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(232, 576);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 56;
            this.label8.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(232, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 54;
            this.label6.Text = "Tanggal Lahir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Jenis Kelamin";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(496, 584);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 80);
            this.btnClear.TabIndex = 67;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(496, 528);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 56);
            this.btnAdd.TabIndex = 66;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnEdit.Location = new System.Drawing.Point(584, 584);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 40);
            this.btnEdit.TabIndex = 65;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(584, 624);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 40);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logout.png");
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(664, 208);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(48, 48);
            this.btnLogout.TabIndex = 92;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tugas_PBO_08012019.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(16, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Roboto Medium", 28F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(200, 256);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(401, 46);
            this.label21.TabIndex = 94;
            this.label21.Text = "MANAGE KARYAWAN";
            // 
            // frm_Karyawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(719, 725);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbjabatan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txjmlanak);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtanggallahir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txalamat);
            this.Controls.Add(this.txnohp);
            this.Controls.Add(this.txtempatlahir);
            this.Controls.Add(this.txnama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVKaryawan);
            this.Name = "frm_Karyawan";
            this.Text = "frm_Karyawan";
            this.Load += new System.EventHandler(this.Frm_Karyawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVKaryawan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVKaryawan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txpassword;
        private System.Windows.Forms.TextBox txusername;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txalamat;
        private System.Windows.Forms.TextBox txnohp;
        private System.Windows.Forms.TextBox txtempatlahir;
        private System.Windows.Forms.TextBox txnama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdlajang;
        private System.Windows.Forms.RadioButton rdmenikah;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdlaki;
        private System.Windows.Forms.RadioButton rdperempuan;
        private System.Windows.Forms.ComboBox cbjabatan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txjmlanak;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtanggallahir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label21;
    }
}
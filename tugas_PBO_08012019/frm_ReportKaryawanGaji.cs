using Microsoft.Reporting.WinForms;
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
    public partial class frm_ReportKaryawanGaji : Form
    {
        string sqla = "";
        Lib lib = new Lib();
        public frm_ReportKaryawanGaji(string sql)
        {
            InitializeComponent();
            sqla = sql;
        }

        private void Frm_ReportKaryawanGaji_Load(object sender, EventArgs e)
        {
            dsPBO ds = new dsPBO();
            ReportDataSource rds = lib.execReport(sqla, ds, "KaryawanGaji", "dskaryawangaji");
            repotKaryawanGaji.LocalReport.ReportEmbeddedResource = "tugas_PBO_08012019.reportKaryawanGaji.rdlc";
            repotKaryawanGaji.LocalReport.DataSources.Clear();
            repotKaryawanGaji.LocalReport.DataSources.Add(rds);
            repotKaryawanGaji.RefreshReport();

            repotKaryawanGaji.Refresh();
        }
    }
}

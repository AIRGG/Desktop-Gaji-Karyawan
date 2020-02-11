using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace tugas_PBO_08012019
{
    class Lib
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;

        private void open()
        {
            try
            {
                //con = new MySqlConnection("server='remotemysql.com'; user='l1aQS7gR7i'; database='l1aQS7gR7i'; pwd='wlI8Bkhz3R'");
                con = new MySqlConnection("server='localhost'; user='root'; database='db_pbo_08012019'; pwd=''");
                con.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Some Error: " + e.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void close()
        {
            con.Close();
        }

        public DataTable selectData(string sql)
        {
            dt = new DataTable();
            try
            {
                open();
                da = new MySqlDataAdapter(sql, con);
                da.Fill(dt);
                close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Some Error: " + e.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return dt;
        }

        public Boolean execute(String sql)
        {
            Boolean hasil = false;
            try
            {
                open();
                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                hasil = true;
                close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Some Error: " + e.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return hasil;
        }


        public ReportDataSource execReport(string sql, DataSet ds, string nama, string namaRdlcNya)
        {
            ReportDataSource rds = new ReportDataSource(namaRdlcNya, ds.Tables[nama]);
            try
            {
                open();
                cmd = new MySqlCommand(sql, con);
                da = new MySqlDataAdapter(cmd);
                da.Fill(ds, nama);
                close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in CreateReport: " + e.Message);
            }
            return rds;
        }

    }
}

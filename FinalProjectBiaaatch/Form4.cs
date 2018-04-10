using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace FinalProjectBiaaatch
{
    public partial class Form4 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int j = 0;
        public Form4()
        {
            InitializeComponent();
        }

        public void DB_Connect()
        {
            String oradb = "Data Source=XE; User ID=system; Password=kEYBOARDS";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            j++;
            if (j >= dt.Rows.Count)
                j = 0;
            dr = dt.Rows[j];
            textBox2.Text = dr["weapon_name"].ToString();
            textBox3.Text = dr["material_used"].ToString();
            textBox4.Text = dr["type"].ToString();
            textBox5.Text = dr["alias_name"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            String str = textBox2.Text;
            comm.CommandText = "select * from Weapon where weapon_name=" + "'" + str + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Weapon");
            dt = ds.Tables["Tbl_Weapon"];
            int t = dt.Rows.Count;
            if (t == 0)
                MessageBox.Show("Sorry! The weapon you requested isn't on our shop. Why don't you pay us a visit some other time?");
            else
            {
                dr = dt.Rows[j];
                textBox3.Text = dr["material_used"].ToString();
                textBox4.Text = dr["type"].ToString();
                textBox5.Text = dr["alias_name"].ToString();
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            j--;
            if (j < 0)
                j = dt.Rows.Count - 1;
            dr = dt.Rows[j];
            textBox2.Text = dr["weapon_name"].ToString();
            textBox3.Text = dr["material_used"].ToString();
            textBox4.Text = dr["type"].ToString();
            textBox5.Text = dr["alias_name"].ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

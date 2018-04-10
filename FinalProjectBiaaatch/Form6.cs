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
    public partial class Form6 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;

        public Form6()
        {
            InitializeComponent();
        }

        public void DB_Connect()
        {
            String oradb = "Data Source=XE; User ID=system; Password=kEYBOARDS";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            String strin = textBox2.Text;
            comm.CommandText = "select * from Organization where organization_name=" + "'" + strin + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Organization");
            dt = ds.Tables["Tbl_Organization"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            textBox1.Text = dr["current_alias"].ToString();
            textBox7.Text = dr["con_name"].ToString();
            textBox6.Text = dr["universe"].ToString();
            textBox3.Text = dr["slogan"].ToString();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i++;
            if (i >= dt.Rows.Count)
                i = 0;
            dr = dt.Rows[i];
            textBox2.Text = dr["organization_name"].ToString();
            textBox1.Text = dr["current_alias"].ToString();
            textBox7.Text = dr["con_name"].ToString();
            textBox6.Text = dr["universe"].ToString();
            textBox3.Text = dr["slogan"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = dt.Rows.Count - 1;
            dr = dt.Rows[i];
            textBox2.Text = dr["organization_name"].ToString();
            textBox1.Text = dr["current_alias"].ToString();
            textBox7.Text = dr["con_name"].ToString();
            textBox6.Text = dr["universe"].ToString();
            textBox3.Text = dr["slogan"].ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            String str = textBox2.Text;
            comm.CommandText = "select * from Organization where organization_name=" + "'" + str + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Organization");
            dt = ds.Tables["Tbl_Organization"];
            int t = dt.Rows.Count;
            if (t == 0)
                MessageBox.Show("Oops!");
            else
            {
                dr = dt.Rows[i];
                textBox1.Text = dr["current_alias"].ToString();
                textBox7.Text = dr["con_name"].ToString();
                textBox3.Text = dr["slogan"].ToString();
                textBox6.Text = dr["universe"].ToString();
                conn.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = dt.Rows.Count - 1;
            dr = dt.Rows[i];
            textBox2.Text = dr["organization_name"].ToString();
            textBox1.Text = dr["current_alias"].ToString();
            textBox7.Text = dr["con_name"].ToString();
            textBox6.Text = dr["universe"].ToString();
            textBox3.Text = dr["slogan"].ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            i++;
            if (i >= dt.Rows.Count)
                i = 0;
            dr = dt.Rows[i];
            textBox2.Text = dr["organization_name"].ToString();
            textBox1.Text = dr["current_alias"].ToString();
            textBox7.Text = dr["con_name"].ToString();
            textBox6.Text = dr["universe"].ToString();
            textBox3.Text = dr["slogan"].ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

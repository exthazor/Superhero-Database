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
    public partial class Form7 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form7()
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
            String str = textBox1.Text;
            comm.CommandText = "select * from planet where planet_name=" + "'" + str + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_planet");
            dt = ds.Tables["Tbl_planet"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            textBox2.Text = dr["abundant_material"].ToString();
            textBox3.Text = dr["universe"].ToString();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = dt.Rows.Count - 1;
            dr = dt.Rows[i];
            textBox1.Text = dr["planet_name"].ToString();
            textBox2.Text = dr["abundant_material"].ToString();
            textBox3.Text = dr["universe"].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            String str = textBox1.Text;
            comm.CommandText = "select * from planet where planet_name=" + "'" + str + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_planet");
            dt = ds.Tables["Tbl_planet"];
            int t = dt.Rows.Count;
            if (t == 0)
                MessageBox.Show("Sorry! The planet you inserted isn't in our database. Wait for future updates!");
            else
            {
                dr = dt.Rows[i];
                textBox2.Text = dr["abundant_material"].ToString();
                textBox3.Text = dr["universe"].ToString();
                conn.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            i++;
            if (i >= dt.Rows.Count)
                i = 0;
            dr = dt.Rows[i];
            textBox1.Text = dr["planet_name"].ToString();
            textBox2.Text = dr["abundant_material"].ToString();
            textBox3.Text = dr["universe"].ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = dt.Rows.Count - 1;
            dr = dt.Rows[i];
            textBox1.Text = dr["planet_name"].ToString();
            textBox2.Text = dr["abundant_material"].ToString();
            textBox3.Text = dr["universe"].ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            String str = textBox1.Text;
            comm.CommandText = "select weapon_name from weapon where alias_name in (select alias_name from planet where planet_name=" + "'" + str + "'" + ")";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_weapon");
            dt = ds.Tables["Tbl_weapon"];
            int t = dt.Rows.Count;
            if (t == 0)
                MessageBox.Show("Oops!");
            else
            {
                MessageBox.Show(t.ToString());
                dr = dt.Rows[i];
                textBox4.Text = dr["weapon_name"].ToString();
                conn.Close();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
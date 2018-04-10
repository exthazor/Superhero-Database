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
    public partial class Form8 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form8()
        {
            InitializeComponent();
        }

        public void DB_Connect()
        {
            String oradb = "Data Source=XE; User ID=system; Password=kEYBOARDS";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            String str = textBox1.Text;
            comm.CommandText = "select * from supervillain where con_name=" + "'" + str + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Supervillain");
            dt = ds.Tables["Tbl_Supervillain"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            textBox2.Text = dr["name"].ToString();
            textBox3.Text = dr["DOB"].ToString();
            textBox4.Text = dr["fav_dish"].ToString();
            textBox5.Text = dr["weakness"].ToString();
            textBox7.Text = dr["universe"].ToString();
            textBox6.Text = dr["Planet_Name"].ToString();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            String str = textBox1.Text;
            comm.CommandText = "select * from supervillain where con_name=" + "'" + str + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Supervillain");
            dt = ds.Tables["Tbl_Supervillain"];
            int t = dt.Rows.Count;
            if (t == 0)
                MessageBox.Show("Sorry! This villain isn't in the asylum. He must've escaped. Sigh!");
            else
            {
                dr = dt.Rows[i];
                textBox2.Text = dr["name"].ToString();
                textBox3.Text = dr["DOB"].ToString();
                textBox4.Text = dr["fav_dish"].ToString();
                textBox5.Text = dr["weakness"].ToString();
                textBox7.Text = dr["universe"].ToString();
                textBox6.Text = dr["Planet_Name"].ToString();
                conn.Close();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB_Connect();
            //OracleConnection connObj = new OracleConnection();
            //connObj.Open();
            comm = new OracleCommand();
            OracleCommand c = new OracleCommand("weak_villain", conn);
            c.CommandType = CommandType.StoredProcedure;
            c.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("The villains who are relatively weak have been sent to the Weak_Villain table!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            String str = textBox1.Text;
            comm.CommandText = "select slogan from Organization where con_name in (select con_name from Supervillain where con_name=" + "'" + str + "'" + ")";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Supervillain");
            dt = ds.Tables["Tbl_Supervillain"];
            int t = dt.Rows.Count;
            if (t == 0)
                MessageBox.Show("Oops! Your supervillain isn't leading any organization.");
            else
            {
                dr = dt.Rows[i];
                String slog = dr["slogan"].ToString();
                MessageBox.Show(slog);
                conn.Close();
            }
        }
    }
}
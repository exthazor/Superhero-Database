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
    public partial class Form5 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        String pow1, pow2, person1, person2;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form1_formClosing(object sender, FormClosedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit the Superhero Database?", "Exit", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
                //e.Cancel = true;
                Application.Exit();
        }

        public void DB_Connect()
        {
            String oradb = "Data Source=XE; User ID=system; Password=kEYBOARDS";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int result1;
            result1 = int.Parse(pow1);
            int result2;
            result2 = int.Parse(pow2);
            if (result1 > result2)
                textBox3.Text = person1;
            else textBox3.Text = person2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            person1 = textBox1.Text;
            comm.CommandText = "select power_index from Superhero where current_alias=" + "'" + person1 + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Superhero");
            dt = ds.Tables["Tbl_Superhero"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            pow1 = dr["power_index"].ToString();
            conn.Close();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            person2 = textBox2.Text;
            comm.CommandText = "select power_index from Superhero where current_alias=" + "'" + person2 + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Superhero");
            dt = ds.Tables["Tbl_Superhero"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            pow2 = dr["power_index"].ToString();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            person1 = textBox1.Text;
            comm.CommandText = "select power_index from Superhero where current_alias=" + "'" + person1 + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Superhero");
            dt = ds.Tables["Tbl_Superhero"];
            int t = dt.Rows.Count;
            if (t == 0)
                MessageBox.Show("Sorry! The superhero you provided is not in our database. Why don't you try inserting it yourself? Make them fight afterwards.");
            else
            {
                MessageBox.Show("Sent to the arena!");
                dr = dt.Rows[i];
                pow1 = dr["power_index"].ToString();
                conn.Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            person2 = textBox2.Text;
            comm.CommandText = "select power_index from Superhero where current_alias=" + "'" + person2 + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Superhero");
            dt = ds.Tables["Tbl_Superhero"];
            int t = dt.Rows.Count;
            if (t == 0)
                MessageBox.Show("Sorry! The superhero you provided is not in our database. Why don't you try inserting it yourself? Make them fight afterwards.");
            else
            {
                MessageBox.Show("Sent to the arena!");
                dr = dt.Rows[i];
                pow2 = dr["power_index"].ToString();
                conn.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int result1;
            result1 = int.Parse(pow1);
            int result2;
            result2 = int.Parse(pow2);
            if (result1 > result2)
                textBox3.Text = person1;
            else textBox3.Text = person2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

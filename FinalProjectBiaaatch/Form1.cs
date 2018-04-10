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
    public partial class Form1 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;

        public Form1()
        {

            InitializeComponent();
        }

        public void DB_Connect()
        {
            String oradb = "Data Source=XE; User ID=system; Password=kEYBOARDS";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            String str = textBox1.Text;
            comm.CommandText = "select * from Superhero where current_alias=" + "'" + str + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Superhero");
            dt = ds.Tables["Tbl_Superhero"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            textBox2.Text = dr["name"].ToString();
            textBox3.Text = dr["DOB"].ToString();
            textBox4.Text = dr["fav_dish"].ToString();
            textBox5.Text = dr["weakness"].ToString();
            textBox7.Text = dr["universe"].ToString();
            textBox6.Text = dr["Planet_Name"].ToString();
            textBox8.Text = dr["con_name"].ToString();
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to exit the Superhero Database?", "Go so soon?", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
                //e.Cancel = true;
                Application.Exit();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            String str = textBox1.Text;
            comm.CommandText = "select * from Superhero where current_alias=" + "'" + str + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Superhero");
            dt = ds.Tables["Tbl_Superhero"];
            int t = dt.Rows.Count;
            if (t == 0)
                MessageBox.Show("Sorry! The superhero you provided is not in our database. Why don't you try inserting it yourself?");
            else
            {
                dr = dt.Rows[i];
                textBox2.Text = dr["name"].ToString();
                textBox3.Text = dr["DOB"].ToString();
                textBox4.Text = dr["fav_dish"].ToString();
                textBox5.Text = dr["weakness"].ToString();
                textBox7.Text = dr["universe"].ToString();
                textBox6.Text = dr["Planet_Name"].ToString();
                textBox8.Text = dr["con_name"].ToString();
                conn.Close();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            String str = textBox1.Text;
            comm.CommandText = "select slogan from Organization where current_alias in (select current_alias from Superhero where current_alias=" + "'" + str + "'" + ")";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Organization");
            dt = ds.Tables["Tbl_Organization"];
            int t = dt.Rows.Count;
            if (t == 0)
                MessageBox.Show("Oops! Your Superhero isn't leading any organization.");
            else
            {
                dr = dt.Rows[i];
                String slog = dr["slogan"].ToString();
                MessageBox.Show(slog);
                conn.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            OracleCommand c = new OracleCommand("earth_heroes", conn);
            c.CommandType = CommandType.StoredProcedure;
            c.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("The Superheroes born on Earth have been moved to a new table called Earth_Heroes!");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            String str = textBox1.Text;
            comm.CommandText = "select count(*) as Haa from Superhero)";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Superhero");
            dt = ds.Tables["Tbl_Superhero"];
            int t = dt.Rows.Count;
            if (t == 0)
                MessageBox.Show("Oops!");
            else
            {
                dr = dt.Rows[i];
                String slog = dr["Haa"].ToString();
                MessageBox.Show("Number of Superheroes in our database = "+slog);
                conn.Close();
            }
        }
        }
    }
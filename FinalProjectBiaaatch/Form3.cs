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
    public partial class Form3 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        String power, pow;
        public Form3()
        {
            InitializeComponent();
        }

        public void DB_Connect()
        {
            String oradb = "Data Source=XE; User ID=system; Password=kEYBOARDS";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int supaa;
            supaa = int.Parse(pow);
            if (supaa > 5)
                MessageBox.Show("Run for your life you wanna-be hero!");
            else MessageBox.Show("Yeah you can fight him. But don't blame us if you get hurt!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            power = textBox1.Text;
            comm.CommandText = "select danger_index from Superpower where type=" + "'" + power + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Superpower");
            dt = ds.Tables["Tbl_Superpower"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            pow = dr["power_index"].ToString();
            conn.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            power = textBox1.Text;
            comm.CommandText = "select danger_index from Superpower where type=" + "'" + power + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_Superpower");
            dt = ds.Tables["Tbl_Superpower"];
            int t = dt.Rows.Count;
            if (t == 0)
                MessageBox.Show("Sorry! The uploaded superpower isn't supported by our database. Wait for future updates!");
            else
            {
                MessageBox.Show(t.ToString());
                dr = dt.Rows[i];
                pow = dr["danger_index"].ToString();
                conn.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int supaa;
            supaa = int.Parse(pow);
            if (supaa > 5)
                MessageBox.Show("RUN FOR YOUR LIFE YOU WANNA-BE HERO!");
            else MessageBox.Show("Yeah you can fight him. But don't blame us if you get hurt!");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp7
{
    public partial class Main : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Downloads\p1-main\p1-main\WindowsFormsApp7\Database1.mdf;Integrated Security=True";     
        
        void connection()
        {
            con = new SqlConnection(s);
            con.Open();
        }
        public Main()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Customer f7 = new Customer();
            f7.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            stock s = new stock();
            s.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            record r = new record();
            r.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            connection();

            string dt = DateTime.Now.ToBinary().ToString();

            cmd = new SqlCommand("insert into maintbl(company_name , model , color , storage, camera ,network_type , price , ram) values ('" + txtnm.Text + "','" + txtmdl.Text + "','" + txtclr.Text + "','" + txtstrg.Text + "','" + txtcmr.Text + "','" + txttyp.Text + "','" + txtprs.Text + "','" + txtrm.Text + "')",con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("data inserted .... ");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtnm_TextChanged(object sender, EventArgs e)
        {

        }
        void clear()
        {
            txtnm.Clear();
            txtmdl.Clear();
            txtclr.Clear();
            txtstrg.Clear();
            txtcmr.Clear();
            txttyp.Clear();
            txtprs.Clear();
            txtrm.Clear();

        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtclr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

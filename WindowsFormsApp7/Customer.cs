using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp7
{
    public partial class Customer : Form
    {
        SqlConnection con;
        SqlCommand cmd;


        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Parag\source\repos\Parag\WindowsFormsApp7\WindowsFormsApp7\Database1.mdf;Integrated Security=True";
        void connection()
        {
            con = new SqlConnection(s);
            con.Open();
        }
        public Customer()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            connection();

            string pt = DateTime.Now.ToBinary().ToString();

            cmd = new SqlCommand(cmdText: "insert into cutomerdatatbl (customer_name , phonesmodel , gender , contact_number , e_mail , address,imei_number,payment_method) values ('" + txtnm.Text + "','" + txtmdl.Text + "','" + txtgdr.Text + "','" + txtphn.Text + "','" + txteml.Text + "','" + txtadd.Text + "','"+ txtimei.Text +"','"+ txtpay.Text + "')", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("data inserted .... ");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void txteml_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

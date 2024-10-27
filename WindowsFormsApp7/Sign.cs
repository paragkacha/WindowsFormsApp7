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
    public partial class Sign : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        DataSet ds;

        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Downloads\p1-main\p1-main\WindowsFormsApp7\Database1.mdf;Integrated Security = True";

        void conn()
        {
            con = new SqlConnection(constr);
            con.Open();
        }
        public Sign()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conn();
            cmd = new SqlCommand("insert into signup (email , Password) values ('" + txtUname.Text + "','" + txtPwd.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added Successfully");

            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sign_Load(object sender, EventArgs e)
        {

        }
    }
}

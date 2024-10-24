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
    public partial class Login : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        DataSet ds;

        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Parag\source\repos\Parag\WindowsFormsApp7\WindowsFormsApp7\Database1.mdf;Integrated Security=True";
        void conn()
        {
            con = new SqlConnection(constr);
            con.Open();
        }
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            

            if(txtuname.Text == "" || txtpwd.Text == "")
            {
                MessageBox.Show("Enter Valid Email Or Password");
            }
            else
            {
                conn();
                da = new SqlDataAdapter("select count(*) from signup where email = '" + txtuname.Text + "' and Password = '" + txtpwd.Text + "' ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows[0][0].ToString() == "1")
                {
                    Main f6 = new Main();
                    f6.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Paassword");
                }
            }
            

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Sign sg = new Sign();
            sg.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

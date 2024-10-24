using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class stock : Form
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
        public stock()
        {
            InitializeComponent();
            stock_show();
        }

        void stock_show()
        {
            conn();
            da = new SqlDataAdapter("select * from maintbl", con);
            ds = new DataSet();
            da.Fill(ds);
            stock_DVG.DataSource = ds.Tables[0];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void stock_Load(object sender, EventArgs e)
        {

        }
    }
}

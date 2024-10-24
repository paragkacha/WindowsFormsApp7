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
    public partial class record : Form
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
        public record()
        {
            InitializeComponent();
            showData();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Customer f7 = new Customer();
            f7.Show();
            this.Hide();
        }

        void showData()
        {
            conn();
            da = new SqlDataAdapter("select * from cutomerdatatbl", con);
            ds = new DataSet();
            da.Fill(ds);
            Stock_DGV.DataSource = ds.Tables[0];
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

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
        int key = 0;
        private void Stock_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IMEI.Text = Stock_DGV.SelectedRows[0].Cells[1].Value.ToString();
            IMEI.Text = Stock_DGV.SelectedRows[0].Cells[2].Value.ToString();
            IMEI.Text = Stock_DGV.SelectedRows[0].Cells[3].Value.ToString();
            IMEI.Text = Stock_DGV.SelectedRows[0].Cells[4].Value.ToString();
            IMEI.Text = Stock_DGV.SelectedRows[0].Cells[5].Value.ToString();
            IMEI.Text = Stock_DGV.SelectedRows[0].Cells[6].Value.ToString();
            IMEI.Text = Stock_DGV.SelectedRows[0].Cells[7].Value.ToString();
            IMEI.Text = Stock_DGV.SelectedRows[0].Cells[8].Value.ToString();

            if(IMEI.Text == "IMEI")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Stock_DGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            conn();
            if (key == 0)
            {
                MessageBox.Show("Select Stock");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("delete from cutomerdatatbl where Id = '" + key + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Stock Details Deleted");
                    showData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

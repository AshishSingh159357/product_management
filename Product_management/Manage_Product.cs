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

namespace Product_management
{
    public partial class Manage_Product : Form
    {
        public Manage_Product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string sql = "SELECT * FROM manage_product2";
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ashish\Documents\P_M.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Login_form");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Login_form";
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_new_product adp = new add_new_product();
            Manage_Product mp = new Manage_Product();

            adp.Show();
            mp.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            Manage_Product mp = new Manage_Product();
            up.Show();
            mp.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            remove re = new remove();
            re.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string text="";
            int prd_id=0;
            if (textBox1.Text is string)
            {
                 text = textBox1.Text;
            }
            else
            {

                prd_id = Convert.ToInt32(textBox1.Text);
            }
            string sql="select * from manage_product2 where prd_id='"+prd_id+"' or prd_name='"+text+"' or stock_quatity='"+text+"' or description='"+text+"' or cat_name='"+text+"' or price='"+text+"'";
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ashish\Documents\P_M.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sd = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            connection.Open();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

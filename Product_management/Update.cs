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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox5.Text);
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ashish\Documents\P_M.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
            string q = "select * from manage_product2 where prd_id='"+id+"'";
            SqlCommand cmd = new SqlCommand(q,cn);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                textBox1.Text = r.GetValue(1).ToString();
                textBox2.Text = r.GetValue(2).ToString();
                textBox3.Text = r.GetValue(3).ToString();
                textBox4.Text = r.GetValue(4).ToString();
                comboBox1.Text = r.GetValue(5).ToString();
            }
            cn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(textBox5.Text);
            string name=textBox1.Text;
            int quatity=Convert.ToInt32(textBox2.Text);
            int price=Convert.ToInt32(textBox3.Text);
            string description =textBox4.Text;
            string cat_name=comboBox1.Text;
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ashish\Documents\P_M.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
            string q = "update manage_product2 set prd_id='" + id + "',prd_name='" + name + "',stock_quatity='" + quatity + "',price='" + price + "',description='" + description + "',cat_name='" + cat_name + "' where prd_id='"+id+"'";
            SqlCommand cmd = new SqlCommand(q, cn);
            if (cmd.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Error during updation...");
            }
            cn.Close();
        }
    }
}

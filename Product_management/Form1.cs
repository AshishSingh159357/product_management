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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            string first_name=textBox1.Text;
            string last_name=textBox2.Text;
            string username = textBox3.Text;
            int password = Convert.ToInt32(textBox4.Text);
            SqlConnection cn=new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ashish\Documents\P_M.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
            string s = "insert into Login(username,password,first_name,last_name) values('" + username + "','" + password + "','" + first_name + "','" + last_name + "')";

            SqlCommand cmd = new SqlCommand(s, cn);
            if (cmd.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Inserted success");
            }
            else 
            {
                MessageBox.Show("Not Inserted");
            }
            cn.Close();
            f2.Show();
        }
    }
}

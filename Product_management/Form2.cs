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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int password = Convert.ToInt32(textBox4.Text);
            string username = textBox3.Text;
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ashish\Documents\P_M.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
            string s = "select * from Login where username='" + username + "' ";
            SqlCommand q = new SqlCommand(s, cn);
            SqlDataReader r = q.ExecuteReader();
            
            if (r.Read())
            {
                string us = r.GetValue(0).ToString();
                int pass = Convert.ToInt32(r.GetValue(1));

                if (pass == password)
                {
                    Form3 f3=new Form3();
                    Form2 f2 = new Form2();
                    f3.Show();
                    f2.Hide();
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            cn.Close();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox4.UseSystemPasswordChar = false;
            }
            else
            {
                textBox4.UseSystemPasswordChar = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            f1.Show();
            f2.Hide();
            
        }
        

       
       
    }
}

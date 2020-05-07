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


namespace Product_management
{
    public partial class add_new_product : Form
    {
        string location;
        public add_new_product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                location = dialog.FileName.ToString();
                pictureBox1.ImageLocation = location;
 
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string stock = textBox3.Text;
            string price = textBox4.Text;
            string description = textBox5.Text;
            string category = comboBox1.Text;
           

            

            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ashish\Documents\P_M.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
            string s="insert into manage_product2(prd_id,prd_name,stock_quatity,price,description,cat_name) values('"+id+"','"+name+"','"+stock+"','"+price+"','"+description+"','"+category+"')";
            SqlCommand cmd = new SqlCommand(s,cn);
            

            if (cmd.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Inserted successfully");
            }
            else
            {
                MessageBox.Show("Error during Insertion..");
            }
            cn.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "0";
        }
    }
}

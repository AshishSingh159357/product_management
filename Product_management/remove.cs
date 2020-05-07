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
    public partial class remove : Form
    {
        public remove()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(textBox1.Text);
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ashish\Documents\P_M.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
            string q = "delete from manage_product2 where prd_id='"+id+"' ";
            SqlCommand cmd = new SqlCommand(q, cn);
            if (cmd.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Deleted successfully");
            }
            else
            {
                MessageBox.Show("Error during deletion");
            }
        }
    }
}

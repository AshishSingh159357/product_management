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
    public partial class delete_user : Form
    {
        public delete_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ashish\Documents\P_M.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
            string q = "delete from Login where username='"+textBox1.Text+"' ";
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

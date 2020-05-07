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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ashish\Documents\P_M.mdf;Integrated Security=True;Connect Timeout=30");
            string sql = "select * from Login";
            SqlDataAdapter sd = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            cn.Open();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete_user du = new delete_user();
            du.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            changepassword cp = new changepassword();
            cp.Show();
        }
    }
}

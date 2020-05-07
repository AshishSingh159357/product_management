using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_management
{
    public partial class add_new_category : Form
    {
        public string new_cat;
        public add_new_category()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_new_product anp = new add_new_product();
            anp.comboBox1.Items.Add(textBox1.Text);
            MessageBox.Show("Inserted");
            
        }
    }
}

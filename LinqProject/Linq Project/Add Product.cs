using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_Project
{
    public partial class Add_Product : Form
    {
        public Add_Product()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty | textBox2.Text == string.Empty | textBox3.Text == string.Empty)
            {
                MessageBox.Show("Please Fill Product Data");
            }
            else
            {
                ProjectEntities db = new ProjectEntities();

                Product p = new Product();
                p.Product_ID = int.Parse(textBox1.Text);
                p.Product_Name = textBox2.Text;
                p.Product_Period = DateTime.Parse(textBox3.Text);
                db.Products.AddObject(p);
                db.SaveChanges();
                MessageBox.Show("Product Added");
                textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;

            }
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {
             
        }
    }
}

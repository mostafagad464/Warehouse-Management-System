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
    public partial class Add_Store : Form
    {
        ProjectEntities db = new ProjectEntities();

        public Add_Store()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty | textBox2.Text == string.Empty | textBox3.Text == string.Empty)
            {
                MessageBox.Show("Please Fill Store Data");
            }
            else
            {
                Store s = new Store();
                s.Store_Name = textBox1.Text;
                s.Store_Addres = textBox2.Text;
                s.Store_Keeper = textBox3.Text;
                db.Stores.AddObject(s);
                db.SaveChanges();
                MessageBox.Show("Store Added");
                textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;
            }
        }
    }
}

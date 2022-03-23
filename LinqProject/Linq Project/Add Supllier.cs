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
    public partial class Add_Supllier : Form
    {
        ProjectEntities db = new ProjectEntities();

        public Add_Supllier()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty | textBox2.Text == string.Empty | textBox3.Text == string.Empty)
            {
                MessageBox.Show("Please Fill Supplier Data");
            }
            else
            {
                Supplier s = new Supplier();
                s.Suppliers_ID = int.Parse(textBox1.Text);
                s.Suppliers_Name = textBox2.Text;
                s.Suppliers_Phone = int.Parse(textBox3.Text);
                s.Suppliers_fax = textBox4.Text;
                s.Suppliers_Mobile = Convert.ToInt32(textBox5.Text); //convert to varchar in db //wait mostfa to change it
                s.Suppliers_Email = textBox6.Text;
                s.Suppliers_Website = textBox7.Text;
                db.Suppliers.AddObject(s);
                db.SaveChanges();
                MessageBox.Show("Supplier Added");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = string.Empty;

            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

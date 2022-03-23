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
    public partial class Add_Client : Form
    {
        ProjectEntities db = new ProjectEntities();

        public Add_Client()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty | textBox2.Text == string.Empty | textBox3.Text == string.Empty)
            {
                MessageBox.Show("Please Fill Client Data");
            }
            else
            {
                Client C = new Client();
                C.Client_ID = int.Parse(textBox1.Text);
                C.Client_Name = textBox2.Text;
                C.Client_Phone = int.Parse(textBox3.Text);
                C.Client_Fax = textBox4.Text;
                C.Client_Mobile = int.Parse(textBox5.Text);
                C.Client_Email = textBox6.Text;
                C.Client_Website = textBox7.Text;
                db.Clients.AddObject(C);
                db.SaveChanges();
                MessageBox.Show("Client Added");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = string.Empty;

            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

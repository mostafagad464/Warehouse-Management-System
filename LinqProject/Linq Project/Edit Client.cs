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
    public partial class Edit_Client : Form
    {
        int id;
        ProjectEntities db = new ProjectEntities();

        public Edit_Client()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Clients.ToList();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Delete

            //var result = db.Clients.Find(id);
            //db.Clients.remove(result);
            db.SaveChanges();
            dataGridView1.DataSource = db.Clients.ToList();
            MessageBox.Show("Deleted");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Edit
            var cli = db.Clients.SingleOrDefault(x => x.Client_ID == id);
            cli.Client_ID = int.Parse(textBox1.Text);
            cli.Client_Name = textBox2.Text;
            cli.Client_Phone = int.Parse(textBox3.Text);
            cli.Client_Fax = textBox4.Text;
            cli.Client_Mobile = int.Parse(textBox5.Text);
            cli.Client_Email = textBox6.Text;
            cli.Client_Website = textBox7.Text;
            db.SaveChanges();
            dataGridView1.DataSource = db.Clients.ToList();
            MessageBox.Show("Client Updated");

        }
    }
}

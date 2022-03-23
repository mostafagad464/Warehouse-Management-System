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
    public partial class Edit_Supplier : Form
    {
        int id;
        ProjectEntities db = new ProjectEntities();

        public Edit_Supplier()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Suppliers.ToList();

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
            //var result = db.Suppliers.(id);
            //db.Suppliers.remove(result);
            db.SaveChanges();
            dataGridView1.DataSource = db.Suppliers.ToList();
            MessageBox.Show("Deleted");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var supp = db.Suppliers.SingleOrDefault(x => x.Suppliers_ID == id);
            supp.Suppliers_ID = int.Parse(textBox1.Text);
            supp.Suppliers_Name = textBox2.Text;
            supp.Suppliers_Phone = int.Parse(textBox3.Text);
            supp.Suppliers_fax = textBox4.Text;
            supp.Suppliers_Mobile = int.Parse(textBox5.Text); //convert to varchar in db //wait mostfa to change it
            supp.Suppliers_Email = textBox6.Text;
            supp.Suppliers_Website = textBox7.Text;
            db.SaveChanges();
            dataGridView1.DataSource = db.Suppliers.ToList();
            MessageBox.Show("Supplier Updated");

        }
    }
}

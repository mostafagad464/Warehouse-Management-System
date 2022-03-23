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
    public partial class Edit_Product : Form
    {
        int id;
        ProjectEntities db = new ProjectEntities();

        public Edit_Product()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Products.ToList();

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            id =int.Parse( dataGridView1.CurrentRow.Cells[0].Value.ToString());///tarteb el cells kda sah wla 8alat ??
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //var result = db.Products.(id);
            //db.Products.remove(result);
            db.SaveChanges();
            dataGridView1.DataSource = db.Products.ToList();
            MessageBox.Show("Deleted");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var prod = db.Products.SingleOrDefault(x => x.Product_ID == id);
            prod.Product_ID = int.Parse(textBox1.Text);
            prod.Product_Name = textBox2.Text;
            prod.Product_Period = DateTime.Parse(textBox3.Text);
            db.SaveChanges();
            dataGridView1.DataSource = db.Products.ToList();
            MessageBox.Show("Product Updated");
        }
    }
}

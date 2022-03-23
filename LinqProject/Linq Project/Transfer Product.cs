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
    public partial class Transfer_Product : Form
    {
        int id;
        ProjectEntities db = new ProjectEntities();

        public Transfer_Product()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.MoveProducts.ToList();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty | textBox2.Text == string.Empty | textBox3.Text == string.Empty)
            {
                MessageBox.Show("Please Fill Data");
            }
            else
            {
                MoveProduct t = new MoveProduct();
                db.AddToMoveProducts(t);
                db.SaveChanges();
                dataGridView1.DataSource = db.MoveProducts.ToList();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = string.Empty;
                MessageBox.Show("Transfer Added");


            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
          id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
          textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}

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
    public partial class Edit_Store : Form
    {

        ProjectEntities db = new ProjectEntities();
        //String Name;

        public Edit_Store()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Stores.ToList();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var store = db.Stores.SingleOrDefault(x => x.Store_Name==Name);
            store.Store_Name = textBox1.Text;
            store.Store_Addres = textBox2.Text;
            store.Store_Keeper = textBox3.Text;
            db.SaveChanges();
            dataGridView1.DataSource = db.Stores.ToList();
            MessageBox.Show("Store Updated");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
          //  var result = db.Stores.(Name);
            //db.Stores.re(result);
            db.SaveChanges();
            dataGridView1.DataSource = db.Stores.ToList();
            MessageBox.Show("Deleted");
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {   textBox1.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}

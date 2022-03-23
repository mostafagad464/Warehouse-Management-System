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
    public partial class Supplier_Permission : Form
    {
        int id;
        ProjectEntities db = new ProjectEntities();

        public Supplier_Permission()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.SupplyPermissions.ToList();
            dataGridView1.DataSource = db.SupplyPermissionDetails.ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty | textBox2.Text == string.Empty | textBox3.Text == string.Empty)
            {
                MessageBox.Show("Please Fill Supplier Permission Data");
            }
            else
            {
                // supplier Permission

                SupplyPermission s = new SupplyPermission();
                s.ID = int.Parse(textBox1.Text);          //1
                s.Date = DateTime.Parse(textBox4.Text);      //4
                s.Suppliers_ID = int.Parse(textBox2.Text);        //2 
                db.AddToSupplyPermissions(s);
                db.SaveChanges();
                dataGridView1.DataSource = db.SupplyPermissions.ToList();

                //supplier permision details
                SupplyPermissionDetail f = new SupplyPermissionDetail();
                f.ID = int.Parse(textBox1.Text);
                f.Product_ID = int.Parse(textBox3.Text);    //3
                f.Store_Name = textBox5.Text;                  //5
                f.Quantity = textBox6.Text;           //6             //====================
                f.Product_Date = DateTime.Parse(textBox7.Text);
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = string.Empty;
                db.AddToSupplyPermissionDetails(f);
                db.SaveChanges();
                dataGridView1.DataSource = db.SupplyPermissionDetails.ToList();

                MessageBox.Show("Supplier Permission Added");
            }

        }

    }
}

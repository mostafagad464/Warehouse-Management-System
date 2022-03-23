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
    public partial class Client_Permission : Form
    {
        int id;
        ProjectEntities db = new ProjectEntities();

        public Client_Permission()
        {
            
            InitializeComponent();
            dataGridView1.DataSource = db.ClientPermissions.ToList();
            dataGridView1.DataSource = db.ClientPermissionDetails.ToList();


        }

        
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty | textBox2.Text == string.Empty | textBox3.Text == string.Empty)
            {
                MessageBox.Show("Please Fill Client Permission Data");
            }
            else
            {
                //client permission


                ClientPermission t = new ClientPermission();
             t.ID = int.Parse(textBox1.Text);          //1
               t.Date = DateTime.Parse(textBox4.Text);      //4
               t.Client_ID = int.Parse(textBox2.Text);        //2 
                db.ClientPermissions.AddObject(t);
                //db.AddToClientPermissions(t);
                db.SaveChanges();
             dataGridView1.DataSource = db.ClientPermissions.ToList();


                //Client permission details

                ClientPermissionDetail f = new ClientPermissionDetail();
                //f.ID = int.Parse(textBox1.Text);
                //f.Product_ID = int.Parse(textBox3.Text);    //3
                //f.Store_Name = textBox5.Text;                  //5
                //f.Quantity = int.Parse(textBox6.Text);           //6
                //f.Product_Date = DateTime.Parse(textBox7.Text);
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = string.Empty;
                db.ClientPermissionDetails.AddObject(f);
              //db.AddToClientPermissionDetails(f);
                db.SaveChanges();
                dataGridView1.DataSource = db.ClientPermissionDetails.ToList();

                MessageBox.Show("Client Permission Added");


            }

        }

       
       

        private void Button2_Click(object sender, EventArgs e)
        {
            
         // var cliper = db.ClientPermissions.SingleOrDefault(x => x.ID == id);
        //  cliper.ID = int.Parse(textBox1.Text);
        //  cliper.Date= DateTime.Parse(textBox4.Text);
        //  cliper.Client_ID = int.Parse(textBox2.Text);
         // db.SaveChanges();
         // dataGridView1.DataSource = db.ClientPermissions.ToList();

            var cliperdetails = db.ClientPermissionDetails.SingleOrDefault(x => x.ID == id);
      cliperdetails.ID= int.Parse(textBox1.Text);
            cliperdetails.Product_ID= int.Parse(textBox3.Text);
            cliperdetails.Store_Name= textBox5.Text;
            cliperdetails.Quantity= int.Parse(textBox6.Text);
            cliperdetails.Product_Date= DateTime.Parse(textBox7.Text);
            //db.SaveChanges();
            dataGridView1.DataSource = db.ClientPermissionDetails.ToList();

            MessageBox.Show("Client Permission Updated");


        }
    }
}

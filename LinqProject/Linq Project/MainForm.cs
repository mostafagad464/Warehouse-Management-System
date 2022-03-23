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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       

        private void AddStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Store a = new Add_Store();
            a.Show();
        }

        private void AddRoductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Product f = new Add_Product();
            f.Show();
        }

        private void AddClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Add_Client c = new Add_Client();
            c.Show();
        }

        private void AddSupllierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Supllier d = new Add_Supllier();
            d.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Add_Store a = new Add_Store();
            a.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Add_Store a = new Add_Store();
            a.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            Add_Product f = new Add_Product();
            f.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

            Add_Product f = new Add_Product();
            f.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Add_Client c = new Add_Client();
            c.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Add_Client c = new Add_Client();
            c.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Add_Supllier d = new Add_Supllier();
            d.Show();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Add_Supllier d = new Add_Supllier();
            d.Show();
        }

       

        private void EditStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Store z = new Edit_Store();
            z.Show();
        }

        private void EditProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Product y = new Edit_Product();
            y.Show();
        }

        private void EditClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Edit_Client x = new Edit_Client();
            x.Show();
        }

        private void EditSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Supplier f = new Edit_Supplier();
            f.Show();
        }

       

        private void ClentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client_Permission j = new Client_Permission();
            j.Show();
        }

        private void TrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfer_Product v = new Transfer_Product();
            v.Show();
        }

        private void SupplierPermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier_Permission t = new Supplier_Permission();
            t.Show();
        }

        private void ReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Report r = new Report();
            r.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
        }
    }
}

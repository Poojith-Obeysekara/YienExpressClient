
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YienExpressClient
{
    public partial class YienExpressMain : Form
    {
        public static YienExpressMain obj;
        public YienExpressMain()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void packageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PackageDetails package = new PackageDetails();
            package.MdiParent = this;
            package.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOrder uorder = new UpdateOrder();
            uorder.MdiParent = this;
            uorder.Show();
        }

        private void showOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewOrderCustomer vorder = new ViewOrderCustomer();
            vorder.MdiParent = this;
            vorder.Show();
        }

        private void addOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrder aorder = new AddOrder();
            aorder.MdiParent = this;
            aorder.Show();
        }

        private void updateOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void YienEmployee_Load(object sender, EventArgs e)
        {
           SetAccess(false,-1);

            


            foreach (Control ctl in this.Controls)
            {
                try
                {
                    System.Windows.Forms.Control Mdi = (MdiClient)ctl;

                    Mdi.BackColor = System.Drawing.Color.AliceBlue;
                }
                catch (Exception a)
                {
                }
            }
        }

        public void SetAccess(bool access, int type)
        {
            if (type == 0)
            {
                packageToolStripMenuItem.Visible = access;
                orderToolStripMenuItem.Visible = access;
                customerToolStripMenuItem.Visible = access;

            }

            else if (type == 1)
            {
                viewPackagesToolStripMenuItem1.Visible = access;
                addOrdersToolStripMenuItem.Visible = access;
                viewOrdersToolStripMenuItem.Visible = access;

            }

            else if (type == 2)
            {
                viewPackagesToolStripMenuItem1.Visible = access;
                addOrdersToolStripMenuItem.Visible = access;
                viewOrdersToolStripMenuItem.Visible = access;
            }

            else
            {
                packageToolStripMenuItem.Visible = access;
                customerToolStripMenuItem.Visible = access;
                orderToolStripMenuItem.Visible = access;
                viewPackagesToolStripMenuItem1.Visible = access;
                addOrdersToolStripMenuItem.Visible = access;
                viewOrdersToolStripMenuItem.Visible = access;
                obj = this;

            }



        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                YienExpressLogin log = new YienExpressLogin();
                log.ShowDialog();
            }
            catch (Exception x)
            {

            }
            Cursor.Current = Cursors.Default;   
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                YienExpressRegistration reg = new YienExpressRegistration();
                reg.ShowDialog();
            }
            catch (Exception x)
            {

            }
            Cursor.Current = Cursors.Default;
        }

        private void managePackagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewPackagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPackage vpackage = new ViewPackage();
            vpackage.MdiParent = this;
            vpackage.Show();
        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewPackagesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewPackage cvpackage = new ViewPackage();
            cvpackage.MdiParent = this;
            cvpackage.Show();
        }

        private void addOrdersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddOrder corder = new AddOrder();
            corder.MdiParent = this;
            corder.Show();
        }

        private void viewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewOrderCustomer vcorder = new ViewOrderCustomer();
            vcorder.MdiParent = this;
            vcorder.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using Yien Express Courier Services");
            Application.Exit();
        }

        private void welcomeToYienExpressToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void manageNormalCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerDetails customer = new CustomerDetails();
            customer.MdiParent = this;
            customer.Show();
        }

        private void manageCoporateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoporateCustomerDetails scustomer = new CoporateCustomerDetails();
            scustomer.MdiParent = this;
            scustomer.Show();
        }
    }
}

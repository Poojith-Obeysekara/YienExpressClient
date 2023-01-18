using Nancy.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YienExpressClient
{
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string uri = "https://localhost:44323/api/Orders";
                WebClient client = new WebClient();
                client.Headers["content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                Order order = new Order();

                order.packageName = txtPackage.Text;
                order.quantity = Convert.ToInt32(txtQuantity.Text);
                order.customerName = txtCustomer.Text;
                order.customerTel = txtTel.Text;
                order.DateOfOrder = dtpOrderDate.Value.Date.ToString("O");
                order.DateOfDelivery = dtpDeliveryDate.Value.Date.ToString("O");
                order.Description = txtDesc.Text;
                order.deliveryLocation = txtLocation.Text;
                order.trackStatus = cmbTrack.Text;

                String info = (new JavaScriptSerializer().Serialize(order));


                string up = client.UploadString(uri, info);
                MessageBox.Show("Order Placed Successfully, Thank you for using Yien Express");
                txtPackage.Clear();
                txtQuantity.Clear();
                txtCustomer.Clear();
                txtTel.Clear();
                txtDesc.Clear();
                txtLocation.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all the fields accurately");
            }

        }
        public class Order
        {
            public int Id { get; set; }

            public string? packageName { get; set; }

            public int quantity { get; set; }

            public string? customerName { get; set; }

            public string? customerTel { get; set; }
            public String? DateOfOrder { get; set; }


            public String? DateOfDelivery { get; set; }


            public string? Description { get; set; }


            public string? deliveryLocation { get; set; }


            public string? trackStatus { get; set; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }


}

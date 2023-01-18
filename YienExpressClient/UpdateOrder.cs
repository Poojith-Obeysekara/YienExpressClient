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
using System.Xml.Linq;

namespace YienExpressClient
{
    public partial class UpdateOrder : Form
    {
        public UpdateOrder()
        {
            InitializeComponent();
        }



       /* private void UpdateOrder_Load(object sender, EventArgs e)
        {
            string uri = "https://localhost:44323/api/Orders";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            String json = client.DownloadString(uri);
            dgvOrder.DataSource = (new JavaScriptSerializer().Deserialize<List<Order>>(json));
        }*/

        private void LoadData()
        {
            string uri = "https://localhost:44323/api/Orders\r\n";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(uri);
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Order>>(json);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string uri = "https://localhost:44323/api/Orders";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            String json = client.DownloadString(uri);
            dgvOrder.DataSource = (new JavaScriptSerializer().Deserialize<List<Order>>(json));
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            int c = e.ColumnIndex;
            if (c == 0)
            {
                DataGridViewRow row = dgvOrder.Rows[r];
                lblID.Text = row.Cells[1].Value.ToString();
                txtPackage.Text = row.Cells[2].Value.ToString();
                txtQuantity.Text = row.Cells[3].Value.ToString();
                txtCustomer.Text = row.Cells[4].Value.ToString();
                txtTel.Text = row.Cells[5].Value.ToString();
                dtpOrderDate.Text = row.Cells[6].Value.ToString();
                dtpDeliveryDate.Text = row.Cells[7].Value.ToString();
                txtDesc.Text = row.Cells[8].Value.ToString();
                txtLocation.Text = row.Cells[9].Value.ToString();
                txtTrack.Text = row.Cells[10].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string uri = "https://localhost:44323/api/Orders/" + lblID.Text;
            HttpClient client = new HttpClient();

            Order order = new Order();
            order.Id = Convert.ToInt32(lblID.Text);
            order.packageName = txtPackage.Text;
            order.quantity = Convert.ToInt32(txtQuantity.Text);
            order.customerName = txtCustomer.Text;
            order.customerTel = txtTel.Text;
            order.DateOfOrder = dtpOrderDate.Value.Date.ToString("O");
            order.DateOfDelivery = dtpDeliveryDate.Value.Date.ToString("O");
            order.Description = txtDesc.Text;
            order.deliveryLocation = txtLocation.Text;
            order.trackStatus = txtTrack.Text;
            string data = Newtonsoft.Json.JsonConvert.SerializeObject(order);
            var content = new StringContent(data, UnicodeEncoding.UTF8, "application/json");
            var response = client.PutAsync(uri, content);
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
                LoadData();
            else
                MessageBox.Show("Failed to Update");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uri = "https://localhost:44323/api/Orders/" + lblID.Text;
            HttpClient client = new HttpClient();
            var res = client.DeleteAsync(uri);
            res.Wait();
            var result = res.Result;
            if (result.IsSuccessStatusCode)
            {
                LoadData();
            }
            else
                MessageBox.Show("Fail to Delete");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void UpdateOrder_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

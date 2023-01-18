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
using static YienExpressClient.CustomerDetails;

namespace YienExpressClient
{
    public partial class CoporateCustomerDetails : Form
    {
        public CoporateCustomerDetails()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string uri = "https://localhost:44323/api/CoporateCustomers\r\n";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(uri);
            dgvCoporateCustomers.DataSource = null;
            dgvCoporateCustomers.DataSource = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CoporateCustomer>>(json);

        }

        public class CoporateCustomer
        {
            public int ID { get; set; }
            public string? Name { get; set; }
            public string? Address { get; set; }
            public string? Phone { get; set; }

            public string? Email { get; set; }
            public string? specialPlan { get; set; }


        }

        private void CoporateCustomerDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string uri = "https://localhost:44323/api/CoporateCustomers";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            CoporateCustomer coporateCustomer = new CoporateCustomer();
            coporateCustomer.Name = txtName.Text;
            coporateCustomer.Address = txtAddress.Text;
            coporateCustomer.Phone = txtPhone.Text;
            coporateCustomer.Email = txtEmail.Text;
            coporateCustomer.specialPlan = txtPlan.Text;
            string data = Newtonsoft.Json.JsonConvert.SerializeObject(coporateCustomer);
            client.UploadString(uri, data);
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string uri = "https://localhost:44323/api/CoporateCustomers/" + lblID.Text;
            HttpClient client = new HttpClient();

            CoporateCustomer coporateCustomer = new CoporateCustomer();
            coporateCustomer.ID = Convert.ToInt32(lblID.Text);
            coporateCustomer.Name = txtName.Text;
            coporateCustomer.Address = txtAddress.Text;
            coporateCustomer.Phone = txtPhone.Text;
            coporateCustomer.Email = txtEmail.Text;
            coporateCustomer.specialPlan = txtPlan.Text;

            string data = Newtonsoft.Json.JsonConvert.SerializeObject(coporateCustomer);
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
            string uri = "https://localhost:44323/api/CoporateCustomers/" + lblID.Text;
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

        private void dgvCoporateCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            int c = e.ColumnIndex;
            if (c == 0)
            {
                DataGridViewRow row = dgvCoporateCustomers.Rows[r];
                lblID.Text = row.Cells[1].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtPhone.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
                txtPlan.Text = row.Cells[6].Value.ToString();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

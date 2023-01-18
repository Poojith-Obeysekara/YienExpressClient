using System.Net;
using System.Net.Http;
using System.Web;
using System.Text.Json.Serialization;
using System.Text;
using Newtonsoft.Json.Serialization;

namespace YienExpressClient
{
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string uri = "https://localhost:44323/api/Customers\r\n";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(uri);
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Customer>>(json);

        }

        public class Customer
        {
            public int ID { get; set; }
            public string? Name { get; set; }
            public string? Address { get; set; }
            public string? Phone { get; set; }

            public string? Email { get; set; }
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string uri = "https://localhost:44323/api/Customers";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            Customer customer = new Customer();
            customer.Name = txtName.Text;
            customer.Address = txtAddress.Text;
            customer.Phone = txtPhone.Text;
            customer.Email = txtEmail.Text;

            string data = Newtonsoft.Json.JsonConvert.SerializeObject(customer);
            client.UploadString(uri, data);
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string uri = "https://localhost:44323/api/Customers/" + lblID.Text;
            HttpClient client = new HttpClient();

            Customer customer = new Customer();
            customer.ID = Convert.ToInt32(lblID.Text);
            customer.Name = txtName.Text;
            customer.Address = txtAddress.Text;
            customer.Phone = txtPhone.Text;
            customer.Email = txtEmail.Text;

            string data = Newtonsoft.Json.JsonConvert.SerializeObject(customer);
            var content = new StringContent(data, UnicodeEncoding.UTF8, "application/json");
            var response = client.PutAsync(uri, content);
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
                LoadData();
            else
                MessageBox.Show("Failed to Update");
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string uri = "https://localhost:44323/api/Customers/" + lblID.Text;
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

        private void dgvCustomers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            int c = e.ColumnIndex;
            if (c == 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[r];
                lblID.Text = row.Cells[1].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtPhone.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
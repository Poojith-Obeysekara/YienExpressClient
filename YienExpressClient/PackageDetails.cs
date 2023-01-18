using System.Net;
using System.Net.Http;
using System.Web;
using System.Text.Json.Serialization;
using System.Text;
using Newtonsoft.Json.Serialization;

namespace YienExpressClient
{
    public partial class PackageDetails : Form
    {
        public PackageDetails()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string uri = "https://localhost:44323/api/Packages\r\n";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(uri);
            dgvPackages.DataSource = null;
            dgvPackages.DataSource = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Package>>(json);
            
        }

        public class Package
        {
            public int ID { get; set; }
            public string? Name { get; set; }
            public decimal Price { get; set; }
            public int Stock { get; set; }
            public int ReorderLevel { get; set; }
            public string? Category { get; set; }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uri = "https://localhost:44323/api/Packages/"+lblID.Text;
            HttpClient client = new HttpClient();
            
            Package package = new Package();
            package.ID = Convert.ToInt32(lblID.Text);
            package.Name = txtName.Text;
            package.Price = Convert.ToDecimal(txtPrice.Text);
            package.Stock = Convert.ToInt32(txtStock.Text);
            package.ReorderLevel = Convert.ToInt32(txtReorder.Text);
            package.Category=txtCategory.Text;
            //package.Mdate = dtpMdate.Value.Date.ToString("o");
            //package.Edate = dtpEdate.Value.Date.ToString("o");
            string data = Newtonsoft.Json.JsonConvert.SerializeObject(package);
            var content = new StringContent(data, UnicodeEncoding.UTF8,"application/json");
            var response = client.PutAsync(uri, content);
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
                LoadData();
            else
                MessageBox.Show("Failed to Update");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string uri = "https://localhost:44323/api/Packages";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            Package package = new Package();
            package.Name = txtName.Text;
            package.Price = Convert.ToDecimal(txtPrice.Text);
            package.Stock = Convert.ToInt32(txtStock.Text);
            package.ReorderLevel = Convert.ToInt32(txtReorder.Text);
            package.Category = txtCategory.Text;
            //package.Mdate = dtpMdate.Value.Date.ToString("o");
            //package.Edate = dtpEdate.Value.Date.ToString("o");
            string data = Newtonsoft.Json.JsonConvert.SerializeObject(package);
            client.UploadString(uri, data);
            LoadData();
        }

        private void dgvPackages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            int c = e.ColumnIndex;
            if(c == 0)
            {
                DataGridViewRow row = dgvPackages.Rows[r];
                lblID.Text = row.Cells[1].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();
                txtStock.Text = row.Cells[4].Value.ToString();
                txtReorder.Text = row.Cells[5].Value.ToString();
                txtCategory.Text = row.Cells[6].Value.ToString();
                //dtpMdate.Text = row.Cells[6].Value.ToString();
                //dtpEdate.Text = row.Cells[7].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uri = "https://localhost:44323/api/Packages/" + lblID.Text;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YienExpressClient
{
    public partial class ViewPackage : Form
    {
        public ViewPackage()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string uri = "https://localhost:44323/api/Packages";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            String json = client.DownloadString(uri);
            dgvPackage.DataSource = (new JavaScriptSerializer().Deserialize<List<Package>>(json));

        }
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadData();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}

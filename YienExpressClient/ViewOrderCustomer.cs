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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YienExpressClient
{
    public partial class ViewOrderCustomer : Form
    {
        public ViewOrderCustomer()
        {
            InitializeComponent();
        }

        private void LoadData() 
        {
            string uri = "https://localhost:44323/api/Orders?OrderId" + txtOrderID.Text; ;
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            String json = client.DownloadString(uri);
            dgvOrder.DataSource = (new JavaScriptSerializer().Deserialize<List<Order>>(json));

        }

        private void ViewOrderCustomer_Load(object sender, EventArgs e)
        {

            LoadData(); 
            

        }
        private void btnView_Click(object sender, EventArgs e)
        {

            LoadData();

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

        private void btnBack_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvOrder.DataSource];
            currencyManager.SuspendBinding();
            this.dgvOrder.ClearSelection();
            foreach (DataGridViewRow r in this.dgvOrder.Rows)
            {
                if (r.Cells[0].Value != null)
                {
                    if ((r.Cells[0].Value).ToString().StartsWith(this.txtOrderID.Text.Trim()))
                    {
                        this.dgvOrder.Rows[r.Index].Visible = true;
                    }
                    else
                    {
                        dgvOrder.Rows[r.Index].Visible = false;
                    }
                }
                currencyManager.ResumeBinding();
            }
        }

        private void ViewOrderCustomer_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

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
    public partial class YienExpressRegistration : Form
    {
        public YienExpressRegistration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string uri = "https://localhost:44323/api/Users";
                WebClient client = new WebClient();
                client.Headers["content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                User user = new User();

                user.userType = cmbType.Text;
                user.userName = txtName.Text;
                user.Password = txtPass.Text;
                user.cPassword = txtcPass.Text;


                String info = (new JavaScriptSerializer().Serialize(user));


                

                if (txtPass.Text == txtcPass.Text)
                {
                    string up = client.UploadString(uri, info);
                    MessageBox.Show("User Registered Successfully, Login via the main menu to use Yien Express Courier Services");
                    txtName.Clear();
                    txtPass.Clear();
                    txtcPass.Clear();

                }
                else
                {
                    MessageBox.Show("Passwords don't match. Please try again !");
                    txtName.Clear();
                    txtPass.Clear();
                    txtcPass.Clear();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public class User
        {
            public int Id { get; set; }

            public string? userType { get; set; }

            public string? userName { get; set; }

            public string? Password { get; set; }
            public string? cPassword { get; set; }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void YienExpressRegistration_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

        }
    }
}

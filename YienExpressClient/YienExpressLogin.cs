using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YienExpressClient
{
    public partial class YienExpressLogin : Form
    {

        public YienExpressLogin()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.ComboBox.ObjectCollection Employee { get; private set; }
        public System.Windows.Forms.ComboBox.ObjectCollection Coporate_Customer { get; private set; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=POOJITH; Initial Catalog = YienDB; TrustServerCertificate=True;Persist Security Info=True;Integrated Security = True");   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM users WHERE userType='" + cmbType.Text + "'AND userName='" + txtName.Text + "' AND Password='" + txtPassword.Text + "'", con);
            
            DataTable dt = new DataTable();  
            sda.Fill(dt);
            int type = -1;   
            if (dt.Rows[0][0].ToString() == "1")
            {
                if(cmbType.Text == "Employee")
                    type = 0;   

                else if(cmbType.Items == Coporate_Customer)

                    type = 1;


                else
                {
                    type = 2;
                }


                ((YienExpressMain)(Application.OpenForms["YienExpressMain"])).SetAccess(true,type);
                this.Close();

                
            }
            else
                MessageBox.Show("Invalid user type or username or password");
        }

        private void YienExpressLogin_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}

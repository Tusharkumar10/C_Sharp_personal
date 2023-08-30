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
using System.Data.SqlClient;

namespace DatabaseWork
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = 10.0.0.13; Database= mcadotnet; uid=student; pwd=mca@123");
            con.Open();
            string str = "Select * from users_tushar where id='"+ txtuid.Text+"' and password='"+ txtpwd.Text+"'";
            SqlDataAdapter ada = new SqlDataAdapter(str, con);
            DataTable dta = new DataTable();
            ada.Fill(dta);
            con.Close();
            if(dta.Rows.Count>0)
            {
                //Form2 f2 = new Form2();
                //f2.Show();
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}

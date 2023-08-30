using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace DatabaseWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtquery_Click(object sender, EventArgs e) //Execute query button
        {
            SqlConnection con = new SqlConnection("Data Source = 10.0.0.13; Database = mcadotnet; uid = student; pwd = mca@123");
            con.Open();
            // MessageBox.Show("Connection is ready");
            string str = txtboxquery.Text;//"Create table tushar_std(rollno varchar(20),name varchar(50),father varchar(50),state varchar(50),gender varchar(1))";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Done");
        }

       private void saveData()
        {
            if (checkExistance() == false)
            {
                if (txtrollno.Text == "" || txtfname.Name == "" || txtname.Name == "")
                {
                    MessageBox.Show("Please fill all the entries.");

                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source = 10.0.0.13; Database= mcadotnet; uid=student; pwd=mca@123");
                    con.Open();

                    string gender = "M";
                    if (rbtnmale.Checked == true)
                        gender = "M";
                    else
                        gender = "F";

                    string str = " insert into tushar_std(rollno, name, father, state, gender)values('" + txtrollno.Text + "', '" + txtname.Text + "','" + txtfname.Text + "', '" + combostate.SelectedItem.ToString() + "', '" + gender + "')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data saved");
                    txtname.Text = "";
                    txtfname.Text = "";
                    txtrollno.Text = "";
                    fetchAllData();
                }
            }
            else
                MessageBox.Show("Sorry,Student already exist.");
        }

        private void updateData()
        {
            if (txtrollno.Text == "" || txtfname.Name == "" || txtname.Name == "")
            {
                MessageBox.Show("Please fill all the entries.");

            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source = 10.0.0.13; Database= mcadotnet; uid=student; pwd=mca@123");
                con.Open();

                string gender = "M";
                if (rbtnmale.Checked == true)
                    gender = "M";
                else
                    gender = "F";     //(rollno, name, , state, gender)values(

                string str = " update tushar_std set name='" + txtname.Text + "',father='"+txtfname.Text + "', state='" + combostate.SelectedItem.ToString() + "',gender= '" + gender + "' where rollno='"+txtrollno.Text +"'";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
                txtname.Text = "";
                txtfname.Text = "";
                txtrollno.Text = "";
                txtrollno.Enabled = true;
                btnsave.Text = "Save";
                fetchAllData();
            }
        }
        private void btnsave_Click(object sender, EventArgs e) //Save button
        {
            if (btnsave.Text == "Save")
                saveData();
            if (btnsave.Text == "Update")
                updateData();
            btndelete.Visible = false;


        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = 10.0.0.13; Database= mcadotnet; uid=student; pwd=mca@123");
            con.Open();
            string str = txtboxquery.Text;
            SqlDataAdapter ada = new SqlDataAdapter(str,con);
            DataTable dta = new DataTable();
            ada.Fill(dta);
            con.Close();
            dataGridView1.DataSource = dta;

        }

       
        private bool checkExistance()
        {

            SqlConnection con = new SqlConnection("Data Source = 10.0.0.13; Database= mcadotnet; uid=student; pwd=mca@123");
            con.Open();
            string str = "Select * from tushar_std where rollno='"+ txtrollno.Text+"'";
            SqlDataAdapter ada = new SqlDataAdapter(str, con);
            DataTable dta = new DataTable();
            ada.Fill(dta);
            con.Close();
            if (dta.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private void fetchAllData()
        {
            SqlConnection con = new SqlConnection("Data Source = 10.0.0.13; Database= mcadotnet; uid=student; pwd=mca@123");
            con.Open();
            string str = "Select * from tushar_std order by rollno";
            SqlDataAdapter ada = new SqlDataAdapter(str, con);
            DataTable dta = new DataTable();
            ada.Fill(dta);
            con.Close();
            listView1.Items.Clear();
            if (dta.Rows.Count > 0)
            {
                for (int i = 0; i < dta.Rows.Count; i++)
                {
                    ListViewItem li = new ListViewItem(dta.Rows[i].ItemArray[0].ToString());
                    li.SubItems.Add(dta.Rows[i].ItemArray[1].ToString());
                    li.SubItems.Add(dta.Rows[i].ItemArray[2].ToString());
                    li.SubItems.Add(dta.Rows[i].ItemArray[4].ToString());
                    li.SubItems.Add(dta.Rows[i].ItemArray[3].ToString());
                    listView1.Items.Add(li);
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
                fetchAllData();
            txtrollno.Enabled = true;
            btnsave.Text = "Save";
            btndelete.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combostate.SelectedIndex = 0;
            fetchAllData();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtrollno.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtname.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtfname.Text = listView1.SelectedItems[0].SubItems[2].Text;
            if (listView1.SelectedItems[0].SubItems[4].Text == "M")
            {
                rbtnmale.Checked =true;
            }
            else
            { rbtnfemale.Checked = true; }
            combostate.SelectedItem = listView1.SelectedItems[0].SubItems[4].Text;
            txtrollno.Enabled = false;
            btnsave.Text = "Update";
            btndelete.Visible = true;

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtrollno_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtboxquery_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Are you sure to delete the selected data?","Confirmatio",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source = 10.0.0.13; Database= mcadotnet; uid=student; pwd=mca@123");
                con.Open();

                string str = " delete from tushar_std where  rollno='" + txtrollno.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
                txtname.Text = "";
                txtfname.Text = "";
                txtrollno.Text = "";
                txtrollno.Enabled = true;
                btnsave.Text = "Save";
                btndelete.Visible = false;
                fetchAllData();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (btnoption.Text == ">>")
            {
                this.Size = new System.Drawing.Size(454, 529);
                btnoption.Text = "<<";
            }
            else
            {

                this.Size = new System.Drawing.Size(454, 374);
                btnoption.Text = ">>";
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
    }
 //"Create table tushar_std(rollno varchar(20),name varchar(50),father varchar(50),state varchar(50),gender varchar(1))";
// insert into tushar_std(rollno,name,father,state,gender)values('1','T','S','UP','M')

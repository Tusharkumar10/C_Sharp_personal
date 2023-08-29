using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gr1.Checked = true;
            n1.Checked = true;
            output.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gr1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void n1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string gen ;
            if(gr1.Checked==true)
            {
                gen = "S/O ";
            }
            else
            {
                gen = "D/O ";
            }

            string nat;
            if(n1.Checked==true)
            {
                nat = " You are an Indian";
            }
            else
            {
                nat = " You have other country Citizenship";
            }

            string hob=" ";
            if(ch1.Checked==true && ch2.Checked == true)
            {
                hob = "hobbies are: " + ch1.Text + "," + ch2.Text + ".";

            }
            else if (ch2.Checked == true)
            {
                hob = "hobby is: " + ch2.Text;
            }
            else
            {
                hob = "hobby is: " + ch1.Text;
                
            }
            output.Visible = true;
            string data = "Hello " + nametxt.Text + " " + gen + "Mr."+fnametxt.Text + " " + "R/O "+citytxt.Text + ","+nat+"\n and your " +hob;
            output.Text = data;

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cname = TextBox1.Text + " you have selected";
            if (CheckBox1.Checked)
            {
                cname += CheckBox1.Text + ",";
            }
            if (CheckBox2.Checked)
            {
                cname += CheckBox2.Text + ",";
            }
            if (CheckBox3.Checked)
            {
                cname += CheckBox3.Text + ",";
            }
            if (CheckBox4.Checked)
            {
                cname += CheckBox4.Text + ",";
            }
            Label3.Text = cname;
            if(CheckBox1.Checked==false && CheckBox2.Checked==false && CheckBox3.Checked==false && CheckBox4.Checked==false )
            {
                Label3.Text = TextBox1.Text+" Please select one course";
            }

        }
    }
}
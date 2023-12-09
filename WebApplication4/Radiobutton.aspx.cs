using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
                Label3.Text = TextBox1.Text + " you are " + RadioButton1.Text;
            else if (RadioButton2.Checked)
                Label3.Text = TextBox1.Text + " you are " + RadioButton2.Text;
            else
                Label3.Text = TextBox1.Text + " please select your gender";

        }
    }
}
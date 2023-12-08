using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int val1, val2,sum;
            val1=Convert.ToInt32(TextBox1.Text);
            val2=Convert.ToInt32(TextBox2.Text);
            sum=val1 + val2;
            Label3.Text = "sum is "+sum;
        }
    }
}
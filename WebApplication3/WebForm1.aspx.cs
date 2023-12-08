using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name, pass;
            name=TextBox1.Text;
            pass=TextBox2.Text;
            if(name=="Saiteja" && pass == "12345")
            {
                Label3.Text = "Welcome " + name;
                TextBox1.Text=string.Empty;
                TextBox1.Focus();
            }
            else
            {
                Label3.Text="Invalid input";
                TextBox2.Text=string.Empty;
                TextBox1.Text=string.Empty;
                TextBox2.Text=string.Empty;
                TextBox1.Focus();
            }
        }
    }
}
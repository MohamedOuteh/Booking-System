using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ContactUsPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        //return to home page
        Response.Redirect("LotusHome.aspx");
    }

    protected void btnService_Click(object sender, EventArgs e)
    {
        //go to service page
        Response.Redirect("ServicePage.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //redirect to sign up page
        Response.Redirect("SignupPage.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //redirect to log in page
        Response.Redirect("LoginPage.aspx");
    }
}
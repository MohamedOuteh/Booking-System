using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ServicePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        //redirect to home page
        Response.Redirect("LotusHome.aspx");
    }

    protected void btnContact_Click(object sender, EventArgs e)
    {
        //go to contact page
        Response.Redirect("ContactUsPage.aspx");
    }

    protected void btnSignup_Click(object sender, EventArgs e)
    {
        //redirect to sign up page
        Response.Redirect("SignupPage.aspx");
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //redirect to log in page
        Response.Redirect("LoginPage.aspx");
    }
}
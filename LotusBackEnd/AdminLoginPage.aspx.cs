using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class AdminLoginPage : System.Web.UI.Page
{
    //create scope 
    clsSecurity Sec;

    protected void Page_Load(object sender, EventArgs e)
    {
        //session object for the class
        Sec = (clsSecurity)Session["Sec"];
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create instance of the class
        clsSecurity Sec = new clsSecurity();
        //var to store the data entered
        string AdminUsername = txtUsername.Text;
        string AdminPassword = txtPassword.Text;
        //var to store error and function
        lblError.Text = Sec.AdminSignIn(txtUsername.Text, txtPassword.Text);
        //if everything is ok
        if(lblError.Text == "")
        {
            //redirect to account page
            Response.Redirect("AdminAccountPage.aspx");
        }
        else
        {
            //display error
            lblError.Text = lblError.Text;
        }
        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //return to home page
        Response.Redirect("AdminHomePage.aspx");
    }

    protected void btnForgotPassword_Click(object sender, EventArgs e)
    {
        //redirect to change password
        Response.Redirect("ChangePasswordPage.aspx");
    }
}
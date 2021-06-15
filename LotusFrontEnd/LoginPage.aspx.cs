using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class LoginPage : System.Web.UI.Page
{
    clsSecurity Sec;
    protected void Page_Load(object sender, EventArgs e)
    {
        Sec = (clsSecurity)Session["Sec"];
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create instance of the class
        clsSecurity Sec = new clsSecurity();
        //var to store the data entered
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        //var to store the error and function
        lblError.Text = Sec.SignIn(txtUsername.Text, txtPassword.Text);
        //if there is no error
        if(lblError.Text == "")
        {
            //go to account page
            Response.Redirect("AccountPage.aspx");
        }
        else
        {
            //sho the error
            lblError.Text = lblError.Text;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //return to home page
        Response.Redirect("LotusHome.aspx");
    }

    protected void btnForgotPassword_Click(object sender, EventArgs e)
    {
        //go to forgot password page
        Response.Redirect("ForgotPassword.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //go to sign up page
        Response.Redirect("SignupPage.aspx");
    }
}
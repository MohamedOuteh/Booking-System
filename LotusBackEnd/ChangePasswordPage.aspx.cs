using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class ChangePasswordPage : System.Web.UI.Page
{
    //private security class instance
    private clsSecurity mSec;

    //public security class
    public clsSecurity Sec
    {
        get
        {
            return mSec;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        mSec = new clsSecurity();
    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        //var to store the data entered
        string Username = txtUsername.Text;
        string Password1 = txtPassword.Text;
        string Password2 = txtConfirmPassword.Text;
        string Secret = txtSecretPassword.Text;

        //change the password and confirm the outcome
        lblError.Text = Sec.AdminChangePassword(Username, Password1, Password2, Secret);
        //if there is an error
        if(lblError.Text=="")
        {
            //redirect to account page
            Response.Redirect("AdminAccountPage.aspx");
        }
        else //if there is an error
        {
            lblError.Text = lblError.Text;
        }
        Session["Sec"] = Sec;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to account page
        Response.Redirect("AdminAccountPage.aspx");
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //return to account page
        Response.Redirect("AdminAccountPage.aspx");
    }
}
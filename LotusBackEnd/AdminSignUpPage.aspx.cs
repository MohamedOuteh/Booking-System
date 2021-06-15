using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class AdminSignUpPage : System.Web.UI.Page
{
    //var to store primary key
    Int32 AdminID;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the admin to be processed
        AdminID = Convert.ToInt32(Session["AdminID"]);
        if(IsPostBack == false)
        {

        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //return to the admin page
        Response.Redirect("AdminViewAdmin.aspx");
    }

    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        //create instance of the class
        clsSecurity Sec = new clsSecurity();
        //var to sotre the data entered
        string AdminFirstName = txtFirstName.Text;
        string AdminLastName = txtLastName.Text;
        string AdminPhoneNo = txtPhoneNo.Text;
        string AdminUsername = txtUsername.Text;
        string AdminPassword = txtPassword.Text;
        string PasswordConfirm = txtPasswordConfirm.Text;
        string Secret = txtSecret.Text;
        //var to store the error and function
        lblError.Text = Sec.AdminSignUp(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword, PasswordConfirm, Secret);
        //if username is not taken 
        if (Sec.AdminUsernameTaken(txtUsername.Text) == false)
        {
            //if there are no errors
            if(lblError.Text=="")
            {
                //redirect to success page
                Response.Redirect("SignUpSuccess.aspx");
            }
            else
            {
                //return error
                lblError.Text = lblError.Text;
            }
        }
        else//if username is taken
        {
            //return error
            lblError.Text = lblError.Text;
        }
    }
}
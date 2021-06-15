using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class SignupPage : System.Web.UI.Page
{
    //variable to store the primary key
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //return to home page
        Response.Redirect("AdminViewCustomers.aspx");
    }

    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        //create instance of the class
        clsSecurity Sec = new clsSecurity();
        //store the variables that hold the data
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string EmailAddress = txtEmailAddress.Text;
        string PhoneNo = txtPhoneNo.Text;
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        string PasswordConfirm = txtPasswordConfirm.Text;
        string Secret = txtSecret.Text;
        //add the variable for the function
        lblError.Text = Sec.SignUp(FirstName, LastName, EmailAddress, PhoneNo, Username, Password, PasswordConfirm, Secret);
        //if the username is not taken
        if(Sec.UsernameTaken(txtUsername.Text)==true)
        {
            //if there is no error
            if (lblError.Text == "")
            {
                //redirect to the view customer page
                Response.Redirect("AdminViewCustomers.aspx");
            }
            else
            {
                //show error
                lblError.Text = lblError.Text + "<br />";
            }
        }
        else//if username is taken
        {
            //show error
            lblError.Text = lblError.Text + "<br />";
        }
        Session["Sec"] = Sec;

    }
}
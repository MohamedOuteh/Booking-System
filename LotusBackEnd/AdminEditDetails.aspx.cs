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
            //populate the list of admins
            DisplayAdmin();
            //if this is not a new record
            if(AdminID !=-1)
            {
                //display the current data
                DisplayAdmin();
            }
        }

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //update record
        Update();
    }

    //function for updating
    void Update()
    {
        //create an instance of the class
        clsAdminCollection AdminBook = new clsAdminCollection();
        //validare the data on the web form
        String Error = AdminBook.ThisAdmin.ValidAdmin(txtFirstName.Text, txtLastName.Text, txtPhoneNo.Text, txtUsername.Text);
        //if the data is OK then add it to the object
        if(Error == "")
        {
            //find the record to update
            AdminBook.ThisAdmin.Find(AdminID);
            //get the data entered by the user
            AdminBook.ThisAdmin.AdminFirstName = txtFirstName.Text;
            AdminBook.ThisAdmin.AdminLastName = txtLastName.Text;
            AdminBook.ThisAdmin.AdminPhoneNo = Convert.ToInt64(txtPhoneNo.Text);
            AdminBook.ThisAdmin.AdminUsername = txtUsername.Text;
            //update the record
            AdminBook.Update();
            //return to the admin page
            Response.Redirect("AdminViewAdmin.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayAdmin()
    {
        //create instance of the class
        clsAdminCollection AdminBook = new clsAdminCollection();
        //find the record to update
        AdminBook.ThisAdmin.Find(AdminID);
        //diplay the data for this record
        txtFirstName.Text = AdminBook.ThisAdmin.AdminFirstName;
        txtLastName.Text = AdminBook.ThisAdmin.AdminLastName;
        txtPhoneNo.Text = AdminBook.ThisAdmin.AdminPhoneNo.ToString();
        txtUsername.Text = AdminBook.ThisAdmin.AdminUsername;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //return to the admin page
        Response.Redirect("AdminViewAdmin.aspx");
    }
}
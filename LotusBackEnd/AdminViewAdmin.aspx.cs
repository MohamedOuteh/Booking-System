using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class AdminViewAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time displaying the page
        if (IsPostBack == false)
        {
            //update the list box
            DisplayAdmin();
        }
    }

    void DisplayAdmin()
    {
        //create instance of the collection
        clsAdminCollection Admins = new clsAdminCollection();
        //set the data source to list the admin in the box
        lstAdmin.DataSource = Admins.AdminList;
        //set the name of the primary key
        lstAdmin.DataValueField = "AdminID";
        //set the data feild to display
        lstAdmin.DataTextField = "AdminUsername";
        //bind the data to the list
        lstAdmin.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate it's a new record
        Session["AdminID"] = -1;
        //redirect to the sign up page
        Response.Redirect("AdminSignUpPage.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key
        Int32 AdminID;
        //if a record has been selected
        if(lstAdmin.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            AdminID = Convert.ToInt32(lstAdmin.SelectedValue);
            //store the data in the session object
            Session["AdminID"] = AdminID;
            //redirect to the edit page
            Response.Redirect("AdminEditDetails.aspx");
        }
        else //if no record has been selected
        {
            //display error message
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key to be deleted
        Int32 AdminID;
        //if a record has been selected from the list
        if(lstAdmin.SelectedIndex !=-1)
        {
            //get the primary key value to delete
            AdminID = Convert.ToInt32(lstAdmin.SelectedValue);
            //store the data in the session object
            Session["AdminID"] = AdminID;
            //redirect to the delete page
            Response.Redirect("AdminDeletePage.aspx");
        }
        else //if no record has been selected
        {
            //display error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    Int32 DsiplayAdmin(string AdminFilter)
    {
        Int32 AdminID;
        string AdminUserName;
        string AdminFirstname;
        string AdminLastname;
        //create instance of the collection class
        clsAdminCollection AdminUsername = new clsAdminCollection();
        //invoke username filter
        AdminUsername.ReportByAdminUsername(AdminFilter);
        //var to store the count of records
        Int32 RecordCount;
        //var to store the index of the loop
        Int32 Index = 0;
        //get the count of records
        RecordCount = AdminUsername.Count;
        //clear the list box
        lstAdmin.Items.Clear();
        //while there are records to process
        while(Index < RecordCount)
        {
            //get the primary key
            AdminID = AdminUsername.AdminList[Index].AdminID;
            //get the admin details
            AdminUserName = AdminUsername.AdminList[Index].AdminUsername;
            AdminFirstname = AdminUsername.AdminList[Index].AdminFirstName;
            AdminLastname = AdminUsername.AdminList[Index].AdminLastName;
            //create new entry for list box
            ListItem NewEntry = new ListItem(AdminUserName + "| " + AdminFirstname + AdminLastname, AdminID.ToString());
            //add the username to list
            lstAdmin.Items.Add(NewEntry);
            //move the index to the next record
            Index++;
        }
        return RecordCount;
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //declar var to store the record count
        Int32 RecordCount;
        RecordCount = DsiplayAdmin(txtUsernameFilter.Text);
        lblError.Text = RecordCount + "Record Found";
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //display admins
        DisplayAdmin();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //return to account page
        Response.Redirect("AdminAccountPage.aspx");
    }

    protected void btnViewCustomer_Click(object sender, EventArgs e)
    {
        //go to customers
        Response.Redirect("AdminCustomers.aspx");
    }

    protected void btnViewBooking_Click(object sender, EventArgs e)
    {
        //go to bookings
        Response.Redirect("AdminViewBookings.aspx");
    }

    protected void btnViewHaircuts_Click(object sender, EventArgs e)
    {
        //go to haircuts
        Response.Redirect("AdminViewHaircuts.aspx");
    }
}
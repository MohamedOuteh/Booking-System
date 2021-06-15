using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class AdminViewCustomers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ////if this is the first time displaying the page
        //if(IsPostBack == false)
        //{
        //    //update the list box
        //    DisplayCustomers();
        //}
    }

    //void DisplayCustomers()
    //{
    //    //create instance of customer collection
    //    clsCustomerCollection Customers = new clsCustomerCollection();
    //    //set the data source to list the customer in the box
    //    lstCustomer.DataSource = Customers.CustomerList;
    //    //set the name of primary key
    //    lstCustomer.DataValueField = "CustomerID";
    //    //set the data field to display
    //    lstCustomer.DataTextField = "UserName";
    //    //bind the data to the list
    //    lstCustomer.DataBind();
    //}




    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key
        Int32 CustomerID;
        //if a record has been selected from the list
        if(lstCustomer.SelectedIndex != -1)
        {
            //get the primary key from the record to edit
            CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("EditAccount.aspx");
        }
        else
        {
            {
                //display an error msg
                lblError.Text = "Please select a record from the list to edit";
            }
        }
    }

    Int32 DisplayUsername(string UsernameFilter)
    {
        Int32 CustomerID;
        string CustomerUserName;
        string CustomerFirstName;
        string CustomerLastName;
        //create instance of the customer collection class
        clsCustomerCollection CustomerUsername = new clsCustomerCollection();
        //invoke username filter
        CustomerUsername.ReportByUsername(UsernameFilter);
        //var to store the count of records
        Int32 RecordCount;
        //var to store the index of the loop
        Int32 Index = 0;
        //get the count of records
        RecordCount = CustomerUsername.Count;
        //clear the list box
        lstCustomer.Items.Clear();
        //while there are records to process
        while(Index < RecordCount)
        {
            //get the primary key
            CustomerID = CustomerUsername.CustomerList[Index].CustomerID;
            //get the customer details
            CustomerUserName = CustomerUsername.CustomerList[Index].UserName;
            CustomerFirstName = CustomerUsername.CustomerList[Index].FirstName;
            CustomerLastName = CustomerUsername.CustomerList[Index].LastName;
            //create new entry for the list box
            ListItem NewEntry = new ListItem(CustomerUserName + "| " + CustomerFirstName + " "+ CustomerLastName, CustomerID.ToString());
            //add the username to list
            lstCustomer.Items.Add(NewEntry);
            //move the index to the next record
            Index++;
        }
        return RecordCount;
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //declare var to store record count
        Int32 RecordCount;
        //var to store string
        string Username = txtUsernameFilter.Text;
        //if text is empty
        if(Username=="")
        {
            lblError.Text = "Please enter your username";
        }
        else
        {

            RecordCount = DisplayUsername(txtUsernameFilter.Text);
            lblError.Text = RecordCount + " Record Found";
        }


    }



    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //return to account page
        Response.Redirect("AccountPage.aspx");
    }

    protected void btnMakeBooking_Click(object sender, EventArgs e)
    {
        //go to booking page
        Response.Redirect("BookingView.aspx");
    }

    protected void btnEditAccount_Click(object sender, EventArgs e)
    {
        //return to find account page
        Response.Redirect("FindAccount.aspx");
    }

    protected void btnDeleteAccount_Click(object sender, EventArgs e)
    {
        //go to delete account
        Response.Redirect("FindAccountDelete.aspx");
    }
}
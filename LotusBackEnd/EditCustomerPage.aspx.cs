using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class EditCustomerPage : System.Web.UI.Page
{
    //variable to store the primary key
    Int32 CustomerID;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if(IsPostBack == false)
        {
            //populate list of customer
            DisplayCustomer();
            //populate the list of customer
            if(CustomerID !=-1)
            {
                //display current record
                DisplayCustomer();
            }

        }
    }



    //function for updating record
    void Update()
    {
        //create instance of the customer
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //validare the data on the web form
        String Error = CustomerBook.ThisCustomer.ValidUpdate(txtFirstName.Text, txtLastName.Text, txtEmailAddress.Text, txtPhoneNo.Text, txtUsername.Text);
        //if the data is ok then add it to project
        if (Error == "")
        {
            //find the record to update
            CustomerBook.ThisCustomer.Find(CustomerID);
            //get the data entered by user
            CustomerBook.ThisCustomer.FirstName = txtFirstName.Text;
            CustomerBook.ThisCustomer.LastName = txtLastName.Text;
            CustomerBook.ThisCustomer.EmailAddress = txtEmailAddress.Text;
            CustomerBook.ThisCustomer.PhoneNo = Convert.ToInt64(txtPhoneNo.Text);
            CustomerBook.ThisCustomer.UserName = txtUsername.Text;
            //add the record
            CustomerBook.Update();
            //return to the viewer page
            Response.Redirect("AdminViewCustomers.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data you entered :" + Error;
        }
    }

    void DisplayCustomer()
    {
        //create instance of the customers
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerID);
        //display data for this record
        txtFirstName.Text = CustomerBook.ThisCustomer.FirstName;
        txtLastName.Text = CustomerBook.ThisCustomer.LastName;
        txtEmailAddress.Text = CustomerBook.ThisCustomer.EmailAddress;
        txtPhoneNo.Text = CustomerBook.ThisCustomer.PhoneNo.ToString();
        txtUsername.Text = CustomerBook.ThisCustomer.UserName;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
       //update the record
       Update();
        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminViewCustomers.aspx");
    }
}
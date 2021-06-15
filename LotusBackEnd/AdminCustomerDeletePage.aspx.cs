using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class AdminCustomerDeletePage : System.Web.UI.Page
{
    //var to store the primary key
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    public void DeleteCustomer()
    {
        //function to delete the selected record
        //create a new instance of the class
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to delete
        CustomerBook.ThisCustomer.Find(CustomerID);
        //delete the record
        CustomerBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteCustomer();
        //redirect back to the main page
        Response.Redirect("AdminViewCustomers.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //return to the view customer page
        Response.Redirect("AdminViewCustomers.aspx");
    }
}
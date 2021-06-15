using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class AdminDeletePage : System.Web.UI.Page
{
    //var to sotre the primary key
    Int32 AdminID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the admin id from session object
        AdminID = Convert.ToInt32(Session["AdminID"]);
    }

    void DeleteAdmin()
    {
        //function to delete the selected record
        //create a new instance of the class
        clsAdminCollection AdminBook = new clsAdminCollection();
        //find the record to delete
        AdminBook.ThisAdmin.Find(AdminID);
        //delete the record
        AdminBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete record
        DeleteAdmin();
        //redirect to the account page
        Response.Redirect("AdminViewAdmin.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to the account page
        Response.Redirect("AdminViewAdmin.aspx");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAccountPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnViewCustomers_Click(object sender, EventArgs e)
    {
        //redirect to the view customer
        Response.Redirect("AdminViewCustomers.aspx");
    }

    protected void btnViewHaricuts_Click(object sender, EventArgs e)
    {
        //redirect to the haircut page
        Response.Redirect("AdminViewHaircuts.aspx");
    }

    protected void btnViewAdmins_Click(object sender, EventArgs e)
    {
        //redirect to view admin page
        Response.Redirect("AdminViewAdmin.aspx");
    }

    protected void btnAddHaircut_Click(object sender, EventArgs e)
    {
        //store -1 into the session oject to indicate this is a new record
        Session["HaircutID"] = -1;
        //redirect to the add haircut page
        Response.Redirect("AddHaircut.aspx");
    }

    protected void btnMakeBooking_Click(object sender, EventArgs e)
    {
        //redirect to booking page
        Response.Redirect("AdminViewBookings.aspx");
    }

    protected void btnEditDelete_Click(object sender, EventArgs e)
    {
        //redirect to booking page
        Response.Redirect("AdminFindBooking.aspx");
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        //redirect to booking page
        Response.Redirect("AdminHomePage.aspx");
    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        //redirect to add customer page
        Response.Redirect("AdminAddCustomer.aspx");
    }

    protected void btnChangePassword_Click(object sender, EventArgs e)
    {
        //redirect to change password page
        Response.Redirect("ChangePasswordPage.aspx");
    }
}
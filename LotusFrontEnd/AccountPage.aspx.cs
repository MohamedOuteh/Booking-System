using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AccountPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnBookHaircut_Click(object sender, EventArgs e)
    {
        Response.Redirect("BookingView.aspx");
    }

    protected void btnEditDelete_Click(object sender, EventArgs e)
    {
        Response.Redirect("FindBooking.aspx");
    }

    protected void btnEditAccount_Click(object sender, EventArgs e)
    {
        Response.Redirect("FindAccount.aspx");
    }

    protected void btnChangePassword_Click(object sender, EventArgs e)
    {
        Response.Redirect("ChangePasswordPage.aspx");
    }

    protected void btnDeleteAccount_Click(object sender, EventArgs e)
    {
        Response.Redirect("FindAccountDelete.aspx");
    }

    protected void btnSignOut_Click(object sender, EventArgs e)
    {
        Response.Redirect("LotusHome.aspx");
    }
}
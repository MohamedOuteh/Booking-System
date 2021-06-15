using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class SignUpSuccess : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAccount_Click(object sender, EventArgs e)
    {
        //return to account page
        Response.Redirect("AdminAccountPage.aspx");
    }
}
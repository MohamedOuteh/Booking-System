using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class AdminHaircutDelete : System.Web.UI.Page
{
    //var to store the primary
    Int32 HaircutID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the haircut from the session object
        HaircutID = Convert.ToInt32(Session["HaircutID"]);
    }

     void DeleteHaircut()
    {
        //function to delete the selected record
        //create a new instance of the class
        clsHaircutCollection HaircutBook = new clsHaircutCollection();
        //find the recprd to delete
        HaircutBook.ThisHaircut.Find(HaircutID);
        //delete the record
        HaircutBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteHaircut();
        //redicr to the main page
        Response.Redirect("AdminViewHaircuts.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("AdminViewHaircuts.aspx");
    }
}
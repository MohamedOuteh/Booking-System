using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class AdminViewHaircuts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time displaying the page
        if(IsPostBack == false)
        {
            //update the list box
            DisplayHaircuts();
        }
    }

    void DisplayHaircuts()
    {
        //create instance of the class
        clsHaircutCollection Haircuts = new clsHaircutCollection();
        //set the data source to list the haircuts in the box
        lstHaircuts.DataSource = Haircuts.HaircutList;
        //set the name of the primary key
        lstHaircuts.DataValueField = "HaircutID";
        //set the feild to display
        lstHaircuts.DataTextField = "HaircutName";
        //bind the data to the list
        lstHaircuts.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session oject to indicate this is a new record
        Session["HaircutID"] =-1;
        //redirect to the add haircut page
        Response.Redirect("AddHaircut.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to edit
        Int32 HaircutID;
        //if a record has been selected
        if(lstHaircuts.SelectedIndex != -1)
        {
            //get the primary key value from the list
            HaircutID = Convert.ToInt32(lstHaircuts.SelectedValue);
            //store the data in the session object
            Session["HaircutID"] = HaircutID;
            //redirect to the edit page
            Response.Redirect("AddHaircut.aspx");
        }
        else//if no record has been selected
        {
            //display error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //var to store record count
        Int32 RecordCount;
        RecordCount = DisplayHaircutName(txtHaircutFilter.Text);
        lblError.Text = RecordCount + " Record Found";
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //display all haircuts
        DisplayHaircuts();
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of record to be deleted
        Int32 HaircutID;
        //if a record has been selected from the list
        if(lstHaircuts.SelectedIndex !=-1)
        {
            //get the primary key to record to delete
            HaircutID = Convert.ToInt32(lstHaircuts.SelectedValue);
            //store the data in the session object
            Session["HaircutID"] = HaircutID;
            //redirect to the delete page
            Response.Redirect("AdminHaircutDelete.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    Int32 DisplayHaircutName (string HaircutFilter)
    {
        Int32 HaircutID;
        string HaircutName;
        double HaircutPrice;
        //create an instance of haircut collection
        clsHaircutCollection Haircutname = new clsHaircutCollection();
        //invoke haircut filter
        Haircutname.ReportByHaircutName(HaircutFilter);
        //var to store the count of records
        Int32 RecordCount;
        //var to store the index loop
        Int32 Index = 0;
        //get the count of records
        RecordCount = Haircutname.Count;
        //clear the list box
        lstHaircuts.Items.Clear();
        //while there are records to process
        while(Index < RecordCount)
        {
            //get the PK
            HaircutID = Haircutname.HaircutList[Index].HaircutID;
            //get the haircut name
            HaircutName = Haircutname.HaircutList[Index].HaircutName;
            HaircutPrice = Haircutname.HaircutList[Index].HaircutPrice;
            //create new entry for the list box
            ListItem NewEntry = new ListItem(HaircutName + " " + HaircutPrice + ".00", HaircutID.ToString());
            //add the haircut onto the list
            lstHaircuts.Items.Add(NewEntry);
            //move the index to the next record
            Index++;
        }
        return RecordCount;
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //return to account page
        Response.Redirect("AdminAccountPage.aspx");
    }

    protected void btnViewCustomer_Click(object sender, EventArgs e)
    {
        //go to customers
        Response.Redirect("AdminViewCustomers.aspx");
    }

    protected void btnViewBooking_Click(object sender, EventArgs e)
    {
        //go to bookings
        Response.Redirect("AdminViewBookings.aspx");
    }

    protected void btnViewAdmins_Click(object sender, EventArgs e)
    {
        //go to admins
        Response.Redirect("AdminViewAdmin.aspx");
    }
}
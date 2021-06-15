using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class AdminViewBookings : System.Web.UI.Page
{
    //create instance of the booking collection with page level scope
    clsBookingCollection Books;

    protected void Page_Load(object sender, EventArgs e)
    {
        txtDate.Text = Convert.ToString(DateTime.Today);
        ////if this is the first time it is displayed
        //if (IsPostBack == false)
        //{
        //    //initialise the list of bookings for a specific date
        //    Books = new clsBookingCollection(Convert.ToDateTime(txtDate.Text));
        //    //display the booking
        //    DisplayBook();
        //}
        //else //if this is a re-load page
        //{
        //    //read in the already initialised list
        //    Books = (clsBookingCollection)Session["Books"];
        //}
    }

    protected void Page_Unload(object sender, EventArgs e)
    {
        ////store the booking list
        //Session["Books"] = Books;
    }



    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store PK
        Int32 BookingID;
        string BookingTime;
        string BookingDate;
        //string Username;
        //string HaircutName;
        //if a record has been selected
        if (lstBooking.SelectedIndex !=-1)
        {
            //read in primary key
            BookingTime = lstBooking.SelectedValue;
            //get the booking date
            BookingDate = txtDate.Text;
            //Username = lstBooking.SelectedValue;
            //HaircutName = lstBooking.SelectedValue;
            //get the pk from the list to edit
            BookingID = Convert.ToInt32(lstBooking.SelectedValue);
            //store the data in the session object
            Session["BookingID"] = BookingID;
            Session["BookingDate"] = BookingDate;
            Session["BookingTime"] = BookingTime;
            //redirect to the booking page
            Response.Redirect("AdminEditBooking.aspx?BookingDate=" + BookingDate + "&BookingTime=" + BookingTime /*+ Username + HaircutName*/);
        }
        else
        {
            //show error
            lblError.Text = "You must select a booking to edit!";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store pk
        Int32 BookingID;
        DateTime BookingDate;
        //if a record has been selected
        if(lstBooking.SelectedIndex !=-1)
        {
            //get the pk to delete
            BookingID = Convert.ToInt32(lstBooking.SelectedValue);
            BookingDate = Convert.ToDateTime(txtDate.Text);
            //store the data in the session object
            Session["BookingID"] = BookingID;
            Session["BookingDate"] = BookingDate;
            //redirect to the delete page
            Response.Redirect("AdminBookingDelete.aspx");
        }
        else
        {
            //display error 
            lblError.Text = "Please select a booking from the list to delete!";
        }

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //store the record count
        Int32 RecordCount;
        //if there is a username
        RecordCount = DisplayUsername(txtUsername.Text);
        //show how many records there are
        lblError.Text = RecordCount + " Record Found";
    }

    Int32 DisplayUsername(string UsernameFilter)
    {
        Int32 BookingID;
        string Username;
        DateTime BookingDate;
        int BookingTime;
        //create instance of the class
        clsBookingCollection BookingUsername = new clsBookingCollection(Convert.ToDateTime(txtDate.Text));
        //invoke the filter
        BookingUsername.ReportByUsername(UsernameFilter);
        //var to store the count of records
        Int32 RecordCount;
        //var to store the index of the loop
        Int32 Index = 0;
        //get the count of records
        RecordCount = BookingUsername.Count;
        //clear the box
        lstBooking.Items.Clear();
        //while there are records to process
        while (Index < RecordCount) 
        {
            //get the id
            BookingID = BookingUsername.Book[Index].BookingID;
            //get the details
            Username = BookingUsername.Book[Index].Username;
            BookingDate = BookingUsername.Book[Index].BookingDate;
            BookingTime = BookingUsername.Book[Index].BookingTime;
            //create new entry for the list box
            ListItem NewEntry = new ListItem(Username + "|" + BookingDate + "|" + BookingTime + ":00", BookingID.ToString());
            //add the username to the list
            lstBooking.Items.Add(NewEntry);
            //move the index to next record
            Index++;
        }
        return RecordCount;
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //return to account page
        Response.Redirect("AdminAccountPage.aspx");
    }
}
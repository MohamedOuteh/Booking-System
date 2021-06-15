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
        //txtDate.Text = Convert.ToString("07/04/2021");
        //if this is the first time it is displayed
        if (IsPostBack == false)
        {
            //initialise the list of bookings for a specific date
            Books = new clsBookingCollection(Convert.ToDateTime(txtDate.Text));
            //display the booking
            DisplayBook();
        }
        else //if this is a re-load page
        {
            //read in the already initialised list
            Books = (clsBookingCollection)Session["Books"];
        }
    }

    protected void Page_Unload(object sender, EventArgs e)
    {
        //store the booking list
        Session["Books"] = Books;
    }

    protected void btnGo_Click(object sender, EventArgs e)
    {
        //re-initialise the list of booking with the new date
        Books = new clsBookingCollection(Convert.ToDateTime(txtDate.Text));
        String Error = Books.ThisBooking.ValidDate(txtDate.Text);
        if(Error=="")
        {
            //display the list of booking
            DisplayBook();
        }
        else
        {
            lblError.Text = "There were problems with the date " + "</br >" + Error;
        }
    }

    protected void btnBook_Click(object sender, EventArgs e)
    {
        
        Session["BookingID"] = -1;
        //var to store the vairables
        string BookingTime;
        string BookingDate;
        //clear previous error
        //check to see if an entry has been selected
        if(lstBooking.SelectedIndex != -1)
        {
            //read in primary key
            BookingTime = lstBooking.SelectedValue;
            //get the booking date
            BookingDate = txtDate.Text;
            //if this booking is availabe
            if (BookingTime.Contains("-") == true)
            {
                //redirect to the booking page
                Response.Redirect("BookingPage.aspx?BookingDate=" + BookingDate + "&BookingTime=" + BookingTime);
            }
            else//otherwise cannot change the booking
            {
                lblError.Text = "This time has been booked";
            }
        }
        else
        {
            //show error
            lblError.Text = "You must select a booking first";
        }
    }

    void DisplayBook()
    {
        //var to store booking id if an exisitng appointment it is the primary key
        //if it is an available book it is the time 
        Int32 BookingID;
        //var to store variables
        Int32 BookingTime;
        string Username;
        //index for the loop
        Int32 Index = 0;
        //clear the list of any entries
        lstBooking.Items.Clear();
        //loop for processing the books
        while(Index < Books.Count)
        {
            //get the booking id
            BookingID = Books.Book[Index].BookingID;
            //get the variables
            BookingTime = Books.Book[Index].BookingTime;
            Username = Books.Book[Index].Username;
            //create the booking entry
            ListItem NewItem = new ListItem("Booking Time " + BookingTime.ToString() +":00" + " |" + Username , BookingID.ToString());
            //add booking to list
            lstBooking.Items.Add(NewItem);
            //increase the index
            Index++;
        }
    }





    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //return to account page
        Response.Redirect("AccountPage.aspx");
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
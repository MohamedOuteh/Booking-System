using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class AdminEditBooking : System.Web.UI.Page
{
    Int32 BookingID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //var to store the date and time
        string BookingDate;
        int BookingTime;
        //get the date and time from query string
        BookingDate = Request.QueryString["BookingDate"];
        BookingTime = Convert.ToInt32(Request.QueryString["BookingTime"]);
        //display the date
        txtBookingDate.Text = BookingDate;
        //display the time removing the - character
        //txtBookingTime.Text = BookingTime.Remove(0, 1);
        //txtBookingDate.Text = BookingDate.Remove(0, 1);
        //get booking id
        BookingID = Convert.ToInt32(Session["BookingID"]);
        if (IsPostBack != true)
        {
 
            DisplayHaircut();
            if (BookingID != -1)
            {
                if(IsPostBack != true)
                {
                    DisplayBookings(BookingID);
                }
         
            }
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //update booking
        Update();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("FindBooking.aspx");
    }

    void DisplayBooking()
    {
        //get the date
        DateTime BookingDate = Convert.ToDateTime(txtBookingDate.Text);
        //create instance of the class
        clsBookingCollection Booking = new clsBookingCollection(BookingDate);
        //find the record
        Booking.ThisBooking.Find(BookingID);
        //display data for this record
        txtBookingDate.Text = Booking.ThisBooking.BookingDate.ToString();
        txtBookingTime.Text = Booking.ThisBooking.BookingTime.ToString();
        txtUsername.Text = Booking.ThisBooking.Username;
        ddlHaircutName.Text = Booking.ThisBooking.HaircutName;
    }

    void DisplayBookings(Int32 BookingID)
    {
        //creat instance of the class
        clsBooking Booking = new clsBooking();
        //find the booking
        Booking.Find(BookingID);
        //var to store the data retrieved
        txtBookingDate.Text = Convert.ToString(Booking.BookingDate);
        txtBookingTime.Text = Convert.ToString(Booking.BookingTime);
        txtUsername.Text = Booking.Username;
        ddlHaircutName.SelectedValue = Convert.ToString(Booking.HaircutName);
    }

    void Update()
    {
        //create instance of the class
        clsBooking ThisBooking = new clsBooking();
        clsBookingCollection Booking = new clsBookingCollection(Convert.ToDateTime(txtBookingDate.Text));
        clsSecurity Sec = new clsSecurity();
        //var to store data entered
        DateTime BookingDate = Convert.ToDateTime(txtBookingDate.Text);
        string BookingTime = txtBookingTime.Text;

        //store the valid function
        lblError.Text = ThisBooking.Valid(txtBookingDate.Text, txtBookingTime.Text, txtUsername.Text, ddlHaircutName.SelectedValue.ToString());
        //if a booking has not been found
        if (Booking.BookingFound(BookingDate, BookingTime) == false)
        {
            //if everything is ok
            if (lblError.Text == "")
            {
                Booking.ThisBooking.Find(BookingID);
                Booking.ThisBooking.BookingDate = Convert.ToDateTime(txtBookingDate.Text);
                Booking.ThisBooking.BookingTime = Convert.ToInt32(txtBookingTime.Text);
                Booking.ThisBooking.Username = txtUsername.Text;
                Booking.ThisBooking.HaircutName = Convert.ToString(ddlHaircutName.SelectedValue);
                Booking.Update();
                Response.Redirect("EditSuccess.aspx");
            }
            else //if there is an error
            {
                lblError.Text = lblError.Text;
            }
        }
        else
        {
            lblError.Text = "The booking has been taken";
        }

    }


    //display the drop down list for haircuts name
    Int32 DisplayHaircut()
    {
        //create instance of the class
        clsHaircutCollection Haircuts = new clsHaircutCollection();
        //var to store primary key
        string HaircutID;
        //var to store the hairuct name
        string HaircutName;
        //var to store the index for the loop
        Int32 Index = 0;
        //while index is less than the no of records
        while (Index < Haircuts.Count)
        {
            //get the id from database
            HaircutID = Convert.ToString(Haircuts.HaircutList[Index].HaircutID);
            //get the name from the database
            HaircutName = Haircuts.HaircutList[Index].HaircutName;
            //set up the new row to be added to the list
            ListItem NewHaircut = new ListItem(HaircutName, HaircutID);
            //add the new row to the list
            ddlHaircutName.Items.Add(NewHaircut);
            //increment the index to the next record
            Index++;
        }
        return Haircuts.Count;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class AdminBookingDelete : System.Web.UI.Page
{
    //var to store pk
    Int32 BookingID;
    DateTime BookingDate;

    protected void Page_Load(object sender, EventArgs e)
    {
        BookingID = Convert.ToInt32(Session["BookingID"]);
        BookingDate = Convert.ToDateTime(Session["BookingDate"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete record
        DeleteBooking();
        //redirect to view page
        Response.Redirect("AdminViewBookings.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to viewer page
        Response.Redirect("AdminViewBookings.aspx");
    }

    public void DeleteBooking()
    {
        //create instance of the class
        clsBookingCollection Booking = new clsBookingCollection(BookingDate);
        //find the record to delete
        Booking.ThisBooking.Find(BookingID);
        //delete record
        Booking.Delete();
    }
}
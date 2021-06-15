using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class AdminBookingPage : System.Web.UI.Page
{
    Int32 BookingID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //var to store the date and time
        string BookingDate;
        string BookingTime;
        //get the date and time from query string
        BookingDate = Request.QueryString["BookingDate"];
        BookingTime = Request.QueryString["BookingTime"];
        //display the date
        txtBookingDate.Text = BookingDate;
        //display the time removing the - character
        txtBookingTime.Text = BookingTime.Remove(0, 1);
        //display haircut
        DisplayHaircut();
    }

    protected void btnBook_Click(object sender, EventArgs e)
    {
        //get the time of the booking
        int BookingTime = Convert.ToInt32(txtBookingTime.Text);
        //get the date
        DateTime BookingDate = Convert.ToDateTime(txtBookingDate.Text);
        //get the username
        string Username = Convert.ToString(txtUsername.Text);
        //get the haircut name
        string HaircutName = Convert.ToString(ddlHaircutName.SelectedValue.ToString());
        //create an instance of the class
        clsBookingCollection Books = new clsBookingCollection(BookingDate);
        //add the new booking
        Books.Add(BookingTime, Username, HaircutName);
        //redirect to the view booking page
        Response.Redirect("AdminViewBookings.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("AdminViewBookings.aspx");
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
        while(Index < Haircuts.Count)
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotusClasses;

public partial class AddHaircut : System.Web.UI.Page
{
    //variable to store the primary key
    Int32 HaircutID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the haircut to be processed
        HaircutID = Convert.ToInt32(Session["HaircutID"]);
        if(IsPostBack == false)
        {
            //populate the list of haircut
            DisplayHaircut();
            //populate list of haircut
            if(HaircutID != -1)
            {
                //display current record
                DisplayHaircut();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if(HaircutID == -1)
        {
           //add the new record
           Add();
        }
        else
        {
            //update the record
            Update();
        }
        
    }

    //function for adding record
    void Add()
    {
        //create instance of the class for the haircut
        clsHaircutCollection HaircutBook = new clsHaircutCollection();
        //validate the data on the web form
        String Error = HaircutBook.ThisHaircut.Valid(txtHaircutName.Text, Convert.ToDouble(txtHaircutPrice.Text));
        //if the datais OK then add it to the project
        if (Error == "")
        {
            //get the data entered by the user
            HaircutBook.ThisHaircut.HaircutName = txtHaircutName.Text;
            HaircutBook.ThisHaircut.HaircutPrice = Convert.ToDouble(txtHaircutPrice.Text);
            //add the record
            HaircutBook.Add();
            //redirect to the main page
            Response.Redirect("AdminViewHaircuts.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + "<br />" + Error;
        }
    }

    //function for updating record
    void Update()
    {
        //create instance of the class
        clsHaircutCollection HaircutBook = new clsHaircutCollection();
        //validate the data on the web form
        String Error = HaircutBook.ThisHaircut.Valid(txtHaircutName.Text, Convert.ToDouble(txtHaircutPrice.Text));
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            HaircutBook.ThisHaircut.Find(HaircutID);
            //get the data entered
            HaircutBook.ThisHaircut.HaircutName = txtHaircutName.Text;
            HaircutBook.ThisHaircut.HaircutPrice = Convert.ToDouble(txtHaircutPrice.Text);
            //update the record
            HaircutBook.Update();
            //redirect to the main page
            Response.Redirect("AdminViewHaircuts.aspx");
        }
        else
        {
            //report error
            lblError.Text = "There were problems with the data enetered" + "<br />" + Error;
        }
    }

    void DisplayHaircut()
    {
        //create instance of the customer
        clsHaircutCollection HaircutBook = new clsHaircutCollection();
        //find the record to update
        HaircutBook.ThisHaircut.Find(HaircutID);
        //display data for this record
        txtHaircutName.Text = HaircutBook.ThisHaircut.HaircutName;
        txtHaircutPrice.Text = HaircutBook.ThisHaircut.HaircutPrice.ToString();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("AdminViewHaircuts.aspx");
    }
}
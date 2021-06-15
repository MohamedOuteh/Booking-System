using System;

namespace LotusClasses
{
    public class clsHaircut
    {
        //private data members
        private Int32 mHaircutID;
        private string mHaircutName; 
        private double mHaircutPrice; 

        //public property for Haircut id
        public Int32 HaircutID
        {
            get
            {
                //return the private data
                return mHaircutID;
            }
            set
            {
                //set the private data
                mHaircutID = value;
            }
        }

        //public property for haircut name
        public string HaircutName
        {
            get
            {
                //return private data
                return mHaircutName;
            }
            set
            {
                //set the private data
                mHaircutName = value;
            }
        }

        //public property for haircut price
        public double HaircutPrice
        {
            get
            {
                //return the private data
                return mHaircutPrice;
            }
            set
            {
                //set the private data
                mHaircutPrice = value;
            }
        }

        public string Valid(string haircutname, double haircutprice)
        {
            //create a string variable to store the error
            String Error = "";

            //HAIRCUT NAME VALIDATION//////////////////////
            if (haircutname.Length == 0 | haircutname.Length <5)
            //if haircut name is blank
            {
                //record the error
                Error = Error + "The Haircut Name may not be blank and have more than 4 characters" + "<br />";
            }
            //if haircut name is greater than 24 character
            if (haircutname.Length > 24)
            {
                //record error
                Error = Error + "The Haircut Name must be less than 24 characters" + "<br />";
            }

            //HAIRCUT NAME VALIDATION//////////////////////

            //HAIRCUT PRICE VALIDATION/////////////////////
            if (haircutprice == 0)
            //if haircut price is blank
            {
                //record error
                Error = Error + "The Haircut Price must not be blank" + "<br />";
            }

            if (haircutprice > 100)
            //if haircut price is blank
            {
                //record error
                Error = Error + "The Haircut Price must be less than 5 digits" + "<br />";
            }

            //HAIRCUT PRICE VALIDATION/////////////////////
            //return Error
            return Error;
        }

        public bool Find(int HaircutID)
        {
            //create an instance of the data class
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the cusotmer id to search for
            DB.AddParameter("@HaircutID", HaircutID);
            //execute the stored procedure 
            DB.Execute("sproc_tblHaircut_FilterByHaircutID");
            //if record is found
            if(DB.Count ==1)
            {
                //copy data from the database to the private data member
                mHaircutID = Convert.ToInt32(DB.DataTable.Rows[0]["HaircutID"]);
                mHaircutName = Convert.ToString(DB.DataTable.Rows[0]["HaircutName"]);
                mHaircutPrice = Convert.ToDouble(DB.DataTable.Rows[0]["HaircutPrice"]);
                //return that everything is ok
                return true;
            }
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}
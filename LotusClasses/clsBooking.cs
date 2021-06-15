using System;

namespace LotusClasses
{
    public class clsBooking
    {
        //private data members
        private Int32 mBookingID;
        private DateTime mBookingDate;
        private int mBookingTime;
        private string mUsername;
        private string mHaircutName;

        //public property for booking id 
        public Int32 BookingID
        {
            get
            {
                //return private data members
                return mBookingID;
            }
            set
            {
                //set private data
                mBookingID = value;
            }
        }

        //public property for booking data
        public DateTime BookingDate
        {
            get
            {
                return mBookingDate;
            }
            set
            {
                mBookingDate = value;
            }
        }

        //public property for booking time
        public int BookingTime
        {
            get
            {
                return mBookingTime;
            }
            set
            {
                mBookingTime = value;
            }
        }

        //public property for username
        public string Username
        {
            get
            {
                return mUsername;
            }
            set
            {
                mUsername = value;
            }
        }

        //public property for haircut name
        public string HaircutName
        {
            get
            {
                return mHaircutName;
            }
            set
            {
                mHaircutName = value;
            }
        }

        public bool Find(int BookingID)
        {
            //create instance of the class
            clsDataConnection DB = new clsDataConnection();
            //add parameter for booking id
            DB.AddParameter("@BookingID", BookingID);
            //execute stored procedure
            DB.Execute("sproc_tblBooking_FilterByBookingID");
            //if record is found
            if (DB.Count == 1)
            {
                //copy the data from database to the private data member
                mBookingID = Convert.ToInt32(DB.DataTable.Rows[0]["BookingID"]);
                mBookingDate = Convert.ToDateTime(DB.DataTable.Rows[0]["BookingDate"]);
                mBookingTime = Convert.ToInt32(DB.DataTable.Rows[0]["BookingTime"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mHaircutName = Convert.ToString(DB.DataTable.Rows[0]["HaircutName"]);
                //return that its ok
                return true;
            }
            else
            {
                //return false
                return false;
            }
        }

        public string Valid(string BookingDate, string BookingTime, string Username, string HaircutName)
        {
            String Error = "";
            //Booking Date Validation///////////////////////////
            try
            {
                DateTime Temp;
                Temp = Convert.ToDateTime(BookingDate);

                if (Temp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past: " + "<br />";
                }

                if (Temp > DateTime.Today.AddMonths(6))
                {
                    Error = Error + "The date cannot be in the future: " + "<br />";
                }
            }
            catch
            {
                Error = Error + "The date is not in the correct format" + "<br />";
            }
            //Booking Date Validation///////////////////////////

            //Booking Time Validation///////////////////////////
           if(BookingDate.Length < 0)
            {
                Error = Error + "Booking Date must not be blank" + "<br />";
            }


            //Booking Time Validation///////////////////////////


            //Username Validation///////////////////////////////


            //Username Validation///////////////////////////////


            //Haircut Validation///////////////////////////////


            //Haircut Validation///////////////////////////////

            return Error;
        }

        private int HasBooking(int bookingTime)
        {
            clsDataConnection DB = new clsDataConnection();
            String Error = "";
            //index for the loop
            Int32 Index = 0;
            //Boolean var to indicate if an entry is found
            Boolean Found = false;
            //loop through any record for this data from the database
            while (Index < DB.Count & Found == false)
            {
                //if a record is found
                if (bookingTime == Convert.ToUInt32(DB.DataTable.Rows[Index]["BookingTime"]))
                {
                    //set the found to true and make the loop end
                    Found = true;
                    Error = Error + "This Time has been taken" + "<br />";
                }
                else
                {
                    ////otherwise keep on searching to the end
                    //Index++;
                }
            }
            if (Found)//if a record is found
            {
                return Index;//return the index of the entry 0 or above
            }
            else
            {
                return -1;//return -1 indicating it was not found
            }
        }

        public string ValidDate(string BookingDate)
        {
            String Error = "";
            try
            {
                DateTime Temp;
                Temp = Convert.ToDateTime(BookingDate);

                if (Temp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past: " + "<br />";
                }

                if (Temp > DateTime.Today.AddMonths(6))
                {
                    Error = Error + "The date cannot be in the future: " + "<br />";
                }
            }
            catch
            {
                Error = Error + "The date is not in the correct format" + "<br />";
            }
            return Error;
        }

 
    }
}
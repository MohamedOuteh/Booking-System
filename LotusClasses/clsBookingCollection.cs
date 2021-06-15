using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusClasses
{
    public class clsBookingCollection
    {
        //private data member for booking date
        private DateTime mBookDate;
        //data connection with class level scope
        clsDataConnection DB = new clsDataConnection();
        //private data member for list of booking 
        private List<clsBooking> mBooks = new List<clsBooking>();
        clsBooking mThisBooking = new clsBooking();

        //constructor for the class
        public clsBookingCollection(DateTime ADate)
        {
            //get booing data
            FilterByDate(ADate);
            //remember date used
            mBookDate = ADate;
            //object for data connection
            //clsDataConnection DB = new clsDataConnection();
            ////execute stored procedure
            //DB.Execute("sproc_tblBooking_SelectAll");
            ////populate the array list with the data table
            //PopulateArray(DB);
        }

        public List<clsBooking> Book
        {
            get
            {
                return mBooks;
            }
            set
            {
                mBooks = value;
            }
        }

        public clsBooking ThisBooking
        {
            get
            {
                return mThisBooking;
            }
            set
            {
                mThisBooking = value;
            }
        }

        private void FilterByDate(DateTime BookingDate)
            //filters data in the table based on the date inquestion
        {
            //reinitialise the data connection
            DB = new clsDataConnection();
            //add parameter for the data
            DB.AddParameter("@BookingDate", BookingDate);
            //execute stored procedure
            DB.Execute("sproc_tblBooking_FilterByDate");
            //get the schedule for this date
            mBooks = GetSchedule();
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate array list based on the table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array
            mBooks = new List<clsBooking>();
            //while there are records to process
            while(Index < RecordCount)
            {
                //create blank booking
                clsBooking ABooking = new clsBooking();
                //read in feilds for the current record
                ABooking.BookingID = Convert.ToInt32(DB.DataTable.Rows[Index]["BookingID"]);
                ABooking.BookingDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["BookingDate"]);
                ABooking.BookingTime = Convert.ToInt32(DB.DataTable.Rows[Index]["BookingTime"]);
                ABooking.Username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                ABooking.HaircutName = Convert.ToString(DB.DataTable.Rows[Index]["HaircutName"]);
                mBooks.Add(ABooking);
                //point at the next record
                Index++;
            }
        }

        private List<clsBooking> GetSchedule()
        {
            //list of booking for this function
            List<clsBooking> mAvailableBooks = new List<clsBooking>();
            //loop throught the times of day
            for(Int32 SomeTime=9; SomeTime <17; SomeTime++)
            {
                //check to see if this time is booked
                Int32 Index = HasBooking(SomeTime);
                //if the returned entry is <0 then it doesn't
                if(Index < 0)
                {
                    //create a blank slot
                    clsBooking NewBook = new clsBooking();
                    //record the primary key as -time
                    NewBook.BookingID = -SomeTime;
                    //store the date using private data member
                    NewBook.BookingDate = mBookDate;
                    //record the time
                    NewBook.BookingTime = SomeTime;
                    //set the username to blank
                    NewBook.Username = "";
                    //set the haircut name to blank
                    NewBook.HaircutName = "";
                    //add it to the list
                    mAvailableBooks.Add(NewBook);
                }
                else //if it has a booking
                {
                    //create a new blank booking
                    clsBooking NewBook = new clsBooking();
                    //record the var from the db
                    NewBook.BookingID = Convert.ToInt32(DB.DataTable.Rows[Index]["BookingID"]);
                    NewBook.BookingDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["BookingDate"]);
                    NewBook.BookingTime = Convert.ToInt32(DB.DataTable.Rows[Index]["BookingTime"]);
                    NewBook.Username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                    NewBook.HaircutName = Convert.ToString(DB.DataTable.Rows[Index]["HaircutName"]);
                    //add it to the list
                    mAvailableBooks.Add(NewBook);
                }
            }
            return mAvailableBooks;
        }

        private Int32 HasBooking(Int32 SomeTime)
        {
            //index for the loop
            Int32 Index = 0;
            //Boolean var to indicate if an entry is found
            Boolean Found = false;
            //loop through any record for this data from the database
            while(Index <DB.Count&Found == false)
            {
                //if a record is found
                if(SomeTime == Convert.ToInt32(DB.DataTable.Rows[Index]["BookingTime"]))
                {
                    //set the found to true and make the loop end
                    Found = true;
                }
                else
                {
                    //otherwise keep on searching to the end
                    Index++;
                }
            }
            if(Found)//if a record is found
            {
                return Index;//return the index of the entry 0 or above
            }
            else
            {
                return -1;//return -1 indicating it was not found
            }
        }

        //returns the count of booking
        public Int32 Count
        {
            get
            {
                return mBooks.Count;
            }
        }

        public void Add(Int32 BookingTime, string Username, string HaircutName)
        {
            //reinitialse data connection
            DB = new clsDataConnection();
            //send the procedure the parameter
            DB.AddParameter("@BookingDate", mBookDate);
            DB.AddParameter("@BookingTime", BookingTime);
            DB.AddParameter("@Username", Username);
            DB.AddParameter("@HaircutName", HaircutName);
            //execute stored procedure
            DB.Execute("sproc_tblBooking_Insert");
        }

        public void Update()
        {
            //initialse data connection
            DB = new clsDataConnection();
            //send the procedure the parameter
            DB.AddParameter("@BookingID", mThisBooking.BookingID);
            DB.AddParameter("@BookingDate", mBookDate);
            DB.AddParameter("@BookingTime", mThisBooking.BookingTime);
            DB.AddParameter("@Username", mThisBooking.Username);
            DB.AddParameter("@HaircutName", mThisBooking.HaircutName);
            //execute stored procedure
            DB.Execute("sproc_tblBooking_Update");
        }

        public void Delete()
        {
            //initialse data connection
            DB = new clsDataConnection();
            //send the procedure the parameter
            DB.AddParameter("@BookingID", mThisBooking.BookingID);
            //execute stored procedure
            DB.Execute("sproc_tblBooking_Delete");
        }

        public void ReportByUsername(string Username)
        {
            //filter records based on a full or partial code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the username parameter to the database
            DB.AddParameter("@Username", Username);
            //execute the stored procedure
            DB.Execute("sproc_tblBooking_FilterByUsername");
            //populate the array
            PopulateArray(DB);
        }

        public Boolean BookingFound(DateTime BookingDate, string BookingTime)
        {
            //test to see if a booking is found
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookingDate", BookingDate);
            DB.AddParameter("@BookingTime", BookingTime);
            //DB.AddParameter("@Username", Username);
            //execute stored procedure
            DB.Execute("sproc_tblBooking_SelectAll");
            //if a record is found
            if(DB.Count == 2)
            {
                //return true
                return true;
            }
            else
            {
                //return false
                return false;
            }
        }

    }
}

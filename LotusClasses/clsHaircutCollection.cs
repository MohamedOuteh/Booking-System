using System;
using System.Collections.Generic;
using LotusClasses;


namespace LotusClasses
{
    public class clsHaircutCollection
    {
        List<clsHaircut> mHaircutList = new List<clsHaircut>();
        clsHaircut mThisHaircut = new clsHaircut();


        //public property for haircut list
        public List<clsHaircut> HaircutList
        {
            get
            {
                //return to private data
                return mHaircutList;
            }
            set
            {
                //set the private data
                mHaircutList = value;
            }
        }

        //public property for ThisHaircut
        public clsHaircut ThisHaircut
        {
            get
            {
                //return the private
                return mThisHaircut;
            }
            set
            {
                //set the private data
                mThisHaircut = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mHaircutList.Count;

            }
            set
            {
                //we shall worry about this later
            }
        }

        public List<clsHaircut> AllHaircuts
        {
            get
            {
                //create connection to database
                clsDataConnection DB = new clsDataConnection();
                //create an instance of a list 
                List<clsHaircut> mAllHaircuts = new List<clsHaircut>();
                //var to store index loop
                Int32 Index = 0;
                //while the index is less than the number to process
                while (Index < DB.Count)
                {
                    //set up the new entry
                    clsHaircut NewHaircut = new clsHaircut();
                    //get id from database
                    NewHaircut.HaircutID = Convert.ToInt32(DB.DataTable.Rows[Index]["HaircutID"]);
                    //get the haircut name
                    NewHaircut.HaircutName = Convert.ToString(DB.DataTable.Rows[Index]["HaircutName"]);
                    //add the new entry to the list
                    mAllHaircuts.Add(NewHaircut);
                    //index to next record
                    Index++;
                }
                //return the query results to database
                return mAllHaircuts;
            }
        }

        //constructor for the class
        public clsHaircutCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure 
            DB.Execute("sproc_tblHaircut_SelectAll");
            //populate array
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count
            RecordCount = DB.Count;
            //clear the private array list
            mHaircutList = new List<clsHaircut>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank haircut
                clsHaircut AHaircut = new clsHaircut();
                //read in fields for the current record
                AHaircut.HaircutID = Convert.ToInt32(DB.DataTable.Rows[Index]["HaircutID"]);
                AHaircut.HaircutName = Convert.ToString(DB.DataTable.Rows[Index]["HaircutName"]);
                AHaircut.HaircutPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["HaircutPrice"]);
                //add the record to the private data member
                mHaircutList.Add(AHaircut);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisHaircut
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter
            DB.AddParameter("@HaircutName", mThisHaircut.HaircutName);
            DB.AddParameter("@HaircutPrice", mThisHaircut.HaircutPrice);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblHaircut_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters of the stored procedure
            DB.AddParameter("@HaircutID", mThisHaircut.HaircutID);
            //execute stored procedure
            DB.Execute("sproc_tblHaircut_Delete");
        }

        public void Update()
        {
            //update existing record
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@HaircutID", mThisHaircut.HaircutID);
            DB.AddParameter("@HaircutName", mThisHaircut.HaircutName);
            DB.AddParameter("@HaircutPrice", mThisHaircut.HaircutPrice);
            //execute the stored procedure
            DB.Execute("sproc_tblHaircut_Update");
        }

        public void ReportByHaircutName(string HaircutName)
        {
            //filter the record based of haircut name
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send the haircut name parameter
            DB.AddParameter("@HaircutName", HaircutName);
            //execute stored procedure
            DB.Execute("sproc_tblHaircut_FilterByHaircutName");
            //populate array list
            PopulateArray(DB);
        }
    }
}
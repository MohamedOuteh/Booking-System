using System.Collections.Generic;
using System;
using System.Data.SqlClient;

namespace LotusClasses
{
    public class clsAdminCollection
    {
        List<clsAdmin> mAdminList = new List<clsAdmin>();
        clsAdmin mThisAdmin = new clsAdmin();

        //public property for admin list
        public List<clsAdmin> AdminList
        {
            get
            {
                //return the private data
                return mAdminList;
            }
            set
            {
                //set the private data
                mAdminList = value;
            }
        }

        //public property for this admin
        public clsAdmin ThisAdmin
        {
            get
            {
                //return the private data
                return mThisAdmin;
            }
            set
            {
                //set the private data
                mThisAdmin = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return count to the list
                return mAdminList.Count;
            }
            set
            {
                //worry about it later
            }
        }

        //constructor for the class
        public clsAdminCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the sotred procedure
            DB.Execute("sproc_tblAdmin_SelectAll");
            //populate array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of record
            RecordCount = DB.Count;
            //clear the private array list
            mAdminList = new List<clsAdmin>();
            RecordCount = DB.Count;
            //while there are records
            while (Index < RecordCount)
            {
                //create blank admin
                clsAdmin AAdmin = new clsAdmin();
                //read in the feilds from the current record
                AAdmin.AdminID = Convert.ToInt32(DB.DataTable.Rows[Index]["AdminID"]);
                AAdmin.AdminFirstName = Convert.ToString(DB.DataTable.Rows[Index]["AdminFirstName"]);
                AAdmin.AdminLastName = Convert.ToString(DB.DataTable.Rows[Index]["AdminLastName"]);
                AAdmin.AdminPhoneNo = Convert.ToInt64(DB.DataTable.Rows[Index]["AdminPhoneNo"]);
                AAdmin.AdminUsername = Convert.ToString(DB.DataTable.Rows[Index]["AdminUsername"]);
                AAdmin.AdminPassword = Convert.ToString(DB.DataTable.Rows[Index]["AdminPassword"]);
                //add the record to the private data member
                mAdminList.Add(AAdmin);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //add a new record to the database
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter
            DB.AddParameter("@AdminFirstName", mThisAdmin.AdminFirstName);
            DB.AddParameter("@AdminLastName", mThisAdmin.AdminLastName);
            DB.AddParameter("@AdminPhoneNo", mThisAdmin.AdminPhoneNo);
            DB.AddParameter("@AdminUsername", mThisAdmin.AdminUsername);
            DB.AddParameter("@AdminPassword", mThisAdmin.AdminPassword);
            //execute stored procedure
            return DB.Execute("sproc_tblAdmin_Insert");
        }

        public void Delete()
        {
            //deletes the record form the database
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter
            DB.AddParameter("@AdminID", mThisAdmin.AdminID);
            //execute the stored procedure
            DB.Execute("sproc_tblAdmin_Delete");
        }

        public void Update()
        {
            //update existing record from the data
            //connect to database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameter
            DB.AddParameter("@AdminID", mThisAdmin.AdminID);
            DB.AddParameter("@AdminFirstName", mThisAdmin.AdminFirstName);
            DB.AddParameter("@AdminLastName", mThisAdmin.AdminLastName);
            DB.AddParameter("@AdminPhoneNo", mThisAdmin.AdminPhoneNo);
            DB.AddParameter("@AdminUsername", mThisAdmin.AdminUsername);
            DB.AddParameter("@AdminPassword", mThisAdmin.AdminPassword);
            DB.AddParameter("@Secret", mThisAdmin.Secret);
            //execute stored procedure
            DB.Execute("sproc_tblAdmin_Update");

        }

        public void ReportByAdminUsername(string AdminUsername)
        {
            //filters the records based on full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the admin username parameter to the database
            DB.AddParameter("@AdminUsername", AdminUsername);
            //execute the stored procedure
            DB.Execute("sproc_tblAdmin_FilterByAdminUsername");
            //populate the array list with the data tables
            PopulateArray(DB);
        }
    }
}
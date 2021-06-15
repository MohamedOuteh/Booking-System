using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LotusClasses
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();


        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the prvate data
                mCustomerList = value;
            }
        }

        //public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //constructor for the class
        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

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
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in feilds for the current record
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                ACustomer.PhoneNo = Convert.ToInt64(DB.DataTable.Rows[Index]["PhoneNo"]);
                ACustomer.UserName = Convert.ToString(DB.DataTable.Rows[Index]["UserName"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisAddress
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@PhoneNo", mThisCustomer.PhoneNo);
            DB.AddParameter("@UserName", mThisCustomer.UserName);
            DB.AddParameter("@Password", mThisCustomer.Password);
            //execute the query returning the primary key
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            //update the existing record
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@PhoneNo", mThisCustomer.PhoneNo);
            DB.AddParameter("@UserName", mThisCustomer.UserName);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@Secret", mThisCustomer.Secret);
            //execute stored procedure
            DB.Execute("sproc_tblCustomer_Update");

        }

        public void ReportByUsername(string UserName)
        {
            //filter records based on a full or partial code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the username parameter to the database
            DB.AddParameter("@UserName", UserName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByUsername");
            PopulateArray(DB);
        }
        
    }
}
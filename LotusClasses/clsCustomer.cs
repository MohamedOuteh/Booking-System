using System;

namespace LotusClasses
{
    public class clsCustomer
    {
        //private data members
        private Int32 mCustomerID;
        private string mFirstName;
        private string mLastName;
        private string mEmailAddress;
        private long mPhoneNo;
        private string mUserName;
        private string mPassword;
        private string mSecret;

        //public property for customer id
        public Int32 CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the private data
                mCustomerID = value;
            }
        }

        //public property for first name
        public string FirstName
        {
            get
            {
                //return private data
                return mFirstName;
            }
            set
            {
                //set private data
                mFirstName = value;
            }
        }

        //public property for last name
        public string LastName
        {
            get
            {
                //return private data member
                return mLastName;
            }
            set
            {
                //set private data
                mLastName = value;
            }
        }

        //public property for email address
        public string EmailAddress
        {
            get
            {
                //return private data member
                return mEmailAddress;
            }
            set
            {
                //set the value
                mEmailAddress = value;
            }
        }

        //public property for phone no
        public long PhoneNo
        {
            get
            {
                //return private data member
                return mPhoneNo;
            }
            set
            {
                //set the value
                mPhoneNo = value;
            }
        }

        //public property for username
        public string UserName
        {
            get
            {
                //return private data member
                return mUserName;
            }
            set
            {
                //set the value
                mUserName = value;
            }
        }

        //public property for password
        public string Password
        {
            get
            {
                //return private data member
                return mPassword;
            }
            set
            {
                //set the value
                mPassword = value;
            }
        }

        //public property for secret
        public string Secret
        {
            get
            {
                //return private data member
                return mSecret;
            }
            set
            {
                //set private data
                mSecret = value;
            }
        }


        public bool Find(int CustomerID)
        {
            //create an instance of the data class
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the cusotmer id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mPhoneNo = Convert.ToInt64(DB.DataTable.Rows[0]["PhoneNo"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mSecret = Convert.ToString(DB.DataTable.Rows[0]["Secret"]);
                //return that everything is ok
                return true;
            }
            else
            {
                //return false indicating a problem
                return false;
            }
        }



        public string Valid(string FirstName, string LastName, string EmailAddress, string PhoneNo, string UserName, string Password)
        {
            //create a string variable to store the error
            String Error = "";

            //FIRST NAME VALIDATION///////////////
            
            //if First name is blank
            if(FirstName.Length ==0| FirstName.Length <3)
            {
                //record the error
                Error = Error + "The First Name may not be blank and exceed 3 characters" + "<br />";
            }
            //if first name is greater than 20 character
            if(FirstName.Length >20)
            {
                //record error
                Error = Error + "The First name must be less than 20 characters" + "<br />";
            }

            //FIRST NAME VALIDATION///////////////

            //LAST NAME VALIDATION///////////////

            //if last name is blank
            if(LastName.Length ==0| LastName.Length <3)
            {
                //record error
                Error = Error + "The Last Name may not be blank" + "<br />";
            }
            //if last name is greater than 20 character
            if(LastName.Length >20)
            {
                //record error
                Error = Error + "The Last Name may be more thank 20 character" + "<br />";
            }

            //LAST NAME VALIDATION///////////////

            //EMAIL ADDRESS VALIDATION//////////

            //if email address is blank or has less than 14 characters
            if (EmailAddress.Length ==0| EmailAddress.Length <14)
            {
                //record error
                Error = Error + "The Email Address may not be blank also exceed 14 characters" + "<br />";
            }
            //if email address is greater than 30 character
            if (EmailAddress.Length >30)
            {
                //record error
                Error = Error + "The Eamil Address may not be more than 30 character" + "<br />";
            }

            //EMAIL ADDRESS VALIDATION//////////

            //PHONE NO VALIDATION//////////////

            //if phone no is blank or has less than 14 characters
            if (PhoneNo.Length == 0 | PhoneNo.Length < 7)
            {
                //record error
                Error = Error + "The Phone Number may not be blank also exceed 7 digits" + "<br />";
            }
            //if phone no is greater than 15 character
            if (PhoneNo.Length > 15)
            {
                //record error
                Error = Error + "The Phone Number may not be more than 15 digits" + "<br />";
            }

            //PHONE NO VALIDATION//////////////

            //USERNAME VALIDATION//////////////

            //if Username is blank or has less than 3 characters
            if (UserName.Length == 0 | UserName.Length < 3)
            {
                //record error
                Error = Error + "The Username may not be blank also exceed 3 characters" + "<br />";
            }
            //if Username is greater than 20 character
            if (UserName.Length > 20)
            {
                //record error
                Error = Error + "The Username may not be more than 20 characters" + "<br />";
            }

            //USERNAME VALIDATION//////////////

            //PASSWORD VALIDATION//////////////

            //if Username is blank or has less than 5 characters
            if (Password.Length == 0 | Password.Length < 5)
            {
                //record error
                Error = Error + "The Password may not be blank also exceed 5 characters" + "<br />";
            }
            //if Username is greater than 20 character
            if (Password.Length > 20)
            {
                //record error
                Error = Error + "The Password may not be more than 20 characters" + "<br />";
            }

            //PASSWORD VALIDATION//////////////
            //return the error message
            return Error;
        }

        public string ValidUpdate(string FirstName, string LastName, string EmailAddress, string PhoneNo, string UserName)
        {
            //create a string variable to store the error
            String Error = "";

            //FIRST NAME VALIDATION///////////////

            //if First name is blank
            if (FirstName.Length == 0 | FirstName.Length < 3)
            {
                //record the error
                Error = Error + "The First Name may not be blank and exceed 3 characters" + "<br />";
            }
            //if first name is greater than 20 character
            if (FirstName.Length > 20)
            {
                //record error
                Error = Error + "The First name must be less than 20 characters" + "<br />";
            }

            //FIRST NAME VALIDATION///////////////

            //LAST NAME VALIDATION///////////////

            //if last name is blank
            if (LastName.Length == 0 | LastName.Length < 3)
            {
                //record error
                Error = Error + "The Last Name may not be blank" + "<br />";
            }
            //if last name is greater than 20 character
            if (LastName.Length > 20)
            {
                //record error
                Error = Error + "The Last Name may be more thank 20 character" + "<br />";
            }

            //LAST NAME VALIDATION///////////////

            //EMAIL ADDRESS VALIDATION//////////

            //if email address is blank or has less than 14 characters
            if (EmailAddress.Length == 0 | EmailAddress.Length < 14)
            {
                //record error
                Error = Error + "The Email Address may not be blank also exceed 14 characters" + "<br />";
            }
            //if email address is greater than 30 character
            if (EmailAddress.Length > 30)
            {
                //record error
                Error = Error + "The Eamil Address may not be more than 30 character" + "<br />";
            }

            //EMAIL ADDRESS VALIDATION//////////

            //PHONE NO VALIDATION//////////////

            //if phone no is blank or has less than 14 characters
            if (PhoneNo.Length == 0 | PhoneNo.Length < 7)
            {
                //record error
                Error = Error + "The Phone Number may not be blank also exceed 7 digits" + "<br />";
            }
            //if phone no is greater than 15 character
            if (PhoneNo.Length > 15)
            {
                //record error
                Error = Error + "The Phone Number may not be more than 15 digits" + "<br />";
            }

            //PHONE NO VALIDATION//////////////

            //USERNAME VALIDATION//////////////

            //if Username is blank or has less than 3 characters
            if (UserName.Length == 0 | UserName.Length < 3)
            {
                //record error
                Error = Error + "The Username may not be blank also exceed 3 characters" + "<br />";
            }
            //if Username is greater than 20 character
            if (UserName.Length > 20)
            {
                //record error
                Error = Error + "The Username may not be more than 20 characters" + "<br />";
            }

            //USERNAME VALIDATION//////////////
            //return the error message
            return Error;
        }
    }
}
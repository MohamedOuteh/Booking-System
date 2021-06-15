using System;

namespace LotusClasses
{
    public class clsAdmin
    {
        private Int32 mAdminID;
        private string mAdminFirstName;
        private string mAdminLastName;
        private Int64 mAdminPhoneNo;
        private string mAdminUsername;
        private string mAdminPassword;
        private string mSecret;

        //public property for admin id
        public Int32 AdminID
        {
            get
            {
                return mAdminID;
            }
            set
            {
                mAdminID = value;
            }
        }

        //public property for Admin first name
        public string AdminFirstName
        {
            get
            {
                return mAdminFirstName;
            }
            set
            {
                mAdminFirstName = value;
            }
        }

        //public property for admin last name
        public string AdminLastName
        {
            get
            {
                return mAdminLastName;
            }
            set
            {
                mAdminLastName = value;
            }
        }

        //public property for admin phone no
        public Int64 AdminPhoneNo
        {
            get
            {
                return mAdminPhoneNo;
            }
            set
            {
                mAdminPhoneNo = value;
            }
        }

        //public property for admin username
        public string AdminUsername
        {
            get
            {
                return mAdminUsername;
            }
            set
            {
                mAdminUsername = value;
            }
        }

        //public property for admin passord
        public string AdminPassword
        {
            get
            {
                return mAdminPassword;
            }
            set
            {
                mAdminPassword = value;
            }
        }

        //public property for Admin secret
        public string Secret
        {
            get
            {
                return mSecret;
            }
            set
            {
                mSecret = value;
            }
        }

        public bool Find (int AdminID)
        {
            //create instance of the data 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the admin id to search for
            DB.AddParameter("@AdminID", AdminID);
            //execute the stored procedure
            DB.Execute("sproc_tblAdmin_FilterByAdminID");
            //if record is found
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data
                mAdminID = Convert.ToInt32(DB.DataTable.Rows[0]["AdminID"]);
                mAdminFirstName = Convert.ToString(DB.DataTable.Rows[0]["AdminFirstName"]);
                mAdminLastName = Convert.ToString(DB.DataTable.Rows[0]["AdminLastName"]);
                mAdminPhoneNo = Convert.ToInt64(DB.DataTable.Rows[0]["AdminPhoneNo"]);
                mAdminUsername = Convert.ToString(DB.DataTable.Rows[0]["AdminUsername"]);
                mAdminPassword = Convert.ToString(DB.DataTable.Rows[0]["AdminPassword"]);
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

        public string Valid(string AdminFirstName, string AdminLastName, string AdminPhoneNo, string AdminUsername, string AdminPassword)
        {
            //create a string variable to store the error
            String Error = "";

            //FIRST NAME VALIDATION////////////////////

            //If first name is blank
            if(AdminFirstName.Length ==0 | AdminFirstName.Length <3)
            {
                //record error
                Error = Error + "The first name may not be blank and have more than 3 characters" + "<br />";
            }

            //if first name has greater than 20 characters
            if(AdminFirstName.Length >21)
            {
                //record error
                Error = Error + "The first name must be less than 20 characters" + "<br />";
            }

            //FIRST NAME VALIDATION////////////////////

            //LAST NAME VALIDATION////////////////////
            if (AdminLastName.Length == 0 | AdminLastName.Length < 3)
            {
                //record error
                Error = Error + "The last name may not be blank and have more than 3 characters" + "<br />";
            }

            //if first name has greater than 20 characters
            if (AdminLastName.Length > 21)
            {
                //record error
                Error = Error + "The last name must be less than 20 characters" + "<br />";
            }

            //LAST NAME VALIDATION////////////////////

            //PHONE NO VALIDATION////////////////////
            if (AdminPhoneNo.Length == 0 | AdminPhoneNo.Length < 7)
            {
                //record error
                Error = Error + "The phone number may not be blank and have more than 7 digits" + "<br />";
            }

            //if first name has greater than 20 characters
            if (AdminPhoneNo.Length > 12)
            {
                //record error
                Error = Error + "The phone number must be less than 12 digits" + "<br />";
            }

            //PHONE NO VALIDATION////////////////////

            //USERNAME VALIDATION////////////////////

            if (AdminUsername.Length == 0 | AdminUsername.Length < 3)
            {
                //record error
                Error = Error + "The username may not be blank and have more than 3 characters" + "<br />";
            }

            //if first name has greater than 20 characters
            if (AdminUsername.Length > 21)
            {
                //record error
                Error = Error + "The username must be less than 20 characters" + "<br />";
            }

            //USERNAME VALIDATION////////////////////

            //PASSWORD VALIDATION////////////////////

            if (AdminPassword.Length == 0 | AdminPassword.Length < 5)
            {
                //record error
                Error = Error + "The password may not be blank and have more than 5 characters" + "<br />";
            }

            //if first name has greater than 20 characters
            if (AdminPassword.Length > 21)
            {
                //record error
                Error = Error + "The password must be less than 20 characters" + "<br />";
            }

            //PASSWORD VALIDATION////////////////////

            return Error;
        }

        public string ValidAdmin(string AdminFirstName, string AdminLastName, string AdminPhoneNo, string AdminUsername)
        {
            //create a string variable to store the error
            String Error = "";

            //FIRST NAME VALIDATION////////////////////

            //If first name is blank
            if (AdminFirstName.Length == 0 | AdminFirstName.Length < 3)
            {
                //record error
                Error = Error + "The first name may not be blank and have more than 3 characters" + "<br />";
            }

            //if first name has greater than 20 characters
            if (AdminFirstName.Length > 21)
            {
                //record error
                Error = Error + "The first name must be less than 20 characters" + "<br />";
            }

            //FIRST NAME VALIDATION////////////////////

            //LAST NAME VALIDATION////////////////////
            if (AdminLastName.Length == 0 | AdminLastName.Length < 3)
            {
                //record error
                Error = Error + "The last name may not be blank and have more than 3 characters" + "<br />";
            }

            //if first name has greater than 20 characters
            if (AdminLastName.Length > 21)
            {
                //record error
                Error = Error + "The last name must be less than 20 characters" + "<br />";
            }

            //LAST NAME VALIDATION////////////////////

            //PHONE NO VALIDATION////////////////////
            if (AdminPhoneNo.Length == 0 | AdminPhoneNo.Length < 7)
            {
                //record error
                Error = Error + "The phone number may not be blank and have more than 7 digits" + "<br />";
            }

            //if first name has greater than 20 characters
            if (AdminPhoneNo.Length > 12)
            {
                //record error
                Error = Error + "The phone number must be less than 12 digits" + "<br />";
            }

            //PHONE NO VALIDATION////////////////////

            //USERNAME VALIDATION////////////////////

            if (AdminUsername.Length == 0 | AdminUsername.Length < 3)
            {
                //record error
                Error = Error + "The username may not be blank and have more than 3 characters" + "<br />";
            }

            //if first name has greater than 20 characters
            if (AdminUsername.Length > 21)
            {
                //record error
                Error = Error + "The username must be less than 20 characters" + "<br />";
            }

            //USERNAME VALIDATION////////////////////

            return Error;
        }
    }
}
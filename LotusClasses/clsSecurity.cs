using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LotusClasses
{
    public class clsSecurity
    {
        //private data members
        private string mUsername = "";
        private string mAdminUsername = "";
        //indicates if it is an admin

        //constructor
        public clsSecurity()
        {

        }

        //allows access to the username of the current user
        public string Username
        {
            get
            {
                //return username
                return mUsername;
            }
        }


        //allows access to the username of the current user
        public string AdminUsername
        {
            get
            {
                //return username
                return mAdminUsername;
            }
        }

        public string SignIn(string Username, string Password)
        {
            //sign in a user based on their username and password
            //if not all attemps are used
            string Error = "";
            //convert plain text password to hash code
            Password = GetHashString(Password + Username);
            //find the matching record
            clsDataConnection UserAccount = new clsDataConnection();
            //add the parameter
            UserAccount.AddParameter("@UserName", Username);
            UserAccount.AddParameter("@Password", Password);
            //execute stored procedure
            UserAccount.Execute("sproc_tblCustomer_FilterByUsernameAndPassword");
            //if there is one record found
            if (UserAccount.Count >= 1)
            {
                //return blank error
                Error = "";
            }
            else
            {
                //return error message
                Error = "There were problems with the sign in";
            }
            return Error;

        }

        public string AdminSignIn(string AdminUsername, string AdminPassword)
        {
            //sign in a user based on their username and password
            //if not all attemps are used
            string Error = "";
            //convert plain text password to hash code
            AdminPassword = GetHashString(AdminPassword + AdminUsername);
            //find the matching record
            clsDataConnection UserAccount = new clsDataConnection();
            //add the parameter
            UserAccount.AddParameter("@AdminUsername", AdminUsername);
            UserAccount.AddParameter("@AdminPassword", AdminPassword);
            //execute stored procedure
            UserAccount.Execute("sproc_tblAdmin_FilterByUsernameAndPassword");
            //if there is one record found
            if (UserAccount.Count >= 1)
            {
                Error = "";
            }
            else
            {
                Error = "There were problems with the sign in";
            }
            return Error;

        }


        private string GetHashString(string SomeText)
        {
            //generates a hash for storing secure data in the database
            if (SomeText != "")//if there is text to process
            {
                //create an instance of the hash generator
                SHA256Managed HashGenerator = new SHA256Managed();
                //var to store the final hash
                string HashString;
                //array to store the bytes of the orignal text
                byte[] TextBytes;
                //array to store the bytes of the new hash
                byte[] HashBytes;
                //convert the text in the string to an array of bytes
                TextBytes = System.Text.Encoding.UTF8.GetBytes(SomeText);
                //generate the hash based on the array of bytes
                HashBytes = HashGenerator.ComputeHash(TextBytes);
                //generate the hash string replacing blank characters with -
                HashString = BitConverter.ToString(HashBytes).Replace("-", "");
                return HashString;
            }
            else   //if there is nothing to process
            {
                //return a blank string
                return "";
            }
        }

        public string SignUp(string FirstName, string LastName, string EmailAddress, string PhoneNo, string Username, string Password, string PasswordConfirm, string Secret)
        {
            //var to store error
            String Error = "";
            //check if username is taken
            if (UsernameTaken(Username) == false)
            {
                //check to see if passwords match
                if (Password == PasswordConfirm)
                {
                    //validate the data stored
                    if (Valid(Password, FirstName, LastName, EmailAddress, PhoneNo, Username, Secret) == "")
                    {
                        //hash the password
                        string HashPassword = GetHashString(Password + Username);
                        string HashSecret = GetHashString(Secret + Username);
                        //connect to DB
                        clsDataConnection DB = new clsDataConnection();
                        //add the parameters
                        DB.AddParameter("@FirstName", FirstName);
                        DB.AddParameter("@LastName", LastName);
                        DB.AddParameter("@EmailAddress", EmailAddress);
                        DB.AddParameter("@PhoneNo", PhoneNo);
                        DB.AddParameter("@Username", Username);
                        DB.AddParameter("@Password", HashPassword);
                        DB.AddParameter("@Secret", HashSecret);
                        //executet the stored procedure
                        DB.Execute("sproc_tblCustomer_Insert");
                    }
                    //if there was an error
                    else
                    {
                        //error msg
                        Error = Valid(Password, FirstName, LastName, EmailAddress, PhoneNo, Username, Secret);
                    }
                }
                else
                {
                     Error = Error + "The passwords do not match";
                }
            }
            //error msg
            return Error;
        }

        public string AdminSignUp(string AdminFirstName, string AdminLastName, string AdminPhoneNo, string AdminUsername, string AdminPassword, string PasswordConfirm, string Secret)
        {
            //var to store error
            String Error = "";
            //check if username is taken
            if (UsernameTaken(AdminUsername) == false)
            {
                //check to see if passwords match
                if (AdminPassword == PasswordConfirm)
                {
                    //validate the data stored
                    if (ValidAdmin(AdminPassword, AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, Secret) == "")
                    {
                        //hash the password
                        string HashPassword = GetHashString(AdminPassword + AdminUsername);
                        string HashSecret = GetHashString(Secret + AdminUsername);
                        //connect to DB
                        clsDataConnection DB = new clsDataConnection();
                        //add the parameters
                        DB.AddParameter("@AdminFirstName", AdminFirstName);
                        DB.AddParameter("@AdminLastName", AdminLastName);
                        DB.AddParameter("@AdminPhoneNo", AdminPhoneNo);
                        DB.AddParameter("@AdminUsername", AdminUsername);
                        DB.AddParameter("@AdminPassword", HashPassword);
                        DB.AddParameter("@Secret", HashSecret);
                        //executet the stored procedure
                        DB.Execute("sproc_tblAdmin_Insert");
                    }
                    //if there was an error
                    else
                    {
                        //error msg
                        Error = ValidAdmin(AdminPassword, AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, Secret);
                    }
                }
                else
                {
                    Error = Error + "The passwords do not match";
                }
            }
            //error msg
            return Error;
        }

        private string ValidAdmin(string AdminPassword, string AdminFirstName, string AdminLastName, string AdminPhoneNo, string AdminUsername, string Secret)
        {
            //var to store error
            string Error = "";

            //Password Validation//////////////////////////////////
            //if password has less than 7 characters
            if (AdminPassword.Length <= 7)
            {
                //error msg
                Error = "Password must be at least 7 characters" + "<br />";
            }
            //if the password doesnt contain numbers
            if (ContainsNumber(AdminPassword) == false)
            {
                //error msg
                Error = Error + "Your password must have numbers in it" + "<br />";
            }
            //Password Validation//////////////////////////////////

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


            //SECRET VALIDATION////////////////////////

            //if secret is blank or has less than 3 characters
            if (Secret.Length == 0 | Secret.Length < 3)
            {
                //record error
                Error = Error + "The Secret password may not be blank also exceed 3 characters" + "<br />";
            }
            //if secret is greater than 20 character
            if (Secret.Length > 20)
            {
                //record error
                Error = Error + "The Secret password may not be more than 20 characters" + "<br />";
            }
            //SECRET VALIDATION////////////////////////

            //return error
            return Error;
        }



        private string CheckPassword(string Password)
        {
            //var to store error
            string Error = "";
            //if password has less than 7 characters
            if (Password.Length < 7)
            {
                //error msg
                Error = "Password must be at least 7 characters" + "<br />";
            }
            //if the password doesnt contain numbers
            if (ContainsNumber(Password) == false)
            {
                //error msg
                Error = Error + "Your password must have numbers in it" + "<br />";
            }
            return Error;
        } 


            private string Valid(string Password, string FirstName, string LastName, string EmailAddress, string PhoneNo, string UserName, string Secret)
        {   
            string Error = "";
            //PASSWORD VALIDATION///////////////////
            if(Password.Length <= 7)
            {
                Error = "Password must be at least 7 characters" + "<br />"; 
            }
            if(ContainsNumber(Password)== false)
            {
                Error = Error + "Your password must have numbers in it" + "<br />";
            }
            //PASSWORD VALIDATION///////////////////

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

            //SECRET VALIDATION//////////////

            //if Username is blank or has less than 3 characters
            if (Secret.Length == 0 | Secret.Length < 3)
            {
                //record error
                Error = Error + "The Secret password may not be blank also exceed 3 characters" + "<br />";
            }
            //if Username is greater than 20 character
            if (Secret.Length > 20)
            {
                //record error
                Error = Error + "The Secret password may not be more than 20 characters" + "<br />";
            }

            //return error
            return Error;
        }

        private Boolean ContainsNumber(string Password)
        {
            //checks to see if a password contains a number
            //var to indicate found
            Boolean Found = false;
            //counter for loop
            int Counter = 0;
            //used to store a single character
            char AChar;
            //while found is false and char less than 9
            while (Found == false & Counter < 9)
            {
                //set temp to the value of Counter plus 48 to point at the numeric ascii codes
                int Temp = Counter + 48;
                //get the char value of the ascii code
                AChar = (char)Temp;
                //if the code is in the password
                if (Password.Contains(AChar) == true)
                {
                    //set found = true
                    Found = true;
                }
                else
                {
                    //otherwise keep looking
                    Counter += 1;
                }
            }
            //return the state of found
            return Found;
        }

        public Boolean UsernameTaken(string Username)
        {
            //tests to see if the email address is taken
            //connect to the database and see if it there already
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", Username);
            DB.Execute("sproc_tblCustomer_FilterByUsername");
            //if one record found then it is already gone
            if (DB.Count == 1)
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

        public Boolean AdminUsernameTaken(string AdminUsername)
        {
            //tests to see if the email address is taken
            //connect to the database and see if it there already
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AdminUsername", AdminUsername);
            DB.Execute("sproc_tblAdmin_FilterByAdminUsername");
            //if one record found then it is already gone
            if (DB.Count == 1)
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


        public string ChangePassword(string Username, string Password1, string Password2, string secret)
        {
            //used to change a users password
            //var to store any errors
            string Message = "";
            //connect to db
            //get hash for secret
            string HashSecret = GetHashString(secret + Username);
            clsDataConnection UserAccount = new clsDataConnection();
            UserAccount.AddParameter("@UserName", Username);
            UserAccount.AddParameter("@Secret", HashSecret);
            //execute the stored procedure
            UserAccount.Execute("sproc_tblCustomer_CheckSecret");
            if (UserAccount.Count >=-1)
            {
                //if the passwords match
                if(Password1 == Password2)
                {
                    //validate the password
                    Message = CheckPassword(Password1);
                    //if everything is ok
                    if(Message=="")
                    {
                        //get the hash of the password
                        string HashPassword = GetHashString(Password1 + Username);
                        //update the password in db
                        clsDataConnection DB = new clsDataConnection();
                        //add the parameter
                        DB.AddParameter("@UserName", Username);
                        DB.AddParameter("@Password", HashPassword);
                        //execute the stored procedure
                        DB.Execute("sproc_tblCustomer_UpdatePassword");
                    }
                }
                //if passwords do not match
                else
                {
                    //Error Message
                    Message = "The passwords do not match";
                }
            }
            else
            {
                //error message
                Message = "Username or secret are not correct";
            }
            //return the error if there is one
            return Message;
        }

        public string AdminChangePassword(string AdminUsername, string Password1, string Password2, string Secret)
        {
            //used to change a users password
            //var to store any errors
            string Message = "";
            //connect to db
            //get hash for secret
            string HashSecret = GetHashString(Secret + AdminUsername);
            clsDataConnection UserAccount = new clsDataConnection();
            UserAccount.AddParameter("@AdminUsername", AdminUsername);
            UserAccount.AddParameter("@Secret", HashSecret);
            //execute the stored procedure
            UserAccount.Execute("sproc_tblAdmin_CheckSecret");
            if (UserAccount.Count >= -1)
            {
                //if the passwords match
                if (Password1 == Password2)
                {
                    //validate the password
                    Message = CheckPassword(Password1);
                    //if everything is ok
                    if (Message == "")
                    {
                        //get the hash of the password
                        string HashPassword = GetHashString(Password1 + Username);
                        //update the password in db
                        clsDataConnection DB = new clsDataConnection();
                        //add the parameter
                        DB.AddParameter("@AdminUsername", AdminUsername);
                        DB.AddParameter("@AdminPassword", HashPassword);
                        //execute the stored procedure
                        DB.Execute("sproc_tblAdmin_UpdatePassword");
                    }
                }
                //if passwords do not match
                else
                {
                    //Error Message
                    Message = "The passwords do not match" + "<br />";
                }
            }
            else
            {
                //error message
                Message = "Username or secret are not correct" + "<br />";
            }
            //return the error if there is one
            return Message;
        }
    }
}

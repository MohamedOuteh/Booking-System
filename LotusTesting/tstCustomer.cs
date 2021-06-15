using System;
using LotusClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotusTesting
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass the method
        string FirstName = "Mohamed";
        string LastName = "Outeh";
        string EmailAddress = "mouteh@hotmail.com";
        string PhoneNo = "07588763421";
        string UserName = "mouteh";
        string Password = "Password";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want 
            clsCustomer ACustomer = new clsCustomer();
            //test to see it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ActiveCustomerIDOK()
        {
            //create an instance of the class we want 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void CustomerFirstNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Marc";
            //assign the data to property
            ACustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        [TestMethod]
        public void CustomerLastNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Smith";
            //assign the data to property
            ACustomer.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        [TestMethod]
        public void EmailAddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "smith@hotmail.com";
            //assign the data to property
            ACustomer.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.EmailAddress, TestData);
        }

        [TestMethod]
        public void PhoneNoOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int64 TestData = 1234567890123;
            //assign the data to the property
            ACustomer.PhoneNo = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.PhoneNo, TestData);
        }

        [TestMethod]
        public void UsernameOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "msmith";
            //assign the data to property
            ACustomer.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.UserName, TestData);
        }

        [TestMethod]
        public void PasswordOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "password";
            //assign the data to property
            ACustomer.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Password, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke method
            Found = ACustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if(ACustomer.CustomerID !=4)
            {
                OK = false;
            }
            //TEST TO SEE THAT THE RESULT IS CORRECT
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.FirstName != "Mohamed             ")
            {
                OK = false;
            }
            //TEST TO SEE THAT THE RESULT IS CORRECT
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.LastName != "Outeh               ")
            {
                OK = false;
            }
            //TEST TO SEE THAT THE RESULT IS CORRECT
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailAddressFound()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.EmailAddress != "mouteh@hotmail.com")
            {
                OK = false;
            }
            //TEST TO SEE THAT THE RESULT IS CORRECT
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.PhoneNo != 7588763421)
            {
                OK = false;
            }
            //TEST TO SEE THAT THE RESULT IS CORRECT
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUsernameFound()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.UserName != "mouteh")
            {
                OK = false;
            }
            //TEST TO SEE THAT THE RESULT IS CORRECT
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.Password != "arsenal")
            {
                OK = false;
            }
            //TEST TO SEE THAT THE RESULT IS CORRECT
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error messages
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //trst to see the results are correct
            Assert.AreEqual(Error, "");
        }

        //FIRST NAME TESTING//////////////////////

        [TestMethod]
        public void FirstNameExtremeMin()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string FirstName = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string FirstName = "dd";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string FirstName = "";
            FirstName = FirstName.PadRight(20, 'b'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string FirstName = "";
            FirstName = FirstName.PadRight(200, 'b'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //FIRST NAME TESTING//////////////////////

        //LAST NAME TESTING//////////////////////

        [TestMethod]
        public void LastNameExtremeMin()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string LastName = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string LastName = "aa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string LastName = "";
            LastName = LastName.PadRight(21, 'b'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string LastName = "";
            LastName = LastName.PadRight(200, 'b'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //LAST NAME TESTING//////////////////////

        //EMAIL ADDRESS TESTING//////////////////////

        [TestMethod]
        public void EmailAddressExtremeMin()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string EmailAddress = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(13, 'a');//this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(31, 'b'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(100, 'b'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //EMAIL ADDRESS TESTING//////////////////////

        //PHONE NUMBER TESTING///////////////////////

        [TestMethod]
        public void PhoneNoExtremeMin()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string PhoneNo = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinLessOne()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string PhoneNo = "123456";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxPlusOne()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(16, '1'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoExtremeMax()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(100, '1'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //PHONE NUMBER TESTING///////////////////////


        //USERNAME TESTING//////////////////////////

        [TestMethod]
        public void UsernameExtremeMin()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string UserName = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMinLessOne()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string UserName = "aa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMaxPlusOne()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string UserName = "";
            UserName = UserName.PadRight(21, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameExtremeMax()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string UserName = "";
            UserName = UserName.PadRight(100, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //USERNAME TESTING//////////////////////////

        //PASSWORD TESTING//////////////////////////

        [TestMethod]
        public void PasswordExtremeMin()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string Password = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string Password = "aaaa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string Password = "";
            Password = Password.PadRight(21, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create some test data to pass the method
            string Password = "";
            Password = Password.PadRight(100, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, EmailAddress, PhoneNo, UserName, Password);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //PASSWORD TESTING//////////////////////////
    }
}

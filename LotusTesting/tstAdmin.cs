using System;
using LotusClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotusTesting
{
    [TestClass]
    public class tstAdmin
    {
        //good test data
        //create some test data
        string AdminFirstName = "Abdi";
        string AdminLastName = "Suldan";
        string AdminPhoneNo = "12345678901";
        string AdminUsername = "asuldan";
        string AdminPassword = "password";

        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //test to see it exists
            Assert.IsNotNull(AAdmin);
        }

        [TestMethod]
        public void ActiveAdminIDOK()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AAdmin.AdminID = TestData;
            //test to see that it is the same
            Assert.AreEqual(AAdmin.AdminID, TestData);
        }

        [TestMethod]
        public void AdminFirstNameOK()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //create some test data to assign to the property
            string TestData = "John";
            AAdmin.AdminFirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AAdmin.AdminFirstName, TestData);
        }

        [TestMethod]
        public void AdminLastNameOK()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //create some test data to assign to the property
            string TestData = "Snow";
            AAdmin.AdminLastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AAdmin.AdminLastName, TestData);
        }

        [TestMethod]
        public void AdminPhoneNoOK()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //create some test data
            Int64 TestData = 07566743212;
            //assign the data to the property
            AAdmin.AdminPhoneNo = TestData;
            //test to see that it is the same
            Assert.AreEqual(AAdmin.AdminPhoneNo, TestData);
        }

        [TestMethod]
        public void AdminUserNameOK()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //create some test data to assign to the property
            string TestData = "jsnow";
            //assign the data to the property
            AAdmin.AdminUsername = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AAdmin.AdminUsername, TestData);
        }

        [TestMethod]
        public void AdminPasswordOK()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //create some test data to assign to the property
            string TestData = "password";
            //assign the data to the property
            AAdmin.AdminPassword = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AAdmin.AdminPassword, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        //FIRST NAME TESTING//////////////////////////////

        [TestMethod]
        public void AdminFirstNameExtremeMin()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminFirstName = ""; //ERROR
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminFirstNameMinLessOne()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminFirstName = "aa"; //ERROR
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminFirstNameMaxPlusOne()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminFirstName = ""; //ERROR
            AdminFirstName = AdminFirstName.PadRight(22, 'a');
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminFirstNameExtremeMax()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminFirstName = ""; //ERROR
            AdminFirstName = AdminFirstName.PadRight(100, 'a');
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //FIRST NAME TESTING//////////////////////////////

        //LAST NAME TESTING//////////////////////////////

        [TestMethod]
        public void AdminLastNameExtremeMin()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminLastName = "";
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminLastNameMinLessOne()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminLastName = "aa";
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminLastNameMaxPlusOne()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminLastName = "";
            AdminLastName = AdminLastName.PadRight(22, 'a');
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminLastNameExtremeMax()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminLastName = "";
            AdminLastName = AdminLastName.PadRight(100, 'a');
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //LAST NAME TESTING//////////////////////////////

        //PHONE NO TESTING//////////////////////////////

        [TestMethod]
        public void AdminPhoneExtremeMin()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminPhoneNo = "";
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminPhoneMinLessOne()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminPhoneNo = "123456";
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminPhoneMaxPlusOne()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminPhoneNo = "";
            AdminPhoneNo = AdminPhoneNo.PadRight(13, '1');
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminPhoneExtremeMax()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminPhoneNo = "";
            AdminPhoneNo = AdminPhoneNo.PadRight(100, '1');
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //PHONE NO TESTING//////////////////////////////

        //USERNAME TESTING//////////////////////////////

        [TestMethod]
        public void AdminUsernameExtremeMin()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminUsername = "";
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminUsernameMinLessOne()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminUsername = "aa";
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminUsernameMaxPlusOne()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminUsername = "";
            AdminUsername = AdminUsername.PadRight(22, 'a');
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminUsernameExtremeMax()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminUsername = "";
            AdminUsername = AdminUsername.PadRight(100, 'a');
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //USERNAME TESTING//////////////////////////////

        //PASSWORD TESTING//////////////////////////////
        [TestMethod]
        public void AdminPasswordExtremeMin()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminPassword = "";
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminPasswordMinLessOne()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminPassword = "aaaa";
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminPasswordMaxPlusOne()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminPassword = "";
            AdminPassword = AdminPassword.PadRight(22, 'a');
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminPasswordExtremeMax()
        {
            //create instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data
            string AdminPassword = "";
            AdminPassword = AdminPassword.PadRight(100, 'a');
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminPhoneNo, AdminUsername, AdminPassword);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //PASSWORD TESTING//////////////////////////////
    }
}

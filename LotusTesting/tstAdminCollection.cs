using System;
using LotusClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LotusTesting
{
    [TestClass]
    public class tstAdminCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class
            clsAdminCollection AllAdmin = new clsAdminCollection();
            //test to see it exists
            Assert.IsNotNull(AllAdmin);
        }

        [TestMethod]
        public void AdminListOK()
        {
            //create instance of the class
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //create some test data to asign to the property
            //in this case the data needs to be a list of objects
            List<clsAdmin> TestList = new List<clsAdmin>();
            //add items to the list
            //create the test items of test data
            clsAdmin TestItem = new clsAdmin();
            //set the properties
            TestItem.AdminID = 1;
            TestItem.AdminFirstName = "mohamed";
            TestItem.AdminLastName = "outeh";
            TestItem.AdminPhoneNo = 07599843214;
            TestItem.AdminUsername = "admin";
            TestItem.AdminPassword = "password";
            //add items to list
            TestList.Add(TestItem);
            //assign the data to property
            AllAdmins.AdminList = TestList;
            //test to see the two values are equal
            Assert.AreEqual(AllAdmins.AdminList, TestList);
        }

        [TestMethod]
        public void ThisAdminOK()
        {
            //create instance of the class
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //create some test data to asign to the property
            clsAdmin TestAdmin = new clsAdmin();
            //set the properties
            TestAdmin.AdminID = 2;
            TestAdmin.AdminFirstName = "John";
            TestAdmin.AdminLastName = "doe";
            TestAdmin.AdminPhoneNo = 07655432156;
            TestAdmin.AdminUsername = "jdoe";
            TestAdmin.AdminPassword = "password";
            //assign the data property
            AllAdmins.ThisAdmin = TestAdmin;
            //test to see the values are the same
            Assert.AreEqual(AllAdmins.ThisAdmin, TestAdmin);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create instance of the class
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //create some test data to asign to the property
            //in this case the data needs to be a list of objects
            List<clsAdmin> TestList = new List<clsAdmin>();
            //add items to the list
            //create the test items of test data
            clsAdmin TestItem = new clsAdmin();
            //set the properties
            TestItem.AdminID = 1;
            TestItem.AdminFirstName = "Sam";
            TestItem.AdminLastName = "Jones";
            TestItem.AdminPhoneNo = 07599843214;
            TestItem.AdminUsername = "sjones";
            TestItem.AdminPassword = "password";
            //add items to list
            TestList.Add(TestItem);
            //assign the data to property
            AllAdmins.AdminList = TestList;
            //test to see the two values are equal
            Assert.AreEqual(AllAdmins.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of the class
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //create the item of the test data
            clsAdmin TestItem = new clsAdmin();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.AdminFirstName = "Mohamed";
            TestItem.AdminLastName = "Outeh";
            TestItem.AdminPhoneNo = 07599843214;
            TestItem.AdminUsername = "mouteh";
            TestItem.AdminPassword = "password";
            //set ThisAdmin to the test data
            AllAdmins.ThisAdmin = TestItem;
            //add the record
            PrimaryKey = AllAdmins.Add();
            //set the primary key of the test data
            TestItem.AdminID = PrimaryKey;
            //find the record
            AllAdmins.ThisAdmin.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllAdmins.ThisAdmin, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create instance of the class
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //create the item of the test data
            clsAdmin TestItem = new clsAdmin();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AdminID = 2;
            TestItem.AdminFirstName = "Mohamed";
            TestItem.AdminLastName = "Outeh";
            TestItem.AdminPhoneNo = 07599843214;
            TestItem.AdminUsername = "mouteh";
            TestItem.AdminPassword = "password";
            //set ThisAdmin to the test data
            AllAdmins.ThisAdmin = TestItem;
            //add the record
            PrimaryKey = AllAdmins.Add();
            //set the primary key of the test data
            TestItem.AdminID = PrimaryKey;
            //find the record
            AllAdmins.ThisAdmin.Find(PrimaryKey);
            //delete the record
            AllAdmins.Delete();
            //now find the record
            Boolean Found = AllAdmins.ThisAdmin.Find(PrimaryKey);
            //test to see the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance of the class
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //create the item of the test data
            clsAdmin TestItem = new clsAdmin();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AdminID = 2;
            TestItem.AdminFirstName = "Mohamed";
            TestItem.AdminLastName = "Outeh";
            TestItem.AdminPhoneNo = 07599843214;
            TestItem.AdminUsername = "mouteh";
            TestItem.AdminPassword = "password";
            //set ThisAdmin to the test data
            AllAdmins.ThisAdmin = TestItem;
            //add the record
            PrimaryKey = AllAdmins.Add();
            //set the primary key of the test data
            TestItem.AdminID = PrimaryKey;
            //modify the test data
            TestItem.AdminFirstName = "Outeh";
            TestItem.AdminLastName = "Mohamed";
            TestItem.AdminPhoneNo = 07599843214;
            TestItem.AdminUsername = "mouteh";
            TestItem.AdminPassword = "password";
            //set the record based on the new test data
            AllAdmins.ThisAdmin = TestItem;
            //update the record
            AllAdmins.Update();
            //find the record
            AllAdmins.ThisAdmin.Find(PrimaryKey);
            //test to see this admin matches the data
            Assert.AreEqual(AllAdmins.ThisAdmin, TestItem);
        }

        [TestMethod]
        public void ReportByAdminUsernameMethodOK()
        {
            //create instance of the class containing unfiltered results
            clsAdminCollection AllAdmins = new clsAdminCollection();
            //create an instance of the filtered data
            clsAdminCollection FilteredAdmins = new clsAdminCollection();
            //apply a blank string (should return all records)
            FilteredAdmins.ReportByAdminUsername("");
            //test to see that the two values are the same
            Assert.AreEqual(AllAdmins.Count, FilteredAdmins.Count);
        }

        [TestMethod]
        public void ReportByAdminUsernameNoneFound()
        {
            //create an instance of the filtered data
            clsAdminCollection FilteredAdmins = new clsAdminCollection();
            //apply a blank string (should return all records)
            FilteredAdmins.ReportByAdminUsername("xxxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredAdmins.Count);
        }

        [TestMethod]
        public void ReportByAdminUsernameFound()
        {
            //create an instance of the filtered data
            clsAdminCollection FilteredAdmins = new clsAdminCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a username that exists
            FilteredAdmins.ReportByAdminUsername("admin");
            //check the correct number of records are found
            if(FilteredAdmins.Count==1)
            {
                //chec that the id is 1
                if(FilteredAdmins.AdminList[0].AdminID !=1)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}

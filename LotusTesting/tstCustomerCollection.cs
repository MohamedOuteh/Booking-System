using System;
using LotusClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LotusTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to asign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add items to the list
            //create the test items of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 7;
            TestItem.FirstName = "john";
            TestItem.LastName = "doe";
            TestItem.EmailAddress = "jdoe@hotmail.com";
            TestItem.PhoneNo = 07599834621;
            TestItem.UserName = "jdoe";
            TestItem.Password = "eslignto";
            //add the items to the test list
            TestList.Add(TestItem);
            //assing the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test
            TestCustomer.CustomerID = 2;
            TestCustomer.FirstName = "Khalid";
            TestCustomer.LastName = "Outeh";
            TestCustomer.EmailAddress = "kouteh@hotmail.com";
            TestCustomer.PhoneNo = 07599834631;
            TestCustomer.UserName = "kouteh";
            TestCustomer.Password = "password";
            //assign data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to asign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add items to the list
            //create the test items of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 9;
            TestItem.FirstName = "jane";
            TestItem.LastName = "snow";
            TestItem.EmailAddress = "jsnow@hotmail.com";
            TestItem.PhoneNo = 07599833231;
            TestItem.UserName = "jsnow";
            TestItem.Password = "whitecollar";
            //add the items to the test list
            TestList.Add(TestItem);
            //assing the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create item for test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            //TestItem.CustomerID = 8;
            TestItem.FirstName = "Aubrey";
            TestItem.LastName = "Graham";
            TestItem.EmailAddress = "agraham@hotmail.com";
            TestItem.PhoneNo = 12345678900;
            TestItem.UserName = "agraham";
            TestItem.Password = "password";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add this record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if the values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create item for test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.CustomerID = 6;
            TestItem.FirstName = "Husain";
            TestItem.LastName = "Makda";
            TestItem.EmailAddress = "hmakda@hotmail.com";
            TestItem.PhoneNo = 7566783421;
            TestItem.UserName = "hmakda";
            TestItem.Password = "chelsers";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add this record
            PrimaryKey = AllCustomers.Add();
            //set primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see its not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void EditMethodOK()
        {
            //create instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create item for test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.CustomerID = 21;
            TestItem.FirstName = "abdi                ";
            TestItem.LastName = "McGregor            ";
            TestItem.EmailAddress = "amcgregor@hotmail.com";
            TestItem.PhoneNo = 7588763421;
            TestItem.UserName = "amcgregor";
            TestItem.Password = "manutd";
            //set thisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify test data
            TestItem.FirstName = "abdi";
            TestItem.LastName = "McGregor";
            TestItem.EmailAddress = "amcgregor@hotmail.com";
            TestItem.PhoneNo = 7588763421;
            TestItem.UserName = "amcgregor";
            TestItem.Password = "arsenal";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see thisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportByUsernameMethodOK()
        {
            //create instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create instance of filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply blank string (should return all record)
            FilteredCustomers.ReportByUsername("");
            //test to see the values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByUsernameNoneFound()
        {
            //create instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply username that doesn't exists
            FilteredCustomers.ReportByUsername("xxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByUsernameTestDataFound()
        {
            //create instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a username that does not exists
            FilteredCustomers.ReportByUsername("mouteh");
            //checl that the correct number of records are found
            if(FilteredCustomers.CustomerList.Count == 1)
            {
                if(FilteredCustomers.CustomerList[0].CustomerID !=4)
                {
                    //check to see the first record is id 4
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

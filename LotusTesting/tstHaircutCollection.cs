using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LotusClasses;
using System.Collections.Generic;

namespace LotusTesting
{
    [TestClass]
    public class tstHaircutCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class
            clsHaircutCollection AllHaircuts = new clsHaircutCollection();
            //test to see its there
            Assert.IsNotNull(AllHaircuts);
        }

        [TestMethod]
        public void HaircutListOK()
        {
            //create instance of the class
            clsHaircutCollection AllHaircuts = new clsHaircutCollection();
            //create some test data to asign to the property
            //in this case the data needs to be a list of objects
            List<clsHaircut> TestList = new List<clsHaircut>();
            //add to the test list
            clsHaircut TestItem = new clsHaircut();
            //set the properties
            TestItem.HaircutID = 1;
            TestItem.HaircutName = "Skin Fade";
            TestItem.HaircutPrice = 5.0;
            //add items to the test list
            TestList.Add(TestItem);
            //assign data to property
            AllHaircuts.HaircutList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllHaircuts.HaircutList, TestList);
        }

        [TestMethod]
        public void ThisHaircutOK()
        {
            clsHaircutCollection AllHaircuts = new clsHaircutCollection();
            //create some test data to asign to the property
            clsHaircut TestHaircut = new clsHaircut();
            //set the properties
            TestHaircut.HaircutID = 1;
            TestHaircut.HaircutName = "Skin Fade";
            TestHaircut.HaircutPrice = 5.0;
            //assign data to property
            AllHaircuts.ThisHaircut = TestHaircut;
            //test to see the two values are the same
            Assert.AreEqual(AllHaircuts.ThisHaircut, TestHaircut);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create instance of the class
            clsHaircutCollection AllHaircuts = new clsHaircutCollection();
            //create some test data to asign to the property
            //in this case the data needs to be a list of objects
            List<clsHaircut> TestList = new List<clsHaircut>();
            //add to the test list
            clsHaircut TestItem = new clsHaircut();
            //set the properties
            TestItem.HaircutID = 1;
            TestItem.HaircutName = "Skin Fade";
            TestItem.HaircutPrice = 5.0;
            //add items to the test list
            TestList.Add(TestItem);
            //assign data to property
            AllHaircuts.HaircutList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllHaircuts.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of the class
            clsHaircutCollection AllHaircuts = new clsHaircutCollection();
            //create items for test data
            clsHaircut TestItem = new clsHaircut();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            //TestItem.HaircutID = 4;
            TestItem.HaircutName = "Trim";
            TestItem.HaircutPrice = 5.0;
            //set ThisHaircut to the test data
            AllHaircuts.ThisHaircut = TestItem;
            //add this record
            PrimaryKey = AllHaircuts.Add();
            //set the primary key of the test data
            TestItem.HaircutID = PrimaryKey;
            //find the record
            AllHaircuts.ThisHaircut.Find(PrimaryKey);
            //test to see the two values are the same
            Assert.AreEqual(AllHaircuts.ThisHaircut, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create instance of the class
            clsHaircutCollection AllHaircuts = new clsHaircutCollection();
            //create items for test data
            clsHaircut TestItem = new clsHaircut();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.HaircutID = 4;
            TestItem.HaircutName = "Trim";
            TestItem.HaircutPrice = 5;
            //set ThisHaircut to the test data
            AllHaircuts.ThisHaircut = TestItem;
            //add the record
            PrimaryKey = AllHaircuts.Add();
            //set the primary key of the test data
            TestItem.HaircutID = PrimaryKey;
            //find the record
            AllHaircuts.ThisHaircut.Find(PrimaryKey);
            //delete the record
            AllHaircuts.Delete();
            //now find the record
            Boolean Found = AllHaircuts.ThisHaircut.Find(PrimaryKey);
            //test to see the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance of the class
            clsHaircutCollection AllHaircuts = new clsHaircutCollection();
            //create items for test data
            clsHaircut TestItem = new clsHaircut();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.HaircutID = 3;
            TestItem.HaircutName = "Trim";
            TestItem.HaircutPrice = 5;
            //set ThisHaircut to the test data
            AllHaircuts.ThisHaircut = TestItem;
            //add the record
            PrimaryKey = AllHaircuts.Add();
            //set the primary key of the data
            TestItem.HaircutID = PrimaryKey;
            //modify the test data
            TestItem.HaircutName = "High Top";
            TestItem.HaircutPrice = 5;
            //set the record based on the new test data
            AllHaircuts.ThisHaircut = TestItem;
            //update the record
            AllHaircuts.Update();
            //find the record
            AllHaircuts.ThisHaircut.Find(PrimaryKey);
            //test to see ThisHaircut matches the test data
            Assert.AreEqual(AllHaircuts.ThisHaircut, TestItem);
        }

        [TestMethod]
        public void ReportByHaircutNameMethodOK()
        {
            //create instance of the class
            clsHaircutCollection AllHaircuts = new clsHaircutCollection();
            //create instance of the filtered data
            clsHaircutCollection FilteredHaircuts = new clsHaircutCollection();
            //apply a blank string (should return all record)
            FilteredHaircuts.ReportByHaircutName("");
            //test to see the values are the same
            Assert.AreEqual(AllHaircuts.Count, FilteredHaircuts.Count);
        }

        [TestMethod]
        public void ReportByHaircutNameNoneFound()
        {
            //create instance of the filtered data
            clsHaircutCollection FilteredHaircuts = new clsHaircutCollection();
            //apply name that doesn't exist
            FilteredHaircuts.ReportByHaircutName("xxx");
            //test to see the values are the same
            Assert.AreEqual(0, FilteredHaircuts.Count);
        }

        [TestMethod]
        public void ReportByHaircutNameDataFound()
        {
            //create instance of the filtered data
            clsHaircutCollection FilteredHaircuts = new clsHaircutCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a haircut name that does exists
            FilteredHaircuts.ReportByHaircutName("Bald");
            //check that the correct number of records are found
            if(FilteredHaircuts.Count ==1)
            {
                //check to see the id is 1
                if(FilteredHaircuts.HaircutList[0].HaircutID !=1)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no record
            Assert.IsTrue(OK);
        }
    }
}

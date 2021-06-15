using System;
using LotusClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotusTesting
{
    [TestClass]
    public class tstHaircut
    {
        //test data
        string haircutname = "Fade";
        double haircutprice = 7.5;

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want 
            clsHaircut AHaircut = new clsHaircut();
            //test to see it exists
            Assert.IsNotNull(AHaircut);
        }

        [TestMethod]
        public void ActiveHaircutIDOK()
        {
            //create an instance of the class we want 
            clsHaircut AHaircut = new clsHaircut();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AHaircut.HaircutID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AHaircut.HaircutID, TestData);
        }

        [TestMethod]
        public void ActiveHaircutNameOK()
        {
            //create an instance of the class we want 
            clsHaircut AHaircut = new clsHaircut();
            //create some test data to assign to the property
            string TestData = "Skin Fade";
            //assign the data to the property
            AHaircut.HaircutName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AHaircut.HaircutName, TestData);
        }


        [TestMethod]
        public void ActiveHaircutPriceOK()
        {
            //create an instance of the class we want 
            clsHaircut AHaircut = new clsHaircut();
            //create some test data to assign to the property
            double TestData = 7.8;
            //assign the data to the property
            AHaircut.HaircutPrice = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AHaircut.HaircutPrice, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create instance of the class we want to create
            clsHaircut AHaircut = new clsHaircut();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use the method
            Int32 HaircutID = 1;
            //invoke the method
            Found = AHaircut.Find(HaircutID);
            //test to see the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestHaircutIDFound()
        {
            //create instance of the class we want to create
            clsHaircut AHaircut = new clsHaircut();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HaircutID = 1;
            //invoke the method
            Found = AHaircut.Find(HaircutID);
            //check the haircut id
            if(AHaircut.HaircutID !=1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHaircutNameFound()
        {
            //create instance of the class we want to create
            clsHaircut AHaircut = new clsHaircut();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HaircutID = 1;
            //invoke the method
            Found = AHaircut.Find(HaircutID);
            //check the haircut id
            if (AHaircut.HaircutName != "Bald")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHaircutPriceFound()
        {
            //create instance of the class we want to create
            clsHaircut AHaircut = new clsHaircut();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HaircutID = 1;
            //invoke the method
            Found = AHaircut.Find(HaircutID);
            //check the haircut id
            if (AHaircut.HaircutPrice != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //HAIRCUT NAME TESTING///////////////////////////
        [TestMethod]
        public void HaircutNameExtremeMin()
        {
            //create instance of the class
            clsHaircut AHaircut = new clsHaircut();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass the method
            string haircutname = "";
            //invoke the method
            Error = AHaircut.Valid(haircutname, haircutprice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HaircutNameMinLessOne()
        {
            //create instance of the class
            clsHaircut AHaircut = new clsHaircut();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass the method
            string haircutname = "ddd";
            //invoke the method
            Error = AHaircut.Valid(haircutname, haircutprice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HaircutNameMaxPlusOne()
        {
            //create instance of the class
            clsHaircut AHaircut = new clsHaircut();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass the method
            string haircutname = "";
            haircutname = haircutname.PadRight(25, 'a');
            //invoke the method
            Error = AHaircut.Valid(haircutname, haircutprice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void HaircutNameExtremeMax()
        {
            //create instance of the class
            clsHaircut AHaircut = new clsHaircut();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass the method
            string haircutname = "";
            haircutname = haircutname.PadRight(100, 'a');
            //invoke the method
            Error = AHaircut.Valid(haircutname, haircutprice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //HAIRCUT NAME TESTING///////////////////////////

        //HAIRCUT PRICE TESTING//////////////////////////

        [TestMethod]
        public void HaircutPriceExtremeMin()
        {
            //create instance of the class
            clsHaircut AHaircut = new clsHaircut();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass the method
            double haircutprice = 0;
            //invoke the method
            Error = AHaircut.Valid(haircutname, haircutprice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HaircutPriceMaxPlusOne()
        {
            //create instance of the class
            clsHaircut AHaircut = new clsHaircut();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass the method
            double haircutprice = 10.00;
            //invoke the method
            Error = AHaircut.Valid(haircutname, haircutprice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HaircutPriceExtremeMax()
        {
            //create instance of the class
            clsHaircut AHaircut = new clsHaircut();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass the method
            double haircutprice = 1000.00;
            //invoke the method
            Error = AHaircut.Valid(haircutname, haircutprice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //HAIRCUT PRICE TESTING//////////////////////////
    }
}

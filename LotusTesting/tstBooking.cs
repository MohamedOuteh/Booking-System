using System;
using LotusClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotusTesting
{
    [TestClass]
    public class tstBooking
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want 
            clsBooking ABooking = new clsBooking();
            //test to see it exists
            Assert.IsNotNull(ABooking);
        }

        [TestMethod]
        public void ActiveBooingIDOK()
        {
            //create an instance of the class we want 
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ABooking.BookingID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ABooking.BookingID, TestData);
        }

        [TestMethod]
        public void BookingDateOK()
        {
            //create an instance of the class we want 
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ABooking.BookingDate = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ABooking.BookingDate, TestData);
        }
    }
}

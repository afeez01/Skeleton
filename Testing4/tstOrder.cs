using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            //teste to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            //create some test data to assign to the property
            Int32 TestData = 1;
            
            //assign the data to the property
            AnOrder.OrderId = TestData;
           
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);

        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assing to the property
            Int32 TestData = 3;

            //assign the data to the property
            AnOrder.CustomerId = TestData;

            //test to see the two values are the same
            Assert.AreEqual(AnOrder.CustomerId, TestData);


        }
        [TestMethod]
        public void ShippingAddressPropertyOK()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //creat some test data to assign to the property
            string TestData = "Poland";

            //assign the data to the property   
            AnOrder.ShippingAddress = TestData;

            //test to see the two values are the same
            Assert.AreEqual(AnOrder.ShippingAddress, TestData);


        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            AnOrder.OrderDate = TestData;

            //test to see the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);


        }
        [TestMethod]
        public void OrderEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            string TestData = "joanaalmeida@gmail.com";

            //assign the data to the property
            AnOrder.OrderEmail = TestData;
            
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.OrderEmail, TestData);

        }
        [TestMethod]
        public void OrderCompleted()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            AnOrder.OrderCompleted = TestData;

            //test to see the two values are the same
            Assert.AreEqual(AnOrder.OrderCompleted, TestData);

        }
}
}
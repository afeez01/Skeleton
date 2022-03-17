using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass to the method
        
        string CustomerId  =  "213121";
        string ShippingAddress  = "Portugal";
        string OrderEmail = "francisco.neves@gmail.com";
        string OrderDate = DateTime.Now.Date.ToString();
       
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            //test to see that it exists
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
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);


        }
        [TestMethod]
        public void TestOrderIdFound()

        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1 ;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the address no
            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
          
           //boolean variable to store the result of the search
            Boolean Found = false;
        
           //boolean variable to record if data is OK
            Boolean OK = true;

           //create some test data to use with the method
            Int32 OrderId = 1;
        
           //invoke the method
           Found = AnOrder.Find(OrderId);
          
           //check the property
           if (AnOrder.CustomerId != 232335)
             {
             OK = false;
             }
         
           //test to see that result is correct
           Assert.IsTrue(OK);
          
         } 
        [TestMethod]
        public void TestShippingAddressFound()
        {
            
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
             Boolean Found = false;

            //boolean variable to record if data is OK
            Boolean OK = true;

             //create some test data to use with the method
             Int32 OrderId = 1;

            //invoke the method
             Found = AnOrder.Find(OrderId);
           
            //check the property
            if (AnOrder.ShippingAddress != "Madeira")
            {
                OK = false;
            }

            //test to see that result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestOrderDateFound()
        {

            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderId = 1;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //check the property
            if (AnOrder.OrderDate != Convert.ToDateTime("2022-04-23"))
            {
                OK = false;
            }

            //test to see that result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestOrderEmailFound()
        {

            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderId = 1;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //check the property
            if (AnOrder.OrderEmail != "andreiamartins@gmail.com")
            {
                OK = false;
            }

            //test to see that result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestOrderCompletedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderId = 1;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //check the property
            if (AnOrder.OrderCompleted != true)
            {
                OK = false;
            }

            //test to see that result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerId,ShippingAddress,OrderDate,OrderEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
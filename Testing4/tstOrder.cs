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
        
        //string CustomerId  =  "213121";
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
            if (AnOrder.CustomerId != 137)
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
            Error = AnOrder.Valid(ShippingAddress,OrderDate,OrderEmail);
           
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

//        ************************************** Shipping address **************************************
        [TestMethod]
        public void ShippingAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
           
            //string variable to store any error message
            String Error = "";
            
            //create some test data to pass to the method
            String ShippingAddress = "";//this should fail
            
            //invoke the method
            Error = AnOrder.Valid( ShippingAddress,OrderDate, OrderEmail);
            
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
           
            //string variable to store any error message
            String Error = "";
            
            //create some test data to pass to the method
            string ShippingAddress = "a";//this should pass
            
            //invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);
            
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void ShippingAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
           
            //string variable to store any error message
            String Error = "";
           
            //create some test data to pass to the method
            string ShippingAddress = "aa";//this should pass
          
            //invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);
           
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
           
            //string variable to store any error message
            String Error = "";
        
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadLeft(49, 'a'); //this should pass

            //invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);
           
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
          
            //string variable to store any error message
            String Error = "";
            
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(50, 'a'); //this should pass
            
            //invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);
            
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            //string variable to store any error message
            String Error = "";
            
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(25, 'a');//this should pass
            
            //invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);
            
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            //string variable to store any error message
            String Error = "";
            
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(51, 'a');//this should fail

            //invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);
            
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void ShippingAddressExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            String ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(1000, 'a');//this should fail

            // invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //        ********************************* OrderDate ***********************************************

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);

            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();

            // invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);

            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();

            // invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();

            // invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);

            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();

            // invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);

            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();

            // invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "";

            //convert the date variable to a string variable
            string OrderDate = "this is not a date";

            // invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);

            // test to see that the result is correcto
            Assert.AreNotEqual(Error, "");
        }
        //    ************************** OrderEmail*******************
        [TestMethod]
        public void OrderEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //this should fail
            String OrderEmail = "";

            //invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderEmailMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //this should pass 
            string OrderEmail = "a";

            //invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //this should pass 
            string OrderEmail = "aa";

            //invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //this should pass 
            string OrderEmail = "";
            OrderEmail = OrderEmail.PadRight(49, 'a');


            //invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderEmailMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //this should pass 
            string OrderEmail = "";
            OrderEmail = OrderEmail.PadRight(50, 'a');


            //invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //this should fail
            string OrderEmail = "";
            OrderEmail = OrderEmail.PadRight(51, 'a');


            //invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderEmailMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //this should pass
            string OrderEmail = "";
            OrderEmail = OrderEmail.PadRight(25, 'a');

           //invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, OrderEmail);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

    }
    }
}
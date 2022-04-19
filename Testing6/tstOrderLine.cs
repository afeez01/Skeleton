using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstOrderLine
    {
        //good test data
        //create some test data to pass to the method

       // string OrderID = "1";
        //string ToolID = "53";
        string Description = "Drill";
        string OrderLineDate = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //test to see that it exists
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void OrderLineIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //create some test data to assign to the property
            Int32 TestData = 1;

            //assign the data to the property
            AnOrderLine.OrderLineID = TestData;

            //test to see the two values are the same
            Assert.AreEqual(AnOrderLine.OrderLineID, TestData);

        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //create some test data to assing to the property
            Int32 TestData = 3;

            //assign the data to the property
            AnOrderLine.OrderID = TestData;

            //test to see the two values are the same
            Assert.AreEqual(AnOrderLine.OrderID, TestData);


        }
        [TestMethod]
        public void ToolIDPropertyOK()
        {
            //create a new instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //creat some test data to assign to the property
            Int32 TestData = 53;

            //assign the data to the property   
            AnOrderLine.ToolID = TestData;

            //test to see the two values are the same
            Assert.AreEqual(AnOrderLine.ToolID, TestData);


        }
        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create a new instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //create some test data to assign to the property
            string TestData = "hammer";

            //assign the data to the property
            AnOrderLine.Description = TestData;

            //test to see the two values are the same
            Assert.AreEqual(AnOrderLine.Description, TestData);


        }
        [TestMethod]
        public void OrderLineDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            AnOrderLine.OrderLineDate = TestData;

            //test to see the two values are the same
            Assert.AreEqual(AnOrderLine.OrderLineDate, TestData);

        }
        [TestMethod]
        public void OrderLineConfirmed()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //create some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            AnOrderLine.OrderLineConfirmed = TestData;

            //test to see the two values are the same
            Assert.AreEqual(AnOrderLine.OrderLineConfirmed, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            
            //boolean variable to store the results of the validation
            Boolean Found = false;
            
            //create some test data to use with the method
            Int32 OrderLineID = 1;
            
            //invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            
            //test to see if the result is true
            Assert.IsTrue(Found);


        }
        [TestMethod]
        public void TestOrderLineIDFound()

        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            
            //boolean variable to store the result of the search
            Boolean Found = false;
            
            //boolean variable to record if the data is OK
            Boolean OK = true;
            
            //create some test data to use with the method
            Int32 OrderLineID = 1;
           
            //invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            
            //check the address no
            if (AnOrderLine.OrderLineID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    
    [TestMethod]
    public void TestOrderIDFound()
    {
        //create an instance of the class we want to create
        clsOrderLine AnOrderLine = new clsOrderLine();

        //boolean variable to store the result of the search
        Boolean Found = false;

        //boolean variable to record if data is OK
        Boolean OK = true;

        //create some test data to use with the method
        Int32 OrderLineID = 1;

        //invoke the method
        Found = AnOrderLine.Find(OrderLineID);

        //check the property
        if (AnOrderLine.OrderID != 1)
        {
            OK = false;
        }

        //test to see that result is correct
        Assert.IsTrue(OK);

    }
    [TestMethod]
    public void TestToolIDFound()
    {

        //create an instance of the class we want to create
        clsOrderLine AnOrderLine = new clsOrderLine();

        //boolean variable to store the result of the search
        Boolean Found = false;

        //boolean variable to record if data is OK
        Boolean OK = true;

        //create some test data to use with the method
        Int32 OrderLineID = 1;

        //invoke the method
        Found = AnOrderLine.Find(OrderLineID);

        //check the property
        if (AnOrderLine.ToolID != 53)
        {
            OK = false;
        }

        //test to see that result is correct
        Assert.IsTrue(OK);

    }
    [TestMethod]
    public void TestDescriptionFound()
    {

        //create an instance of the class we want to create
        clsOrderLine AnOrderLine = new clsOrderLine();

        //boolean variable to store the result of the search
        Boolean Found = false;

        //boolean variable to record if data is OK
        Boolean OK = true;

        //create some test data to use with the method
        Int32 OrderLineID = 1;

        //invoke the method
        Found = AnOrderLine.Find(OrderLineID);

        //check the property
        if (AnOrderLine.Description != "Drill")
        {
            OK = false;
        }

        //test to see that result is correct
        Assert.IsTrue(OK);

    }

    [TestMethod]
    public void TestOrderLineDateFound()
    {

        //create an instance of the class we want to create
        clsOrderLine AnOrderLine = new clsOrderLine();

        //boolean variable to store the result of the search
        Boolean Found = false;

        //boolean variable to record if data is OK
        Boolean OK = true;

        //create some test data to use with the method
        Int32 OrderLineID = 1;

        //invoke the method
        Found = AnOrderLine.Find(OrderLineID);

        //check the property
        if (AnOrderLine.OrderLineDate != Convert.ToDateTime("2022-06-23")) 
        {
            OK = false;
        }

        //test to see that result is correct
        Assert.IsTrue(OK);

    }
    [TestMethod]
    public void TestOrderLineConfirmedFound()
    {
        //create an instance of the class we want to create
        clsOrderLine AnOrderLine = new clsOrderLine();

        //boolean variable to store the result of the search
        Boolean Found = false;

        //boolean variable to record if data is OK
        Boolean OK = true;

        //create some test data to use with the method
        Int32 OrderLineID = 1;

        //invoke the method
        Found = AnOrderLine.Find(OrderLineID);

        //check the property
        if (AnOrderLine.OrderLineConfirmed != true)
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
            clsOrderLine AnOrderLine = new clsOrderLine();

            //string variable to store any error message
            String Error = "";

            //invoke the method
            Error = AnOrderLine.Valid(Description, OrderLineDate);
            
          //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //        ************************************** Description **************************************
        [TestMethod]
        public void DescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            String Description = "";//this should fail

            //invoke the method
            Error = AnOrderLine.Valid(Description, OrderLineDate);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMin()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Description = "a";//this should pass

            //invoke the method
            Error = AnOrderLine.Valid(Description, OrderLineDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Description = "aa";//this should pass

            //invoke the method
            Error = AnOrderLine.Valid(Description, OrderLineDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Description = "";
            Description = Description.PadLeft(49, 'a'); //this should pass

            //invoke the method
            Error = AnOrderLine.Valid(Description, OrderLineDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMax()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Description = "";
            Description = Description.PadRight(50, 'a'); //this should pass

            //invoke the method
            Error = AnOrderLine.Valid(Description, OrderLineDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMid()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Description = "";
            Description = Description.PadRight(25, 'a');//this should pass

            //invoke the method
            Error = AnOrderLine.Valid(Description, OrderLineDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Description = "";
            Description = Description.PadRight(51, 'a');//this should fail

            //invoke the method
            Error = AnOrderLine.Valid(Description, OrderLineDate);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void DescriptionExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            String Description = "";
            Description = Description.PadRight(1000, 'a');//this should fail

            // invoke the method
            Error = AnOrderLine.Valid(Description, OrderLineDate);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //******************************** OrderLineDate ************************************

        [TestMethod]
        public void OrderLineDateExtremeMin()
        {
            // create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);

            //convert the date variable to a string variable
            string OrderLineDate = TestDate.ToString();

            // invoke the method
            Error = AnOrderLine.Valid(Description, OrderLineDate);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderLineDateMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);

            //convert the date variable to a string variable
            string OrderLineDate = TestDate.ToString();

            // invoke the method
            Error = AnOrderLine.Valid(Description, OrderLineDate);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderLineDateMin()
        {
            // create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //convert the date variable to a string variable
            string OrderLineDate = TestDate.ToString();

            // invoke the method
            Error = AnOrderLine.Valid(Description, OrderLineDate);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderLineDateMinPlusOne()
        {
            // create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);

            //convert the date variable to a string variable
            string OrderLineDate = TestDate.ToString();

            // invoke the method
            Error = AnOrderLine.Valid(Description, OrderLineDate);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderLineDateExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);

            //convert the date variable to a string variable
            string OrderLineDate = TestDate.ToString();

            // invoke the method
            Error = AnOrderLine.Valid(Description, OrderLineDate);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderLineDateInvalidData()
        {
            // create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message
            String Error = "";

            //convert the date variable to a string variable
            string OrderLineDate = "this is not a order line date";

            // invoke the method
            Error = AnOrderLine.Valid(Description, OrderLineDate);

            // test to see that the result is correcto
            Assert.AreNotEqual(Error, "");
        }
     

    }
}


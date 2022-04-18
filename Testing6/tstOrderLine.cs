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

        string OrderID = "3234322";
        string ToolID = "7655654";
        string Quantity = "3";
        string Price = "3.0000";

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
            Int32 TestData = 2;

            //assign the data to the property   
            AnOrderLine.ToolID = TestData;

            //test to see the two values are the same
            Assert.AreEqual(AnOrderLine.ToolID, TestData);


        }
        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create a new instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //create some test data to assign to the property
            Int32 TestData = 3;

            //assign the data to the property
            AnOrderLine.Quantity = TestData;

            //test to see the two values are the same
            Assert.AreEqual(AnOrderLine.Quantity, TestData);


        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();

            //create some test data to assign to the property
            decimal TestData = 2.000m;

            //assign the data to the property
            AnOrderLine.Price = TestData;

            //test to see the two values are the same
            Assert.AreEqual(AnOrderLine.Price, TestData);

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
        if (AnOrderLine.OrderID != 3234322)
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
        if (AnOrderLine.ToolID != 7655654)
        {
            OK = false;
        }

        //test to see that result is correct
        Assert.IsTrue(OK);

    }
    [TestMethod]
    public void TestQuantityFound()
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
        if (AnOrderLine.Quantity != 3)
        {
            OK = false;
        }

        //test to see that result is correct
        Assert.IsTrue(OK);

    }

    [TestMethod]
    public void TestPriceFound()
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
        if (AnOrderLine.Price != 3.0000m)
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

}
}


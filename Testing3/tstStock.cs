using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // test to see that it exists
            Assert.IsNotNull(AnStock);

        }

        [TestMethod]
        public void ToolIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // create some test data
            Int32 TestData = 3;

            // assign the data to the property
            AnStock.ToolID = TestData;

            // test to see if the two values are the same
            Assert.AreEqual(AnStock.ToolID, TestData);

        }

        [TestMethod]
        public void ToolNamePropertyOK()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // create some test data
            string TestData = "Bosch HSS-R Drill Bit";

            // assign the data to the property
            AnStock.ToolName = TestData;

            // test to see if the two values are the same
            Assert.AreEqual(AnStock.ToolName, TestData);
        }

        [TestMethod]
        public void QuantityInStockPropertyOK()
        {            
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // create some test data
            Int32 TestData = 3;

            // assign the data to the property
            AnStock.QuantityInStock = TestData;

            // test to see if the two values are the same
            Assert.AreEqual(AnStock.QuantityInStock, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {            
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // create some test data
            DateTime TestData = DateTime.Now.Date;

            // assign the data to the property
            AnStock.DateAdded = TestData;

            // test to see if the two values are the same
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }

        [TestMethod]
        public void UnitPricePropertyOK()
        {            
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // create some test data
            decimal TestData = 3.78m;

            // assign the data to the property
            AnStock.UnitPrice = TestData;

            // test to see if the two values are the same
            Assert.AreEqual(AnStock.UnitPrice, TestData);
        }

        [TestMethod]
        public void OnSalePropertyOK()
        {            
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // create some test data
            Boolean TestData = true;

            // assign the data to the property
            AnStock.OnSale = TestData;

            // test to see if the two values are the same
            Assert.AreEqual(AnStock.OnSale, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // boolean variable to store the results of the validation
            Boolean Found = false;

            // create some test data to use with the method
            Int32 ToolID = 21;

            // invoke the method
            Found = AnStock.Find(ToolID);

            // test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestToolIDFound()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // boolean variable to store the results of the validation
            Boolean Found = false;

            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            // create some test data to use with the method
            Int32 ToolID = 21;

            // invoke the method
            Found = AnStock.Find(ToolID);
            // check the tool name
            if(AnStock.ToolID != ToolID)
            {
                OK = false;
            }

            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestToolNameFound()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // boolean variable to store the results of the validation
            Boolean Found = false;

            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            // create some test data to use with the method
            Int32 ToolID = 21;

            // invoke the method
            Found = AnStock.Find(ToolID);
            // check the tool name
            if (AnStock.ToolName != "Test Tool Name")
            {
                OK = false;
            }

            // test to see if the result is true
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestQuantityInStockFound()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // boolean variable to store the results of the validation
            Boolean Found = false;

            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            // create some test data to use with the method
            Int32 ToolID = 21;

            // invoke the method
            Found = AnStock.Find(ToolID);
            // check the tool name
            if (AnStock.QuantityInStock != 100)
            {
                OK = false;
            }

            // test to see if the result is true
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // boolean variable to store the results of the validation
            Boolean Found = false;

            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            // create some test data to use with the method
            Int32 ToolID = 21;

            // invoke the method
            Found = AnStock.Find(ToolID);
            // check the tool name
            if (AnStock.DateAdded!= Convert.ToDateTime("15/05/2017"))
            {
                OK = false;
            }

            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUnitPriceFound()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // boolean variable to store the results of the validation
            Boolean Found = false;

            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            // create some test data to use with the method
            Int32 ToolID = 21;

            // invoke the method
            Found = AnStock.Find(ToolID);
            // check the tool name
            if (AnStock.UnitPrice != 100.99m)
            {
                OK = false;
            }

            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOnSaleFound()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // boolean variable to store the results of the validation
            Boolean Found = false;

            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            // create some test data to use with the method
            Int32 ToolID = 21;

            // invoke the method
            Found = AnStock.Find(ToolID);
            // check the tool name
            if (AnStock.OnSale != true)
            {
                OK = false;
            }

            // test to see if the result is true
            Assert.IsTrue(OK);
        }




    }
}

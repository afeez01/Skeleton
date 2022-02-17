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


    }
}

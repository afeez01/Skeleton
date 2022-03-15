using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        // good test data
        // create some test data to pass to the method
        String ToolName = "Bosch HSS-R Drill Bit";
        String QuantityInStock = "7";
        String DateAdded = DateTime.Now.ToString();
        String UnitPrice = "1.9500";


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
            Int32 ToolID = 1;

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
            Int32 ToolID = 1;

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
            Int32 ToolID = 1;

            // invoke the method
            Found = AnStock.Find(ToolID);
            // check the tool name
            if (AnStock.ToolName != "Bosch HSS-R Drill Bit")
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
            Int32 ToolID = 1;

            // invoke the method
            Found = AnStock.Find(ToolID);
            // check the tool name
            if (AnStock.QuantityInStock != 7)
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
            Int32 ToolID = 1;

            // invoke the method
            Found = AnStock.Find(ToolID);
            // check the tool name
            if (AnStock.DateAdded!= Convert.ToDateTime("07/02/2022"))
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
            Int32 ToolID = 1;

            // invoke the method
            Found = AnStock.Find(ToolID);
            // check the tool name
            if (AnStock.UnitPrice != 1.9500m)
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
            Int32 ToolID = 1;

            // invoke the method
            Found = AnStock.Find(ToolID);
            // check the tool name
            if (AnStock.OnSale != false)
            {
                OK = false;
            }

            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // string variable to store any error message
            String Error = "";

            // invoke the method
            Error = AnStock.Valid(ToolName, QuantityInStock, DateAdded, UnitPrice);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");
               
        }

        [TestMethod]
        public void ToolNameMinLessOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // string variable to store any error message
            String Error = "";

            // this should fail
            String ToolName = "";

            // invoke the method
            Error = AnStock.Valid(ToolName, QuantityInStock, DateAdded, UnitPrice);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ToolNameMin()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // string variable to store any error message
            String Error = "";

            // this should pass
            String ToolName = "a";

            // invoke the method
            Error = AnStock.Valid(ToolName, QuantityInStock, DateAdded, UnitPrice);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ToolNameMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // string variable to store any error message
            String Error = "";

            // this should pass
            String ToolName = "aa"; 

            // invoke the method
            Error = AnStock.Valid(ToolName, QuantityInStock, DateAdded, UnitPrice);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ToolNameMaxLessOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // string variable to store any error message
            String Error = "";

            // this should pass
            String ToolName = ""; 
            ToolName = ToolName.PadRight(49, 'a');

            // invoke the method
            Error = AnStock.Valid(ToolName, QuantityInStock, DateAdded, UnitPrice);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ToolNameMax()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // string variable to store any error message
            String Error = "";

            // this should pass            
            String ToolName = "".PadRight(50, 'a');

            // invoke the method
            Error = AnStock.Valid(ToolName, QuantityInStock, DateAdded, UnitPrice);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ToolNameMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // string variable to store any error message
            String Error = "";

            // this should fail
            String ToolName = "";
            ToolName = ToolName.PadRight(51, 'a');

            // invoke the method
            Error = AnStock.Valid(ToolName, QuantityInStock, DateAdded, UnitPrice);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ToolNameMid()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // string variable to store any error message
            String Error = "";

            // this should pass
            String ToolName = "";
            ToolName = ToolName.PadRight(25, 'a');

            // invoke the method
            Error = AnStock.Valid(ToolName, QuantityInStock, DateAdded, UnitPrice);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ToolNameExtremeMax()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // string variable to store any error message
            String Error = "";

            // this should fail
            String ToolName = "";
            ToolName = ToolName.PadRight(500, 'a');

            // invoke the method
            Error = AnStock.Valid(ToolName, QuantityInStock, DateAdded, UnitPrice);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //*********************** DateAdded ***************************
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();

            // string variable to store any error message
            String Error = "";

            // create a variable to store the test date data
            DateTime TestDate = DateTime.Now.Date;
            // change the date to wharever the date is less than 1000
            TestDate = TestDate.AddYears(-1000);

            // this should fail
            String DateAdded = TestDate.ToString();           

            // invoke the method
            Error = AnStock.Valid(ToolName, QuantityInStock, DateAdded, UnitPrice);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



    }
}

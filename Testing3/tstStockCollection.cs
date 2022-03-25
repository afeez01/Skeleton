using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {  
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();

            // test to see that it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            // create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();

            // create some test data to assign to the property
            //  in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();

            // add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();

            // set its properties
            TestItem.ToolID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OnSale = false;
            TestItem.QuantityInStock = 7;
            TestItem.ToolName = "Bosch HSS-R Drill Bit";
            TestItem.UnitPrice = 1.9500m;

            // add the item to the test list
            TestList.Add(TestItem);

            // assign the data to the property
            AllStock.StockList = TestList;

            // test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }
        
        /*
        [TestMethod]
        public void CountPropertyOK()
        {
            // create an instance of the class we want to createg
            clsStockCollection AllStock = new clsStockCollection();

            // create some test data to assign to the property
            Int32 SomeCount = 2;

            // assign data to the property
            AllStock.Count = SomeCount;

            // test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, SomeCount);
        }*/

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            // create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();

            // create some test data to assign to the property
            clsStock TestStock = new clsStock();

            // set its properties
            TestStock.ToolID = 1;
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.OnSale = false;
            TestStock.QuantityInStock = 7;
            TestStock.ToolName = "Bosch HSS-R Drill Bit";
            TestStock.UnitPrice = 1.9500m;

            // assign the data to the property
            AllStock.ThisStock = TestStock;

            // test to see that the two values are same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();

            // create some test data to assign to the property
            //  in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();

            // add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();

            // set its properties
            TestItem.ToolID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OnSale = false;
            TestItem.QuantityInStock = 7;
            TestItem.ToolName = "Bosch HSS-R Drill Bit";
            TestItem.UnitPrice = 1.9500m;

            // add the item to the test list
            TestList.Add(TestItem);

            // assign the data to the property
            AllStock.StockList = TestList;

            // test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        /*
        [TestMethod]
        public void TwoRecordsPresent()
        {
            // create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();

            // test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, 2);
        }*/


        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();

            //create the item of test data
            clsStock TestItem = new clsStock();

            // var to store the primary key
            Int32 PrimaryKey = 0;

            // set its properties
            TestItem.ToolID = 4;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OnSale = false;
            TestItem.QuantityInStock = 17;
            TestItem.ToolName = "Makita DHP453STE 18V 5.0Ah Li-Ion LXT Cordless Combi Drill ";
            TestItem.UnitPrice = 139.99m;

            // set ThisStock to the test data
            AllStock.ThisStock = TestItem;

            // add the record
            PrimaryKey = AllStock.Add();

            // set the primary key of the test data
            TestItem.ToolID = PrimaryKey;

            // find the record
            AllStock.ThisStock.Find(PrimaryKey);

            // test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();

            //create the item of test data
            clsStock TestItem = new clsStock();

            // var to store the primary key
            Int32 PrimaryKey = 0;

            // set its properties
            //TestItem.ToolID = 4;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OnSale = false;
            TestItem.QuantityInStock = 17;
            TestItem.ToolName = "Makita DHP453STE 18V 5.0Ah Li-Ion LXT Cordless Combi Drill ";
            TestItem.UnitPrice = 139.99m;

            // set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            // add the record
            PrimaryKey = AllStock.Add();
            // set the primary key of the test data
            TestItem.ToolID = PrimaryKey;

            // modify the test data
            //TestItem.ToolID = 4;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OnSale = true;
            TestItem.QuantityInStock = 50;
            TestItem.ToolName = "Makita Cordless Combi Drill ";
            TestItem.UnitPrice = 100.99m;
            // set the record based on the new test data
            AllStock.ThisStock = TestItem;

            // update the record
            AllStock.Update();

            // find the record
            AllStock.ThisStock.Find(PrimaryKey);

            // test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();

            //create the item of test data
            clsStock TestItem = new clsStock();

            // var to store the primary key
            Int32 PrimaryKey = 0;

            // set its properties
            TestItem.ToolID = 10;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OnSale = false;
            TestItem.QuantityInStock =29;
            TestItem.ToolName = "Shesto RC36 3.6V Electric Screwdriver, Euro Plug";
            TestItem.UnitPrice = 34.33m;

            // set ThisStock to the test data
            AllStock.ThisStock = TestItem;

            // add the record
            PrimaryKey = AllStock.Add();

            // set the primary key of the test data
            TestItem.ToolID = PrimaryKey;

            // find the record
            AllStock.ThisStock.Find(PrimaryKey);

            // delete the record
            AllStock.Delete();
            // now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);

            // test to see if the record was not found
            Assert.IsFalse(Found);
        }




    }
}

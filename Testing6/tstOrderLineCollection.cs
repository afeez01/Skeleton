using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing6
{
    [TestClass]
    public class tstOrderLineCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrderLine);
        }

        [TestMethod]
        public void OrderLineListOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            //create some data to assign to the property
            //in this case tha data needs to be a list of objects
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //add an item to the list 
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //set its properties

            TestItem.OrderLineID = 1;
            TestItem.OrderID = 1;
            TestItem.ToolID = 53;
            TestItem.Description = "Drill";
            TestItem.OrderLineDate = DateTime.Now.Date;
            TestItem.OrderLineConfirmed = true;

            //add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllOrderLine.OrderLineList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllOrderLine.OrderLineList, TestList);

        }

        [TestMethod]
        public void ThisOrderLinePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            //create some test data to assign to the property
            clsOrderLine TestOrder = new clsOrderLine();
            //set the properties of the test object

            TestOrder.OrderLineID = 1;
            TestOrder.OrderID = 1;
            TestOrder.ToolID = 53;
            TestOrder.Description = "Drill";
            TestOrder.OrderLineDate = DateTime.Now.Date;
            TestOrder.OrderLineConfirmed = true;
            //assign the data to the property
            AllOrderLine.ThisOrderLine = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLine.ThisOrderLine, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //add an item to the list
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //set the properties of the test object

            TestItem.OrderLineID = 1;
            TestItem.OrderID = 1;
            TestItem.ToolID = 53;
            TestItem.Description = "Drill";
            TestItem.OrderLineDate = DateTime.Now.Date;
            TestItem.OrderLineConfirmed = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property

            AllOrderLine.OrderLineList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLine.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderLineConfirmed = true;
            TestItem.OrderLineID = 2;
            TestItem.OrderID = 2;
            TestItem.ToolID = 57;
            TestItem.Description = "hammer";
            TestItem.OrderLineDate = DateTime.Now.Date;
            //set ThisOrder to the test data
            AllOrderLine.ThisOrderLine = TestItem;
            //add the record
            PrimaryKey = AllOrderLine.Add();
            //set the primary key of the test data
            TestItem.OrderLineID = PrimaryKey;
            //find the record
            AllOrderLine.ThisOrderLine.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLine.ThisOrderLine, TestItem);


        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderLineConfirmed = true;
            TestItem.OrderLineID = 1;
            TestItem.OrderID = 1;
            TestItem.ToolID = 53;
            TestItem.Description = "Drill";
            TestItem.OrderLineDate = DateTime.Now.Date;

            //set ThisOrder to the test data
            AllOrderLine.ThisOrderLine = TestItem;
            //add the record
            PrimaryKey = AllOrderLine.Add();
            //set the primary key of the test data
            TestItem.OrderLineID = PrimaryKey;
            //modify the test data
            TestItem.OrderLineConfirmed = false;
            TestItem.OrderLineID = 3;
            TestItem.OrderID = 3;
            TestItem.ToolID = 59;
            TestItem.Description = "ladder";
            TestItem.OrderLineDate = DateTime.Now.Date;
            //set the record based on the new test data
            AllOrderLine.ThisOrderLine = TestItem;
            //update the record
            AllOrderLine.Update();
            //find the record
            AllOrderLine.ThisOrderLine.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrderLine.ThisOrderLine, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //vare to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderLineConfirmed = true;
            TestItem.OrderLineID = 1;
            TestItem.OrderID = 1;
            TestItem.ToolID = 53;
            TestItem.Description = "Drill";
            TestItem.OrderLineDate = DateTime.Now.Date;

            //set ThisOrder to the test data
            AllOrderLine.ThisOrderLine = TestItem;
            //add the record
            PrimaryKey = AllOrderLine.Add();
            //set the primary key of the test data
            TestItem.OrderLineID = PrimaryKey;
            //find the record
            AllOrderLine.ThisOrderLine.Find(PrimaryKey);
            //delete the record
            AllOrderLine.Delete();
            //now find the record
            Boolean Found = AllOrderLine.ThisOrderLine.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByDescriptionMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            //create an instance of the filtered data
            clsOrderLineCollection FilteredOrderLine = new clsOrderLineCollection();
            //apply a blank string(should return all records);
            FilteredOrderLine.ReportByDescription("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLine.Count, FilteredOrderLine.Count);


        }
        [TestMethod]
        public void ReportByDescriptionNoneFound()
        {
            //create an instance of the filtered data
            clsOrderLineCollection FilteredOrderLine = new clsOrderLineCollection();
            //apply a shipping address that does not exist
            FilteredOrderLine.ReportByDescription("ttttt");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrderLine.Count);
        }
        [TestMethod]
        public void ReportByDescriptionTestDataFound()
        {
            //create an instance of the filtered data
            clsOrderLineCollection FilteredOrderLine = new clsOrderLineCollection();

            //var to store outcome
            Boolean OK = true;
            //apply a shipping address that does not exist
            FilteredOrderLine.ReportByDescription("wrench");
            //check that the correct number of records are found
            if (FilteredOrderLine.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredOrderLine.OrderLineList[0].OrderLineID != 6)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredOrderLine.OrderLineList[1].OrderLineID != 7)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
    

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing4
{

    [TestClass]
    public class tstOrderCollection
    {
       

        [TestMethod]
       public void InstanceOK()
        {
            //create an instance of the class we want to create
         clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
       Assert.IsNotNull(AllOrders);
     }

       [TestMethod]
       public void OrderListOK()
        {
            //create an instance of the class we want to create
           clsOrderCollection AllOrders = new clsOrderCollection();
            //create some data to assign to the property
            //in this case tha data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list 
            //create the item of test data
           clsOrder TestItem = new clsOrder();
            //set its properties
            
            TestItem.OrderId = 1;
            TestItem.CustomerId = 232335;
            TestItem.ShippingAddress = "Madeira"; 
            TestItem.OrderDate = DateTime.Now.Date;
           TestItem.OrderEmail = "andreiamartins@gmail.com";
           TestItem.OrderCompleted = true;
            
           //add the item to the test list
           TestList.Add(TestItem);
          // assign the data to the property
          AllOrders.OrderList = TestList;
           // test to see that the two values are the same
           Assert.AreEqual(AllOrders.OrderList, TestList);

     }
    
       [TestMethod]
       public void ThisOrderPropertyOK()
      {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
           clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            
            TestOrder.OrderId = 1;
           TestOrder.CustomerId = 137;
            TestOrder.ShippingAddress = "Madeira";
           TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.OrderEmail = "andreiamartins@gmail.com"; 
            TestOrder.OrderCompleted = true;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
       [TestMethod]
       public void ListAndCountOK()
       {
            //create an instance of the class we want to create
           clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
          List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
           clsOrder TestItem = new clsOrder();
            //set the properties of the test object
         
          TestItem.OrderId = 1;
            TestItem.CustomerId = 137;
            TestItem.ShippingAddress = "Madeira";
           TestItem.OrderEmail = "andreiamartins@gmail.com";
            TestItem.OrderDate = DateTime.Now.Date;  
           TestItem.OrderCompleted = true;
            //add the item to the test list
           TestList.Add(TestItem);
            //assign the data to the property

           AllOrders.OrderList = TestList;
           //test to see that the two values are the same
          Assert.AreEqual(AllOrders.Count, TestList.Count);
       }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderCompleted = true;
            TestItem.OrderId = 8;
            TestItem.CustomerId = 146;
            TestItem.ShippingAddress = "Poland";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderEmail = "joaoroberto@gmail.com";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);


        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderCompleted = true;
            TestItem.CustomerId = 137;
            TestItem.OrderId = 1;
            TestItem.ShippingAddress = "Madeira";
            TestItem.OrderEmail = "andreiamartins@gmail.com";
            TestItem.OrderDate = DateTime.Now.Date;

            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //modify the test data
            TestItem.OrderCompleted = false;
            TestItem.CustomerId = 2;
            TestItem.ShippingAddress = "Nigeria";
            TestItem.OrderEmail = "joanamaria@gmail.com";
            TestItem.OrderDate = DateTime.Now.Date;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
 }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //vare to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderCompleted = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 137;
            TestItem.ShippingAddress = "Madeira";
            TestItem.OrderEmail = "andreiamartins@gmail.com";
            TestItem.OrderDate = DateTime.Now.Date;

            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByShippingAddressMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string(should return all records);
            FilteredOrders.ReportByShippingAddress("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);


        }
        [TestMethod]
        public void ReportByShippingAddressNoneFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a shipping address that does not exist
            FilteredOrders.ReportByShippingAddress("ttttt");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByShippingAddressTestDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            //var to store outcome
            Boolean OK = true;
            //apply a shipping address that does not exist
            FilteredOrders.ReportByShippingAddress("ddddd");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredOrders.OrderList[0].OrderId != 20)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredOrders.OrderList[1].OrderId != 21)
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
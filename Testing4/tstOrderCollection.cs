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
           TestOrder.CustomerId = 232335;
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
            TestItem.CustomerId = 232335;
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
            TestItem.CustomerId = 232445;
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
    }
}
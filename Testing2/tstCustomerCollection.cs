using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create instance of class collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exist 
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerList()
        {
            //create instance of class collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create tesat data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //create item to test Data 
            clsCustomer TestItem = new clsCustomer();
            //set properties 
            TestItem.CustomerID = 1;
            TestItem.CustomerDetails = "Bob Marley";
            TestItem.DateOfBirth = Convert.ToDateTime("16/09/1992");
            TestItem.EmailAddress = "bobmarley@gmail.com";
            TestItem.AccountBalance = 50;
            TestItem.OrderProcess = true;
            //add test item to list 
            TestList.Add(TestItem);
            //assign data to property 
            AllCustomers.CustomerList = TestList;
            //test to see that it exist 
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create instance of class collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create tesat data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //create item to test Data 
            clsCustomer TestItem = new clsCustomer();
            //set properties 
            TestItem.CustomerID = 2;
            TestItem.CustomerDetails = "Rachel Silver";
            TestItem.DateOfBirth = Convert.ToDateTime("17/04/1997");
            TestItem.EmailAddress = "rachelsilver@gmail.com";
            TestItem.AccountBalance = 150;
            TestItem.OrderProcess = true;
            //add test item to list 
            TestList.Add(TestItem);
            //assign data to property 
            AllCustomers.CustomerList = TestList;
            //test to see that it exist 
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

   

    }



    }
  



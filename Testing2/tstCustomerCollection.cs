using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        public bool Found { get; private set; }

        [TestMethod]
        public void InstanceOK()
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
            TestItem.CustomerID = 21;
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
        public void ThisCustomerPropertyOK()
        {
            //create instance of class collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create tesat data to assign to the property
            //in this case the data needs to be a list of objects
            
            //create item to test Data 
            clsCustomer TestItem = new clsCustomer();
            //set properties 
            TestItem.CustomerID = 21;
            TestItem.CustomerDetails = "Bob Marley";
            TestItem.DateOfBirth = Convert.ToDateTime("16/09/1992");
            TestItem.EmailAddress = "bobmarley@gmail.com";
            TestItem.AccountBalance = 50;
            TestItem.OrderProcess = true;
            //assign data to property 
            AllCustomers.ThisCustomer = TestItem;
            //test to see that it exist 
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
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
            TestItem.CustomerID = 21;
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
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of class collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create item to test Data 
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set properties 
            TestItem.CustomerID = 21;
            TestItem.CustomerDetails = "Bob Marley";
            TestItem.DateOfBirth = Convert.ToDateTime("16/09/1992");
            TestItem.EmailAddress = "bobmarley@gmail.com";
            TestItem.AccountBalance = 50;
            TestItem.OrderProcess = true;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //ADD THE record
            PrimaryKey = AllCustomers.Add();
            //set primary key of test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance of class collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create item to test Data 
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set properties 
            TestItem.CustomerID = 21;
            TestItem.CustomerDetails = "Bob Marley";
            TestItem.DateOfBirth = Convert.ToDateTime("16/09/1992");
            TestItem.EmailAddress = "bobmarley@gmail.com";
            TestItem.AccountBalance = 50;
            TestItem.OrderProcess = true;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //ADD THE record
            PrimaryKey = AllCustomers.Add();
            //set primary key of test data
            TestItem.CustomerID = PrimaryKey;
            //modify test data
            TestItem.CustomerDetails = "Bobby brown";
            TestItem.DateOfBirth = Convert.ToDateTime("16/09/1992");
            TestItem.EmailAddress = "bobbyBrown@gmail.com";
            TestItem.AccountBalance = 500;
            TestItem.OrderProcess = false;
            //set record based on new set data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //create instance of class collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create item to test Data 
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set properties 
            TestItem.CustomerID = 20;
            TestItem.CustomerDetails = "Add Name";
            TestItem.DateOfBirth = Convert.ToDateTime("1995-05-05");
            TestItem.EmailAddress = "addname@gmail.com";
            TestItem.AccountBalance = 40;
            TestItem.OrderProcess = true;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            
            
            //ADD THE record
            PrimaryKey = AllCustomers.Add();
            //set primary key of test data
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //update the record
            AllCustomers.Delete();
            //test to see that the two values are the same
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        public void ReportByCustomerDetailsMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            FilteredCustomers.ReportByCustomerDetails("");

            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerDetailsNoneFound()
        {
            //create instance of class collection
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByCustomerDetails("xxx xxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

    }



}
  



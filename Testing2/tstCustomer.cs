using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            
            Assert.IsNotNull(AnCustomer);
        }


        [TestMethod]
        public void CustomerIdOK()

        {
            clsCustomer AnCustomer = new clsCustomer();
            Int16 TestData = 1;
            AnCustomer.CustomerID = TestData;
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void DateOfBirthOK()

        {
            clsCustomer AnCustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            AnCustomer.DOB = TestData;
            Assert.AreEqual(AnCustomer.DOB, TestData);
        }

        [TestMethod]
        public void EmailAddressOK()

        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "toolsunited@gmail.com";
            AnCustomer.EmailAddress = TestData;
            Assert.AreEqual(AnCustomer.EmailAddress, TestData);
        }

        [TestMethod]
        public void CustomerDetailsOK()

        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "bob marley";
            AnCustomer.CustomerDetails = TestData;
            Assert.AreEqual(AnCustomer.CustomerDetails, TestData);
        }

        [TestMethod]
        public void AccountBalanceOK()

        {
            clsCustomer AnCustomer = new clsCustomer();
            decimal TestData = 1;
            AnCustomer.AccountBalance = TestData;
            Assert.AreEqual(AnCustomer.AccountBalance, TestData);
        }

        [TestMethod]
        public void OrderProcessOK()

        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean TestData = true;
            AnCustomer.OrderProcess = TestData;
            Assert.AreEqual(AnCustomer.OrderProcess, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //test to see if result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to record if data is valid
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer id
            if (AnCustomer.CustomerID != 21)
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void DateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.DOB != Convert.ToDateTime("16/09/2016"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailAddressound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to record if data is valid
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer id
            if (AnCustomer.EmailAddress != "testemail@customer.com")
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerDetailsFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to record if data is valid
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer id
            if (AnCustomer.CustomerDetails != "Test Name")
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAccountBalanceFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to record if data is valid
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer id
            if (AnCustomer.AccountBalance != 41)
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderProcessFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to record if data is valid
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer id
            if (AnCustomer.OrderProcess != true)
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(Found);
        }

    }
}

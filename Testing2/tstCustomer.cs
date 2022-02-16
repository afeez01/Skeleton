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
    }
}

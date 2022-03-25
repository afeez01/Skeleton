using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {

        //test data

        String DateOfBirth = "16/09/1992";
        String EmailAddress= "bobmarley@gmail.com";
        String CustomerDetails = "Bob Marley";
        String AccountBalance = "50";











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
            AnCustomer.DateOfBirth = TestData;
            Assert.AreEqual(AnCustomer.DateOfBirth, TestData);
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
            string TestData = "Bob Marley";
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
            Int32 CustomerID = 2;
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
            Int32 CustomerID = 2;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer id
            if (AnCustomer.CustomerID != 2)
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
            Int32 CustomerID = 2;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.DateOfBirth != Convert.ToDateTime("10/10/2001"))
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
            Int32 CustomerID = 2;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer id
            if (AnCustomer.EmailAddress != "benten@gmail.com")
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
            Int32 CustomerID = 2;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer id
            if (AnCustomer.CustomerDetails != "Ben 10")
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
            Int32 CustomerID = 2;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer id
            if (AnCustomer.AccountBalance != 10)
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
            Int32 CustomerID = 2;
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






        /*
         * Validation Method 
         */
        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }



        /*
         *
         *Email Address VALIDATION
         *
         */
        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change date to extreme date -150
            TestDate = TestDate.AddYears(-150);
            //Set dat of birth
            String DateOfBirth = TestDate.ToString();
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change date to extreme date -150
            TestDate = TestDate.AddYears(-101);
            //Set date of birth
            String DateOfBirth = TestDate.ToString();
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateOfBirthMin()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change date to extreme date -150
            TestDate = TestDate.AddYears(-100);
            //Set date of birth
            String DateOfBirth = TestDate.ToString();
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthPlusOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change date to extreme date -150
            TestDate = TestDate.AddYears(-99);
            //Set date of birth
            String DateOfBirth = TestDate.ToString();
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMid()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change date to extreme date -150
            TestDate = TestDate.AddYears(-50);
            //Set date of birth
            String DateOfBirth = TestDate.ToString();
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxLessOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change date to extreme date -150
            TestDate = TestDate.AddYears(-19);
            //Set date of birth
            String DateOfBirth = TestDate.ToString();
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-18);
            //Set date of birth
            String DateOfBirth = TestDate.ToString();
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change date to extreme date -150
            TestDate = TestDate.AddYears(-17);
            //Set date of birth
            String DateOfBirth = TestDate.ToString();
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change date to extreme date -150
            TestDate = TestDate.AddYears(+10);
            //Set date of birth
            String DateOfBirth = TestDate.ToString();
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidDate()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //Input that is not date 
            String DateOfBirth = "This is not a date";
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }


        /*
         *
         *Customer Details VALIDATION
         *
         */
        [TestMethod]
        public void CustomerDetailsMinLessOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String CustomerDetails = ""; // this will trigger error
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDetailsMin()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String CustomerDetails = "a"; // this will trigger error
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDetailsMinPlusOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            // this will trigger error
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDetailsMid()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String CustomerDetails = "aaaaaaaaaaaaaaaaaaaaaaaaa"; // this will trigger error
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDetailsMaxLessOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String CustomerDetails = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // this will trigger error
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDetailsMax()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String CustomerDetails = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDetailsMaxPlusOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String CustomerDetails = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDetailsExtremeMax()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String CustomerDetails = "";
            CustomerDetails = CustomerDetails.PadRight(100, 'a'); // this will trigger error
            //invoke method
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        /*
         *
         *Email Address VALIDATION
         *
         */
        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String EmailAddress= ""; // this will trigger error
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMin()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String EmailAddress = "a"; // this will trigger error
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String EmailAddress = "aa"; // this will trigger error
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String EmailAddress = ""; // this will trigger error
            EmailAddress = EmailAddress.PadRight(25, 'a');
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String EmailAddress = ""; // this will trigger error
            EmailAddress = EmailAddress.PadRight(49, 'a');
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String EmailAddress = ""; // this will trigger error
            EmailAddress = EmailAddress.PadRight(51, 'a');
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String EmailAddress = ""; // this will trigger error
            EmailAddress = EmailAddress.PadRight(100, 'a');
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }


        /*
         *
         * ACCOUNT BALANCE 
         * 
         */

        [TestMethod]
        public void AccountBalanceLessOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String AccountBalance = "-1";
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountBalanceMin()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String AccountBalance = "1";
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountBalanceMinPlusOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String AccountBalance = "2";
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountBalanceMid()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String AccountBalance = "500";
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountBalanceMaxLessOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String AccountBalance = "999";
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountBalanceMaxPlusOne()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String AccountBalance = "1001";
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountBalanceExtremeMax()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String AccountBalance = "2000";
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountBalanceInvalidDate()
        {
            clsCustomer Ancustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String AccountBalance = "This is not a decimal";
            //Invoke the method 
            Error = Ancustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

    }
}

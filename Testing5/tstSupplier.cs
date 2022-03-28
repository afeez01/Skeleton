using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        //Test data

        string SupplierId = "21";
        string Name = "Factory";
        string Address = "Industry ST";
        Boolean GlobalSupplier  = true;
        string DateAdded = "21/02/2020";
        string Feedback = "1";

         [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //test to see that it exists
            Assert.IsNotNull(ASupplier);
        }

        [TestMethod]
        public void SupplierIdOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //create some test data to assign to the property
            Int16 TestData = 1;

            //assign the data to the property
            ASupplier.SupplierId = TestData;

            //test to see the two values are the same
            Assert.AreEqual(ASupplier.SupplierId, TestData);

        }
        [TestMethod]
        public void NameOK()
        {
            //create a new instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //creat some test data to assign to the property
            string TestData = "Factory";

            //assign the data to the property   
            ASupplier.Name = TestData;

            //test to see the two values are the same
            Assert.AreEqual(ASupplier.Name, TestData);

        }
        [TestMethod]
        public void AddressOK()
        {
            //create a new instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //creat some test data to assign to the property
            string TestData = "Industry ST";

            //assign the data to the property   
            ASupplier.Address = TestData;

            //test to see the two values are the same
            Assert.AreEqual(ASupplier.Address, TestData);

        }
        [TestMethod]
        public void DateAddedOK()
        {
            //create a new instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //creat some test data to assign to the property
            DateTime TestData = Convert.ToDateTime("21 / 02 / 2020");

            //assign the data to the property   
            ASupplier.DateAdded = TestData;

            //test to see the two values are the same
            Assert.AreEqual(ASupplier.DateAdded, TestData);

        }
        [TestMethod]
        public void GlobalSupplierOK()
        {
            //create a new instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //creat some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property   
            ASupplier.GlobalSupplier = TestData;

            //test to see the two values are the same
            Assert.AreEqual(ASupplier.GlobalSupplier, TestData);

        }
        [TestMethod]
        public void FeedbackOK()
        {
            //create a new instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //creat some test data to assign to the property
            decimal TestData = 4;

            //assign the data to the property   
            ASupplier.Feedback = TestData;

            //test to see the two values are the same
            Assert.AreEqual(ASupplier.Feedback, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create a new instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //Variable to store results of validation
            Boolean Found = false;

            //creat some test data to assign to the method
            Int32 SupplierId = 21;

            //assign the data to the property   
            Found = ASupplier.Find(SupplierId);

            //test to see if the result is found
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void testSupplierNoFound()
        {
            //create a new instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //Variable to store results of validation
            Boolean Found = false;

            //Variable to store results of validation
            Boolean ok = true;

            //creat some test data to assign to the method
            Int32 SupplierId = 21;

            //invoke method    
            Found = ASupplier.Find(SupplierId);

            //check SupplierId
            if (ASupplier.SupplierId != 21)
            {
                ok = false;
            }

            //test to see if the result is correct
            Assert.IsTrue(ok);

        }
        [TestMethod]
        public void testDateAddedFound()
        {
            //create a new instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //Variable to store results of validation
            Boolean Found = false;

            //Variable to store results of validation
            Boolean ok = true;

            //creat some test data to assign to the method
            Int32 SupplierId = 21;

            //invoke method    
            Found = ASupplier.Find(SupplierId);

            //check Property
            if (ASupplier.DateAdded != Convert.ToDateTime("21/02/2020"))
            {
                ok = false;
            }

            //test to see if the result is correct
            Assert.IsTrue(ok);

        }
        [TestMethod]
        public void testAddressFound()
        {
            //create a new instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //Variable to store results of validation
            Boolean Found = false;

            //Variable to store results of validation
            Boolean ok = true;

            //creat some test data to assign to the method
            Int32 SupplierId = 21;

            //invoke method    
            Found = ASupplier.Find(SupplierId);

            //check Property
            if (ASupplier.Address != "Industry ST")
            {
                ok = false;
            }

            //test to see if the result is correct
            Assert.IsTrue(ok);

        }
        [TestMethod]
        public void testNameFound()
        {
            //create a new instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //Variable to store results of validation
            Boolean Found = false;

            //Variable to store results of validation
            Boolean ok = true;

            //creat some test data to assign to the method
            Int32 SupplierId = 21;

            //invoke method    
            Found = ASupplier.Find(SupplierId);

            //check Property
            if (ASupplier.Name != "Factory")
            {
                ok = false;
            }

            //test to see if the result is correct
            Assert.IsTrue(ok);

        }
        [TestMethod]
        public void testGlobalSupplierFound()
        {
            //create a new instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //Variable to store results of validation
            Boolean Found = false;

            //Variable to store results of validation
            Boolean ok = true;

            //creat some test data to assign to the method
            Int32 SupplierId = 21;

            //invoke method    
            Found = ASupplier.Find(SupplierId);

            //check Property
            if (ASupplier.GlobalSupplier != true)
            {
                ok = false;
            }

            //test to see if the result is correct
            Assert.IsTrue(ok);

        }
        [TestMethod]
        public void testFeedbackFound()
        {
            //create a new instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //Variable to store results of validation
            Boolean Found = false;

            //Variable to store results of validation
            Boolean ok = true;

            //creat some test data to assign to the method
            Int32 SupplierId = 21;

            //invoke method    
            Found = ASupplier.Find(SupplierId);

            //check Property
            if (ASupplier.Feedback != 1)
            {
                ok = false;
            }

            //test to see if the result is correct
            Assert.IsTrue(ok);

        }
        [TestMethod]
        public void testValidMethodOK()
        {
            //create a new instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //string for errors
            string Error = "";

            //invoke method
            Error = ASupplier.Valid(Name, Address, DateAdded, Feedback);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Limits validation

        //***********Name

        [TestMethod]
        public void NameMinMinus1()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to see the result
            String Name = ""; // this will fail
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to pass test
            String Name = "A"; // this will pass
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMinPlus1()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to see the result
            String Name = "AA"; // this will pass
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxMinus1()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to see the result
            String Name = ""; 
            Name = Name.PadLeft(49, '*');// this will pass
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void NameMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to see the result
            String Name = "";
            Name = Name.PadLeft(50, '*');// this will pass
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxPlus1()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to see the result
            String Name = "";
            Name = Name.PadLeft(51, '*');// this will fail
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to see the result
            String Name = "";
            Name = Name.PadLeft(25, '*');// this will pass
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to see the result
            String Name = "";
            Name = Name.PadLeft(700, '*');// this will fail
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }

        //**********Address

        [TestMethod]
        public void AddressMinMinus1()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to see the result
            String Address = ""; // this will fail
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to pass test
            String Address = "A"; // this will pass
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlus1()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to see the result
            String Address = "AA"; // this will pass
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxMinus1()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to see the result
            String Address = "";
            Address = Address.PadLeft(49, '*');// this will pass
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to see the result
            String Address = "";
            Address = Address.PadLeft(50, '*');// this will pass
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlus1()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to see the result
            String Address = "";
            Address = Address.PadLeft(51, '*');// this will fail
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to see the result
            String Address = "";
            Address = Address.PadLeft(25, '*');// this will pass
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            //String to store the error
            String Error = "";
            //create some test to see the result
            String Address = "";
            Address = Address.PadLeft(700, '*');// this will fail
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }

        //******Date Added
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //create a date to test on  
            DateTime TestDate;
            //make test date today
            TestDate = DateTime.Now.Date;
            //Make test date 100 years in the past
            TestDate = TestDate.AddYears(-100);
            //Convert the test date to a string
            string DateAdded = TestDate.ToString();
            //Invoke the method
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinMinus1()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //create a date to test on  
            DateTime TestDate;
            //make test date today
            TestDate = DateTime.Now.Date;
            //Make test date 1 year in the past
            TestDate = TestDate.AddYears(-1);
            //Convert the test date to a string
            string DateAdded = TestDate.ToString();
            //Invoke the method
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedTODAY()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //create a date to test on  
            DateTime TestDate;
            //make test date today
            TestDate = DateTime.Now.Date;
            //Convert the test date to a string
            string DateAdded = TestDate.ToString();
            //Invoke the method
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual(Error, "");
        }
        public void DateAddedMaxPlus1()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //create a date to test on  
            DateTime TestDate;
            //make test date today
            TestDate = DateTime.Now.Date;
            //Make test date 1 year in the past
            TestDate = TestDate.AddYears(1);
            //Convert the test date to a string
            string DateAdded = TestDate.ToString();
            //Invoke the method
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //create a date to test on  
            DateTime TestDate;
            //make test date today
            TestDate = DateTime.Now.Date;
            //Make test date 100 years in the past
            TestDate = TestDate.AddYears(100);
            //Convert the test date to a string
            string DateAdded = TestDate.ToString();
            //Invoke the method
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalid()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //Convert the test date to a string
            string DateAdded = "*";
            //Invoke the method
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }

        //**********Feedback

         [TestMethod]
        public void FeedbackMinMinus1()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //create some test to see the result
            String Feedback = "-0.1";
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FeedbackExtremeMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //create some test to see the result
            String Feedback = "-99";
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FeedbackMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //create some test to see the result
            String Feedback = "0.0";
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FeedbackMinPlus1()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //create some test to see the result
            String Feedback = "0.1";
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FeedbackMaxMinus1()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //create some test to see the result
            String Feedback = "4.9";
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FeedbackMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //create some test to see the result
            String Feedback = "5.0";
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FeedbackMaxPlus1()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //create some test to see the result
            String Feedback = "5.1";
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FeedbackMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //create some test to see the result
            String Feedback = "2.5";
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FeedbackExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //create some test to see the result
            String Feedback = "99";
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FeedbackInv()
        {
            clsSupplier ASupplier = new clsSupplier();
            //string to store the error
            String Error = "";
            //create some test to see the result
            String Feedback = "*";
            //Invoke the method 
            Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
            //Test to see if the results are the expected
            Assert.AreNotEqual(Error, "");
        }
    }
}


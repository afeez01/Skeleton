using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass to the method
        string FullName = "Uways Sidat";
        string Salary = "30000";
        string DateAdded = DateTime.Now.Date.ToString();
        string Address = "123 Some Street";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 3;
            //assign the data to the property
            AnStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);
        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Uways Sidat";
            //assign the data to the property
            AnStaff.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.FullName, TestData);
        }

        [TestMethod]
        public void SalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            double TestData = 12345.67;
            //assign the data to the property
            AnStaff.Salary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Salary, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.DateAdded, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "123 This Street";
            //assign the data to the property
            AnStaff.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Address, TestData);
        }

        [TestMethod]
        public void PermanentEmploymentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.PermanentEmployment = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.PermanentEmployment, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.StaffId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFullNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.FullName != "Uways Sidat")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Salary != 30000.00)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.DateAdded != Convert.ToDateTime("2002-07-03"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Address != "123 Some Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPermanentEmploymentFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.PermanentEmployment != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = ""; //this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void FullNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "";
            FullName = FullName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Salary = "-1000000000000";
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Salary = "-0.01";
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void SalaryMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Salary = "0"; 
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Salary = "0.01"; 
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Salary = "This is not a salary!"; 
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateAdded = "This is not a date!";
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "a";
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "aa";
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            Address = Address.PadRight(51, 'a');
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }

}

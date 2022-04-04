using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffId = 1;
            TestItem.FullName = "Uways Sidat";
            TestItem.Salary = 30000;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Address = "123 Some Street";
            TestItem.PermanentEmployment = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
            //create an instance of the class we want to create
            //clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //Int32 SomeCount = 2;
            //assign the data to the property
            //AllStaff.Count = SomeCount;
            //test to see that the two values are the same
            //Assert.AreEqual(AllStaff.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.StaffId = 1;
            TestStaff.FullName = "Uways Sidat";
            TestStaff.Salary = 30000;
            TestStaff.DateAdded = DateTime.Now.Date;
            TestStaff.Address = "123 Some Street";
            TestStaff.PermanentEmployment = true;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffId = 1;
            TestItem.FullName = "Uways Sidat";
            TestItem.Salary = 30000;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Address = "123 Some Street";
            TestItem.PermanentEmployment = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
            //create an instance of the class we want to create
            //clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that the two values are the same
            //Assert.AreEqual(AllStaff.Count, 2);
        //}


    }
}

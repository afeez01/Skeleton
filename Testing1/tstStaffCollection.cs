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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffId = 6;
            TestItem.FullName = "Wayne Rooney";
            TestItem.Salary = 300000;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Address = "9 Some Street";
            TestItem.PermanentEmployment = true;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FullName = "Wayne Rooney";
            TestItem.Salary = 300000;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Address = "9 Some Street";
            TestItem.PermanentEmployment = true;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //modify the test data
            TestItem.FullName = "Wayne Rooney";
            TestItem.Salary = 350000;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Address = "99 Some Street";
            TestItem.PermanentEmployment = true;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffId = 6;
            TestItem.FullName = "Wayne Rooney";
            TestItem.Salary = 300000;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Address = "9 Some Street";
            TestItem.PermanentEmployment = true;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFullNameOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaff.ReportByFullName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByFullNameNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a full name that does not exist
            FilteredStaff.ReportByFullName("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByFullNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a full name that doesn't exist
            FilteredStaff.ReportByFullName("Wayne Rooney 1");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first record is ID 9
                if (FilteredStaff.StaffList[0].StaffId != 139)
                {
                    OK = false;
                }
                //check that the second record is ID 12
                if (FilteredStaff.StaffList[1].StaffId != 140)
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

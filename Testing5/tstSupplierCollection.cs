using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    {
        //Test data

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();

            //test to see that it exists
            Assert.IsNotNull(AllSuppliers);
        }
        [TestMethod]
        public void SupplierListOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();

            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierId = 1;
            TestItem.DateAdded = DateTime.Today;
            TestItem.Name = "Tool Shop";
            TestItem.Address = "Industry ST";
            TestItem.GlobalSupplier = true;
            TestItem.Feedback = 1;
            //add test item to test list
            TestList.Add(TestItem);
            //assing the value to the class
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }
        /*[TestMethod]
        public void CountPropertyOk()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //teste data
            int SomeCount = 1;
            AllSuppliers.Count = SomeCount;
            //test to see if the values are the same
            Assert.AreEqual(AllSuppliers.Count, SomeCount);
        }
        */
        [TestMethod]
        public void ThisSupplierPropertyOk()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //test data
            clsSupplier TestItem = new clsSupplier();
            //set properties
            TestItem.SupplierId = 1;
            TestItem.DateAdded = DateTime.Today;
            TestItem.Name = "Tool Shop";
            TestItem.Address = "Industry ST";
            TestItem.GlobalSupplier = true;
            TestItem.Feedback = 1;
            //assing the value to the supplier
            AllSuppliers.ThisSupplier = TestItem;

        }
        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //test data
            clsSupplier TestItem = new clsSupplier();
            List<clsSupplier> TestList = new List<clsSupplier>();
            TestItem.SupplierId = 1;
            TestItem.DateAdded = DateTime.Today;
            TestItem.Name = "Tool Shop";
            TestItem.Address = "Industry ST";
            TestItem.GlobalSupplier = true;
            TestItem.Feedback = 1;
            //add item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSuppliers.SupplierList = TestList;
            //test to see if the values are the same
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);


        }
         [TestMethod]
         public void AddMethodOk()
         {
             //create an instance of the class we want to create
             clsSupplierCollection AllSuppliers = new clsSupplierCollection();
             //test data
             clsSupplier TestItem = new clsSupplier();
             //Var to store primary key
             int PrimaryKey = 0;
            //set properties
            TestItem.SupplierId = 6;
            TestItem.DateAdded = DateTime.Today;
             TestItem.Name = "Tool Shop";
             TestItem.Address = "Industry ST";
             TestItem.GlobalSupplier = true;
             TestItem.Feedback = 1.0m;
             //set ThisSupplier to the test data
             AllSuppliers.ThisSupplier = TestItem;
             //add the record
             PrimaryKey = AllSuppliers.Add();
             //set primary key to test data
             TestItem.SupplierId = PrimaryKey;
             //find record
             AllSuppliers.ThisSupplier.Find(PrimaryKey);
             //test to see if the values match
             Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);


         }
        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //test data
            clsSupplier TestItem = new clsSupplier();
            //Var to store primary key
            int PrimaryKey = 0;
            //set properties
            TestItem.DateAdded = DateTime.Today;
            TestItem.Name = "Tool Shop";
            TestItem.Address = "Industry ST";
            TestItem.GlobalSupplier = true;
            TestItem.Feedback = 1.0m;
            //set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set primary key to test data
            TestItem.SupplierId = PrimaryKey;
            //modefy test data
            TestItem.DateAdded = DateTime.Today;
            TestItem.Name = "Tool Shop2";
            TestItem.Address = "Industry ST2";
            TestItem.GlobalSupplier = false;
            TestItem.Feedback = 5.0m;
            AllSuppliers.ThisSupplier = TestItem;
            //update record
            AllSuppliers.Update();
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //test data
            clsSupplier TestItem = new clsSupplier();
            //Var to store primary key
            int PrimaryKey = 0;
            //set properties
            TestItem.DateAdded = DateTime.Today;
            TestItem.Name = "Tool Shop";
            TestItem.Address = "Industry ST";
            TestItem.GlobalSupplier = true;
            TestItem.Feedback = 1.0m;
            //set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set primary key to test data
            TestItem.SupplierId = PrimaryKey;
            //find record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //delete record
            AllSuppliers.Delete();

           Boolean Found =  AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void FilterByNameMethodOk()
        {
            //create an instance of the class with unfiltered data
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create an instance of the class with filtered data
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportByName("");
            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);
        }
        [TestMethod]
        public void ReportBySupplierName0Found()
        {
            // create an instance of the class of filtered data
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();

            // apply a tool name that does not exist
            FilteredSuppliers.ReportByName("sdaasew");
            // test to see that the two values are the same
            Assert.AreEqual(0, FilteredSuppliers.Count);

        }
        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            // create an instance of the class of filtered data
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();

            // var to store outcome
            Boolean OK = true;

            // apply a name from the database  which has more than one occurrence
            FilteredSuppliers.ReportByName("Factory");
            // check that the correct number of records are found
            if (FilteredSuppliers.Count == 2)
            {
                // check that the first record is ID 21
                if (FilteredSuppliers.SupplierList[0].SupplierId != 21)
                {
                    OK = false;
                }

                // check that the second record is ID 31
                if (FilteredSuppliers.SupplierList[1].SupplierId != 31)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            // test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}

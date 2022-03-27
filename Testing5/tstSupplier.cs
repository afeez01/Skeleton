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
            if (ASupplier.DateAdded != Convert.ToDateTime("16/09/2015"))
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
            if (ASupplier.Name != "Tool Factory")
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
    }
}


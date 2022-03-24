using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        //Test data

        string SupplierId = "0500";
        string Name = "Tool Factory"
        string Address = "Tool Factory, Industry ST";
        Boolean GlobalSupplier  = true;
        string DateAdded = "21/02/2020"
        string Feedback = "4.2"

         [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clSupplier ASupplier = new clsSuppplier();

            //test to see that it exists
            Assert.IsNotNull(ASupplie);
        }

        [TestMethod]
        public void SupplierIdOK()
        {
            //create an instance of the class we want to create
            clSupplier ASupplier = new clsSuppplier();

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
            clSupplier ASupplier = new clsSuppplier();

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
            clSupplier ASupplier = new clsSuppplier();

            //creat some test data to assign to the property
            string TestData = "Industry ST";

            //assign the data to the property   
            ASupplier.Address = TestData;

            //test to see the two values are the same
            Assert.AreEqual(ASupplier.Address, TestData);

        }
        [TestMethod]
        public void AddressOK()
        {
            //create a new instance of the class we want to create
            clSupplier ASupplier = new clsSuppplier();

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
            clSupplier ASupplier = new clsSuppplier();

            //creat some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property   
            ASupplier.DateAdded = TestData;

            //test to see the two values are the same
            Assert.AreEqual(ASupplier.DateAdded, TestData);

        }
        [TestMethod]
        public void GlobalSupplierOK()
        {
            //create a new instance of the class we want to create
            clSupplier ASupplier = new clsSuppplier();

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
            clSupplier ASupplier = new clsSuppplier();

            //creat some test data to assign to the property
            Int16 TestData = 4.2;

            //assign the data to the property   
            ASupplier.Feedback = TestData;

            //test to see the two values are the same
            Assert.AreEqual(ASupplier.Feedback, TestData);

        }


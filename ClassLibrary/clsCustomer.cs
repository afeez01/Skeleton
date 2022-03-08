using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data customer for the customer id
        private Int32 mCustomerID;
        //CustomerID customers
        public Int32 CustomerID 
        {
            get
            {
                //
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }


        //private data member for order process
        private Boolean mOrderProcess;
        //public property for order process
        public bool OrderProcess
        {
            get
            {
                //return the private data
                return mOrderProcess;
            }
            set
            {
                //set the private data
                mOrderProcess = value;
            }
        }


        //private date added data member
        private DateTime mDOB;
        //public property for date of birth
        public DateTime DOB
        {
            get
            {
                //return the private data
                return mDOB;
            }
            set
            {
                //set the private data
                mDOB = value;
            }
        }

        //private data member for the email address
        private string mEmailAddress;
        //public property for the email
        public string EmailAddress
        {
            get
            {
                //return the private data
                return mEmailAddress;
            }
            set
            {
                //set the value of the private data member
                mEmailAddress = value;
            }
        }


        //private data member for the email address
        private string mCustomerDetails;
        //public property for the address number
        public string CustomerDetails
        {
            get
            {
                //return the private data
                return mCustomerDetails;
            }
            set
            {
                //set the value of the private data member
                mCustomerDetails = value;
            }
        }




        //private data customer for the customer id
        private decimal mAccountBalance;
        //CustomerID customers
        public decimal AccountBalance
        {
            get
            {
                //
                return mAccountBalance;
            }
            set
            {
                mAccountBalance = value;
            }
        }









        public bool Find(int CustomerID)
        {
            mCustomerID = 21;
            mDOB = Convert.ToDateTime("16/9/2016");
            mEmailAddress = "testemail@customer.com";
            mCustomerDetails = "Test Name";
            mAccountBalance = 41;
            mOrderProcess = true;
            //always return true
            return true;
        }
    }
}
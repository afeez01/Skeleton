using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private customer data for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        //plubic property for customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return private data
                return mCustomerList;
            }
            set
            {
                //set private data
                mCustomerList = value;

            }
        }
            public int Count
            { 
                get
                {
                return mCustomerList.Count;
            
                }
                set
                {
                    
                }
            }

        
    }
}
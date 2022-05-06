using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplier
    {

        //private data members
        private Int32 mSupplierId;
        private DateTime mDateAdded;
        private string mName;
        private string mAddress;
        private bool mGlobalSupplier;
        private decimal mFeedback;

        public Int32 SupplierId
        {
            get
            {
                return mSupplierId;
            }
            set
            {
                mSupplierId = value;
            }
        }
        public string Name {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        public DateTime DateAdded {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public bool GlobalSupplier
        {
            get
            {
                return mGlobalSupplier;
            }
            set
            {
                mGlobalSupplier = value;
            }
        }
        public Decimal Feedback
        {
            get
            {
                return mFeedback;
            }
            set
            {
                mFeedback = value;
            }
        }

        public bool Find(int SupplierID)
        {
            //create an isntance of the data collection
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", SupplierID);
            DB.Execute("sproc_tblSupplier_FilterBySupplierId");
            if (DB.Count == 1)
            {
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mGlobalSupplier = Convert.ToBoolean(DB.DataTable.Rows[0]["GlobalSupplier"]);
                mFeedback = Convert.ToDecimal(DB.DataTable.Rows[0]["Feedback"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string DateAdded, string Name, string Feedback, string Address)
        {
            //create string for the error
            string Error = "";
            DateTime DateTemp;
            double DoubleTemp;

            //Min for Name
            if (Name.Length == 0)
            {
                Error = Error + "The Name Cannot be blank, ";
            }
            //Max for Name
            if (Name.Length > 50)
            {
                Error = Error + "The Name has a limit of 50 characters, ";
            }
            //DateAdded must be today
            try
            {
                DateTemp = Convert.ToDateTime(DateAdded);

                if (DateTemp < DateTime.Now.Date.AddYears(-10))
                {
                    Error = Error + "The date must be whithin the last decade, ";
                }
            }
            //DateAdded needs to be in valid format
            catch(Exception e)
            {

                Error = Error + "The date needs to be in valid format, " + e;
            }

            //Min for Address
            if (Address.Length == 0)
            {
                Error = Error + "The Address Cannot be blank, ";
            }
            //Max for Address
            if (Address.Length > 50)
            {
                Error = Error + "The Address has a limit of 50 characters, ";
            }
            try
            {
                DoubleTemp = Convert.ToDouble(Feedback);
                if (DoubleTemp < 0.0)
                {
                    Error += "Feedback cannot be negative,  ";
                }
                if (DoubleTemp > 5.0)
                {
                    Error += "Feedback cannot excead 5.0,  ";
                }

            }
            catch(Exception i)
            {
                Error += "This is not a valid feedback number, " + i;
            }



            return Error;
                
        }
    }
}
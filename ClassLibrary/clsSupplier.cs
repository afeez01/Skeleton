using System;

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

        public bool Find(int SupplierId)
        {
            //create an isntance of the data collection
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", SupplierId);
            DB.Execute("sproc_tblSupplier_FilterBySupplierId");
            if (DB.Count == 1)
            {
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0][" SupplierId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mGlobalSupplier = Convert.ToBoolean(DB.DataTable.Rows[0]["GlobalSupplier "]);
                mFeedback = Convert.ToDecimal(DB.DataTable.Rows[0]["Feedback "]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string Name, string Address, string DateAdded, string Feedback)
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

                if (DateTemp != DateTime.Now.Date)
                {
                    Error = Error + "The date must be today, ";
                }
            }
            //DateAdded needs to be in valid format
            catch
            {

                Error = Error + "The date needs to be in valid format, ";
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
            catch
            {
                Error += "This is not a valid feedback number, ";
            }



            return Error;
                
        }
    }
}
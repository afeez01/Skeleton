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
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
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
    }
}
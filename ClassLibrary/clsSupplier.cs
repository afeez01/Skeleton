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
        private Double mFeedback;

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
        public Double Feedback
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
            mSupplierId = 21;
            mDateAdded = Convert.ToDateTime("16/09/2015");
            mName = "Tool Factory";
            mAddress = "Industry ST";
            mGlobalSupplier = true;
            mFeedback = 4.2;

            return true;
        }
    }
}
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        // private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

        public List<clsStock> StockList 
        { 
            get
            {
                // return the private data
                return mStockList;
            }
            set
            {
                // set the private data
                mStockList = value;

            }
        }

        public int Count
        {
            get
            {
                // return the private data
                return mStockList.Count;
            }
            set
            {
                // set the private data
               

            }
        }

        public clsStock ThisStock { get; set; }
    }
}
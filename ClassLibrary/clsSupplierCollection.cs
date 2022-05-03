using System.Collections.Generic;
using System;


namespace ClassLibrary
{
    public class clsSupplierCollection
    {
         List<clsSupplier> mSupplierList = new List<clsSupplier>();
        // private data member thisStock
        clsSupplier mThisSupplier = new clsSupplier(); 

        public clsSupplierCollection()
        { 
        //data connection to object
        clsDataConnection DB = new clsDataConnection();
        //Execute the storage procedure
        DB.Execute("sproc_tblSupplier_SelectAll");
         PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //popluates the array list based on the data table in DB
            //var for the index
            Int32 Index = 0;
            //var to store the count of the records
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mSupplierList = new List<clsSupplier>();
            // while there are records to process do
            while (Index < RecordCount)
            {
                //create instance of supplier class
                clsSupplier ASupplier = new clsSupplier();

                // read in the fields from record
                ASupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                ASupplier.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ASupplier.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ASupplier.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                ASupplier.GlobalSupplier = Convert.ToBoolean(DB.DataTable.Rows[Index]["GlobalSupplier"]);
                ASupplier.Feedback = Convert.ToDecimal(DB.DataTable.Rows[Index]["Feedback"]);
                

                // add the record to private data member
                mSupplierList.Add(ASupplier);

                // point at the next rexord
                Index++;
            }
        }

        public List<clsSupplier> SupplierList
        {
            get
            {
                //return the private data
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
         }
        //public count
        public int Count
        {
            get
            {
                //count of the list
                return mSupplierList.Count;
            }
            set
            {
                //
            }
        }
        public clsSupplier ThisSupplier
        {
            get
            {
                //return the private data
                return mThisSupplier;
            }
            set
            {
             
                mThisSupplier = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the value of mThisSupplier
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisSupplier.Name);
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@DateAdded", mThisSupplier.DateAdded);
            DB.AddParameter("@GlobalSupplier", mThisSupplier.GlobalSupplier);
            DB.AddParameter("@Feedback", mThisSupplier.Feedback);
            return DB.Execute("sproc_tblSupplier_Insert");
        }
        public void Update()
        {
            // update an existing record based on the values of mThisSupplier
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierId);
            DB.AddParameter("@Name", mThisSupplier.Name);
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@DateAdded", mThisSupplier.DateAdded);
            DB.AddParameter("@GlobalSupplier", mThisSupplier.GlobalSupplier);
            DB.AddParameter("@Feedback", mThisSupplier.Feedback);

            // execute return of the primary key value
            DB.Execute("sproc_tblSupplier_Update");
        }
        public void Delete()
        {
            // delete the record pointed by  mThisSupplier
            // connect to the database
            clsDataConnection DB = new clsDataConnection();

            // set the parameters for the stored procedure
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);

            // execute the query returning the primary key value
            DB.Execute("sproc_tblSupplier_Delete");
        }
        public void ReportByName(string Name)
        {
            // filter the records based on Supplier name
            // connect to the database
            clsDataConnection DB = new clsDataConnection();

            // send the supplier name  parameter to the database
            DB.AddParameter("@Name", Name);

            // execute the query returning the primary key value
            DB.Execute("sproc_tblSupplier_FilterByName");

            // populate the array list with the data table
            PopulateArray(DB);
        }
    }
    
}
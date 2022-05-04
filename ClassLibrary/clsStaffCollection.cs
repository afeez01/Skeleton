using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for thisStaff
        clsStaff mThisStaff = new clsStaff();

        //public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //later
            }
        }

        //public property for thisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        //constructor for the class
        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the databse based on the values of mThisStaff
            //connect to the databse
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@PermanentEmployment", mThisStaff.PermanentEmployment);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@PermanentEmployment", mThisStaff.PermanentEmployment);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByFullName(string FullName)
        {
            //filters the records based on a full or partial full name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the full name parameter to the database
            DB.AddParameter("@FullName", FullName);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByFullName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsStaff AnStaff = new clsStaff();
                //read in the fields from the current record
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AnStaff.Salary = Convert.ToDouble(DB.DataTable.Rows[Index]["Salary"]);
                AnStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnStaff.PermanentEmployment = Convert.ToBoolean(DB.DataTable.Rows[Index]["PermanentEmployment"]);
                //add the record to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
                Index++;
            }

        }
    }
}
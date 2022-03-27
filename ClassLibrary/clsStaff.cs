using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the staff id property
        private Int32 mStaffId;
        //staff id public property
        public Int32 StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }

            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }

        //private data member for the full name property
        private string mFullName;
        //full name public property
        public string FullName
        {
            get
            {
                //this line of code sends data out of the property
                return mFullName;
            }

            set
            {
                //this line of code allows data into the property
                mFullName = value;
            }
        }

        //private data member for the salary property
        private double mSalary;
        //salary public property
        public double Salary
        {
            get
            {
                //this line of code sends data out of the property
                return mSalary;
            }

            set
            {
                //this line of code allows data into the property
                mSalary = value;
            }
        }

        //private data member for the date added property
        private DateTime mDateAdded;
        //date added public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }

            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }

        //private data member for the address property
        private string mAddress;
        //address public property
        public string Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }

            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }

        //private data member for the permanent employment property
        private Boolean mPermanentEmployment;
        //permanent employment public property
        public bool PermanentEmployment
        {
            get
            {
                //this line of code sends data out of the property
                return mPermanentEmployment;
            }

            set
            {
                //this line of code allows data into the property
                mPermanentEmployment = value;
            }
        }

        public bool Find(int StaffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff id to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there should be one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mSalary = Convert.ToDouble(DB.DataTable.Rows[0]["Salary"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPermanentEmployment = Convert.ToBoolean(DB.DataTable.Rows[0]["PermanentEmployment"]);
                //return that everything worked ok
                return true;
            }

            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}
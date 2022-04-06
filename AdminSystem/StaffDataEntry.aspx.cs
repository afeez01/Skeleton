using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffId;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffId != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        {
            //create an instance of clsStaff
            clsStaff AnStaff = new clsStaff();
            //capture the full name
            string FullName = txtFullName.Text;
            //capture the salary
            string Salary = txtSalary.Text;
            //capture the date added
            string DateAdded = txtDateAdded.Text;
            //capture the address
            string Address = txtAddress.Text;
            //variable to store any error messages
            string Error = "";
            //validate the data
            Error = AnStaff.Valid(FullName, Salary, DateAdded, Address);
            if (Error == "")
            {
                //capture the staff id
                AnStaff.StaffId = StaffId;
                //capture the full name
                AnStaff.FullName = FullName;
                //capture the salary
                AnStaff.Salary = Convert.ToDouble(Salary);
                //capture the date added
                AnStaff.DateAdded = Convert.ToDateTime(DateAdded);
                //capture the address
                AnStaff.Address = Address;
                //capture permanent employment
                AnStaff.PermanentEmployment = chkPermanentEmployment.Checked;
                //create a new instance of the staff collection
                clsStaffCollection StaffList = new clsStaffCollection();

                //if this is a new record i.e. StaffId = -1, then add the data
                if (StaffId == -1)
                {
                    //set the ThisStaff property
                    StaffList.ThisStaff = AnStaff;
                    //add the new record
                    StaffList.Add();
                }
                //otherwise it must be an update
                else
                {
                    //find the record to update
                    StaffList.ThisStaff.Find(StaffId);
                    //set the ThisStaff property
                    StaffList.ThisStaff = AnStaff;
                    //update the record
                    StaffList.Update();
                }
                //redirect to the list page
                Response.Redirect("StaffList.aspx");
            }
            else
            {
                //display the error message
                lblError.Text = Error;
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = AnStaff.Find(StaffId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFullName.Text = AnStaff.FullName;
            txtSalary.Text = AnStaff.Salary.ToString();
            txtDateAdded.Text = AnStaff.DateAdded.ToString();
            txtAddress.Text = AnStaff.Address;
        }
    }

    void DisplayStaff()
    {
        //create an instance of the class we want to create
        clsStaffCollection StaffList = new clsStaffCollection();
        //find the record to update
        StaffList.ThisStaff.Find(StaffId);
        //display the data for this record
        txtStaffId.Text = StaffList.ThisStaff.StaffId.ToString();
        txtFullName.Text = StaffList.ThisStaff.FullName;
        txtSalary.Text = StaffList.ThisStaff.Salary.ToString();
        txtDateAdded.Text = StaffList.ThisStaff.DateAdded.ToString();
        txtAddress.Text = StaffList.ThisStaff.Address;
        chkPermanentEmployment.Checked = StaffList.ThisStaff.PermanentEmployment;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {

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
                //capture the full name
                AnStaff.FullName = FullName;
                //capture the salary
                AnStaff.Salary = Convert.ToDouble(Salary);
                //capture the date added
                AnStaff.DateAdded = Convert.ToDateTime(DateAdded);
                //capture the address
                AnStaff.Address = Address;
                //store the address in the session object
                Session["AnStaff"] = AnStaff;
                //redirect to the viewer page
                Response.Redirect("StaffViewer.aspx");
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
}
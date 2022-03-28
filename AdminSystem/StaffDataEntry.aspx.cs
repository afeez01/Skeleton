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
            txtStaffId.Text = AnStaff.StaffId.ToString();
            //store the staff in the session object
            Session["AnStaff"] = AnStaff;
            //navigate to the viewer page
            Response.Redirect("StaffViewer.aspx");
        }

        {
            //create an instance of clsStaff
            clsStaff AnStaff = new clsStaff();
            //capture the full name
            txtFullName.Text = AnStaff.FullName;
            //store the staff in the session object
            Session["AnStaff"] = AnStaff;
            //navigate to the viewer page
            Response.Redirect("StaffViewer.aspx");
        }

        {
            //create an instance of clsStaff
            clsStaff AnStaff = new clsStaff();
            //capture the full name
            txtSalary.Text = AnStaff.Salary.ToString();
            //store the staff in the session object
            Session["AnStaff"] = AnStaff;
            //navigate to the viewer page
            Response.Redirect("StaffViewer.aspx");
        }

        {
            //create an instance of clsStaff
            clsStaff AnStaff = new clsStaff();
            //capture the full name
            txtDateAdded.Text = AnStaff.DateAdded.ToString(); 
            //store the staff in the session object
            Session["AnStaff"] = AnStaff;
            //navigate to the viewer page
            Response.Redirect("StaffViewer.aspx");
        }

        {
            //create an instance of clsStaff
            clsStaff AnStaff = new clsStaff();
            //capture the full name
            txtAddress.Text = AnStaff.Address;
            //store the staff in the session object
            Session["AnStaff"] = AnStaff;
            //navigate to the viewer page
            Response.Redirect("StaffViewer.aspx");
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
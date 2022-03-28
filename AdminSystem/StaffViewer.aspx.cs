using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //display the full name for this entry      
        Response.Write("Staff ID =" + AnStaff.StaffId + "<br />");
        Response.Write("Full Name =" + AnStaff.FullName + "<br />");
        Response.Write("Salary =" + AnStaff.Salary + "<br />");
        Response.Write("Date added =" + AnStaff.DateAdded + "<br />");
        Response.Write("Address =" + AnStaff.Address + "<br />");
        Response.Write("Permanent Employment =" + AnStaff.PermanentEmployment + "<br />");

    }
}
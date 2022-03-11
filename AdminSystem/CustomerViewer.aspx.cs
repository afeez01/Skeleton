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
        //create new instance of class
        clsCustomer AnCustomer = new clsCustomer();
        //get data from session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display email address on the page
        Response.Write("ID =" + AnCustomer.CustomerID + "<br />");
        Response.Write("Date Of Birth =" + AnCustomer.DateOfBirth + "<br />");
        Response.Write("Email =" + AnCustomer.EmailAddress + "<br />");
        Response.Write("Details =" + AnCustomer.CustomerDetails + "<br />");
        Response.Write("Balance =" + AnCustomer.AccountBalance + "<br />");
        Response.Write("Order Process =" + AnCustomer.OrderProcess + "<br />");





    }
}
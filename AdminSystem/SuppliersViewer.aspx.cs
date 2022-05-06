using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier ASupplier = new clsSupplier();
        //get the data from the session object
        ASupplier = (clsSupplier)Session["ASupplier"];
        //display the full name for this entry      
        Response.Write("Supplier ID =" + ASupplier.SupplierId + "<br />");
        Response.Write("Name =" + ASupplier.Name + "<br />");
        Response.Write("Address =" + ASupplier.Address + "<br />");
        Response.Write("Date added =" + ASupplier.DateAdded + "<br />");
        Response.Write("Feedback =" + ASupplier.Feedback + "<br />");
        Response.Write("Global Supplier =  " + ASupplier.GlobalSupplier + "<br />");
    }
}
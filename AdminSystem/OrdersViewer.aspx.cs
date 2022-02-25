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
        //create a new instance of the class
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
       
        // display the order for this entry
        Response.Write(AnOrder.OrderId);
        Response.Write("<br/>");

        Response.Write(AnOrder.CustomerId);
        Response.Write("<br/>");

        Response.Write(AnOrder.ShippingAddress);
        Response.Write("<br/>");

        Response.Write(AnOrder.OrderDate);
        Response.Write("<br/>");

        Response.Write(AnOrder.OrderEmail);
        Response.Write("<br/>");

        Response.Write(AnOrder.OrderCompleted);
    }
}
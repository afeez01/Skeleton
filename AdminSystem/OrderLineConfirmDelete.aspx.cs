using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 OrderLineID;
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        OrderLineID = Convert.ToInt32(Session["OrderLineID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the Orders class
        clsOrderLineCollection OrderLine = new clsOrderLineCollection();

        //find the record to delete
        OrderLine.ThisOrderLine.Find(OrderLineID);

        //delete the record
        OrderLine.Delete();

        //redirect back to the main page
        Response.Redirect("OrderLineList.aspx");

    }
}

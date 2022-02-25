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
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        //capture the order
        AnOrder.OrderId = Convert.ToInt32(txtOrderID.Text);
        AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        AnOrder.ShippingAddress = txtShippingAddress.Text;
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        AnOrder.OrderEmail = txtOrderEmail.Text;
        AnOrder.OrderCompleted = chkOrderCompleted.Checked;

        //store the order in the session object
        Session["AnOrder"] = AnOrder;

        //navigate to the viewer page
        Response.Redirect("OrdersViewer.aspx");
       
    
    }




    protected void chkActive_CheckedChanged(object sender, EventArgs e)
    {

    }
}
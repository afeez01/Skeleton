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

        //capture the customer id
        string CustomerId = txtCustomerId.Text;

        //capture the shipping address
        string ShippingAddress = txtShippingAddress.Text;

        //capture the order date
        string OrderDate = txtOrderDate.Text;

        //capture the order email
        string OrderEmail = txtOrderEmail.Text;

        //variable to store any error messages
        string Error = "";
      
        //validate the data
        Error = AnOrder.Valid(CustomerId, ShippingAddress, OrderDate, OrderEmail);
        if (Error == "")
        {

            //capture the customer id
            AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);

            //capture the shipping address
            AnOrder.ShippingAddress = ShippingAddress;

            //capture the order date
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);

            //capture the order email
            AnOrder.OrderEmail = OrderEmail;



            //store the order in the session object
            Session["AnOrder"] = AnOrder;

            //navigate to the viewer page
            Response.Redirect("OrdersViewer.aspx");


        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the use
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
    
         txtCustomerId.Text = AnOrder.CustomerId.ToString();
         txtShippingAddress.Text  = AnOrder.ShippingAddress;
         txtOrderDate.Text  = AnOrder.OrderDate.ToString();
         txtOrderEmail.Text = AnOrder.OrderEmail;
            
    }
}



    protected void chkOrderCompleted_CheckedChanged(object sender, EventArgs e)
    {

    }
}
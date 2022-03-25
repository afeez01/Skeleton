using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if(OrderId != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }

    }
    void DisplayOrder()
            {
                // create a new instance of the stock collection
                clsOrderCollection Orders = new clsOrderCollection();
                // find the record to update
                Orders.ThisOrder.Find(OrderId);
                //display the data for this record
                txtOrderId.Text = Orders.ThisOrder.OrderId.ToString();
                txtCustomerId.Text = Orders.ThisOrder.CustomerId.ToString();
                txtShippingAddress.Text = Orders.ThisOrder.ShippingAddress;
                txtOrderEmail.Text = Orders.ThisOrder.OrderEmail;
                txtOrderDate.Text = Orders.ThisOrder.OrderDate.ToString();
                chkOrderCompleted.Checked = Orders.ThisOrder.OrderCompleted;
  
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

            //capture the order
            AnOrder.OrderId = OrderId;
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            AnOrder.ShippingAddress = ShippingAddress;
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.OrderEmail = OrderEmail;
            AnOrder.OrderCompleted = chkOrderCompleted.Checked;

            //create a new instance of the address collection
            clsOrderCollection OrderList = new clsOrderCollection();

            //if this is a new record i.e OrderId = -1 then add the data
            if(OrderId == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be uodate
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderId);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
                Response.Redirect("OrdersList.aspx");


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

}
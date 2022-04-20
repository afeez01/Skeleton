using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineDataEntry : System.Web.UI.Page
{
    Int32 OrderLineID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        OrderLineID = Convert.ToInt32(Session["OrderLineID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderLineID != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }

    }
    void DisplayOrder()
    {
        // create a new instance of the stock collection
        clsOrderLineCollection OrderLine = new clsOrderLineCollection();
        // find the record to update
        OrderLine.ThisOrderLine.Find(OrderLineID);
        //display the data for this record
        txtOrderLineID.Text = OrderLine.ThisOrderLine.OrderLineID.ToString();
        txtOrderID.Text = OrderLine.ThisOrderLine.OrderID.ToString();
        txtToolID.Text = OrderLine.ThisOrderLine.ToolID.ToString();
        txtDescription.Text = OrderLine.ThisOrderLine.Description;
        txtOrderLineDate.Text = OrderLine.ThisOrderLine.OrderLineDate.ToString();
        chkOrderLineConfirmed.Checked = OrderLine.ThisOrderLine.OrderLineConfirmed;

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrderLine AnOrderLine = new clsOrderLine();

        //capture the order id
        string OrderID = txtOrderID.Text;

        //capture the tool id
        string ToolID = txtToolID.Text;

        //capture the description
        string Description = txtDescription.Text;

        //capture the order line date
        string OrderLineDate = txtOrderLineDate.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AnOrderLine.Valid(Description, OrderLineDate);
        if (Error == "")
        {

            //capture the order
            AnOrderLine.OrderLineID = OrderLineID;
            AnOrderLine.OrderID = Convert.ToInt32(OrderID);
            AnOrderLine.ToolID = Convert.ToInt32(ToolID);
            AnOrderLine.Description = Description;
            AnOrderLine.OrderLineDate = Convert.ToDateTime(OrderLineDate);
            AnOrderLine.OrderLineConfirmed = chkOrderLineConfirmed.Checked;

            //create a new instance of the address collection
            clsOrderLineCollection OrderLineList = new clsOrderLineCollection();

            //if this is a new record i.e OrderLineID = -1 then add the data
            if (OrderLineID == -1)
            {
                //set the ThisOrder property
                OrderLineList.ThisOrderLine = AnOrderLine;
                //add the new record
                OrderLineList.Add();
            }
            //otherwise it must be uodate
            else
            {
                //find the record to update
                OrderLineList.ThisOrderLine.Find(OrderLineID);
                //set the ThisOrder property
                OrderLineList.ThisOrderLine = AnOrderLine;
                //update the record
                OrderLineList.Update();
            }
            Response.Redirect("OrderLineList.aspx");


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
        clsOrderLine AnOrderLine = new clsOrderLine();
        //variable to store the primary key
        Int32 OrderLineID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the use
        OrderLineID = Convert.ToInt32(txtOrderLineID.Text);
        //find the record
        Found = AnOrderLine.Find(OrderLineID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form

            txtOrderID.Text = AnOrderLine.OrderID.ToString();
            txtToolID.Text = AnOrderLine.ToolID.ToString();
            txtDescription.Text = AnOrderLine.Description;
            txtOrderLineDate.Text = AnOrderLine.OrderLineDate.ToString();
            


        }
    }


}

 

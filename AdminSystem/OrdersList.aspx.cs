using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create an instance of the Order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to list of orders in the collection
        lstOrdersList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "OrderId";
        //set the data field to display
        lstOrdersList.DataTextField = "ShippingAddress";
        //bind the data to the list 
        lstOrdersList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderId"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrdersList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderId = Convert.ToInt32(lstOrdersList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //rediret to the edit page
            Response.Redirect("OrdersDataEntry.aspx");

        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderId;
        //if a record has been selected from the list
        if(lstOrdersList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderId = Convert.ToInt32(lstOrdersList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the delete page
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
}

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the order collction
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByShippingAddress(txtFilter.Text);
        lstOrdersList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "OrderId";
        //set the name of the field to display
        lstOrdersList.DataTextField = "ShippingAddress";
        //bind the data to the list
        lstOrdersList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByShippingAddress("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstOrdersList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "OrderId";
        //bind the data to the list
        lstOrdersList.DataBind();
    }
}
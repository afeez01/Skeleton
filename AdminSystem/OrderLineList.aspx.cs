using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create an instance of the Order collection
        clsOrderLineCollection OrderLine = new clsOrderLineCollection();
        //set the data source to list of orders in the collection
        lstOrderLineList.DataSource = OrderLine.OrderLineList;
        //set the name of the primary key
        lstOrderLineList.DataValueField = "OrderLineID";
        //set the data field to display
        lstOrderLineList.DataTextField = "Description";
        //bind the data to the list 
        lstOrderLineList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderLineID"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderLineDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderLineID;
        //if a record has been selected from the list
        if (lstOrderLineList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderLineID = Convert.ToInt32(lstOrderLineList.SelectedValue);
            //store the data in the session object
            Session["OrderLineID"] = OrderLineID;
            //rediret to the edit page
            Response.Redirect("OrderLineDataEntry.aspx");

        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderLineID;
        //if a record has been selected from the list
        if (lstOrderLineList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderLineID = Convert.ToInt32(lstOrderLineList.SelectedValue);
            //store the data in the session object
            Session["OrderLineID"] = OrderLineID;
            //redirect to the delete page
            Response.Redirect("OrderLineConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the order collction
        clsOrderLineCollection OrderLine = new clsOrderLineCollection();
        OrderLine.ReportByDescription(txtFilter.Text);
        lstOrderLineList.DataSource = OrderLine.OrderLineList;
        //set the name of the primary key
        lstOrderLineList.DataValueField = "OrderLineID";
        //set the name of the field to display
        lstOrderLineList.DataTextField = "Description";
        //bind the data to the list
        lstOrderLineList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrderLineCollection OrderLine = new clsOrderLineCollection();
        OrderLine.ReportByDescription("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstOrderLineList.DataSource = OrderLine.OrderLineList;
        //set the name of the primary key
        lstOrderLineList.DataValueField = "OrderLineID";
        //bind the data to the list
        lstOrderLineList.DataBind();
    }


}
  
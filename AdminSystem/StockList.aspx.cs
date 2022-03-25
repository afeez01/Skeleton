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
        // if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            // update the list box
            DisplayStock();
        }        
    }

    void DisplayStock()
    {
        // create an instance of the class we want to create
        clsStockCollection AllStock = new clsStockCollection();

        // set the data source to list of stocks in the collection
        lstStockList.DataSource = AllStock.StockList;

        // set the name of the primary key
        lstStockList.DataValueField = "ToolID";

        // set the data field to display
        lstStockList.DataTextField = "ToolName";

        // bind the data to the list
        lstStockList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["ToolID"] = -1;

        // redircet to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be edited
        Int32 ToolID;
        // if a record has been selected from the list
        if(lstStockList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit
            ToolID = Convert.ToInt32(lstStockList.SelectedValue);
            // store the data in the session object
            Session["ToolID"] = ToolID;
            // redircet to the data entry page
            Response.Redirect("StockDataEntry.aspx");
        }
        else // if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be edited
        Int32 ToolID;

        // if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit
            ToolID = Convert.ToInt32(lstStockList.SelectedValue);
            // store the data in the session object
            Session["ToolID"] = ToolID;
            // redircet to the data entry page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else // if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}
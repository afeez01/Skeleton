using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // variable to store the primary key with page level scope
    Int32 ToolID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the stock to be processed
        ToolID = Convert.ToInt32(Session["ToolID"]);
        if(IsPostBack == false)
        {
            // if this is not a new record
            if(ToolID != -1)
            {
                // display the current data for the record
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        // create a new instance of the stock collection
        clsStockCollection StockList = new clsStockCollection();
        // find the record to update
        StockList.ThisStock.Find(ToolID);
        //display the data for this record
        txtToolID.Text = StockList.ThisStock.ToolID.ToString();
        txtToolName.Text = StockList.ThisStock.ToolName;
        txtQuantityInStock.Text = StockList.ThisStock.QuantityInStock.ToString();
        txtUnitPrice.Text = StockList.ThisStock.UnitPrice.ToString();
        txtDateAdded.Text = StockList.ThisStock.DateAdded.ToString();
        chkOnSale.Checked = StockList.ThisStock.OnSale;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create a new instance of clsStock
        clsStock AnStock = new clsStock();

        // capture the tool
       string ToolName = txtToolName.Text;
       string DateAdded = txtDateAdded.Text;      
       string QuantityInStock = txtQuantityInStock.Text;      
       string UnitPrice = txtUnitPrice.Text;
      
        // Variable to store any error
        string Error= "";

        // validate the entered data
        Error = AnStock.Valid(ToolName, QuantityInStock, DateAdded, UnitPrice);
        if(Error == "")
        {
            // capture the tool
            AnStock.ToolID = ToolID;
            AnStock.ToolName = ToolName;
            AnStock.DateAdded = Convert.ToDateTime(DateAdded);
            AnStock.OnSale = chkOnSale.Checked;
            AnStock.QuantityInStock = Convert.ToInt32(QuantityInStock);            
            AnStock.UnitPrice = Convert.ToDecimal(UnitPrice);

            // create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record i.e. ToolID = -1 then add the data
            if(ToolID == -1)
            {
                // set ThisStock property
                StockList.ThisStock = AnStock;
                // add the new record
                StockList.Add();
            }
            else // otherwise it must be an update
            {
                // find the record to update
                StockList.ThisStock.Find(ToolID);
                //set the ThisStock property
                StockList.ThisStock = AnStock;
                // update the record
                StockList.Update();
            }
            
            // redirect back to the list page
            Response.Redirect("StockList.aspx");

            // store the tool in the session object
            //Session["AnStock"] = AnStock;
            // navigate to the viewer page
            //Response.Redirect("StockViewer.aspx");
        }
        else
        {
            // display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // create an instance of the class we want to create
        clsStock AnStock = new clsStock();

        // variable to store the primary key
        Int32 ToolID;

        // Variable to store any error
        lblError.Text = "";

        // variable to store the results of find operation
        Boolean Found = false;
        try
        {
            // get the primary key entered by the user
            ToolID = Convert.ToInt32(txtToolID.Text);

            // find the record
            Found = AnStock.Find(ToolID);
            // check the result
            if (Found)
            {
                txtToolID.Text = AnStock.ToolID.ToString();
                txtToolName.Text = AnStock.ToolName;
                txtQuantityInStock.Text = AnStock.QuantityInStock.ToString();
                txtUnitPrice.Text = AnStock.UnitPrice.ToString();
                txtDateAdded.Text = AnStock.DateAdded.ToString();


            }
            else
            {
                // display the error message
            lblError.Text = "Tool id not found";
            }
        }
        catch
        {
            // display the error message
            lblError.Text = "Invalid tool id";
        }
        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // redirect back to the list page
        Response.Redirect("StockList.aspx");
    }
}
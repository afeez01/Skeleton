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
            AnStock.ToolName = txtToolName.Text;
            AnStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            AnStock.OnSale = chkOnSale.Checked;
            AnStock.QuantityInStock = Convert.ToInt32(txtQuantityInStock.Text);
            //AnStock.ToolID = Convert.ToInt32(txtToolID.Text);
            AnStock.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);

            // create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();
            // set ThisStock property
            StockList.ThisStock = AnStock;
            // add the new record
            StockList.Add();
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

        // variable to store the results of find operation
        Boolean Found = false;

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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // var to store the primary key value of the record to be deleted
    private Int32 ToolID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the stock to be deleted from the session object
        ToolID = Convert.ToInt32(Session["ToolID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // create an instance of the class we want to create
        clsStockCollection AllStock = new clsStockCollection();

        // find the record to delete
        AllStock.ThisStock.Find(ToolID);
        // delete the record
        AllStock.Delete();
        // redirect back to the main page
        Response.Redirect("StockList.aspx");


    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        // redirect back to the main page
        Response.Redirect("StockList.aspx");
    }
}
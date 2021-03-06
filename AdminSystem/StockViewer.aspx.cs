using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // create a new instance of clsStock
        clsStock AnStock = new clsStock();

        // get the data from the session object
        AnStock = (clsStock)Session["AnStock"];

        // display the tool for this entry
        Response.Write(AnStock.ToolID);
        Response.Write("<br/>");

        Response.Write(AnStock.ToolName);
        Response.Write("<br/>");

        Response.Write(AnStock.QuantityInStock);
        Response.Write("<br/>");

        Response.Write(AnStock.UnitPrice);
        Response.Write("<br/>");

        Response.Write(AnStock.DateAdded);
        Response.Write("<br/>");

        Response.Write(AnStock.OnSale);




    }
}
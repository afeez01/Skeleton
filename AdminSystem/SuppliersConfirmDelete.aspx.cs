using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 SupplierId;
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        SupplierId = Convert.ToInt32(Session["SupplierId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the collection class
        clsSupplierCollection AllSuppliers = new clsSupplierCollection();

        //find the record to delete
        AllSuppliers.ThisSupplier.Find(SupplierId);

        //delete the record
        AllSuppliers.Delete();

        //redirect back to the main page
        Response.Redirect("SuppliersList.aspx");

    }
}
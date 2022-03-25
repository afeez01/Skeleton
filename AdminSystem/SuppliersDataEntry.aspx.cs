using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void cbGlobal_CheckedChanged(object sender, EventArgs e)
    {
        bool GlobalSupplier = true;
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        clsSupplier ASupplier = new clsSupplier();

        ASupplier.Address = txtAddress.Text;
        ASupplier.DateAdded = DateTime.Today;
        ASupplier.GlobalSupplier = cbGlobal.Checked;

        Session["ASupplier"] = ASupplier;

        Response.Redirect("SuppliersViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SuppliersDataEntry.aspx");
    }
}
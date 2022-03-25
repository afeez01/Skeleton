using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("SuppliersViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void cbGlobal_CheckedChanged(object sender, EventArgs e)
    {

    }
}
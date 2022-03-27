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

    protected void btnOk_Click(object sender, EventArgs e)
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


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create instance of Class
        clsSupplier ASupplier = new clsSupplier();
        //store primary key
        Int32 SupplierId;
        //result of find operation
        Boolean Found = false;
        //get primary key from text box
        SupplierId = Convert.ToInt32(txtSupplierID.Text);
        //use find method
        Found = ASupplier.Find(SupplierId);
        //if found
        if (Found == true)
        {
            //display the values in the form
            txtAddress.Text = ASupplier.Address;
            txtDateAdded.Text = ASupplier.DateAdded.ToString();
            txtFeedback.Text = ASupplier.Feedback.ToString();
            txtName.Text = ASupplier.Name;
            cbGlobal.Checked = true;

        }
    }
}
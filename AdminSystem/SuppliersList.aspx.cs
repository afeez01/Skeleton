using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            //firt time being displayed
            if (IsPostBack == false)
            {
            //update list box
            DisplaySuppliers();
            }
    }

    void DisplaySuppliers()
    {
        //create an instance of the supplier collection
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        //set the data source
        lstSupplierList.DataSource = Suppliers.SupplierList;
        lstSupplierList.DataValueField = "SupplierId";
        lstSupplierList.DataTextField = "Name";
        //bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate new record
        Session["SupplierId"] = -1;
        //redirect to data entry
        Response.Redirect("SuppliersDataEntry.aspx");
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 SupplierId;
        //if a record has been selected from the list
        if (lstSupplierList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data in the session object
            Session["SupplierId"] = SupplierId;
            //rediret to the edit page
            Response.Redirect("SuppliersDataEntry.aspx");

        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 SupplierId;
        //if a record has been selected from the list
        if (lstSupplierList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data in the session object
            Session["SupplierId"] = SupplierId;
            //redirect to the delete page
            Response.Redirect("SuppliersConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }


    protected void btnApply_Click1(object sender, EventArgs e)
    {
        //create an instance of the  collction
        clsSupplierCollection AllSuppliers = new clsSupplierCollection();
        AllSuppliers.ReportByName(txtFilter.Text);
        lstSupplierList.DataSource = AllSuppliers.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "SupplierId";
        //set the name of the field to display
        lstSupplierList.DataTextField = "Name";
        //bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnClear_Click1(object sender, EventArgs e)
    {
 //create an instance of the collection
        clsSupplierCollection AllSuppliers = new clsSupplierCollection();
        AllSuppliers.ReportByName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstSupplierList.DataSource = AllSuppliers.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "SupplierId";
        //bind the data to the list
        lstSupplierList.DataBind();
    }
}
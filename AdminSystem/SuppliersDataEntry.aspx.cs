using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    int SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        if (IsPostBack == false)
        {
            //if supplier is not a new 
            if (SupplierID != -1)
            {
                //display the current data for the record
                DisplayData();
            }
        }

    }
    void DisplayData()
    {
        // create a new instance of the collection
        clsSupplierCollection SupplierCollection = new clsSupplierCollection();
        // find the record to update
        SupplierCollection.ThisSupplier.Find(SupplierID);
        //display the data for this record
        txtSupplierID.Text = SupplierCollection.ThisSupplier.SupplierId.ToString();
        txtAddress.Text = SupplierCollection.ThisSupplier.Address;
        txtName.Text = SupplierCollection.ThisSupplier.Name;
        txtDateAdded.Text = SupplierCollection.ThisSupplier.DateAdded.ToString();
        cbGlobal.Checked = SupplierCollection.ThisSupplier.GlobalSupplier;
        txtFeedback.Text = SupplierCollection.ThisSupplier.Feedback.ToString();

    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsSupplier ASupplier = new clsSupplier();
        String Address = txtAddress.Text;
        string DateAdded = txtDateAdded.Text;
        string Feedback = txtFeedback.Text;
        string Name = txtName.Text;
        bool GlobalSupplier = cbGlobal.Checked;
        string Error = "";
        //validate the data entered
        Error = ASupplier.Valid(DateAdded, Name, Feedback, Address);
        if (Error == "")
        {
            //capture the values
            ASupplier.SupplierId = SupplierID;
            ASupplier.Address = Address;
            ASupplier.DateAdded =Convert.ToDateTime( DateAdded);
            ASupplier.GlobalSupplier = GlobalSupplier;
            ASupplier.Feedback = Convert.ToDecimal(Feedback);
            //create instance of collection class
            clsSupplierCollection SupplierCollection = new clsSupplierCollection();
            if (SupplierID == -1)
            {
                SupplierCollection.ThisSupplier = ASupplier;
                SupplierCollection.Add();
            }
            //if not new record, update an existing one
            else
            {
                SupplierCollection.ThisSupplier.Find(SupplierID);
                SupplierCollection.ThisSupplier = ASupplier;
                SupplierCollection.Update();
            }
            //redirect to listpage
            Response.Redirect("SuppliersList.aspx");
        }
        else
        {
            //display error
            lblError.Text = Error;
        }

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
            cbGlobal.Checked = ASupplier.GlobalSupplier;
            

        }
    }
}
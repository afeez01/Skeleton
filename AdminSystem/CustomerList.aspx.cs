using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is first page displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //cerate instance of Customer Collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to list of customers in the collection 
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "CustomerDetails";
        lstCustomerList.DataBind();
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store primary key
        Int32 CustomerID;
        //IF A RECORD HAS BEEN SELECTED FROM THE LIST
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get primary key value to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //STORE DATA
            Session["CustomerID"] = CustomerID;
            //redirect
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }

    }
}

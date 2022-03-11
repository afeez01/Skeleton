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
        //create new instance of clsAddress
        clsCustomer AnCustomer = new clsCustomer();
        //capture email address
        AnCustomer.CustomerID = Convert.ToInt16(txtCustomerID.Text);
        AnCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
        AnCustomer.EmailAddress = txtEmailAddress.Text;
        AnCustomer.CustomerDetails = txtCustomerDetails.Text;
        AnCustomer.AccountBalance = Convert.ToDecimal(txtAccountBalance.Text);
        AnCustomer.OrderProcess = Convert.ToBoolean(chkOrderProcess.Checked);
        //store the date of birth in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to viewer page
        Response.Redirect("CustomerViewer.aspx");


    }





    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();

        Int32 CustomerID;

        Boolean Found = false;
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = AnCustomer.Find(CustomerID);
        if (Found == true)
        {
            txtDateOfBirth.Text = AnCustomer.DateOfBirth.ToString();
            txtEmailAddress.Text = AnCustomer.EmailAddress;
            txtCustomerDetails.Text = AnCustomer.CustomerDetails;
            txtAccountBalance.Text = AnCustomer.AccountBalance.ToString();

        }
    }
}
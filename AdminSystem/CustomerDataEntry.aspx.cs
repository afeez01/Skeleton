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
        AnCustomer.DOB = Convert.ToDateTime(txtDOB.Text);
        AnCustomer.EmailAddress = txtEmailAddress.Text;
        AnCustomer.CustomerDetails = txtCustomerDetails.Text;
        AnCustomer.AccountBalance = Convert.ToDecimal(txtAccountBalance.Text);
        AnCustomer.OrderProcess = Convert.ToBoolean(chkOrderProcess.Checked);
        //store the date of birth in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to viewer page
        Response.Redirect("CustomerViewer.aspx");


    }

    


}
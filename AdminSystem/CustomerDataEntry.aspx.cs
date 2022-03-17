using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of address to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                DisplayCustomers();
            }
        }

    }
    void DisplayCustomers()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find record to update
        CustomerBook.ThisCustomer.Find(CustomerID);
        //display data for this record
        txtCustomerID.Text = CustomerBook.ThisCustomer.CustomerID.ToString();
        txtDateOfBirth.Text = CustomerBook.ThisCustomer.DateOfBirth.ToString();
        txtEmailAddress.Text = CustomerBook.ThisCustomer.EmailAddress;
        txtCustomerDetails.Text = CustomerBook.ThisCustomer.CustomerDetails;
        txtAccountBalance.Text = CustomerBook.ThisCustomer.AccountBalance.ToString();
        chkOrderProcess.Checked = CustomerBook.ThisCustomer.OrderProcess;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {


        //create new instance of clsAddress
        clsCustomer AnCustomer = new clsCustomer();
        string EmailAddress = txtEmailAddress.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string CustomerDetails = txtCustomerDetails.Text;
        string AccountBalance = txtAccountBalance.Text;
        string Error = "";
        Error = AnCustomer.Valid(DateOfBirth, EmailAddress, CustomerDetails, AccountBalance);
        if (Error == "")
        {
            //capture details
            AnCustomer.CustomerID = CustomerID;
            AnCustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            AnCustomer.EmailAddress = EmailAddress;
            AnCustomer.CustomerDetails = CustomerDetails;
            AnCustomer.AccountBalance = Convert.ToDecimal(AccountBalance);
            AnCustomer.OrderProcess = chkOrderProcess.Checked;
            //new instance
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (CustomerID == -1)
            {
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Update();

            }
            Response.Redirect("CustomerList.aspx");

        



            //capture deatils
            AnCustomer.CustomerID = Convert.ToInt16(txtCustomerID.Text);
            AnCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            AnCustomer.EmailAddress = txtEmailAddress.Text;
            AnCustomer.CustomerDetails = txtCustomerDetails.Text;
            AnCustomer.AccountBalance = Convert.ToDecimal(txtAccountBalance.Text);
            AnCustomer.OrderProcess = Convert.ToBoolean(chkOrderProcess.Checked);
            //create new instance of customer collection
            //set this customer property
            CustomerList.ThisCustomer = AnCustomer;
            //add new record
            CustomerList.Add();
            //navigate to viewer page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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
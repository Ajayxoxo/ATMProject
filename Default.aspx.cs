using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATMProject
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Redirect if not logged in
            if (Session["LoggedIn"] == null || !(bool)Session["LoggedIn"])
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void btnCheckBalance_Click(object sender, EventArgs e)
        {
            double balance = (double)Session["Balance"];
            lblMessage.Text = "Your current balance is: ${balance}";
        }
        protected void btnDeposit_Click(object sender, EventArgs e)
        {
            pnlTransaction.Visible = true;
            ViewState["TransactionType"] = "Deposit";
        }
        protected void btnWithdraw_Click(object sender, EventArgs e)
        {
            pnlTransaction.Visible = true;
            ViewState["TransactionType"] = "Withdraw";
        }
         
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
             if (double.TryParse(txtAmount.Text, out double amount))
             {
                 double balance = (double)Session["Balance"];
                 string transactionType = ViewState["TransactionType"].ToString();

                 if (transactionType == "Deposit")
                 {
                     balance += amount;
                     lblMessage.Text = "Deposit successful! New balance: ${balance}";
                 }
                 else if (transactionType == "Withdraw")
                 {
                    if (amount <= balance)
                     {
                         balance -= amount;
                         lblMessage.Text = "Withdrawal successful! New balance: ${balance}";
                     }
                 }
                 else
                 {
                    lblMessage.Text = "Insufficient balance!";
                 }
            Session["Balance"] = balance;
            pnlTransaction.Visible = false;
           
            }
            else
            {
                lblMessage.Text = "Invalid amount. Please try again.";
            }
            
            protected void btnLogout_Click(object sender, EventArgs e)
            {
            Session.Clear();
            Response.Redirect("Login.aspx");
            }
    }
}



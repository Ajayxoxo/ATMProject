using System;
using System.Web.UI;

namespace ATMProject
{
    public partial class LoginPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Balance"] = 1000.00;  // Initial balance
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string pin = txtPin.Text;  // Get PIN from the TextBox

            // Simple PIN check (for demonstration purposes)
            if (pin == "1234")
            {
                Session["LoggedIn"] = true;
                Response.Redirect("Default.aspx");  // Redirect to ATM menu page
            }
            else
            {
                lblError.Text = "Invalid PIN. Please try again.";  // Show error message
            }
        }
    }
}

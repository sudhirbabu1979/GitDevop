using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace helloworld
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string name = txtName.Text.Trim();
            string age = txtAge.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Simple validation (optional)
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(email))
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please fill in all fields.";
                return;
            }

            // Display the saved data (replace with DB save logic as needed)
            lblMessage.ForeColor = System.Drawing.Color.Green;
            lblMessage.Text = $"Student Saved: {name}, Age: {age}, Email: {email}";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all fields and message
            txtName.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";
            lblMessage.Text = "";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using helloworld; // Ensure this is present to reference Student class in Student.cs

namespace helloworld
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }   

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string age = txtAge.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(email))
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please fill in all fields.";
                return;
            }

            // Retrieve the student list from Session or create a new one
            var students = Session["Students"] as List<Student> ?? new List<Student>();

            // Add the new student
            students.Add(new Student { Name = name, Age = age, Email = email });

            // Save the list back to Session
            Session["Students"] = students;

            lblMessage.ForeColor = System.Drawing.Color.Green;
            lblMessage.Text = $"Student Saved: {name}, Age: {age}, Email: {email}";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";
            lblMessage.Text = "";
        }
    }

   
}
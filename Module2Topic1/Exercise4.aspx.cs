using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module1Exercise1
{
    public partial class Exercise4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            
            string FullName= fullName.Text;
            var Age = age.Text;
            string eMail = email.Text;
            string ConfirmEmail = confirmEmail.Text;
            string Result = $"Full name: {FullName} |Age: {Age} |Email: {eMail} |Confirm Email: {ConfirmEmail}";
            result.Text = Result;
            
            Response.Write($"<script>alert('Successfully Registered\\n\\nFull name: {FullName}\\nAge: {Age}\\nEmail: {eMail}\\nConfirm Email: {ConfirmEmail}')</script>");
        }
    }
}

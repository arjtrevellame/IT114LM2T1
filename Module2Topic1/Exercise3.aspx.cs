using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module1Exercise1
{
    public partial class Exercise3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // TODO 3.3 Set the text value of the finalGrade label to "Submit your grade percentage to see your final grade!". Watch out for post backs
        }

        protected void CalcBtn_Click(object sender, EventArgs e)
        {
            double grade = Double.Parse(percentageGrade.Text);
            if (grade <= 100 && grade >= 96 )  {

                finalGrade.Text = "1.00";
                Response.Write("<script>alert('Congratulations your final grade is 1.00!')</script>");
            }
            else if (grade <= 96 && grade >= 91.51) {
                finalGrade.Text = "1.25";
                Response.Write("<script>alert('Congratulations your final grade is 1.25!')</script>");
            }
            else if (grade <= 91.50 && grade >= 87.01)
            {
                finalGrade.Text = "1.50";
                Response.Write("<script>alert('Congratulations your final grade is 1.50!')</script>");
            }
            else if (grade <= 87 && grade >= 82.51)
            {
                finalGrade.Text = "1.75";
                Response.Write("<script>alert('Your final grade is 1.75!')</script>");
            }
            else if (grade <= 82.50 && grade >= 78.01)
            {
                finalGrade.Text = "2.00";
                Response.Write("<script>alert('Your final grade is 2.00!')</script>");
            }
            else if (grade <= 78 && grade >= 73.51)
            {
                finalGrade.Text = "2.25";
                Response.Write("<script>alert('Your final grade is 2.25!')</script>");
            }
            else if (grade <= 73.50 && grade >= 69.01)
            {
                finalGrade.Text = "2.50";
                Response.Write("<script>alert('Your final grade is 2.50!')</script>");
            }
            else if (grade <= 69 && grade >= 64.51)
            {
                finalGrade.Text = "2.75";
                Response.Write("<script>alert('Your final grade is 2.75!')</script>");
            }
            else if (grade <= 64.50 && grade >= 60)
            {
                finalGrade.Text = "3.00";
                Response.Write("<script>alert('Your final grade is 3.00!')</script>");
            }
            else if (grade <60)
            {
                finalGrade.Text = "5.00";
            }
            //Response.Write($"<script>alert('Your grade is {grade}!')</script>");
            //Response.Write($"<script>alert('Working!')</script>");
        }
    }
}

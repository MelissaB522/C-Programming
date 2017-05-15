using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        bool valid = true;
        //validate first name as string
        if (!ValidateInput(txtFirst.Text, @"^[A-Za-z]+$", "Invalid first name, do not use special characters", lblFirst))
        {
            txtFirst.BackColor = System.Drawing.Color.Red;
            valid = false;
        }
        else
        {
            txtFirst.BackColor = System.Drawing.Color.White;
        }
        //validate last name as string
        if (!ValidateInput(txtLast.Text, @"^[A-Za-z]+$", "Invalid last name, do not use special characters", lblLast))
        {
            txtLast.BackColor = System.Drawing.Color.Red;
            valid = false;
        }
        else
        {
            txtLast.BackColor = System.Drawing.Color.White;
        }
        //validate age as integer
        if (!ValidateInput(txtAge.Text, @"^\S[0-9]{0,3}$", "Invalid age, must be a number", lblAge))
        {
            txtAge.BackColor = System.Drawing.Color.Red;
            valid = false;
        }
        else
        {
            txtAge.BackColor = System.Drawing.Color.White;
        }
        //validate birth date as mm/dd/yyyy
        if (!ValidateInput(txtBDay.Text, @"^(0?[1-9]|1[012])[- /.](0?[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$", "Invalid birth date, mm/dd/yyyy", lblBDay))
        {
            txtBDay.BackColor = System.Drawing.Color.Red;
            valid = false;
        }
        else
        {
            txtBDay.BackColor = System.Drawing.Color.White;
        }
        //validate phone number as ###-###-####
        if (!ValidateInput(txtPhone.Text, @"^[2-9]\d{2}-\d{3}-\d{4}$", "Invalid phone number, ###-###-####", lblPhone))
        {
            txtPhone.BackColor = System.Drawing.Color.Red;
            valid = false;
        }
        else
        {
            txtPhone.BackColor = System.Drawing.Color.White;
        }

        //if all fields are valid display user information
        if (valid)
        {
            txtResults.Visible = true;
            txtResults.Text = "USER INFORMATION" + 
                "\r\nName: " + txtFirst.Text + " " + txtLast.Text + 
                "\r\nAge: " + txtAge.Text + 
                "\r\nBirth Date: " + txtBDay.Text + 
                "\r\nPhone Number: " + txtPhone.Text;
        }
    }

    // method for validating input using regular expressions and displaying the message in the label
    private bool ValidateInput(string input, string expression, string message, Label label)
    {
        bool valid = Regex.Match(input, expression).Success;

        if (!valid)
        {
            label.Text = message;
        }

        return valid;
    }
}
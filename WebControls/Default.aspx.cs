using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsPostBack == false)
            {
                Calendar1.SelectedDate = DateTime.Today;
            }
        }
        catch (Exception exc)
        {

            lblMSG.Text = exc.Message;
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblSubmit.Text = "Thanks" + txtBxFname.Text +
            "! You will be contacted...";
        if (lstBxInterests.SelectedIndex > -1)
        {
            lblSubmit.Text += " to discuss joining the \"" +
                lstBxInterests.SelectedItem.Text +
                "\" team.";
        }
    }

    protected void btnShowMembers_Click(object sender, EventArgs e)
    {
        try
        {
            // set up connection
            string sConnection =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\CSharpProjects\\member.accdb";

            OleDbConnection dbConn = new OleDbConnection(sConnection);

            // set up our sql command
            string sql = "Select FirstName as [First Name], " +
                "LastName as [Last Name] " +
                "From memberTable " +
                "Order by LastName ASC, FirstName ASC;";

            OleDbCommand dbCmd = new OleDbCommand();
            dbCmd.CommandText = sql;
            dbCmd.Connection = dbConn;

            // set up data adapter
            OleDbDataAdapter memberDataAdap = new OleDbDataAdapter();
            memberDataAdap.SelectCommand = dbCmd;

            // set up data set
            DataSet memberDS = new DataSet();
            memberDataAdap.Fill(memberDS, "memberTable");

            // connect our grid view
            grdViewMembers.DataSource = memberDS;
            grdViewMembers.DataBind();
            lblMembers.Visible = true;
            grdViewMembers.Visible = true;
        }
        catch (Exception exc)
        {

            lblMSG.Text = exc.Message;
        }
    }

    protected void btnMeeting_Click(object sender, EventArgs e)
    {
        Calendar1.SelectedDates.Clear();

        DateTime meetingDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 8, 0, 0);

        meetingDate = meetingDate.AddDays(7);

        if (meetingDate.DayOfWeek.ToString() == "Sunday")
        {
            meetingDate = meetingDate.AddDays(1);
        }

        Calendar1.TodaysDate = meetingDate;
        Calendar1.SelectedDate = Calendar1.TodaysDate;

        lblMSG.Text = ("Meeting next week: " + meetingDate.DayOfWeek + ", " + meetingDate.Month + "/" + meetingDate.Day + " at " +
            meetingDate.Hour + "PM");
    }

    protected void radButtons_CheckedChanged(Object sender, EventArgs e)
    {
        if (radBtnFresSop.Checked)
        {
            lblClassif.Text = "Freshmen & Sophomores ";
        }
        else
        {
            if (radBtnJrSr.Checked)
            {
                lblClassif.Text = "Juniors & Seniors";
            }
            else
            {
                if (RadBtnOther.Checked)
                {
                    lblClassif.Text = "Special Students ";
                }
            }
        }
        lblClassif.Text += " Always Welcome!";
    }
}
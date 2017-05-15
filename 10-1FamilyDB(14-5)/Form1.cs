using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;             // data provider for Access

namespace _10_1FamilyDB_14_5_
{
    /// <summary>
    /// Class:      Form1
    /// Developer:  Melissa Bakke
    /// Date:       10/31/2016
    /// Purpose:    Use the data grid control to display the data from an access table
    /// </summary>
    public partial class Form1 : Form
    {
        private OleDbConnection dbConn;     // object to hold our connection
        private string sConnection;         // connection string

        private OleDbCommand dbCmd;         // command object
        private string sql;                 // command to run

        private OleDbDataReader dbReader;   // object for reader
        private Family aFamily;             // object for a table row

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            // Construct an object of the OleDbConnection 
            // class to store the connection string 
            // representing the type of data provider 
            // (database) and the source (actual db)
            try
            {
                sConnection =
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=family.accdb";

                // create our connection
                dbConn = new OleDbConnection(sConnection);
                dbConn.Open();

                // build the command to run
                sql = "SELECT FirstName, LastName, Relationship FROM Family " + 
                    "WHERE Hometown='Springfield, MO' AND Relationship <> 'Me';";

                // construct the command object
                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;

                // tie the OldDbCommand object to the OleDbConnection object
                dbCmd.Connection = dbConn;

                // create a dbReader object
                dbReader = dbCmd.ExecuteReader();

                while (dbReader.Read())
                {
                    aFamily = new
                        Family(dbReader["FirstName"].ToString(),
                        dbReader["LastName"].ToString(),
                        dbReader["Relationship"].ToString());
                    txtName.AppendText(aFamily.FirstName + " " + aFamily.LastName + "\n");
                    txtRel.AppendText(aFamily.Relationship + "\n");
                }

                // close the reader
                dbReader.Close();
                // close the connection
                dbConn.Close();
            } // end of try
            catch (System.Exception exc)
            {
                this.lblMessage.Text = exc.Message;
            } // end of catch
        }
    }
}

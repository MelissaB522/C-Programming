using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // directive to use Access DB

namespace DBExample
{
    public partial class DBGUI : Form
    {
        private OleDbConnection dbConn;     // object to hold our connection
        private string sConnection;         // connection string

        private OleDbCommand dbCmd;         // command object
        private string sql;                 // command to run

        private OleDbDataReader dbReader;   // object for reader
        private Member aMember;             // object for a table row

        public DBGUI()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Construct an object of the OleDbConnection 
            // class to store the connection string 
            // representing the type of data provider 
            // (database) and the source (actual db)
            try
            {
                sConnection =
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=member.accdb";
            
                // create our connection
                dbConn = new OleDbConnection(sConnection);
                dbConn.Open();

                // build the command to run
                sql = "SELECT * FROM memberTable " +
                    "ORDER BY LastName ASC, FirstName ASC;";

                // construct the command object
                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;

                // tie the OldDbCommand object to the OleDbConnection object
                dbCmd.Connection = dbConn;

                // create a dbReader object
                dbReader = dbCmd.ExecuteReader();

                while (dbReader.Read())
                {
                    aMember = new
                        Member(dbReader["FirstName"].ToString(),
                        dbReader["LastName"].ToString());
                    this.lstbxMembers.Items.Add(aMember);
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

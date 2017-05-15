using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // directive to use SQL server

namespace DBExampleSQL
{
    public partial class DBGUI : Form
    {
        private SqlConnection dbConn;     // object to hold our connection
        private string sConnection;         // connection string

        private SqlCommand dbCmd;         // command object
        private string sql;                 // command to run

        private SqlDataReader dbReader;   // object for reader
        private Member aMember;             // object for a table row

        public DBGUI()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Construct an object of the SQLConnection 
            // class to store the connection string 
            // representing the type of data provider 
            // (database) and the source (actual db)
            try
            {
                sConnection =
                    "Data Source=stusql.otc.edu;" +
                    "Initial Catalog=mb0242181;" +
                    "Integrated Security=True;";
            
                // create our connection
                dbConn = new SqlConnection(sConnection);
                dbConn.Open();

                // build the command to run
                sql = "SELECT * FROM memberTable " +
                    "ORDER BY LastName ASC, FirstName ASC;";

                // construct the command object
                dbCmd = new SqlCommand();
                dbCmd.CommandText = sql;

                // tie the SQLCommand object to the SQLConnection object
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

        private void DBGUI_Load(object sender, EventArgs e)
        {

        }
    }
}

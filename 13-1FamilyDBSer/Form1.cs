using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;                    // directive to use Access DB

namespace _13_1FamilyDBSer
{
    /// <summary>
    /// Class:      Form1
    /// Developer:  Melissa Bakke
    /// Date:       11/22/2016
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // clear listbox before updated table is added
            lstbxFamily.Items.Clear();

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
                sql = "SELECT * FROM Family;";

                // construct the command object
                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;

                // tie the OldDbCommand object to the OleDbConnection object
                dbCmd.Connection = dbConn;

                // create a dbReader object
                dbReader = dbCmd.ExecuteReader();

                while (dbReader.Read())
                {
                    aFamily = Serializer.DeSerializeNow(dbReader["Data"].ToString());
                    this.lstbxFamily.Items.Add(aFamily);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // connection string
            sConnection =
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=family.accdb";

            // create our connection
            dbConn = new OleDbConnection(sConnection);
            dbConn.Open();
            string serializedData;
            Family newFamily = new Family(txtFirst.Text, txtLast.Text, txtRelationship.Text);
            serializedData = Serializer.SerializeNow(newFamily);

            // build the command to run
            sql = "INSERT INTO Family(Data)VALUES(@serializedData);";

            // construct the command object
            dbCmd = new OleDbCommand();
            dbCmd.CommandText = sql;

            // add data values
            dbCmd.Parameters.AddWithValue("@serializedData", serializedData);

            // tie the OldDbCommand object to the OleDbConnection object
            dbCmd.Connection = dbConn;

            // execute insert statement
            dbCmd.ExecuteNonQuery();

            // close the connection
            dbConn.Close();

            // clear textboxes after family member is added to table
            txtFirst.Clear();
            txtLast.Clear();
            txtRelationship.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _11_1BooksTable
{
    public partial class FrmBooks : Form
    {
        private SqlConnection dbConn;     // object to hold our connection
        private string sConnection;         // connection string

        private SqlCommand dbCmd;         // command object
        private string sql;                 // command to run

        private SqlDataReader dbReader;   // object for reader
        private Book aBook;             // object for a table row
        private CourseBook aCourse;

        public FrmBooks()
        {
            InitializeComponent();
        }

        private void FrmBooks_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                sql = "SELECT CourseNumber, BT.ISBN, Title FROM BookTable BT JOIN CourseBookTable CBT ON BT.ISBN=Convert(varchar(50), CBT.ISBN) " +
                    "ORDER BY CourseNumber ASC;";

                // construct the command object
                dbCmd = new SqlCommand();
                dbCmd.CommandText = sql;

                // tie the SQLCommand object to the SQLConnection object
                dbCmd.Connection = dbConn;

                // create a dbReader object
                dbReader = dbCmd.ExecuteReader();

                while (dbReader.Read())
                {
                    aCourse = new
                        CourseBook(dbReader["CourseNumber"].ToString(),
                        dbReader["ISBN"].ToString(),
                        dbReader["Title"].ToString());
                    this.lstbxBooks.Items.Add(aCourse.ToString());
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

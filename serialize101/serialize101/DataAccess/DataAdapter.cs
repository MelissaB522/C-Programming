using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// add the using for sql and arraylist
using System.Data.SqlClient;


namespace serialize101
{
    class DataAdapter
    {
        // connection string that is needed for connecting to the DB
        // Data Source is the name of the server
        // If off campus, the server is stusql.otc.edu
        // Initial Catalog is the name of the DB (student ID)
        // Integrated Security using Windows Authentication
        // will not work off campus - unless you use the batch file
        static SqlConnection oConn = new SqlConnection("Data Source=stusql.otc.edu;Initial Catalog=mb0242181;Integrated Security=True");

        private static void Connect()
        {
            try
            {
                // SQLConnection object calls the Open()
                // method to open the connection to the DB
                // using the information provided in the connection
                // string
                oConn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void Disconnect()
        {
            try
            {
                // sqlConnection object calls the Close()
                // method to terminate the connection to the DB
                oConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Insert(string data)
        {
            string sqlIns = "INSERT INTO Records(info)VALUES(@data)";
            try
            {
                Connect();
                // setup the command
                SqlCommand cmdIns = new SqlCommand(sqlIns, oConn);
                // add our data values
                cmdIns.Parameters.AddWithValue("@data", data);
                // execute the command (nonquery because it is an insert)
                cmdIns.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using statements for serialization
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace FinalProject_Jeopardy
{
    /// <summary>
    /// Class: Serializer
    /// Developer: Melissa Bakke
    /// Date: 12/13/16
    /// Assignment: Final Project - Jeopardy
    /// </summary>
    class Serializer
    {
        public static string SerializeNow(Player[] newPlayer)
        {
            // setup a memory stream - it is needed to hold the object
            // in memory during the format and transform process
            MemoryStream myStream = new MemoryStream();

            // setup a binary formatter object that perform
            // the format process for serialization
            // (contains the methods to perform the serialization
            BinaryFormatter myFormat = new BinaryFormatter();

            // we call the serialize method, passing the stream and
            // the object it will transform
            myFormat.Serialize(myStream, newPlayer);

            // once we have serialized, we convert to a base 64 string
            // of encoded data for easy storage
            string serializedValue = Convert.ToBase64String(myStream.ToArray());

            // moved insert method to Person class

            // call the deserialize method
            DeSerializeNow(serializedValue);

            // close the memory stream
            myStream.Close();

            // return value
            return serializedValue;
        }

        // changed from public to private
        public static Player[] DeSerializeNow(string encodedData)
        {
            // create a generic object to hold the object since we don't know its type
            object type;

            // create a stream and binary formatter to reverse the encoding and give the stream the incoming data
            MemoryStream myStream = new MemoryStream(Convert.FromBase64String(encodedData));
            BinaryFormatter myFormat = new BinaryFormatter();

            // deserialize what we have in memory into the generic object
            type = myFormat.Deserialize(myStream);

            // Close the memory stream
            myStream.Close();

            return (Player[])type;
        }
    }
}

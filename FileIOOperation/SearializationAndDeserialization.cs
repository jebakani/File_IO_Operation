using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperation
{
    class SearializationAndDeserialization
    {
        //converting the object into the binary format
        public void BinarySerialization()
        {
            string path = @"C:\Users\HP1\source\repos\Lambda\New folder\FileIOOperation\Binary.txt";
            //creating the object for the personData
            PersonData data = new PersonData();
            data.name = "Jeba";
            data.age = 21;
            data.name = "acx";
            data.age = 31;
            //creating the stream for the file to write
            FileStream file = File.OpenWrite(path);
            //it convert the object into binary format
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, data);
        }
    }
}

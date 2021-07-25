using Newtonsoft.Json;
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
        public void BinaryDeSerialization()
        {
            string path = @"C:\Users\HP1\source\repos\Lambda\New folder\FileIOOperation\Binary.txt";
            //creating the stream for the file to write
            FileStream file = File.OpenRead(path);
            BinaryFormatter binary = new BinaryFormatter();
            //deserialize the binary format into object
            PersonData person = (PersonData)binary.Deserialize(file);
            Console.WriteLine("Person detail");
            Console.WriteLine("Name:{0}  Age{1}",person.name,person.age);
        }
        //converting the object into the json file
        public void JSONSerialization()
        {
            try
            {
                string path = @"C:\Users\HP1\source\repos\Lambda\New folder\FileIOOperation\PersonData.json";
                PersonData person = new PersonData() { name="Jeba", age= 10};
                string res = JsonConvert.SerializeObject(person);
                File.WriteAllText(path, res);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

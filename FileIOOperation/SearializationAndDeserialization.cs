using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIOOperation
{
    class SearializationAndDeserialization
    {
        //converting the object into the binary format
        public void BinarySerialization()
        {
            string path = @"C:\Users\HP1\source\repos\Lambda\New folder\FileIOOperation\Binary.txt";
            //creating the object for the personData
            PersonData data = new PersonData("acx",31);
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
                PersonData person = new PersonData("abc",20); 
                string res = JsonConvert.SerializeObject(person);
                File.WriteAllText(path, res);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //converting the json file into object
        public void JSONDeSerialization()
        {
            try
            {
                string path = @"C:\Users\HP1\source\repos\Lambda\New folder\FileIOOperation\PersonData.json";
                string res = File.ReadAllText(path);
                //deserialize the object and store it in the object
                PersonData person=JsonConvert.DeserializeObject<PersonData>(res);
                if(person!=null)
                {
                    Console.WriteLine("Name:{0}  Age:{1}",person.name,person.age);
                }
                else
                {
                    Console.WriteLine("File is empty");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //converting the object into the xml format
        public void XMLSerialization()
        {
            string path = @"C:\Users\HP1\source\repos\Lambda\New folder\FileIOOperation\XMLFile2.xml";
            //creating the object for the personData
            PersonData data = new PersonData("jeba",21);
            //creating the stream for the file to write
            FileStream file = File.OpenWrite(path);
            //it convert the object into xml format
            XmlSerializer serializer = new XmlSerializer(typeof(PersonData));
            serializer.Serialize(file, data);
        }
    }
}

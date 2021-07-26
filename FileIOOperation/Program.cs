using System;
using System.Collections.Generic;

namespace FileIOOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO Operation");
            //SearializationAndDeserialization operation = new SearializationAndDeserialization();
            ////operation.BinarySerialization();
            //operation.BinaryDeSerialization();
            //operation.JSONSerialization();
            //operation.JSONDeSerialization();
            //operation.XMLSerialization();
            new CSVFileOperation().ReadInput();
            Console.Read();
        }
        
    }
}

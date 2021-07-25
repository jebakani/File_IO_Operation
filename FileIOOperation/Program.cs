using System;

namespace FileIOOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO Operation");
            SearializationAndDeserialization operation = new SearializationAndDeserialization();
            //operation.BinarySerialization();
            operation.BinaryDeSerialization();
            Console.Read();
        }
        
    }
}

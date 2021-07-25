using System;

namespace FileIOOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO Operation");
            string filepath = @"C:\Users\HP1\Desktop\TestFiles.txt";
            string outputFile = @"C:\Users\HP1\source\repos\Lambda\New folder\FileIOOperation\TestFile2.txt";
            BasicOperation.FileExists(filepath);
            BasicOperation.ReadAllLine(filepath);
            BasicOperation.ReadFile(filepath);
            BasicOperation.CopyFile(filepath, outputFile);
            Console.Read();
        }
        
    }
}

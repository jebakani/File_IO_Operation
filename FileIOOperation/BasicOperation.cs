using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOOperation
{
    class BasicOperation
    {
        //checking the file exists in the location or not
        public static void FileExists(string filepath)
        {
            if(File.Exists(filepath))
            {
                Console.WriteLine("File exists in the given path");
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        }
        //reading the file line by line
        public static void ReadAllLine(string filepath)
        {
            //storing the each line in array
            string[] lines;
            lines = File.ReadAllLines(filepath);
            for(int i=0;i<lines.Length;i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
        //reading all the line as single string
        public static void ReadFile(string filePath)
        {
            string text;
            text = File.ReadAllText(filePath);
            Console.WriteLine("{0}",text);
        }
        //make the copy of the text file
        public static void CopyFile(string InputFile,string OutputFile)
        {
            File.Copy(InputFile, OutputFile);
            Console.WriteLine("File is copied");
        }
        //Deleting the particular file 
        public static void DeleteFile(string filePath)
        {
            File.Delete(filePath);
            Console.WriteLine("File is deleted");
        }
        //Reading the file using stream reader
        public static void ReadFromStreamReader(string filePath)
        {
            Console.WriteLine("Reading text using file reader");
            StreamReader reader = File.OpenText(filePath);
            string text = "";
            while((text=reader.ReadLine())!=null)
            {
                Console.WriteLine(text);
            }
        }
    }
}

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
    }
}

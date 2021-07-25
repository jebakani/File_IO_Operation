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
    }
}

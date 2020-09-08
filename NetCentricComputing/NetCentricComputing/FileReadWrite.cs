using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NetCentricComputing
{
    class FileReadWrite
    {
        static void Main(string[] args)
        {
            string path = "file1.txt";
            string newPath = "file3.txt";
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "This is a file handling in c#.");
            }
            else {
                Console.WriteLine($"File already exists in {path}");
            }
            File.AppendAllText(path,"Appending in the new line in the existing file");
            string mytxt = File.ReadAllText(path);
            if (!File.Exists(newPath))
            {
                File.Copy(path, newPath);
            }
            else
            {
                Console.WriteLine($"File already exists in {newPath}");

            }
            string newtxt = File.ReadAllText(newPath);
            Console.WriteLine(newtxt);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;


namespace assignment7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create directory
            String path = @"C:\Users\NIKAKADE\source\repos\assignment7_1";
            DirectoryInfo f1 = new DirectoryInfo(path);

            f1.Create();//to display msg
            
                Console.WriteLine("Directory Created");     
            
            Console.WriteLine("Directory path =" + f1.FullName);

            //get the directory name
            Console.WriteLine("Directory Name = " + f1.Name);

            //get the parent directory
            Console.WriteLine("Parent Diretcory = " + f1.Parent);
            //Console.WriteLine( f1.LastAccessTime);
            //Return name of sub directory
            string[] directory = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            //return the name of sub file
            string[] file = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            //retrun name of sub files
            Console.WriteLine("Directory Details with sub directory--");

            foreach(String diNext in directory)
            {
                var dirInfo = new DirectoryInfo(diNext);
                Console.WriteLine(dirInfo.FullName);
            }
            foreach(String fiNext in directory)
            {
                var fileInfo = new FileInfo(fiNext);
                Console.WriteLine(fileInfo.FullName);
            }
       }
    }
}

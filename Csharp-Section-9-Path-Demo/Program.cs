using System;
using System.IO;
namespace CsharpSection9PathDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Wrld!");
            var path = @"/Users/faysalregal/Desktop/C# Fundamentals/Section 9 Working with Files/Demo/Csharp-Section-9-Directory-Demo/Csharp-Section-9-Directory-Demo.sln";

            //Old way
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            //Convenient Way
            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory: " + Path.GetDirectoryName(path));
        }
    }
}

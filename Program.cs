using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;
 
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            StringReader stringReader = new StringReader("\"Приветик\" 123123 \"Как дела?\"");
            using (var parser = new TextFieldParser(stringReader))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(" ");
 
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
 
                    foreach (string field in fields)
                    {
                        Console.WriteLine(field);
                    }
                }
 
                Console.ReadKey();
            }
        }
    }
}
using System;



namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write(123);
            for (int i = 0; i < 100; i++) {
                Console.Beep();
                i = 100;
            }
        }
    }
}
using System;



namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int size;
            Console.WriteLine("Введите, какой длины будет массив");
            size = Console.Read();
            List<int> arr = new List<int>();
            for(int i = 0; i < size; i++) {
                int tmp;
                tmp = Console.Read();
                arr[i] = tmp;
            }
            for(int i = 0; i < size; i++) {
                Console.Write(arr[i]);
            }
        }
    }
}
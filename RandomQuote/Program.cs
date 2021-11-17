using System;
using System.IO;


namespace RandomQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\users\opilane\samples\Randomquote.txt";            
            string[] dataFromFile = File.ReadAllLines(filePath);
            Console.WriteLine(dataFromFile[0]);
            Random rnd = new Random();
            int randomindex = rnd.Next(dataFromFile.Length);
            Console.WriteLine(dataFromFile[randomindex]);
        }
    }
}

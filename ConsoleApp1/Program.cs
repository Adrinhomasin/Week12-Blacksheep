using System;
using System.IO;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\Samples\autumn.txt";
            string otherFilePath = @"C:\Users\opilane\Samples\winter.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string[] dataFromFile1 = File.ReadAllLines(otherFilePath);

            File.WriteAllLines(dataFromFile, filePath);
            File.WriteAllLines(otherFilePath, dataFromFile);
        }
    }
}

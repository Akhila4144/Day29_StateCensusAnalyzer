using System;

namespace IndianStatesCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("read data from csv and write data to json");
            CsvHandler.Implement();

            Console.ReadKey();
        }
    }
    }


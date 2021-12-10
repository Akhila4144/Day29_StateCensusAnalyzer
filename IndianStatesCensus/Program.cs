using System;

namespace IndianStatesCensus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("read data from csv and write data to json");
            CsvHelper.Implement();

            Console.ReadKey();
        }
    }
}

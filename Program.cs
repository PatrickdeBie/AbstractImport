using System;

namespace AbstractClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var importService = new ImportBoxService();

            importService.Import();
        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            plus sum = new plus();
            int n = sum.Add(12, 3);
            Console.WriteLine(n);

            keisann sum2 = new keisann();
            int n2 = sum2.App(12, 3);
            Console.WriteLine(n2);
            Console.ReadKey();

        }
    }
}

using System;

namespace HRSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Console.WriteLine(manager.GetTotalPension());
            Console.WriteLine();
        }
    }
}

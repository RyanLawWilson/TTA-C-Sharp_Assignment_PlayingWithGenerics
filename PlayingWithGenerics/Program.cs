using System;
using System.Collections.Generic;

namespace PlayingWithGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Some random things that an employee might have.
            List<string> things = new List<string>()
                { "Cool Thing", "Ball of Yarn", "Collection of Mirrors",
                  "Magestic Table Cloth", "An Apple", "Super Cool Pencil"};

            List<int> numbers = new List<int>()
                { 1, 3, 5, 6, 2, 2, 2, 1, 5, 6, 1, 5};


            Employee<string> employee1 = new Employee<string>();

            Console.WriteLine("Check out this Employee with his things!");
            System.Threading.Thread.Sleep(1000);
            employee1.Things = things;
            employee1.ShowList();

            System.Threading.Thread.Sleep(2000);

            Employee<int> employee2 = new Employee<int>();

            Console.WriteLine("\nCheck out this Employee with his numbers!");
            System.Threading.Thread.Sleep(1000);
            employee2.Things = numbers;
            employee2.ShowList();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Кошка", "Мяу");
            cat1.ShowInfo();

            Dog dog1 = new Dog("Собака", "Гав");
            dog1.ShowInfo();
            Console.ReadKey();
        }
    }
}

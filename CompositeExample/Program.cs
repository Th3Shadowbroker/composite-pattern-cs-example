using CompositeExample.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager man1 = new Manager("Harald", "Götz");
            Manager man2 = new Manager("Lisa", "Hartung");
            Employee emp1 = new Employee("Klaus", "Schmitz");
            Employee emp2 = new Employee("Jennifer", "Mayson");
            Employee emp3 = new Employee("Birgit", "Müller");

            man1.Add(man2, emp1, emp2);
            man2.Add(emp3);

            man1.PrintToConsole();
            Console.ReadKey();
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample.Classes
{
    /// <summary>
    /// Diese Klasse Repräsentiert einen gewöhnlichen Mitarbeiter.
    /// </summary>
    public class Employee: EmployeeComponent
    {
        /// <summary>
        /// Konstruktor von Employee.
        /// </summary>
        /// <param name="firstName">Vorname</param>
        /// <param name="lastName">Nachname</param>
        public Employee(string firstName, string lastName): base(firstName, lastName)
        {

        }

        /// <summary>
        /// Stelle einen Employee in der Konsole da.
        /// </summary>
        /// <param name="intentionLevel">Gibt an mit welcher Anzahl von Tabulatoren die Darstellung erfolgen soll.</param>
        public override void PrintToConsole(int intentionLevel = 0)
        {
            string intends = "";
            for (int i = 0; i < intentionLevel; i++) intends += "\t";
            Console.WriteLine(String.Format("{0}{1} {2}", intends, FirstName, LastName));
        }
    }
}

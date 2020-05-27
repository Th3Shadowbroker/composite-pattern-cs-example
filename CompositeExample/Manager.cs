using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample.Classes
{
    /// <summary>
    /// Diese Klasse repräsentiert einen Mitarbeiter dem andere Mitarbeiter untergeordnet sind.
    /// </summary>
    public class Manager: EmployeeComponent
    {
        /// <summary>
        /// Die Liste aller untergeordneten Mitarbeiter.
        /// </summary>
        private List<EmployeeComponent> subordinates;
        
        /// <summary>
        /// Konstruktor von Manager.
        /// </summary>
        /// <param name="firstName">Vorname</param>
        /// <param name="lastName">Nachname</param>
        public Manager(string firstName, string lastName) : base(firstName, lastName)
        {
            this.subordinates = new List<EmployeeComponent>();
        }

        /// <summary>
        /// Stelle einen Manager in der Konsole da.
        /// </summary>
        /// <param name="intentionLevel">Gibt an mit welcher Anzahl von Tabulatoren die Darstellung erfolgen soll.</param>
        public override void PrintToConsole(int intentionLevel = 0)
        {
            string intends = "";
            for (int i = 0; i < intentionLevel; i++) intends += "\t";
            Console.WriteLine(String.Format("{0}{1} {2}\n{3}{4}", intends, FirstName, LastName, intends, "Subordinates:"));
            subordinates.ForEach(subordinate => subordinate.PrintToConsole(intentionLevel + 1));
        }

        /// <summary>
        /// Fügt einen oder mehrere untergeordneten Mitarbeiter hinzu.
        /// </summary>
        /// <param name="employeeComponents">Mitarbeiter oder Manager die hinzugefügt werden sollen.</param>
        public void Add(params EmployeeComponent[] employeeComponents)
        {
            foreach( EmployeeComponent employeeComponent in employeeComponents )
            {
                this.subordinates.Add(employeeComponent);
            }
        }

        /// <summary>
        /// Entfernt einen spezifischen Mitarbeiter.
        /// </summary>
        /// <param name="employeeComponent"></param>
        public void Remove(EmployeeComponent employeeComponent)
        {
            this.subordinates.Remove(employeeComponent);
        }
    }
}

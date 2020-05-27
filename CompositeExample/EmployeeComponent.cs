using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample.Classes
{
    /// <summary>
    /// Abstrakte Darstellung eines grundlegenden Mitarbeiters.
    /// </summary>
    public abstract class EmployeeComponent
    {
        /// <summary>
        /// Konstruktor dieser Superklasse.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public EmployeeComponent(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Vorname
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Nachname
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Stellt die erbende Klasse in der Konsole da.
        /// </summary>
        /// <param name="intentionLevel"></param>
        public abstract void PrintToConsole(int intentionLevel = 0);

    }
}

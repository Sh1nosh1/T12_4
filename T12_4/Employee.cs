using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T12_4
{
    internal class Employee
    {
        /// <summary>
        /// Name
        /// </summary>
        string name;
        public string FirstName 
        {
            get { return name; }
            set { name = value;}
        }
        /// <summary>
        /// Surname
        /// </summary>
        public string surname;
        /// <summary>
        /// Minimal salary
        /// </summary>
        public double minsalary;
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Employee() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="minsalary"></param>
        public Employee (string name, string surname, int minsalary)
        {
            this.name = name; this.surname = surname; this.minsalary = minsalary;
        }
        /// <summary>
        /// Output
        /// </summary>
        public void Output()
        {
            WriteLine($"Name: {name}\tSurname: {surname}\nMinimal salary: {minsalary}\n");
        }
        /// <summary>
        /// Output Income
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public double Income(double k)
        {
            return minsalary * k;
        }
        


    }
}

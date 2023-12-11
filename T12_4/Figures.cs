using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T12_4
{
    class Figures
    {
        /// <summary>
        /// Name
        /// </summary>
        public string name;
        /// <summary>
        /// First side
        /// </summary>
        public int side1;
        /// <summary>
        /// Second side
        /// </summary>
        public int side2;
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Figures() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        public Figures(string name, int side1, int side2)
        {
            this.name = name;
            this.side1 = side1;
            this.side2 = side2;
        }
        /// <summary>
        /// Output
        /// </summary>
        public void ShowInfo()
        {
            WriteLine($"Name: {name}\nSide1: {side1}\nSide2: {side2}\nSide3: {side3}\n");
        }
        /// <summary>
        /// Calculation
        /// </summary>
        public void Calc()
        {
            WriteLine($"per:{side1+side2+side3}\narea: {side1*side2*side3}");
        }
        /// <summary>
        /// Third side
        /// </summary>
        public int side3;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        public Figures(string name, int side1, int side2, int side3) : this(name, side1, side2)
        {
            this.side3 = side3;
        }
    }
}

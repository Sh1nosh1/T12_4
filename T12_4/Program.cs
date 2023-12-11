using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace T12_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Task 1
                /*Figures figure1 = new Figures("Прямоугольник", 2, 3);
                figure1.ShowInfo();
                figure1.Calc();
                WriteLine();
                Write("Введите имя: ");
                string name = ReadLine();
                Write("Введите 1 сторону: ");
                int side1 = Convert.ToInt32(ReadLine());
                Write("Введите 2 сторону: ");
                int side2 = Convert.ToInt32(ReadLine());
                Write("Введите 3 сторону: ");
                int side3=Convert.ToInt32(ReadLine());
                WriteLine();
                Figures figure3 = new Figures(name, side1, side2, side3);
                figure3.ShowInfo();
                figure3.Calc();*/

                //Task 2.7

                Employee employee = new Employee("Kirill", "Markov", 3000);
                employee.Output();

                Write("Enter a increasing factor: ");
                double k = Convert.ToDouble(ReadLine());

                WriteLine($"Income: {employee.Income(k)}");
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}

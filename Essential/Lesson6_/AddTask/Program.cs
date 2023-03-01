using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Потрібно: 
    Створити статичний клас Calculator, з методами виконання основних арифметичних операцій. 
    Написати програму, яка виводить на екран основні арифметичні операції.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(9, 71.5));
            Console.WriteLine(Calculator.Subtraction(90, 4.5));
            Console.WriteLine(Calculator.Multiply(10, 20));

            if (Calculator.Division(11, 5) != 0)
            {
                Console.WriteLine(Calculator.Division(11, 5));
            }
            else
            {
                Console.WriteLine("На нуль дiлити неможна");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Створіть чотири лямбда оператора для виконання арифметичних дій: 
    (Add – додавання, Sub – віднімання, Mul – множення, Div – поділ). 
    Кожен лямбда оператор повинен приймати два аргументи та повертати результат обчислення. 
    Лямбда оператор поділу повинен перевірити поділ на нуль. 
    Написати програму, яка виконуватиме арифметичні дії, вказані користувачем. 
     */
    internal class Program
    {
        delegate double MyDelegate(int a, int b);

        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть перше число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть друге число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть оператор(+,-,*,/)");
            string z = Convert.ToString(Console.ReadLine());

            MyDelegate op = null;

            switch (z)
            {
                case "+":
                    op = (x, y) => { return x + y; };
                    break;
                case "-":
                    op = (x, y) => { return x - y; };
                    break;
                case "*":
                    op = (x, y) => { return x * y; };
                    break;
                case "/":
                    op = (x, y) =>
                    {
                        if (y != 0)
                        {
                            return x / (double)y;
                        }
                        else
                        {
                            Console.WriteLine("На нуль ділити не можна!");
                            return 0;
                        }
                    };
                    break;
                default:
                    Console.WriteLine("Ви неправильно ввели знак операції!");
                    break;
            }
            Console.WriteLine(new string('-', 30));
            if (op != null)
                Console.WriteLine("{0:##.###}", op(a, b));

            // Delay.
            Console.ReadKey();
        }
    }
}

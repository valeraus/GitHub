using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Створіть статичний клас із методом void Print (string stroka, int color), який виводить на екран рядок заданим кольором. 
    Використовуючи перелік, створіть набір кольорів, доступних користувачеві. 
    Введення рядка та вибір кольору надайте користувачеві. 
     */
        enum Colors
        {
            Blue = 0,
            Red = 1,
            Green = 2
        }

        static class MyClass
        {
            public static void Print(string stroka, int color)
            {
                switch (color)
                {
                    case (int)Colors.Blue:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case (int)Colors.Green:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case (int)Colors.Red:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    default:
                        Console.WriteLine("Введена вами строка буде виведена кольором за замовчуванням!");
                        break;
                }

                Console.WriteLine(stroka);
            }
        }
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть строку:");
            string line = Console.ReadLine();

            Console.WriteLine("Вкажіть колір: ( 0-blue, 2-green, 1-red)");
            int color = Convert.ToInt32(Console.ReadLine());

            MyClass.Print(line, color);

            // Delay.
            Console.ReadKey();
        }
    }
}

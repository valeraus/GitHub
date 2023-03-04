using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Створіть анонімний метод, який приймає в якості параметрів три цілочисельних аргументу 
    і повертає середнє арифметичне цих аргументів.
     */
    internal class Program
    {
        private delegate double Mydelrgate(int a, int b, int c);

        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть перше число");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть друге число");
            int j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть третє число");
            int k = Convert.ToInt32(Console.ReadLine());

            Mydelrgate del = (a, b, c) => (double)(a + b + c) / 3;
            Console.WriteLine("Середнє арифметичне введених чисел {0:##.###}", del(i, j, k));

            // Delay.
            Console.ReadKey();
        }
    }
}

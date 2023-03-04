using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Створіть анонімний метод, який приймає як аргумент масив делегатів 
    і повертає середнє арифметичне значення значень методів, повідомлених з делегатами в масиві. 
    Методи, повідомлені з делегатами з масиву, повертають випадкове значення типу int. 
     */
    internal class Program
    {
        delegate int MyDelegate();
        delegate double MyDel(MyDelegate[] a);

        static int GetRandom()
        {
            return new Random().Next(100);
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            Console.WriteLine("Введіть число елементів масиву:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 50));

            var array = new MyDelegate[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new MyDelegate(GetRandom).Invoke();
            }

            MyDel d = delegate (MyDelegate[] c)
            {
                double sr = 0;
                for (int i = 0; i < c.Length; i++)
                {
                    sr += c[i].Invoke();
                }
                return sr / array.Length;
            };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].Invoke() + " ");
            }

            Console.WriteLine("\nСереднє арифметичне елементів {0:##.###}", d(array));

            //Delay
            Console.ReadKey();
        }
    }
}

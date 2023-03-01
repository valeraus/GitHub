using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Потрібно: створити розширюючий метод для цілого масиву, який сортує елементи масиву за зростанням. 
     */
    static class Extend
    {
        static public void SortUp(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[i] > array[j])
                    {
                        int x = array[j];
                        array[j] = array[i];
                        array[i] = x;
                    }

                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 0, 2, 3, 7, 8, 9, 6 };

            array.SortUp();

            foreach (int a in array)
                Console.Write(a + "  ");

            // Delay.
            Console.ReadKey();
        }
    }
}

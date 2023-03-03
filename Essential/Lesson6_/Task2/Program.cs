using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Потрібно:
    Створити статичний клас FindAndReplaceManager з методом void FindNext (string str) 
    для пошуку по книзі з прикладу уроку 005_Book. 
    При виклику цього методу, проводиться послідовний пошук рядка в книзі.
     */
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }
    }

    static class FindAndReplaceManager
    {
        static public void FindNext(string str)
        {
            Book a = new Book();
            a.FindNext(str);
        }
    }

    class Program
    {
        static void Main()
        {
            FindAndReplaceManager.FindNext("Hello");

            // Delay.
            Console.ReadKey();
        }
    }
}

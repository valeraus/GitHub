using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Створіть структуру з ім'ям – Notebook. Поля структури: модель, виробник, вартість. 
    У структурі має бути реалізований конструктор для ініціалізації полів та метод для виведення вмісту полів на екран. 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Notebook notebook1 = new Notebook("X556U", "ASUS", 570);
            notebook1.Show();

            Notebook notebook2 = new Notebook("Inspirion");
            notebook2.Show();

            //Notebook notebook3 = new Notebook();
            //notebook3.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Потрібно: 
    Описати структуру з ім'ям Train, що містить такі поля: назву пункту призначення, номер поїзда, час відправлення. 
    Написати програму, яка виконує такі дії: 
    введення з клавіатури даних до масиву, що складається з восьми елементів типу Train 
    (записи мають бути впорядковані за номерами поїздів); 
    виведення на екран інформації про поїзд, номер якого введено з клавіатури 
    (якщо таких поїздів немає, вивести відповідне повідомлення). 
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            var train = new Train[8];

            MyClass.AddingAnArray(train);
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Ви ввели таку інформацію про поїзди:");
            Console.WriteLine(new string('-', 50));

            MyClass.Sort(train);
            MyClass.Show(train);

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Введіть номер поїзда:");
            int poisk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('-', 50));
            MyClass.Search(train, poisk);

            //Delay.
            Console.ReadKey();
        }
    }
}

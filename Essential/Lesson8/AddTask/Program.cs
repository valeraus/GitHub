using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Реалізуйте програму, яка прийматиме від користувача дату народження і виводити кількість днів до наступного дня народження.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            DateTime now = DateTime.Now;
            DateTime birthday;
            TimeSpan wait;

            Console.WriteLine("Введіть дату вашого народження у форматі 'рррр, мм, дд'");
            birthday = Convert.ToDateTime(Console.ReadLine());


            DateTime thisYear = new DateTime(now.Year, birthday.Month, birthday.Day);

            if (thisYear < now)
            {
                thisYear = new DateTime(now.Year + 1, birthday.Month, birthday.Day);
                wait = thisYear - now;
            }
            else
            {
                wait = thisYear - now;
            }

            Console.WriteLine("До дня народження залишилось {0} днів", wait.Days);

            // Delay.
            Console.ReadKey();
        }
    }
}

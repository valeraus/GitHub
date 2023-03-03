using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Створіть перелік, який містить посади співробітників як імена констант. 
    Надайте кожній константі значення, що задає кількість годин, які повинен відпрацювати співробітник протягом місяця. 
    Створіть клас Accountant з методом bool AskForBonus (Post worker, int hours), що відображатиме давати співробітнику премію. 
    Якщо співробітник відпрацював більше годин на місяць, то йому належить премія.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Введіть кільскість відпрацьованих годин: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Accauntant a = new Accauntant();

            if (a.AskForBonus(Post.Cleaner, hours))
            {
                Console.WriteLine("Дати премію");
            }
            else
            {
                Console.WriteLine("Не давати премію");
            }

            //Delay.
            Console.ReadKey();
        }
    }
}

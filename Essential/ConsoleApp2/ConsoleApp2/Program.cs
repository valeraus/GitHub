using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCore
{
    enum MyEnam
    {
        yellow = 4, white = 4, blue = 4, cyan = 4
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Array aray = Enum.GetValues(typeof(MyEnam));
            foreach (MyEnam enam in aray)
                Console.WriteLine(enam);


            for (int i = 0; i < aray.Length; i++)
            {
                if (aray.GetValue(i).ToString() == "green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (aray.GetValue(i).ToString() == "red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (aray.GetValue(i).ToString() == "blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (aray.GetValue(i).ToString() == "cyan")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.WriteLine((int)aray.GetValue(i) + " --- " + aray.GetValue(i).ToString() + " " + i);
                Console.ResetColor();
            }


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*
    Створіть клас MyClass і структуру MyStruct, які містять поля public string change. 
    У класі Program створіть два методи: static void ClassTaker(MyClass myClass), 
    який надає полю change екземпляра myClass значення «змінено». static void StruktTaker(MyStruct myStruct), 
    який надає полю change екземпляра myStruct значення «змінено». 
    Продемонструйте різницю у використанні класів та структур, створивши у методі Main() екземпляри структури та класу. 
    Змініть значення полів екземплярів на «не змінено», а потім викличте методи ClassTaker і StruktTaker. 
    Виведіть на екран значення полів екземплярів. Проаналізуйте отримані результати. 
     */
    class MyClass
    {
        public string change;
    }
    struct MyStruct
    {
        public string change;
    }
    internal class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            //MyClass myClass1 = new MyClass();
            myClass.change = "змінено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            //MyStruct myStruct1 = new MyStruct();
            myStruct.change = "змінено";
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.change = "не змінено";
            myStruct.change = "не змінено";
            ClassTaker(myClass);
            StruktTaker(myStruct);
            Console.WriteLine("Поле класу = {0}", myClass.change);
            Console.WriteLine("Поле структури = {0}",myStruct.change);

            //Dellay
            Console.ReadKey();
        }
    }
}

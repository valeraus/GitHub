using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Розширте приклад уроку 005_Book, створивши в класі Book вкладений клас Notes, який дозволить зберігати нотатки читача.
     */
    class Book
    {
        public class Note
        {
            string text = "";
            public string Text
            {
                get { return text; }
                set
                {
                    if (text != "")
                        text += "\n";
                    text += value;
                }

            }
        }
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
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
        static void Main(string[] args)
        {
            Book.Note note = new Book.Note();

            note.Text = "Good book";
            note.Text = "I like it!";

            Console.WriteLine(note.Text);

            // Delay.
            Console.ReadKey();
        }
    }
}

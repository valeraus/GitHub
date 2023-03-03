using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /* 
    Описати структуру з ім'ям Train, що містить такі поля: назву пункту призначення, номер поїзда, час відправлення. 
    */
    public struct Train
    {
        private string punkt;
        private int number;
        private DateTime time;

        public Train (string punkt, int number, DateTime time)
        {
            this.punkt = punkt;
            this.number = number;
            this.time = time;
        }
        public string Punkt
        {
            get { return punkt; }
        }
        public int Number
        {
            get { return number; }
        }
        public DateTime Time 
        { 
            get { return time; } 
        }
    }
}

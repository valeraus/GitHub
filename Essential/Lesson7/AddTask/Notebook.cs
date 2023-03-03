using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    /*
        Створіть структуру з ім'ям – Notebook. Поля структури: модель, виробник, вартість. 
        У структурі має бути реалізований конструктор для ініціалізації полів та метод для виведення вмісту полів на екран. 
 */
    internal struct Notebook
    {
        private string model;
        private string vyrobnyk;
        private int cost;

        public Notebook (string model, string vyrobnyk, int cost)
        {
            this.model = model;
            this.vyrobnyk = vyrobnyk;
            this.cost = cost;
        }
        public Notebook(string model)
            : this(model, "", 0)
        {
        }
        public Notebook(int cost)
            : this("", "", cost)
        {
        }
        public string Model { get { return model; } }
        public string Vyrobnyk { get {  return vyrobnyk; } }
        public int Cost { get { return cost; } }

        public void Show()
        {
            Console.WriteLine("Модель: {0}, Виробник:  {1}, Вартість: {2}$ ", model, vyrobnyk, cost);
        }
    }
}

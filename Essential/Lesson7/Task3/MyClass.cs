using System;

namespace Task3
{
    public static class MyClass
    {
        public static void Sort(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                for (int q = 0; q < trains.Length; q++)
                {
                    if (trains[i].Number <= trains[q].Number)
                    {
                        Train g = trains[i];
                        trains[i] = trains[q];
                        trains[q] = g;
                    }
                }
            }
        }

        public static void Search(Train[] train, int poisk)
        {
            bool ok = false;
            for (int i = 0; i < train.Length; i++)
            {
                if (train[i].Number == poisk)
                {
                    Console.WriteLine("Номер поїзда: {0} Пункт призначення: {1} Дата і час відправки: {2} ", 
                        train[i].Number, train[i].Punkt, train[i].Time);
                    ok = true;

                }
            }
            if (!ok)
                Console.WriteLine("Поїзд не знайдено!");
        }

        public static void AddingAnArray(Train[] train)
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.Write("Введіть пункт призначення поїзда:");
                string punkt = Console.ReadLine();
                punkt = string.IsNullOrEmpty(punkt) ? "Не вказаний пункт призначення" : punkt;

                Console.Write("Введіть номер поїзда:");
                string d = Console.ReadLine();
                int Number = string.IsNullOrEmpty(d) ? 0 : Convert.ToInt32(d);

                Console.Write("Введіть дату відправки:");
                d = Console.ReadLine();
                DateTime date = string.IsNullOrEmpty(d) ? DateTime.Now : DateTime.Parse(d);

                train[i] = new Train(punkt, Number, date);
            }
        }

        public static void Show(Train[] train)
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.WriteLine("Номер поїзда: {0} Пункт призначення: {1} Дата і час відправки: {2} ", train[i].Number,
                                  train[i].Punkt, train[i].Time);

            }
        }
    }
}
namespace Task3
{
    enum Post
    {
        // посади співробітників і кількість відпрацьованих годин за місяць
        Manager = 195,
        Developer = 200,
        Accountant = 192,
        Secretary = 192,
        Cleaner = 192
    }

    class Accauntant
    {
        // метод який рахує давати співробітнику премію чи ні, якщо співробітник відпрацював 192 години на місяць і більше - премію давати
        public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
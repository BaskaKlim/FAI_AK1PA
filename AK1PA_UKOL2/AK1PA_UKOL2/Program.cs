using System;

namespace AK1PA_UKOL2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[] { 1, 9, 4, 5, 6, 10, 2 };

            // TODO:vypiste na konzoli hodnotu prvniho prvku

            Console.WriteLine(pole[0]);

            // TODO: vypiste na konzoli hodnotu posledniho prvku

            Console.WriteLine(pole[pole.Length-1]);
            // TODO: najdete a vypiste hodnotu nejvyssiho prvku v poli

            int max = 0;

            foreach(int item in pole)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine(max);


            // najdete a vypiste sumu (soucet vsech) prvku v poli

        }
    }
}

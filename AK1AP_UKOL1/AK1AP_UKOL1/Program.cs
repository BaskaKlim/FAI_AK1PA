using System;

namespace AK1AP_UKOL1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }
            // TODO:1. prepiste cyklus for s pomoci cyklu while
            // Zde vlozte kod s resenim
            int j = 2;
            while (j < 20)
            {
                Console.WriteLine(j);
                j += 2;
            }
            // TODO:2. prepiste cyklus for s pomoci cyklu do-while
            // Zde vlozte kod s resenim
            int t1 = 0;
            int t2 = 60;
            int t3 = 70;
            if ((t1 > 50 && t2 > 50) || t3 > 50)
            {
                Console.WriteLine("uspel");
            }

            do
            {
                Console.WriteLine("uspel");

            } while ((t1 > 50 && t2 > 50) || t3 > 50); //bude sa cyklit lebo je to vzdy true

            // TODO:3. Prepiste podminku pouze s pouzitim prikazu if, else a if-else a bez && (AND), || (OR) a bez pomocne promenne
            // Zde vlozte kod s resenim

            if(t1 > 50)
            {
                if (t2 > 50)
                {
                    Console.WriteLine("uspel");
                }

            }
            else if (t3 > 50)
            {
                Console.WriteLine("uspel");

            }

        }
    }
}

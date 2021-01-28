using System;

namespace AK1PA_UKOL3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[] { 1, 9, 4, 7, 6, 9, 2 };

            int prvek = 7;
            // najdete a vypiste na konzoli index prvku s hodnotou 7 v poli (reseni: index 3)

            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] == prvek)
                {
                    Console.WriteLine($"Prvek s hodnotou 7 je na {i}.indexe");
                }
            }


            // seradte hodnoty prvku v poli vzestupne pomoci algoritmu Bubble Sort a vypiste serazene hodnoty na konzoli


            int temp = 0;

            //sortovanie musim spravit tolkokrat, aka velkost je pola, lebo v jednom kole dostanem s urcitostou na koniec vydz len 1 najvyssie cislo 
            for (int i = 0; i < pole.Length; i++)
            {

                //samotne sortovanie -porovnavam pole.lenght-1 cisel
                for (int j = 0; j < pole.Length - 1; j++)
                {
                    //prve cislo je pole[j] druhe cislo ktore porovnavam je pole[j+1]

                    if (pole[j] > pole[j + 1]) //urob sortovanie, teda vymen ich
                    {
                        temp = pole[j + 1]; // uloz si druhe, mensie cislo bokom
                        pole[j + 1] = pole[j]; //na jeho poziciu presun cislo prve
                        pole[j] = temp; // na prve cislo uloz ulozenu hodnotu povodneho druheho cisla
                    }

                }
            }
            // ked mam zosortovane, idem vypisat
            for (int k = 0; k < pole.Length; k++)
            {
                /*  if (k == pole.Length - 1)
                  {
                      Console.Write(pole[k]);
                  }
                  else
                      Console.Write(pole[k] + ","); */
                Console.Write(pole[k]);
            }

        }



    }

}


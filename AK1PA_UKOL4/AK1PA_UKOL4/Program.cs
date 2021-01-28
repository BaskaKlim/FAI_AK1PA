using System;

namespace AK1PA_UKOL4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[] { 1, 5, 7, 9, 8, 12, 11, 15 };
            int prvek = 3;
            int prvek2 = 10;
            int prvek3 = 1;

            //TODO1:
            // mate pole s prvky jiz serazenymy vzestupne
            // vlozte do pole promennou prvek, tak aby bylo pole opet serazeno, nejvyssi prvek po vlozeni z pole odstrante
            // vase reseni musi byt platne pro ruzne dlouhe pole s minimalne jedním prvkem a ruzne hodnoty prvku

            // priklady:
            // pokud vlozite prvek s hodnotou  3, tak vysledne pole bude mit hodnotu  1, 3, 5, 7,  9, 11, 12
            // pokud vlozite prvek s hodnotou 10, tak vysledne pole bude mit hodnotu  1, 5, 7, 9, 10, 11, 12
            // pokud vlozite prvek s hodnotou  1, tak vysledne pole bude mit hodnotu  1, 1, 5, 7,  9, 11, 12


            //pomocne miesto v pamati

            int temp = 0;

            /* pole[0] teda 1.prvok budem pokladat za zatriedeny, a zbytok pola za nezatriedeny.
             zacnem preto od 2.prvku teda na indexe pole[1]
            */

            for (int i = 1; i < pole.Length - 1; i++)
            {

                //2.prvok si ukladam do pomocnej pamati 
                temp = pole[i];

                /* tento prvok porovnavam so zatriedenou castou a posuvam ho do lava dovtedz, kym nie som na zaciatku pola cize na 
                 * indexe 0, alebo kym aktualny prvok nie je vacsi ako lavy prvok
                 */

                while ((i >= 0) && (temp < pole[i - 1]))
                {
                    //prehodim hodnoty
                    pole[i] = pole[i - 1]; //na sucasnu poziciu ide o jedno cislo skor v poly {vacsie}
                    pole[i - 1] = temp; //na predchadzajuci index ide sucasna hodnota ulozena v medzipamati
                    i--; // a posiniem sa na dalsi index v lavo a zopakujem while cyklus kym sedia podmienky
                }


            }
            // vypisanie
            for (int k = 0; k < pole.Length; k++)
            {
                Console.Write($"{pole[k]},");
            }


        }
    }
}

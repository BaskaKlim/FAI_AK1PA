using System;

namespace AK1PA_UKOL4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[] { 1, 5, 7,10, 9, 11, 12, 15 };
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

            int temp = 0;
          

            for (int i = 0; i < pole.Length; i++)
            {
                //ulozim si prve cislo z pola
                temp = pole[i];
               int j = i - 1; ;//samotne porovnavanie resp vkladanie robim presne i -1 krat

                // potrebujem porovnat nielen aktualnu hodnotu pole[i] ale aj hodnotu prednou i-1 a vsetky az po index 0
                // pokym je j> alebo = 0, cize pokial existuju predchadzajuce hodnoty v poli a zaroven hodnota co porovnavam je vacsia ako hodnota co som si ulozil
                while ((j >= 0) && (pole[j] > temp))
                {
                    //prehod hodnoty
                    pole[j + 1] = pole[j];
                    j--; // a takto aj pre hodnoti spatne
                }

                pole[j + 1] = temp;
                
            }
            // vypisanie
            for (int k = 0; k < pole.Length; k++)
            {
                Console.Write($"{pole[k]},");
            }    
        

        }
    }
}

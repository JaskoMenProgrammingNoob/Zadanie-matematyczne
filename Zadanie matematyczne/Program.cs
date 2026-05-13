using System.Security.Cryptography;

class program
{
    static void Main(string[] args)
    {
        int x;
        int b;
        int c;
        int d;
        int czlon1 = 0;
        int czlon2 = 0;
        int wynik = czlon1 * czlon1 + czlon2 * czlon2;
        int wynikcz1 = czlon1 * czlon1;
        int wynikcz2 = czlon2 * czlon2;
        int dzialanie = 0;
        for (czlon1 = 1; czlon1 <= 99; czlon1++)
        {
            Console.WriteLine($"{czlon1:#}");
            for (czlon2 = 1; czlon2 <= 99; czlon2++)
            {
                Console.WriteLine($"{czlon2:#}");
            }
                


        }
        
        /* jedna pętla dla zakresu od 1000 do 9999, pętla zagnieżdzona numer 1 dla zakresu od 1 do 99 ( pierwszy człon ), druga pętla zagnieżdzona numer 2 dla zakresu od 1 do 99 ( drugi człon ).
       
        /* if (czlon1 == czlon1 * czlon1 || czlon2 == czlon2 * czlon2)
             {

                 Console.Write("Wyniki: " + wynikcz1 + wynikcz2);

             } */




    }
}
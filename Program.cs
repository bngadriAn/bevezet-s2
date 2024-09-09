using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace bevezetés2
{
    internal class Program
    {
        static void VezérlésiSzerkezetJegyzet()
        {
            /*
             vezérlési szerkezetek
            1. szekvencia
            utasítások sorozata egymás után
            2. elágazás
             */
            if (true)
            {
                //ez hajtódik végre igaz esetén
            }

            if (false)
            {

            }
            else
            {
                //ez hajtódik végre hamis esetén
            }

            if (true)
            {
                if (true)
                {

                }
            }
            else
            {

            }

            //speciálios eset: értékvizsgálat
            int i = 1;
            if (i == 0)
            {
                Console.WriteLine(0);
            }
            else if (i == 1)
            {
                Console.WriteLine(1);
            }
            else if (i == 2)
            {
                Console.WriteLine(2);
            }
            else if (i == 3 || i == 4)
            {
                Console.WriteLine("3 vagy 4");
            }
            else
            {
                Console.WriteLine("minden más esetben");
            }

            //ezt inkább switch-case megoldással
            switch (i)
            {
                case 0:
                    Console.WriteLine(0);
                    break;
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                case 4:
                    Console.WriteLine("3 vagy 4");
                    break;
                default:
                    Console.WriteLine("minden más esetben");
                    break;
            }



            //3. ciklus
            //utasítások többszöri végrehajtása
            //előltesztelős -> nem biztos hogy akár egyszer is végre akarjuk hajtani
            while (i == 1)
            {

            }
            //hátultesztelős -> 
            do
            {

            } while (i == 2);
            //számláló
            for (int x = 0; x < 3; x++)
            {
                //alapértékes változó, ha igaz a feltétel akkor ciklusmag, utána inkrementál, majd újra
            }
            // for while-al
            int y = 0;
            while (y < 3)
            {
                //...ciklusmag
                y++;
            }

            //bejárás -> !! a bejárás közben az éppen bejárt gyűjtemény elemszámát tilos módosítani !!
            var tömb = new string[5];
            foreach (var item in tömb)
            {

            }

            //foreach ezt helyettesíti
            var enumerator = tömb.GetEnumerator();
            var item2 = enumerator.Current;
            while (item2 == null)
            {
                //.....
                enumerator.MoveNext();
            }


            //ciklus vezérlési utasításai
            //1. break -> megszakítja a ciklus végrehajtását
            //2. continue -> megszakítja az adott ciklus iterációját

            //indexelés...
            //sorszámozás jelentése: valamihez sorrendben számok hozzárendelése 1-től
            //indexelés ugyanez csak a 0-hoz igazítva
        }
        static void KeretRajzolas()
        {
            do
            {
                Console.ResetColor();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.CursorVisible = false;

                /*
                 F5 - futtatás
                 Ctrl + F5 - futtatás debug nélkül (nincsenek breakpointok)
                 Ctrl + Shift + F5 - újrafordítás és indítás
                 F6 - fordítás futtatás nélkül (build)
                 F11 - vezérlés léptetése a következő utasításra (függvényekbe is belép)
                 F10 - vezérlés léptetése a következő utasításra (függvény végrehajtása egy lépés)
                 F9 - breakpoint elhelyezése vagy törlése
                 Ctrl + M + O - függvények összezárása
                 Ctrl + M + M - adott szekció kinyitása/összecsukása
                 Ctrl + -(kötőjel) - visszalépés a kurzor előbbi pozíciójába
                 Ctrl + Q - funkció keresés
                 Ctrl + T - kódban való keresés (navigációs szempont)
                 Ctrl + K + D - kód formázása

                 */
                //╔╗╚╝║═
                Console.Write('╔');
                for (int i = 1; i < Console.WindowWidth - 1; i++)
                {
                    Console.Write('═');
                }
                Console.Write('╗');
                for (int i = 1; i < Console.WindowHeight - 1; i++)
                {
                    Console.SetCursorPosition(Console.WindowWidth - 1, i);
                    Console.Write('║');
                }
                Console.SetCursorPosition(Console.WindowWidth - 1, Console.WindowHeight - 1);
                Console.Write('╝');
                for (int i = Console.CursorLeft - 1; i > 0; i--)
                {
                    Console.SetCursorPosition(i, Console.WindowHeight - 1);
                    Console.Write('═');
                }
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                Console.Write('╚');
                for (int i = Console.WindowHeight - 2; i > 0; i--)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write('║');
                }
                Console.ReadLine();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        static void Main(string[] args)
        {
            KeretRajzolas();

            //feladat: rajzolgatás, karaktertábla használata különböző színekkel, gombokkal (valamelyik F_ gombbal) választani karakterek között
            

        }
    }
}

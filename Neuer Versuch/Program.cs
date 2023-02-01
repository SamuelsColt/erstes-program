using System;

namespace Übungen
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("welche übung möchtest du aufrufen?");

            Console.WriteLine("1 = variablen und mathematische ausdrücke");
            Console.WriteLine("2 = if-abfragen");
            Console.WriteLine("3 = schleifen");
            Console.WriteLine("4 = 2D-Array (noch nicht fertig)");

            Console.WriteLine("gebe die entsprechende zahl ein um zur übung zu springen");

            int Auswahl = Convert.ToInt32(Console.ReadLine());

            switch ( Auswahl)
            {
                    // Übung zu Variablen
                    case 1:

                    Console.WriteLine("du hast Variablen mathematische ausdrücke gewählt");

                    Console.WriteLine("wie alt bist du?");
                    int vAngabe1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("wie alt ist deine Mutter?");
                    int vAngabe2 = Convert.ToInt32(Console.ReadLine()); 

                    Variablen(vAngabe1, vAngabe2);
                    break;


                    // Übung zu IF-Abfragen
                    case 2:

                    Console.WriteLine("du hast if-abfragen gewählt");

                    Console.WriteLine("wie hoch ist die chance das du im lotto gewinnst?");
                    Console.WriteLine("in einer skala von 0 bis 100");
                    Console.WriteLine("gebe eine zahl ein");
                    int iChance = Convert.ToInt32(Console.ReadLine());

                    ifAbfragen(iChance);
                    break;


                    // Übung zu schleifen
                    case 3:

                    Console.WriteLine("du hast schleifen gewählt");

                    Console.WriteLine("wie oft möchtest du idiot genannt werden? ;-) ");
                    Console.WriteLine("gib eine zahl ein");
                    int wiederholung = Convert.ToInt32(Console.ReadLine());

                    schleifen(wiederholung);
                    break;


                    //Übung zu arrays
                    case 4:

                    Console.WriteLine("du hast arrays gewählt");

                    Console.WriteLine("hier kannst du koordinaten angeben um einen punkt zu bestimmen");
                    Console.WriteLine("das koordinatensystem besteht aus 3x3 reihen");

                    Console.WriteLine("bitte gibden X wert");
                    int xwert = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("bitte gib den Y wert ein");
                    int ywert = Convert.ToInt32(Console.ReadLine());

                    arrays(xwert, ywert);
                    break;

                   
            }
        }

        static void Variablen(int alter, int mutterAlter)
        {

            int mutterAlterGebuhrt = (mutterAlter - alter);
            Console.WriteLine("deine mutter war " + mutterAlterGebuhrt + " jahre alt als du gebohren wurdest ");

        }

        static void ifAbfragen(int chance)
        {

            if (chance > 75)
            {
                if (chance > 100)
                {
                    Console.WriteLine("die skala geht nur von 0 bis 100 du idiot");
                }

                else if (chance > 75)
                {
                    Console.WriteLine("du schätzt deine chance hoch ein");
                }
            }

            else
            {
                Console.WriteLine("deine eingabe war zwischen 25 und 75 ");
            }

            if (chance < 25)
            {
                if (chance < 0)
                {
                    Console.WriteLine("dein armer mathelehrer");
                }

                else if (chance < 25)
                {
                    Console.WriteLine("du schätzt deine chance niedrig ein");
                }
            }

            else
            {
                Console.WriteLine("deine eingabe war zwischen 25 und 75 ");
            }

        }

        static void schleifen(int idiotzahl)
        {
            for (int forzahl = 1; forzahl <= idiotzahl; forzahl +=1 )
            {
                Console.WriteLine("du bist ein idiot");
            }
        }

        static void arrays(int x, int y)
        {
            string[,] tabelle = new string[3, 3];
            {
                tabelle[0, 0] = ("links");
                tabelle[1, 0] = ("mitte");
                tabelle[2, 0] = ("rechts");

                tabelle[0, 1] = ("oben");
                tabelle[0, 2] = ("mittig");
                tabelle[0, 3] = ("unten");

                Console.WriteLine(tabelle[int x, int y]);
            }
        }
    }
}
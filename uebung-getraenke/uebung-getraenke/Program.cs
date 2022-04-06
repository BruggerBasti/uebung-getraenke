using System;
using System.Collections.Generic;

namespace uebung_getraenke
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstelle Schachten
            Schachtel s1 = new Schachtel();

            // Erstelle Zylinderflasche
            ZylinderFlasche z1 = new ZylinderFlasche(7, 25);
            ZylinderFlasche z2 = new ZylinderFlasche(3, 5);

            // Erstelle Kegelflasche
            KegelFlasche k1 = new KegelFlasche(15, 8);
            KegelFlasche k2 = new KegelFlasche(12,4);

            // Berechne Inhalt der Flaschen
            z1.BerechneInhalt();
            k1.BerechneInhalt();
            z2.BerechneInhalt();
            k2.BerechneInhalt();

            // Gibt das Volumen von z1 & k1 hinzu
            Console.WriteLine("----------- Inhalt von z1 -----------");
            Console.WriteLine(Math.Round(z1.Volumen, 2));

            Console.WriteLine("\n----------- Inhalt von k1 -----------");
            Console.WriteLine(Math.Round(k1.Volumen, 2));

            Console.WriteLine("\n----------- Inhalt von z2 -----------");
            Console.WriteLine(Math.Round(z2.Volumen, 2));

            Console.WriteLine("\n----------- Inhalt von k2 -----------");
            Console.WriteLine(Math.Round(k2.Volumen, 2));

            // Füge Flaschen in Schachtel hinzu
            s1.AddFlasche(z1);
            s1.AddFlasche(k1);
            s1.AddFlasche(k2);
            s1.AddFlasche(z2);

            // Berechne Inhalt aller Flaschen
            s1.BerechneFlaschenInhalt();
            Console.WriteLine("\n------- Inhalt aller Flaschen -------");
            Console.WriteLine(Math.Round(s1.GesamtVolumen, 2));
        }
    }
}

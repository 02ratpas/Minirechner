using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minirechner
{
    class Program
    {
        static void Main(string[] args)
        {
            int Zahl_1 = 0;
            int Zahl_2 = 0;
            string Rechenart = "";
            int Ergebnis = 0;

            Console.WriteLine("+ = Addieren, - = Subtrahieren, * = Multiplizieren, / = Dividierne");
            Rechenart = Console.ReadLine();
            Console.WriteLine("Zahl 1:");
            Zahl_1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Zahl 2:");
            Zahl_2 = Convert.ToInt16(Console.ReadLine());

            if (Rechenart == "/")
                Ergebnis = Division(Zahl_1, Zahl_2);

            

            Console.WriteLine("Ergebnis = " + Ergebnis);
            Console.ReadKey();
        }
        static int Division(int Zahl_1, int Zahl_2)
        {
            int Erg = Zahl_1 / Zahl_2;
            return Erg;
        }
    }
}

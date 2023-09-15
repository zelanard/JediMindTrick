using System;
using System.Collections.Generic;

namespace JediMindTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** Opgave 1 – erklær et dictionary 
             * Opret et nyt dictionary, hvor nøgletypen er en streng, og værditypen er en int. 
             * Dette dictionary skal ikke indholde værdier.
             */
            Dictionary<string, int> Jedi = new Dictionary<string, int>();

            /** Opgave 2 – læs og skriv dictionary værdier
             * Tilføj en ny værdi, hvis nøgle er dit navn, og hvis værdi er din alder. Gør dette ved hjælp af Add -metoden.
             * Dernæst tilføj en anden værdi til dictionary ved hjælp af indeksnotationen. Denne gang skal du bruge et andet navn og en anden alder.
             * Til sidst skal du læse det første emne, du tilføjede til dictionary, og skrive det til konsollen ved hjælp af Console.WriteLine.
             */
            Jedi.Add("Jonas", 33);
            Jedi["Emmett"] = 2;
            Console.WriteLine(Jedi["Jonas"]);

            /** Opgave 3 – fjern et element fra dictionary
             * Fjern element med nøglen 'Han' fra ordbogen.
             */
            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
                { "Luke", true },
                { "Han", false },
                { "Chewbacca", false }
            };
            characters.Remove("Han");

            /** Opgave 4 – gennemløb af dictionary
             * Opret et foreach-loop efter dictionary deklarationen gennemløb elementer, 
             * skriv værdien til konsollen ved hjælp af Console.WriteLine. Din loop-variabel skal angives som "var"
             */
            foreach (var c in characters)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}

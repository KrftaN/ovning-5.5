using System;

namespace övning_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] svar = {
                "Det är säkert",
                "Utan tvekan",
                "Ja, definitivt",
                "Svara igen senare",
                "Fråga igen senare",
                "Bättre att inte berätta nu",
                "Kan inte förutsäga nu",
                "Mycket tveksamt",
                "Nej, det är inte troligt",
                "Absolut inte"
            };

            Random slumpGenerator = new Random();

            Console.WriteLine("Välkommen till Magic 8-ball!");

            while (true)
            {
                Console.WriteLine("Ställ din fråga (eller skriv 'a' för att avsluta):");
                string fråga = Console.ReadLine();

                if (fråga.ToLower() == "a")
                {
                    Console.WriteLine("Tack för att du spelade! Ha en bra dag!");
                    break;
                }

                int slumpIndex = slumpGenerator.Next(0, svar.Length);
                Console.WriteLine($"Magic 8-ball säger: {svar[slumpIndex]}");
            }
        }
    }
}

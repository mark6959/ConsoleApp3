using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] optælling = new int[7];  // Samlet optælling for begge terninger (1-6)
        int totalØjne = 0;             // Total sum af øjne
        const int antalKast = 100;     // Konstant for antallet af kast

        for (int i = 0; i < antalKast; i++)
        {
            // Kast to terninger og opdater optælling samt total øjne
            int terning1 = random.Next(1, 7);
            int terning2 = random.Next(1, 7);

            optælling[terning1]++;
            optælling[terning2]++;
            totalØjne += terning1 + terning2;
        }

        // Vis samlet optælling
        Console.WriteLine("Resultater fra 100 terningekast med to seksidet terninger:\n");
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine($"Antal {i}'ere: {optælling[i]}");
        }

        // Beregn og vis gennemsnitligt resultat
        double gennemsnit = (double)totalØjne / (2 * antalKast);
        Console.WriteLine($"\nFuldstændigt antal øjne for alle kast: {totalØjne}");
        Console.WriteLine($"Gennemsnitligt resultat for alle individuelle terningeslag: {gennemsnit:F2}");
    }
}

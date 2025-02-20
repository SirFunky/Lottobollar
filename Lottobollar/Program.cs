using System;

namespace Lottobollar
{
    class Program
    {
        static void Main(string[] args)
        {   //sätter max och min värde som random kan bli
            const int minRandom = 0; 
            const int maxRandom = 25;

            int[] lottonummer = new int[10];
            Console.WriteLine("Hej och välkommen till lotto kväll var vänlig och fyll i tio nummer.");
            for (int i = 0; i < lottonummer.Length; i++)
            {
                Console.WriteLine("Skriv ett nummer mellan {0} och {1}: ", minRandom, maxRandom);
                int element = 0;
                if (int.TryParse(Console.ReadLine(), out element)) //Kontrollerar att det är ett nummer mellan 0 och 25 man väljer
                {
                    if (element >= minRandom && element <= maxRandom)
                    { lottonummer[i] = element; }
                    else
                    {
                        Console.WriteLine("Du måste mata in ett tal mellan {0} och {1}", minRandom, maxRandom);
                        --i;
                    }
                }
                else
                {
                    Console.WriteLine("Du måste mata in ett tal mellan 0-25");
                    --i;
                }
            }
            Console.WriteLine("Nu har du valt följande nummer" + " "+ lottonummer[0] + " " + lottonummer[1] + " " + lottonummer[2] + " " + lottonummer[3] + " " + lottonummer[4] + " " + lottonummer[5] + " " + lottonummer[6] + " " + lottonummer[7] + " " + lottonummer[8] + " " + lottonummer[9]);//visar vilka nummer du har valt
            Console.WriteLine("Tryck på valfri tagent för att rulla bollarna.");
            Console.ReadKey();
            int[] bollar = new int[5];// Genererar lottobollarnas nummer och sätter dem i en vektor
            for (int i = 0; i < bollar.Length; i++)
            {
                Random RandomNr = new Random();
                int slump = RandomNr.Next(minRandom, maxRandom + 1);
                bollar[i] = slump;
            }
            Console.WriteLine("Bollarna vissar" + " " + bollar[0] + " " + bollar[1] + " " + bollar[2] + " " + bollar[3] + " " + bollar[4]);// vissar vad bollarna har för nummer
            int points = 0;
            for (int i=0; i < lottonummer.Length; i++)//jämför dina lottonummer med bollarnas nummer
            {
                for (int x = 0; x < bollar.Length; x++)
                {
                    if (lottonummer[i] == bollar[x])
                    { points++; }
                }
            }
            if (points == 5)//om du får fem lika så vinner du!
            {
                Console.WriteLine("Grattis du van! var vänlig tryck på valfri knapp för att avsluta");
                Console.ReadKey();// avslutar programet
            }
            else
            {
                Console.WriteLine("Tyvärr van du inte denna gången men lycka till nästa gång!");
                Console.ReadKey();// avslutar programet
            }
            
        }
    }
}

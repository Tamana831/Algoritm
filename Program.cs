using System;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentManager = new StudentManager();

            while (true)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till en ny student");
                Console.WriteLine("2. Sortera listan baserat på betyg");
                Console.WriteLine("3. Visa alla studenter");
                Console.WriteLine("4. Avsluta");

                string val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        studentManager.LäggTillStudent();
                        break;
                    case "2":
                        studentManager.SorteraStudenter();
                        break;
                    case "3":
                        studentManager.VisaStudenter();
                        break;
                    case "4":
                        Console.WriteLine("Avslutar programmet...");
                        return;
                    default:
                        Console.WriteLine("Felaktigt val. Försök igen.");
                        break;
                }
            }
        }
    }
}







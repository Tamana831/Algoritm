using System;
using System.Collections.Generic;
     
namespace StudentManagement
    {
        public class StudentManager
        {
            private List<Student> students = new List<Student>();

            // Konstruktor som lägger till fördefinierade studenter
            public StudentManager()
            {
                // Lägg till fördefinierade studenter med specifika betyg
                students.Add(new Student("Sara", 4));
                students.Add(new Student("Anna", 8));
                students.Add(new Student("Lisa", 5));
                students.Add(new Student("Sofia", 10));
            }

            // lägga till en student
            public void LäggTillStudent()
            {
                Console.Write("Ange studentens namn: ");
                string namn = Console.ReadLine();
                Console.Write("Ange studentens betyg (5-10): ");
                int betyg;

                //  betyget är ett giltigt tal mellan 5 och 10
                while (!int.TryParse(Console.ReadLine(), out betyg) || betyg < 5 || betyg > 10)
                {
                    Console.WriteLine("Felaktigt betyg. Ange ett nummer mellan 5 och 10.");
                }

                students.Add(new Student(name: namn, betyg));

                // Skapa och lägg till studenten i listan
                Console.WriteLine("Studenten har lagts till!");
            }

            // Metod för att sortera studenter baserat på betyg
            public void SorteraStudenter()
            {
         
                for (int i = 0; i < students.Count - 1; i++)
                {
                    for (int j = 0; j < students.Count - i - 1; j++)
                    {
                        if (students[j].Grade < students[j + 1].Grade)
                        // Sortera i fallande ordning
                        {
                            // Byt plats på studenterna
                            var temp = students[j];
                            students[j] = students[j + 1];
                            students[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("Studenterna har sorterats efter betyg.");
            }

            // för att visa alla studenter
            public void VisaStudenter()
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("Inga studenter i listan.");
                    return;
                }

                Console.WriteLine("\nLista över studenter:");
                foreach (var student in students)
                {
                    Console.WriteLine($"Namn: {student.Name}, Betyg: {student.Grade}");
                }
            
        
    



     
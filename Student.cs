using System;

namespace StudentManagement
{
    public class Student
    {
        private object Namn;

        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(string name, int grade)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }

            if (grade < 5 || grade > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(grade), "Grade must be between 5 and 10.");
            }

            Name = name;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"Namn: {Namn}, Grade: {Grade}";
        }
    }
}

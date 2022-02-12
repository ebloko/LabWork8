using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Abiturient abiturient = new Abiturient("bbaa", 9, 4.5);
            Abiturient abiturient2 = new Abiturient("bbaa", 9, 4.5);

            Console.WriteLine(abiturient.Equals(abiturient2));
        }
    }
}

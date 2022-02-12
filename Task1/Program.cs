using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abiturient abiturient = new Abiturient("asdd", 9, 4.5);

            Console.WriteLine(abiturient + " (неявное преобразование)");
            Console.WriteLine(abiturient.ToString() + " (явное преобразование)");
        }
    }
}

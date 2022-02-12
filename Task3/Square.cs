using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Square : Fiqure
    {
        private double side;

        public Square(int side)
        {
            this.side = side;
        }

        public override string Name => "Квадрат";

        public override void Info()
        {
            Console.WriteLine(Name);
            Console.WriteLine($"Периметр = {Perimeter()}");
            Console.WriteLine($"Площадь = {Area()}");
        }

        public override double Perimeter()
        {
            return side * 4;
        }
        public override double Area()
        {
            return Math.Pow(side,2);
        }
    }
}

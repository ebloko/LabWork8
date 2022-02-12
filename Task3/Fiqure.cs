using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    abstract class Fiqure
    {
        abstract public string Name { get; }
        public abstract double Area();
        public abstract double Perimeter();
        public abstract void Info();
    }
}

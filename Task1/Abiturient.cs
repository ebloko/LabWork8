using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Abiturient
    {
        private string fullName;
        private int baseClass;
        private double avg;

        public Abiturient(string fullName, int baseClass, double avg)
        {
            this.fullName = fullName;
            this.baseClass = baseClass;
            this.avg = avg;
        }

        public override string ToString()
        {
            return $"{fullName} {baseClass} {avg}";
        }
    }
}

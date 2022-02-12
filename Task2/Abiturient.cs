using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
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

        public override bool Equals(object obj)
        {
            Abiturient abiturient = obj as Abiturient;
            return fullName == abiturient.fullName && baseClass == abiturient.baseClass && avg == abiturient.avg;
        }
    }
}

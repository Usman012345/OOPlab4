using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.Student_
{
    class Subject
    {
        public string degree;
        public string code; 
        public string type;
        public int creditHours;
        public int subjectFees;
        public Subject(string degree,string code, string type, int creditHours, int subjectFees)
        {
            this.degree = degree;
            this.code = code; 
            this.type = type;
            this.creditHours = creditHours;
            this.subjectFees = subjectFees;
        }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.Student_;

namespace task4.Student_
{
    class DegreeProgram
    {
        public string degreeName;
        public float degreeDuration;
        public List<Subject> subjects;
        public int seats;
        public DegreeProgram(string degreeName, float degreeDuration, int seats)
        {
            this.degreeName = degreeName;
            this.degreeDuration = degreeDuration;
            this.seats = seats;
            subjects = new List<Subject>();
        }
        public int calculateCreditHours()
        {
            return 0;
        }
        public bool isSubjectExists(Subject sub)
        {
            return false;
        }
        public void AddSubject(Subject s)
        {
            int creditHours =
            calculateCreditHours();
            if (creditHours + s.creditHours
            <= 20)
            {
                subjects.Add(s);
            }
            else
            {
                Console.WriteLine("20 credit hour limit exceeded");
            }
        }
    }
}

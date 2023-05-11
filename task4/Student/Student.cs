using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.Student_;

namespace task4.Student_
{
    class Student
    {
        public string name; 
        public int age;
        public string registered_degree;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public List<string> preferences;
        public List<string> regestered_subjects = new List<string>(); 
        public DegreeProgram regDegree;
        public Student()
        {
        }
        public Student(string name, int age, double fscMarks, double ecatMarks, List<string> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.preferences=preferences;
        }
        public List<double> calculateMerit(List<Student> studentList,List<double> meritlist,List<string> student_name)
        {
            
            foreach(Student data in studentList)
            {
                this.merit = ((data.fscMarks / 1100) * 60) + ((data.ecatMarks / 400) * 40);
                meritlist.Add(this.merit);
            }
            double[] array = meritlist.ToArray();
            string[] array1 = student_name.ToArray();
            Array.Sort(array, array1);
            meritlist.AddRange(array);
            student_name.AddRange(array1);
            meritlist.Reverse();
            student_name.Reverse();
            return meritlist;
            
        }
        public int getCreditHours()
        {
            return 0;
        }
        public float calculateFee(string name,List<Subject> subjects)
        {
            float fee=0F;
            int y = 0;
            do
            {
                for (int x = 0; x < regestered_subjects.Count; x++)
                {
                    if (regestered_subjects[y] == subjects[x].code)
                    {
                        fee += (subjects[x].subjectFees);
                        y++;
                    }

                }
            }
            while (y <= regestered_subjects.Count);
           
            return fee;
        }
       /* public void regStudentSubject(Subject s)
        {
            int stCH = getCreditHours();
            if (regDegree != null && regDegree.isSubjectExists(s) && stCH + s.creditHours <= 9)
            {
                regSubject.Add(s);
            }

            else
            {
                // This needs to change
              *//*  Console.WriteLine("A student cannot have more than 9 CH or Wrong Subject");*//*

            }
            
        }*/
        
    }
}

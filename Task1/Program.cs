using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.CRC;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool iseligible;
            bool ishostalite=false;
            int x = 0;
            int percentfsc=0,percentecat=0;
            double merit;
            List<student> stu = new List<student>();
            stu.Add(input(ref ishostalite));
            intput_(ref percentfsc,ref percentecat);
            merit = stu[x].merit(percentfsc,percentecat);
            iseligible=stu[x].iseligible(merit,ishostalite);
            Console.WriteLine("The is student is eligible: {0}", iseligible);
                x++;
            Console.ReadLine();
        }
       static student input(ref bool ishostalite)
        {
            string name;
            int matricMarks;
            int fscMarks;
            int rollno;
            int ecatmarks;
            float cgpa;
            string hometown;
            bool scholarship;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your matric marks: ");
             matricMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your FSc marks: ");
             fscMarks = int .Parse(Console.ReadLine());
            Console.WriteLine("Enter your roll no: ");
             rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your ECAT marks: ");
            ecatmarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your CGPA: ");
             cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your hometown: ");
             hometown = Console.ReadLine();
            Console.WriteLine("Enter if you are hostalite (true/false): ");
            ishostalite = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter if you have a scholarship (true/false): ");
            scholarship = bool.Parse(Console.ReadLine());
            student s = new student(name,rollno,cgpa,matricMarks,fscMarks,ecatmarks,hometown,ishostalite,scholarship);
            return s;
        }
        static void intput_( ref int percentfsc, ref int percentecat)
        {
            Console.WriteLine("Enter the fsc percent to be considered: ");
            percentfsc = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ecat percent to be considered: ");
            percentecat = int.Parse(Console.ReadLine());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.CRC
{
    class student
    {
        string name;
        int rollno;
        float cgpa;
        int matricmarks;
        int fscmarks;
        int ecatmarks;
        string hometown;
        bool ishostalite;
        bool scholarship;
        public student(string name="",int rollno=1,float cgpa=1F,int matricmarks=1,int fscmarks=1,int ecatmarks=1,string hometown="",bool ishostalite=true,bool scholarship=false)
        {
            this.name = name;
            this.rollno = rollno;
            this.scholarship = scholarship;
            this.matricmarks = matricmarks;
            this.ishostalite = ishostalite;
            this.fscmarks = fscmarks;
            this.ecatmarks = ecatmarks;
            this.cgpa = cgpa;
            this.hometown = hometown;

        }
        public float merit(int percentfsc,int percentecat)
        {
            float fmarks;
            float emarks;
            fmarks = (this.fscmarks / 1100.0F) * percentfsc;
            emarks = (this.ecatmarks / 400.0F) * percentecat;
            /*fmarks = (percentfsc / 100) * this.fscmarks;
            emarks = (percentecat / 100) * this.ecatmarks;*/
            return fmarks+emarks;
        }
        public bool iseligible(double merit,bool ishostalite)
        {
            if(merit>=80.00 && ishostalite==true)
            {
                return true;
            }
            return false;
        }
    }
}

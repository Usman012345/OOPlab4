using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.Student_;

namespace task4
{
    class Program
    {
       static List<Subject> subjects = new List<Subject>();
        static List<Student> studentList = new List<Student>();
        static List<double> meritlist = new List<double>();
        static List<Student> subjects_registered = new List<Student>();
        static List<string> student_name = new List<string>();
        static List<Student> sortedStudentList = new List<Student>();
        static List<string> registered_students=new List<string>();
        static List<DegreeProgram> programList = new List<DegreeProgram>();
        static void Main(string[] args)
        {
            int option,option_Admin,option_student;
            option = Menu();
            while (true)
            {
                if (option == 1)
                {

                    option_Admin = Admin();
                    if(option_Admin==0)
                    {
                        option = Menu();
                    }
                    Admin_Platform(option_Admin);

                }
                if (option == 2)
                {
                    option_student = Student_menu();
                    if (option_student == 0)
                    {
                        option = Menu();
                    }
                    Student_Platform(option_student);
                }
                if(option==0)

                {
                    Environment.Exit(0);
                }

            }
/*
                clearScreen();
                if (option == 1)
                {
                    if (programList.Count > 0)
                    {
                        Student s = takeInputForStudent();
                        addIntoStudentList(s);
                    }
                }
                else if (option == 2)
                {
                    DegreeProgram d = takeInputForDegree();
                    addIntoDegreeList(d);
                }
                else if (option == 3)
                {
                    sortStudentsByMerit();
                    giveAdmission();
                    printStudents();
                }
                else if (option == 4)
                {
                    viewRegisteredStudents();
                }
                else if (option == 5)
                {
                    string degName;
                    Console.Write("Enter Degree Name: ");
                    degName = Console.ReadLine();
                    viewStudentInDegree(degName);
                }
                else if (option == 6)
                {
                    Console.Write("Enter the Student Name: ");
                    string name = Console.ReadLine();
                    Student s = StudentPresent(name);
                    if (s != null)
                    {
                        s.viewSubjects();
                        registerSubjects(s);
                    }
                }
                else if (option == 7)
                {
                    calculateFee();
                }
                clearScreen();
            }
            while (option != 8);
            Console.ReadKey();
*/        }
        static int Menu()
        {
            while (true)
            {
                Console.Clear();
                int option;
                Console.WriteLine("1.Admin.");
                Console.WriteLine("2.Studnet.");
                Console.WriteLine("0.Exit.");
                option = int.Parse(Console.ReadLine());

                return option;
            }
        }
        static int Admin()
        {
            while (true)
            {
                Console.Clear();
                int option;
                Console.WriteLine("1.Add Degree program");
                Console.WriteLine("2.Generate merit");
                Console.WriteLine("3.View registered students");
                Console.WriteLine("4.View students of a specific program");
                Console.WriteLine("5.Calculate fees of all registered students");
                Console.WriteLine("0.Exit");
                option = int.Parse(Console.ReadLine());
                return option;
            }
        }
        static int Admin_Platform(int option_Admin)
        {
            if(option_Admin==1)
            {
              programList.Add(Degree_program());
            }
            if(option_Admin==2)
            {
               subjects.Add( Add_subject());
            }
            if(option_Admin==3)
            {
                Generate_merit();
            }
            if(option_Admin==4)
            {
                print_registered_students();   
            }
            if(option_Admin==5)
            {
                view_specific_program_students();
            }
            if(option_Admin==6)
            {
                calculatefee();
            }
            if(option_Admin==0)
            {
                return 0;
            }
            return 0;
        }
        static DegreeProgram Degree_program()
        {
            string degreeName;
            float degreeDuration;
            int seats;
            Console.WriteLine("Enter the degree name:");
            degreeName = Console.ReadLine();
            Console.WriteLine("Enter the degree duration");
            degreeDuration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the no of seats:");
            seats = int.Parse(Console.ReadLine());
            DegreeProgram d = new DegreeProgram(degreeName, degreeDuration, seats);
            programList.Add(d);
            return d;
        }
        static void Generate_merit()
        {
            string degreename;
            Console.WriteLine("Enter the Program: ");
            degreename = Console.ReadLine();
            int seats=0;
            Student s = new Student();
            foreach (Student data in studentList)
            {
                if (degreename == data.preferences[0])
                {
                    meritlist = s.calculateMerit(studentList, meritlist,student_name);
                    for (int x = 0; x < studentList.Count; x++)
                    {
                        Console.WriteLine("{0}         {1}",studentList[x].name, meritlist[x]);
                        data.registered_degree = degreename;
                        if (seats < programList[x].seats)
                        {
                            registered_students.Add(studentList[x].name);
                            seats++;
                        }
                    }
                }
            }
            Console.ReadKey();
        }
        static void print_registered_students()
        {
            for (int x = 0; x < studentList.Count; x++)
            {
                Console.WriteLine(studentList[x].name);

            }
            Console.ReadKey();
        }
        static void view_specific_program_students()
        {
            string program;
            Console.WriteLine("Enter student program: ");
            program = Console.ReadLine();
            foreach(Student data in studentList)
            {
                if (program == data.registered_degree)
                {
                    Console.WriteLine(data.name);
                }
            }
        }
        static void calculatefee()
        {
            float fee=0F;
            Student s = new Student();
            foreach (Student data in studentList)
            {
                foreach (string data_ in registered_students)
                {
                    if (data.name ==data_)
                    {
                      fee=  s.calculateFee(data.name, subjects);
                    }
                }
                Console.WriteLine(data.name + "    " + fee);
            }

        }
        static Subject Add_subject()
        {
         string code="";
         string type="";
         int creditHours=0;
         int subjectFees=0;
            string degree;
            Console.WriteLine("Enter the name of program: ");
           degree= Console.ReadLine();
            
                foreach (DegreeProgram data in programList)
                {
                    if (degree == data.degreeName)
                    {
                        Console.WriteLine("Enter the subject code: ");
                        code = Console.ReadLine();
                        Console.WriteLine("Enter type:");
                        type = Console.ReadLine();
                        Console.WriteLine("Enter the credit hours:");
                        creditHours = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the subject fees:");
                        subjectFees = int.Parse(Console.ReadLine());

                    }
                }
            Subject s = new Subject(degree,code,type,creditHours,subjectFees);
            return s;
        }
        static int Student_menu()
        {
            while (true)
            {
                Console.Clear();

                int option;
                Console.WriteLine("1.Register student: ");
                Console.WriteLine("2.Register subjects:");
                Console.WriteLine("0.Exit:");
                option = int.Parse(Console.ReadLine());
                return option;
            }
        }
       static int Student_Platform(int option_student)
        {
            Console.Clear();

            if (option_student==1)
            {
               studentList.Add( register());
            }
            if(option_student==2)
            {
               subjects_registered.Add( register_subjects());
            }
            return 0;
        }
        static Student register()
        {
            int no;
             string name;
             int age;
            double fscMarks;
            double ecatMarks;
            List<string> preferences = new List<string>();
        Console.WriteLine("Enter name: ");
          student_name.Add(  name = Console.ReadLine());
            Console.WriteLine("Enter age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fsc Marks: ");
            fscMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ecat Marks: ");
            ecatMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Avaliable programs:");
            for(int x=1;x<programList.Count;x++)
            {
                Console.WriteLine(programList[x].degreeName);
            }
            Console.WriteLine("Enter no of preferences you want to add: ");
            no = int.Parse(Console.ReadLine());
            for(int x=0;x<no;x++)
            {
                Console.WriteLine("Enter the name of preferences:");
                preferences.Add(Console.ReadLine());
            }
            Student s = new Student(name, age, fscMarks, ecatMarks, preferences);
            return s;
        }
        static Student register_subjects()
        {
            Student s = new Student();
            string code;
            int no;
            string degree;
            Console.WriteLine("Enter your degree program: ");
            degree = Console.ReadLine();
            Console.WriteLine("Offered subjects: ");
            foreach(Subject data in subjects)
            {
                if(data.degree==degree)
                {
                    Console.WriteLine("{0}    {1}    {2}    {3}",data.code,data.type,data.creditHours,data.subjectFees);
                }
            }
            Console.WriteLine("Enter the no of subjects you want to register: ");
            no = int.Parse(Console.ReadLine());
            for(int x=0;x<no;x++)
            {
                Console.WriteLine("Enter the subject code: ");
                code = Console.ReadLine();
                foreach(Subject data in subjects)
                {
                    if(data.code==code)
                    {
                      s.regestered_subjects.Add(code);
                    }
                }
            }
            return s;
        }

    }
}

using OopsDemo;
using System;

namespace helloworld
{
    //class Employee
    //{
    //    public int eid;
    //    public string ename;

    //    public Employee()
    //    {
    //        this.eid = 2;
    //        this.ename = "Sai";
    //    }

    //    public Employee(int id, string name)
    //    {
    //        this.eid = id;
    //        this.ename = name;
    //    }
    //    public Employee(int id)
    //    {
    //        this.eid = id;
    //    }
    //    public Employee(string name)
    //    {
    //        this.ename = name;
    //    }
    //}
    class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //int id = 1;
            //string name = "dhanush";
            //double weight = 60.2;
            //bool ismarried = false;

            //Console.WriteLine(name + " id is " + id + " and weight is " + weight);
            //Console.WriteLine("married status " + ismarried);
            //Console.ReadKey();


            //Employee e = new Employee();
            //e.eid = 1;
            //e.ename = "Sais";
            //Console.WriteLine("ID: " + e.eid);
            //Console.WriteLine("Name: " + e.ename);

            //Employee e1 = new Employee();
            //        Console.WriteLine("ID: " + e1.eid);
            //Console.WriteLine("Name: " + e1.ename);

            //Employee e2 = new Employee(3, "Aravindh");
            //        Console.WriteLine("ID: " + e2.eid);
            //Console.WriteLine("Name: " + e2.ename);

            //Employee e3 = new Employee(4);
            //        Console.WriteLine("ID: " + e3.eid);
            //Console.WriteLine("Name: " + e3.ename);

            //Employee e4 = new Employee("Zoro");
            //        Console.WriteLine("ID: " + e4.eid);
            //Console.WriteLine("Name: " + e4.ename);


            //company comp = new company(1, "VR");
            //comp.displayCompanyDetails();



            //employee e = new employee(1,"VR");
            //e.displayCompanyDetails();
            //e.eid = 1;
            //e.ename = "Dhanush";
            //e.yob = 2001;
            //e.salary = 20000;
            //Console.WriteLine(e.displayEmpDetails());



            //customers c  = new SavingsAccount();
            //c.TotalAmount = 100000;
            //Console.WriteLine(c.GetTotalAmount());
            //SavingsAccount b= new SavingsAccount();
            //Console.WriteLine(b.branchAddress());
            //customers c2 = new CurrentAccount();
            //c2.TotalAmount = 150000;
            //Console.WriteLine(c2.GetTotalAmount());
            //CurrentAccount b2 = new CurrentAccount();
            //Console.WriteLine(b2.branchAddress());


            student s1 = new student(1, "Dhanush");
            Console.WriteLine("student collage name " + student.collagename);
            Console.WriteLine("studentID "+s1.sid+" studentName "+s1.sname);
            student s2 = new student(2, "sai");
            student.collagename = "SJIT";
            Console.WriteLine("student collage name " + student.collagename);
            Console.WriteLine("studentID " + s2.sid + " studentName " + s2.sname);
            Console.WriteLine(s1.cname + " has " + student.semester + " semesters");
            Console.WriteLine("No of months in a year " + s1.NoOfMonthsInYear);

        }
    }
}
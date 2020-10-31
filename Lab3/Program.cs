using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.setName("NAHID");
            s.setId("17-34226-1");
            s.setDept("CSE");
            s.setCgpa(3);
            s.ShowInfo();
            Console.WriteLine();

            Course c = new Course();
            c.setCourseName("OOP2");
            c.setCourseCode("3333");
            c.setCourseCredit(3);
            c.ShowInfo();
            Console.WriteLine();

            Account a = new Account();
            a.setAccName("NAHID");
            a.setAcId("123");
            a.setBalance(15000);
            a.Deposit(15000);
            Console.WriteLine(a.getBalance());
            a.Withdraw(5000);
            Console.WriteLine(a.getBalance());

            Triangle t = new Triangle();
            t.setX(3);
            t.setY(3);
            t.setZ(3);
            t.ShowInfo();
            t.TestTriangle();
        }
    }
}

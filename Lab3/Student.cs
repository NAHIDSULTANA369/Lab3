using System;
namespace Lab3
{
    public class Student
    {
        string name;
        string id;
        string dept;
        float cgpa;

        public string getName()
        {
            return name;
        }

        public string getId()
        {
            return id;
        }
        public string getDept()
        {
            return dept;
        }
        public float getCgpa()
        {
            return cgpa;
        }
        public void setName(String Name)
        {
            name = Name;
        }
        public void setId(String Id)
        {
            id = Id;
        }
        public void setDept(String Dept)
        {
            dept = Dept;
        }
        public void setCgpa(float Cgpa)
        {
            cgpa = Cgpa;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id:" + id);
            Console.WriteLine("Dept:" + dept);
            Console.WriteLine("Cgpa:" + cgpa);
        }



      
    }
}

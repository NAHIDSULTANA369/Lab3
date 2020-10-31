using System;
namespace Lab3
{
    public class Course
    {
        string courseName;
        string courseCode;
        int courseCredit;

        public string getCourseName()
        {
            return courseName;
        }
        public string getCourseCde()
        {
            return courseCode;
        }
        public int getCourseCredit()
        {
            return courseCredit;
        }
        public void setCourseName(String CourseName)
        {
            courseName = CourseName;
        }
        public void setCourseCode(String CourseCode)
        {
            courseCode = CourseCode;
        }
        public void setCourseCredit(int CourseCredit)
        {
            courseCredit = CourseCredit;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Course Name:" + courseName);
            Console.WriteLine("Course Code:" + courseCode);
            Console.WriteLine("Course Credit:" + courseCredit);
        }
    }
}

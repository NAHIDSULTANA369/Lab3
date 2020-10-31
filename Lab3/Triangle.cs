using System;
namespace Lab3
{
    public class Triangle
    {
        int x;
        int y;
        int z;

        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public int getZ()
        {
            return z;
        }
        public void setX(int X)
        {
            x = X;
        }
        public void setY(int Y)
        {
            y = Y;
        }
        public void setZ(int Z)
        {
            z = Z;
        }
        public void ShowInfo()
        {
            Console.WriteLine("X value:" + x);
            Console.WriteLine("Y value:" + y);
            Console.WriteLine("Z value:" + z);
        }
        public void TestTriangle()
        {
            if (x==y && x==z)
            {
                Console.WriteLine("The Triangle is Equilateral");
            }
            else if (x==y || y==z || x==z)
            {
                Console.WriteLine("The Triangle is Isosceles");
            }
            else
            {
                Console.WriteLine("The Triangle is Scalene");
            }
        }
    }
}

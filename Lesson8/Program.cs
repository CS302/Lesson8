using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int, int> p1 = new Point<int, int>(12, 46);
            p1.Print();
            Console.WriteLine();

            /*Point<string, double> p2 = new Point<string, double>("Петр", 100000);
            p2.Print();*/

            //Point<Worker, int> p3 = new Point<Worker, int>(new Worker("Петр", 25, 15466), 78000);

            Console.ReadLine();
        }
    }

    class Point<T,M> where T : struct
    {
        public T x;
        public M y;

        public Point(T x, M y)
        {
            this.x = x;
            this.y = y;
        }
        public void Print()
        {
            Console.WriteLine("X = {0} \nY = {1}", x, y);
        }
    }

    class IntPoint
    {
        public int x;
        public int y;

        public IntPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine("X = {0} \nY = {1}", x, y);
        }
    }

    /*class StringPoint
    {
        public string name;
        public double y;

        public StringPoint(string name, double y)
        {
            this.name = name;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine("X = {0} \nY = {1}", x, y);
        }
    }*/
}

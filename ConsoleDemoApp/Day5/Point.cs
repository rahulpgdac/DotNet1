﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day5
{
    internal class Point
    {
        int x;
        int y;
        //public Point()
        //{
        //    this.x = 20;
        //    this.y = 30;
        //}       
        public Point(int x = 40, int y = 40)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"Point({x},{y})";
        }

        //overloading + operator
        public static Point operator +(Point ob1, Point ob2)
        {

            int x = ob1.x + ob2.x;
            int y = ob1.y + ob2.y;
            return new Point(x, y);
        }

        //overloading - operator
        public static Point operator -(Point ob1, Point ob2)
        {

            return new Point(ob1.x - ob2.x, ob1.y - ob2.y);
        }
        //overloading * operator
        public static Point operator *(Point ob1, Point ob2)
        {
            return new Point(ob1.x * ob2.x, ob1.y * ob2.y);
        }
        //Destructor
        ~Point()
        {
            Console.WriteLine("Point destructor called");
        }
    }
    class PointMain
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Console.WriteLine(p1);

            Point p2 = new Point(40, 30);
            Console.WriteLine(p2);
            /*
            Point p3 = new Point(70);
            Console.WriteLine(p3);

            Point p4 = new Point(y:60);
            Console.WriteLine(p4);

            Point p5 = new Point(y:80,x:20);
            Console.WriteLine(p5);*/

            Point p6 = p1 + p2;
            Console.WriteLine(p6);
            //GC.Collect(0);
            Console.WriteLine(p1 - p2);
            Console.WriteLine(p1 * p2);

        }
    }
}

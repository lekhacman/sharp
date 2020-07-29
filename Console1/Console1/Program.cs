using System;
using Console1.models;
using Console1.service;
using Point = System.Drawing.Point;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(3, 4);
            var d3Point = new Point3D(3, 4, 5);
            Console.WriteLine("Hello World!");
            
            Console.WriteLine(MyMath.FibLoop(16));
            Console.WriteLine(MyMath.FibRecursive(16));
        }
    }
}
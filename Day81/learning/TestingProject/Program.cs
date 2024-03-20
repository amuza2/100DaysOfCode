using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject
{
    public class Shape
    {
        public virtual float Area() { return 0; }
    }
    public class Rectangle : Shape
    {
        public float X { get; }
        public float Y { get; }
        public Rectangle(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override float Area()
        {
            return X * Y;
        }
    }
    public class Circle : Shape
    {
        public float Radius { get;}
        public Circle(float r)
        {
            Radius = r;
        }
        public override float Area()
        {
            return Radius * Radius * (float)Math.PI;
        }

    } 
    internal class Program
    {
    public static float CalculateAllArea(IList<Shape> area)
    {
        float totalArea = 0;
        foreach (var areaItem in area)
        {
            totalArea += areaItem.Area();
        }
        return totalArea;
    }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 5);
            Circle c = new Circle(3.4f);
            IList<Shape> shapes = new List<Shape>();
            Shape[] shapes2 = new Shape[] {r,c};
            shapes.Add(r);
            shapes.Add(c);
            float totalArea = CalculateAllArea(shapes2);
            Console.WriteLine("total area is: " + totalArea);

        }
    }
}

using Coding.Exercise;
using System;
using System.Runtime.CompilerServices;

Console.WriteLine("hi");
List<Shape> shapes = new List<Shape>();
shapes.Add(new Rectangle(3, 4));
shapes.Add(new Square(4));
ExerciseShapes.GetShapesAreas(shapes);
Console.ReadLine();

namespace Coding.Exercise {


    public static class ExerciseShapes {
        public static List<double> GetShapesAreas(List<Shape> shapes) {
            var result = new List<double>();

            foreach (var shape in shapes) {
                // result.Add(shape.CalculateArea());
                shape.describe();
            }

            return result;
        }
    }

    public abstract class Shape {
        public string Name { get; set; }
        public abstract double CalculateArea();

        public string describe() {
            Console.WriteLine(this.Name + " from abstract class!");
            return this.Name; 
        }
    }

    public class Square : Shape {
        public double Side { get; }

        public Square(double side) {
            Side = side;
        }

        public override double CalculateArea() {
            return Side * Side;

        }
    }


    public class Rectangle : Shape {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height) {
            Width = width;
            Height = height;
        }

        public override double CalculateArea() {
            return Width * Height;

        }
    }

    public class Circle : Shape {
        public double Radius { get; }

        public Circle(double radius) {
            Radius = radius;
        }

        public override double CalculateArea() {
            return 2 * Math.PI * Radius;

        }
    }
}

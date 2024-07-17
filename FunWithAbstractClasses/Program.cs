using System;



namespace Coding.Exercise {
    public static class ExerciseShapes {
        public static List<double> GetShapesAreas(List<Shape> shapes) {
            var result = new List<double>();

            foreach (var shape in shapes) {
                result.Add(shape.CalculateArea());
            }

            return result;
        }
    }

    public abstract class Shape {
        public abstract List<Double> CalculateArea();
    }

    public class Square : Shape {
        public double Side { get; }

        public Square(double side) {
            Side = side;
        }

        public override List<Double> CalculateArea() {
            return new List<Double>();

        }
    }


    public class Rectangle : Shape {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height) {
            Width = width;
            Height = height;
        }

        public override List<Double> CalculateArea() {
            return new List<Double>();

        }
    }

    public class Circle : Shape {
        public double Radius { get; }

        public Circle(double radius) {
            Radius = radius;
        }

        public override List<Double> CalculateArea() {
            return new List<Double>();

        }
    }
}

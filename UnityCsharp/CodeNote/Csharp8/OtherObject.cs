using System;

public partial class CsharpNote
{
    public int abc = 5;

    public class Square {
        public double Side { get; }
        public Square(double side) {
            Side = side;
        }
    }

    public class Circle {
        public double Radius { get; }
        public Circle (double radius) {
            Radius = radius;
        }
    }

    public class Rectangle {
        public double Length { get; }
        public double Height { get; }
        public Rectangle(double length, double height) {
            Length = length;
            Height = height;
        }
    }

    public class Triangle
    {
        public double Base { get; }
        public double Height { get; }
        public Triangle(double @base, double height) {
            Base = @base;
            Height = height;
        }
    }

    #region C#7 之前

    public static double ComputeArea(object shape)
    {
        if (shape is Square)
        {
            var s = (Square)shape;
            return s.Side * s.Side;
        }
        else if (shape is Circle)
        {
            var c = (Circle)shape;
            return c.Radius * c.Radius * Math.PI;
        }

        throw new ArgumentException(
            message: "shape is not a recognized shape",
            paramName: nameof(shape));
    }
     
    #endregion

    public static double ComputeAreaModernIs(object shape)
    {
        if (shape is Square s)
            return s.Side * s.Side;

        throw new ArgumentException(
            message: "shape is not a recognized shape",
            paramName: nameof(shape));
    }
}
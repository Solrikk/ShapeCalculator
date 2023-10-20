using System;

namespace GeometryLibrary
{
    // Interface defining common methods for all shapes
    public interface IShape
    {
        double CalculateArea(); 
        string GetName(); 
    }

    // Class representing a circle
    public class Circle : IShape
    {
        private double radius; 
        private string name; 

        // Constructor for the Circle class
        public Circle(double radius, string name)
        {
            this.radius = radius;
            this.name = name;
        }

        // Method for calculating the area of the circle
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Method for getting the name of the circle
        public string GetName()
        {
            return name;
        }

        // Method for calculating the circumference of the circle
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }
    }

    // Class representing a triangle
    public class Triangle : IShape
    {
        private double sideA; 
        private double sideB; 
        private double sideC; 
        private string name; 

        // Constructor for the Triangle class
        public Triangle(double sideA, double sideB, double sideC, string name)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.name = name;
        }

        // Method for calculating the area of the triangle
        public double CalculateArea()
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        // Method for getting the name of the triangle
        public string GetName()
        {
            return name;
        }

        // Method for checking if the triangle is a right triangle
        public bool IsRightTriangle()
        {
            return Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2) ||
                      Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2) ||
                      Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2);
        }

        // Method for calculating the perimeter of the triangle
        public double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }
    }
}
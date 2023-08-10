﻿using System;

namespace AbstractClassesAndMethods
{
    class Program
    {
        static void Main()
        {
            //Initate new objects
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            ShapeClass myNewShape = new ShapeClass();
            //AbstractShape myNewAbstractShape = new AbstractShape(); //Error because abstract class cannot be instantiated

            //Reference Child A01_Class to its parent
            //ShapeClass shape = new Circle(); //Error because Circle not inherit from abstract class
            AbstractShape shapes = new Circle();
            IShape shapes2 = new Circle();

            //Reference Parent A01_Class to its child
            //Circle circle2 = new ShapeClass(); //Error you reduce the feature of the child object to the features of the base class

            //override
            shapes.GetArea2(); //GetArea2 but in Circle
            circle.GetArea2(); //GetArea2 but in Circle
            //method hiding
            shapes.GetArea3(); //GetArea3
            circle.GetArea3(); //GetArea3 but in Circle

            Console.ReadKey();
        }
    }

    class ShapeClass
    {
        //Concrete A01_Class as base class
        public void GetArea3()
        {
            Console.WriteLine("GetArea4");
        }
    }

    public abstract class AbstractShape //as a abstract class (base class)
    {
        public AbstractShape()
        {
            Console.WriteLine("Shape constructor"); //Will called every time a new object is created
        }

        public abstract double GetArea();

        public virtual void GetArea2()
        {
            Console.WriteLine("GetArea2");
        }

        public virtual void GetArea3()
        {
            Console.WriteLine("GetArea3");
        }

        public void GetArea4()
        {
            Console.WriteLine("GetArea4");
        }
    }

    public interface IShape
    {
        //Interface
        double GetArea(int a);
    }

    class Circle : AbstractShape, IShape
    {
        public override double GetArea()
        {
            return 22 / 7;
        }

        public override void GetArea2()
        {
            Console.WriteLine("GetArea2 but in Circle");
        }

        public new void GetArea3()
        {
            Console.WriteLine("GetArea3 but in Circle");
        }

        public double GetArea(int a)
        {
            return 22 / 7;
        }
    }

    class Rectangle : ShapeClass, IShape
    {
        public double GetArea()
        {
            return 30 / 2;
        }

        public void GetArea2()
        {
            Console.WriteLine("GetArea2 but in Rectangle");
        }

        public void GetArea3()
        {
            Console.WriteLine("GetArea3 but in Rectangle");
        }

        public double GetArea(int a)
        {
            return 30 / 2;
        }
    }
}
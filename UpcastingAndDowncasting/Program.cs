// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


/*
 Agenda
Conversion from a derived class to a base class (upcasting)

Conversion from a base class to a derived class (downcasting)

The as and is keywords



Upcasting
Circle circle = new Circle();
Shape shape = circle;


Downcasting
Circle circle = new Circle();
Shape shape = circle;
Circle anotherCircle = (Circle)shape;

Car car = (Car)shape; //throws InvalidCastException


The as keyword
Car car = (Car) objl

Car car = obj as Car;
if (car != null)
{
...

}

The is keyword
if (obj is Car)
{
    Car car = (Car) obj;
...
}


 */
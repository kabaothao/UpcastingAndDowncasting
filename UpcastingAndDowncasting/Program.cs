// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace UpcastingAndDowncasting // Note: actual namespace depends on the project name.
{
        public static class Program
            {
                static void Main(string[] args)
                {
                    //Text text = new Text();
                    //Shape shape = text;

                    //text.Width = 200;
                    //shape.Width = 100;

                    //Console.WriteLine(text.Width);

                    StreamReader reader =  new StreamReader(args[0]); //note that here we have a few overloads or the constructor of this class. In the framework stream is the base or parent of every kind of a stream.


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




Both this text and shape objects are actually pointing to the same object in memory.

Well it's more accurate to say takes and shape are both references to the same object in memory but

they have different views what it means is if I go here and say text dot I can see all the properties

of a Takes object.



Line 18
Because all text and shape are references to the same object.

They just have different views.






 */
using System;

namespace QuadrilateralsLSP
{
    /*https://csharp-video-tutorials.blogspot.com/2018/01/open-closed-principle.html
      https://www.codeproject.com/Articles/595160/Understand-Liskov-Substitution-Principle-LSP
    Subtypes must be substitutable for their base type.
    LSP States that IS-A relationship is insufficient and should be replaced with IS-Substitutable with
    IS-Substitutable-For

    If S is a subtype of T then objects of type T may be replaced with objects of type S, without breaking
    the program.
    -->Which means, Derived types must be completely substitutable for their base types
    -->This principle is just an extension of the Open Close Principle

    More formally, the Liskov substitution principle (LSP) is a particular definition of a subtyping relation, 
    called (strong) behavioral subtyping.

    Uncle Bob summarized LSP as “Subtypes must be substitutable for their base types”. In other words, 
    given a specific base class, any class that inherits from it, can be a substitute for the base class.
    
    Implementation guidelines : In the process of development we should ensure that 
    1.No new exceptions can be thrown by the subtype unless they are part of the existing exception hierarchy.
    2.We should also ensure that Clients should not know which specific subtype they are calling, nor should they 
    need to know that. The client should behave the same regardless of the subtype instance that it is given.
    3.And New derived classes just extend without replacing the functionality of old classes

    Violation of LSP:
    The classic example of this shows how you cannot substitute a rectangle class for a square class.
    Means if a square class inherits the Rectangle class it is a voilation.

    To solve this we need to change the inheritance hierarchies by making below as base class:
    public abstract class Quadrilaterals
    {
        abstract public int GetArea();
    }

     */
    class Program
    {
        static void Main(string[] args)
        {
            //Without LSP
            Rectangle rectangle;
            rectangle = new Rectangle();
            rectangle.SetWidth(14);
            rectangle.SetHeight(10);
            Console.WriteLine("Rectangle Area={0}", rectangle.Area); // 140        

            rectangle = new Square();
            rectangle.SetWidth(14);
            rectangle.SetHeight(10);
            Console.WriteLine("Rectangle Area={0}", rectangle.Area); // 100 -> Rectangle Area should be 140

            /*
            Where is the issue?
            At first, it might seem that the code is fine (until we run it). In fact, the code will work fine if we 
            attempt to get the area using the instance of the rectangle class. But if we use an instance of the square class 
            then the result is different. The reason is, when we write:

            Rectangle rectangle = new Square();

            rectangle holds reference of the the type Square. Next, when we execute the setWidth and setHeight methods, 
            it executes the methods of the Square class, that sets height = width (as per the logic of the square has 
            length = breadth) and when the getArea is executed, it calculates an incorrect area.

            This is the reason that this code violates the Liskov Substitution Principle, when we replace the object/instance 
            of the Rectangle with that of Square and this is what this principle is all about. In other words, if S is a 
            subtype of T, then objects of type T may be replaced with objects of type S (in other words, objects of type S 
            may substitute objects of type T) without altering any of the desirable properties of that program (correctness, task performed, and so on).
             */

            //With LSP
            Quadrilaterals_LSP rect = new Rectangle_LSP(14, 10);
            Quadrilaterals_LSP square = new Square_LSP(10);

            Console.WriteLine(rect.GetArea());
            Console.WriteLine(square.GetArea());

            Console.ReadLine();
        }
    }
}

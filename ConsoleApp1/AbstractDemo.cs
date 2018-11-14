using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * default is private
 * 
 */
namespace ConsoleApp1
{
    abstract class AbstractDemo //used as base class of other class
    {
        int i = 4;
        int k = 3;
        public abstract void getClassName(); //abstrace method can only in abstrace class
        public AbstractDemo() //constractor
        {
        }
    }

    abstract class ShapesClass //used as base class of other class
    {
        abstract public int Area(); //no method body, abstract method an only in abstract class
    }

    class Square : ShapesClass //need implement inherited abstrace method
    {
        int side = 0;
        public Square(int n) //constractor with parameter
        {
            side = n;
        }
        public override int Area() //need use keyword overrider for abastract method
        {
            return side * side;
        }
        public static void AbstractDemoTest()
        {
            Square sq = new Square(12);
            Console.WriteLine("Area of the square = {0}", sq.Area());
        }
    }

    interface I { void M(); } //interface no method body

    abstract class C : I
    {
        public abstract void M(); //abstract no method body
    }


    abstract class BaseClass //can only be base class of other class
    {
        protected int _x = 100;
        protected int _y = 150;
        public abstract void AbstractMethod(); //abstract method no body
        public abstract int X { get; }
        public abstract int Y { get; }
    }

    class DerivedClass : BaseClass
    {
        public override void AbstractMethod()
        {
            _x++;
            _y++;
        }
        public override int X
        {
            get { return _x + 10; }
        }
        public override int Y
        {
            get { return _y + 10; }
        }

        public static void DerivedClassTest()
        {
            DerivedClass o = new DerivedClass();
            o.AbstractMethod();
            Console.WriteLine("x = {0}, y ={1}", o.X, o.Y);
        }

    }

    abstract class Motorvehicle
    {
        public abstract void Run();
        public void Fuel()
        {
            Console.WriteLine("Fuel has fill");
        }
    }

    class Car : Motorvehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is ready to drive");
        }
    }

    class Bike : Motorvehicle
    {
        public override void Run()
        {
            Console.WriteLine("Bike is ready to drive");
        }

        public static void BikeTest()
        {
            Car c = new Car();
            Bike b = new Bike();
            c.Fuel ();
            c.Run();
            b.Fuel();
            b.Run();
        }
    }
}

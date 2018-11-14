using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InheritanceApplication
    {
    }

    class Shap 
    {
        public void setWideh(int w) { width = w; }
        public void setHeight(int h) { height = h; }
        protected int width;
        protected int height;
    }

    //Base class PainCost
    public interface PaintCost { int getCost(int area); }

    //Derived class can implement/inheritance multiple class
    class Rectangle : Shap, PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }
        public int getCost(int area)
        {
            return area * 70;
        }
    }

    //Derived clas inheritance single class
    class Tabletop : Rectangle
    {

    }

    //Base class
    class X
    {
        protected virtual void F() { Console.WriteLine("X.F"); }
        protected virtual void F2() { Console.WriteLine("X.F2"); }
        //virtual keyworf override methods in sub classes.
        //Otherwise the base implementation will be hidden by the new implementation
        //.ToString() is virtual method
    }

    //Derived class
    class Y :X
    {
        sealed protected  override void F() { Console.WriteLine("Y.F"); }
        //sealed cannot override by sub class
        //The main purpose of a sealed class is to take away the inheritance feature from the user so they cannot derive a class from a sealed class.
        protected override void F2() { Console.WriteLine("Y.F2"); }

    }

    class Z:Y
    {
        protected override void F2() { Console.WriteLine("Z.F2"); }
      
    }

    class RectangleTester
    {
        static void MainRec (string[] args)
        {
            Rectangle Rect = new Rectangle();
            int area;

            Rect.setHeight(5);
            Rect.setWideh(7);
            area = Rect.getArea();
        }
    }
}

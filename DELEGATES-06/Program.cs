using System;

namespace DELEGATES_06
{
    //Multi Cast Delegate
    public delegate void RectanDelegate(decimal width, decimal height);
    class Program
    {
        static void Main(string[] args)
        {
            var helper = new Rectangelhelper();
            RectanDelegate rect;
            rect = helper.GetArea;
            rect += helper.GetPerimeter;

            rect(10, 10);
            rect -= helper.GetArea;

            Console.WriteLine("After UnSubscribibing rect.GetArea\n");
            rect(10, 10);

            Console.ReadKey();
        }
    }

    public class Rectangelhelper
    {
        public void GetArea(decimal width, decimal height)
        {
            var result = width * height;
            Console.WriteLine($"Area: {width * height} = {result}");
        }

        public void GetPerimeter(decimal width, decimal height)
        {
            var result = 2 * (width + height);
            Console.WriteLine($"Perimeter: 2 × ({ width } + { height}) = {result}");
        }
    }
}

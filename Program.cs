using System;
namespace HelloWorldApplication
{
    class Test{
        double length;
        double width;
        public void Acceptdetails(){
            length = Convert.ToDouble(Console.ReadLine());
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea(){
            return length * width;
        }public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class ExecuteTest
    {
        static void Main(string[] args)
        {
            Test r = new Test();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
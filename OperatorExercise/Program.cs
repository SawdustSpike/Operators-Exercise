using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    internal class Program
    {
        public static double AreaOfACircle(double x)
        {
            double area = Math.PI* Math.Pow(x, 2);
            return area;
        }


        //-----------------------Exercise 1--------------------------------
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            //-------------------------Exercise 2------------------------------

            Console.WriteLine("What's the Radius of your circle, boo?");
            var r = double.Parse(Console.ReadLine());
            double x = AreaOfACircle(r);
            Console.WriteLine($"the area of a circle with a radius of {r} is {x}.");            
        }

    }
}
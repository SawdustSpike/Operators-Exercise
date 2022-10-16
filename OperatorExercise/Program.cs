using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    internal class Program
    {
        public static double AreaOfACircle(double x, double y)
        {
            var area = (x * y);
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

            double pi = 3.14;
            Console.WriteLine("What's the Radius of your circle, boo?");
            var r = double.Parse(Console.ReadLine());
            double rSquared = (r * r);
            double x = AreaOfACircle(pi, rSquared);
            Console.WriteLine($"the area of a circle with a radius of {r} is {x}.");
            /* I saw too late that I did write this exactly as you guys wanted me to 
            let me know if you want me to redo it using the code you asked for */
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class QuadraticEquation
    {
        public void Quadratic()
        {

            Console.WriteLine("Enter value of a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of c:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("It is not a quardatic equation");
                return;
            }

            int delta = b * b - 4 * a * c;
            if (delta > 0)
            {


                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine(("Square roots of eqn a*x*x+b*x+c", x1, x2));
            }
            else
            {
                Console.WriteLine("Roots are complex");
                Console.Write(-(double)b / (2 * a) + " + i" + Math.Sqrt(delta) + "\n"
                         + -(double)b / (2 * a) + " - i" + Math.Sqrt(delta));
            }
        }
    }
}
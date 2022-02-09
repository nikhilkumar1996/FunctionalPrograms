using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class EuclideanDistance
    {
        public void Distance()
        {
            Console.WriteLine("Enter value of x point");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of y point");
            int y = Convert.ToInt32(Console.ReadLine());

            double result = Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));
            Console.WriteLine("Euclidean Distance="+result);
        }
    }
}
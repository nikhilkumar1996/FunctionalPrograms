using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programs");
            Console.WriteLine(  "1)2D Array" +
                              "\n2)Euclidean Distance" +
                              "\n3)Exit");
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Choice");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Arrays arrays = new Arrays();
                        arrays.TwoDimensionalArray();
                        break;

                    case 2:
                        EuclideanDistance euclideanDistance = new EuclideanDistance();
                        euclideanDistance.Distance();
                        break;

                    case 3:
                        flag= false;
                        break;

                    default:
                        Console.WriteLine("INvalid Option");
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Arrays
    {
        public void TwoDimensionalArray()
        {
            Console.WriteLine("Enter no of rows");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no of columns");
            int c = Convert.ToInt32(Console.ReadLine());

            //creating Array-1d
            Console.WriteLine("Enter values:");
            int[] onedimensionalarray = new int[r * c];
            for (int i = 0; i < onedimensionalarray.Length; i++)
            {
                onedimensionalarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            //creating Array-2d
            int index = 0;
            int[,] twodimensionalarray = new int[r, c];
            for (int j = 0; j < r; j++)
            {
                for (int k = 0; k < c; k++)
                {
                    twodimensionalarray[j, k] = onedimensionalarray[index];
                    index++;

                }

            }

            Console.WriteLine("2d array elements");
            foreach (int item in twodimensionalarray)
            {
                Console.WriteLine(item + " ");
            }



        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class IntegerSum
    {
        public void SumEqualToZero(int n)
        {
            Console.WriteLine("Enter numbers in array:");
            int[] arr = new int[n];
            for(int a = 0; a < arr.Length; a++)
            {
                arr[a]=Convert.ToInt32(Console.ReadLine());
            }
            bool Sum = false;

            for(int i = 0; i < n - 2; i++)
            {
                for(int j = i + 1; j < n - 1; j++)
                {
                    for(int k = j + 1; k < n; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Sum = true;
                            Console.WriteLine("sum of {0}+{1}+{2}==0" ,arr[i] ,arr[j] ,arr[k]);
                        }
                        if (Sum == false)
                        {
                            Console.WriteLine("No match is Found");
                        }
                    }
                }
            }
        }
    }
}
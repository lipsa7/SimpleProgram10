using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdppractice8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Userprogramcode.findExistence(arr, num));
            Console.ReadKey();
        }
    }

    class Userprogramcode
    {
        public static string findExistence(int[] arr,int num)
        {
            /*string result = string.Join("", arr);
            string result1 = num.ToString();

            if (result.Contains(result1))
            {
                return "Present";
            }
            else
            {
                return "Not present";
            }
            */
            string max = "Not present";

            for(int i = 0; i < arr.Length; i++)
            {
                if (num == arr[i])
                {
                    max= "Present";
                    break;

                }
                
            }
            return max;
        }
    }
}

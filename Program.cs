using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] nums = new int[10];
            Console.WriteLine("Unsorted:\n");
            //Writing to the console the unsorted array
            for (int i=0; i<nums.Length; i++)
            {
                nums[i] = rnd.Next(0, 1000);
                Console.WriteLine(i.ToString() + ". " + nums[i]);
            }
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] < nums[i + 1])
                    {
                        //put nums[1] into a temporary spot
                        int temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);

            Console.WriteLine("\nSorted:\n");
            //Writing to the console the sorted array
            for(int i = 0; i< nums.Length;i++)
            {
                Console.WriteLine(i.ToString() + ". " + nums[i]);
            }

            Console.WriteLine("\nPress Enter to continue.....");
            Console.ReadLine();
        }
    }
}

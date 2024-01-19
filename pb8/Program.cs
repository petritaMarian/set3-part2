using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayInput = Console.ReadLine();
            string[] nums = arrayInput.Split(' ');
            string aux = nums[0];

            for (int i = 0; i < nums.Length - 1; i += 1)
                nums[i] = nums[i + 1];

            nums[nums.Length - 1] = aux;

            for (int i = 0; i < nums.Length; i += 1)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

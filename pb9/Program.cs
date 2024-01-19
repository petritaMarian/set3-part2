using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayInput = Console.ReadLine();
            string[] nums = arrayInput.Split(' ');
            int k = int.Parse(Console.ReadLine());
            string aux;

            for (int i = 0; i < k; i += 1)
            {
                aux = nums[0];

                for (int j = 0; j < nums.Length - 1; j += 1)
                    nums[j] = nums[j + 1];

                nums[nums.Length - 1] = aux;
            }
            for (int i = 0; i < nums.Length; i += 1)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

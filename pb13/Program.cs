using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayInput = Console.ReadLine();
            string[] nums = arrayInput.Split(' ');
            string aux;

            for (int i = 0; i < nums.Length - 1; i += 1)
            {
                for (int j = i + 1; j < nums.Length; j += 1)
                    if (float.Parse(nums[j]) < float.Parse(nums[i]))
                    {
                        aux = nums[j];
                        nums[j] = nums[i];
                        nums[i] = aux;
                    }
            }

            for (int i = 0; i < nums.Length; i += 1)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}

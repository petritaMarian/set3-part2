using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayInput = Console.ReadLine();
            string[] nums = arrayInput.Split(' ');

            float k = float.Parse(Console.ReadLine());

            string pos = "-1";

            for (int i = 0; i < nums.Length; i += 1)
                if (float.Parse(nums[i]) == k) pos = Convert.ToString(i);

            Console.WriteLine(pos);
        }
    }
}

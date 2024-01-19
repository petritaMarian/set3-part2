using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 1)
            {
                if (isPrime(i)) Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static bool isPrime(int num)
        {
            if (num < 2) return false;
            if (num % 2 == 0 && num != 2) return false;
            for(int i = 3; (i * i) <= num; i += 2)
                if (num % i == 0) return false;
            return true;
        }
    }
}

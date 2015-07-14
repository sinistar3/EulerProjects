using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerCode
{
    class ProjectEuler
    {
        static void Main(string[] args)
        {
            sumsOfThreesAndFivesMultiples();
            Console.ReadLine();
        }

        private static void sumsOfThreesAndFivesMultiples()
        {
            int x = 3;
            int total = 0;
            while (x < 1000)
            {
                if (x % 3 == 0 || x % 5 == 0)
                    total += x++;
                else x++;
            }
            Console.WriteLine(total); //233168
        }
    }
}

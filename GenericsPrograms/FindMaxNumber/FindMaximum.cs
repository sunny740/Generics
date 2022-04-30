using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPrograms.FindMaximum
{
    public class FindMaximum
    {
        public int FindMaxInteger(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First Number is greater: " + first);
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second Number is Greater: " + second);
                return second;
            }
            else
            {
                Console.WriteLine("Third Number is Greater: " + third);
                return third;
            }
        }
        public float FindMaxFloat(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First Float Number is Greater: " + first);
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second Float Number is Greater: " + second);
                return second;
            }
            else
            {
                Console.WriteLine("Third Float Number is Greater: " + third);
                return third;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPrograms.FindMaximum
{
    public class FindMaximum<T> where T : IComparable
    {
        public T first, second, third;

        public FindMaximum(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public T FindMax()
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First Number is greater: " + first);
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second Number is greater: " + second);
                return second;
            }
            else
            {
                Console.WriteLine("Third Number is greater: " + third);
                return third;
            }
            return default;
        }
        public T MaxMethod()
        {
            T max = FindMax();
            return max;
        }
    }
}

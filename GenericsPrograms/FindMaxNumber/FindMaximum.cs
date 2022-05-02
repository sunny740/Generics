using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPrograms.FindMaximum
{
    public class FindMaximum<T> where T : IComparable
    {
        public T[] Val;

        public FindMaximum(T[] Val)
        {
            this.Val = Val;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public T PrintMaxMethod()
        {
            var max = MaxValue(this.Val);
            Console.WriteLine("Maximum Value is :" + max);
            return max;
        }
    }
}

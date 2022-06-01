using System;

namespace Generics
{
    public class GenericMax<T> where T : IComparable
    {
        public T[] value;
        public GenericMax(T[] value)
        {
            this.value = value;

        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValues(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValues(this.value);
            return max;
        }
        public void printMaxValue()
        {
            var max = MaxValues(this.value);
            Console.WriteLine("Maximum Value is:  " + max);
        }

    }
}

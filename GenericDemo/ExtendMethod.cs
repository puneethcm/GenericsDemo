using System;
namespace GenericDemo
{
	public class ExtendMethod<T>where T:IComparable
	{
        public T[] array;
        public ExtendMethod(T[] array)
        {
            this.array = array;
        }
        public T[] Sort(T[] array)
        {
            Array.Sort(array);
            return array;
        }
        public T MaxValue(T[] array)
        {
            var sortedValues = Sort(array);
            return sortedValues[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.array);
            return max;
        }
        public void ToPrintMaxValue()
        {
            var max = MaxValue(this.array);
            Console.WriteLine("Maximux value: " + max);
        }
    }
}


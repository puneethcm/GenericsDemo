using System;
namespace GenericDemo
{
	public class GenericClass<T>
	{
		public T[] array;
		public GenericClass(T[] array)
		{
			this.array = array;
		}
		public void ToPrint()
		{
			Console.WriteLine("\nDisplaying  Values");
			foreach(T elements in array)
			{
				Console.Write(elements + " ");
			}
		}
	}
}


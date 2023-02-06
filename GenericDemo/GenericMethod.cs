using System;
namespace GenericDemo
{
	public class GenericMethod
	{
		public static void GenericMethodConcept<T>(T[] array)
		{
			Console.WriteLine("\nDisplaying value");
			foreach(T elements in array)
			{
				Console.Write(elements + " ");
			}
		}
	}
}


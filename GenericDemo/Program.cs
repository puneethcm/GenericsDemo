using System;
using GenericDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] intArray = { 20, 45, 70, 10, 35 };
        double[] doubleArray = { 30.64, 52.45, 26, 98, 98.7 };
        char[] charArray = { 'A', 'R', 'R', 'A', 'Y' };
        Console.WriteLine("\nWelcome to Generics");
        Console.WriteLine("\nPlease choose any option below");
        Console.WriteLine("1:To Print Array\n2:Generic method concept");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine("\nInt Array values");
                PrintArry.ToPrintArray(intArray);
                Console.WriteLine("\nDouble Array values");
                PrintArry.ToPrintArray(doubleArray);
                Console.WriteLine("\nChar Array values");
                PrintArry.ToPrintArray(charArray);
                break;

            case 2:
                GenericMethod.GenericMethodConcept<int>(intArray);
                GenericMethod.GenericMethodConcept<double>(doubleArray);
                GenericMethod.GenericMethodConcept<char>(charArray);
                break;
        }
        Console.ReadLine();
    }
}
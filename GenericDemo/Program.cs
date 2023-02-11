using System;
using GenericDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] intArray = { 20, 45, 70, 10, 35 };
        double[] doubleArray = { 30.64, 52.45, 26, 98, 98.7 };
        char[] charArray = { 'A', 'R', 'R', 'A', 'Y' };

        float p = 12.3f, q = 5.6f, r = 40.6f;
        Console.WriteLine("\nWelcome to Generics");
        Console.WriteLine("\nPlease choose any option below");
        Console.WriteLine("1:To Print Array\n2:Generic method concept\n3:Generic class concept\n4:Max Integer Numbers\n5:Max Float value");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                //Console.WriteLine("\nInt Array values");
                PrintArry.ToPrintArray(intArray);
                //Console.WriteLine("\nDouble Array values");
                PrintArry.ToPrintArray(doubleArray);
                //Console.WriteLine("\nChar Array values");
                PrintArry.ToPrintArray(charArray);
                break;

            case 2:
                GenericMethod.GenericMethodConcept<int>(intArray);
                GenericMethod.GenericMethodConcept<double>(doubleArray);
                GenericMethod.GenericMethodConcept<char>(charArray);
                break;

            case 3:
                GenericClass<int> intObj = new GenericClass<int>(intArray);
                intObj.ToPrint();
                GenericClass<double> doubleObj = new GenericClass<double>(doubleArray);
                doubleObj.ToPrint();
                GenericClass<char> chatObj = new GenericClass<char>(charArray);
                chatObj.ToPrint();
                break;

            case 4:
                Console.WriteLine("Enter 3 Numbers");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                FindMaxValue.FindMaxValues(a, b, c);
                Console.Write("{0} is greater than {1},{2},{3}", FindMaxValue.FindMaxValues(a, b, c), a, b, c);
                Console.WriteLine("2 or 3 values are same");
                break;

            case 5:
                var result = FindMaxValue.FindMaxValues(p,q,r);
                Console.Write("{0} is greater than {1},{2},{3}", FindMaxValue.FindMaxValues(p,q,r), p,q,r);
                break;
        }
        Console.ReadLine();
    }
}
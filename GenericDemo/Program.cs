using System;
using GenericDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] intArray = { 20, 45, 70, 10, 35 };
        double[] doubleArray = { 30.64, 52.45, 26, 98, 98.7 };
        char[] charArray = { 'A', 'R', 'R', 'A', 'Y' };

        int a = 30, b = 20, c = 10;
        float p = 12.3f, q = 5.6f, r = 40.6f;
        string str1 = "abc", str2 = "pqr", str3 = "xyz";

        //int intObj=0;
        Console.WriteLine("\nWelcome to Generics");
        Console.WriteLine("\nPlease choose any option below");
        Console.WriteLine("1:To Print Array\n2:Generic method concept\n3:Generic class concept\n4:Max Integer Numbers\n5:Max Float value" +
            "\n6:Max string value\n7:Refactor 1 Method\n8: Refactor 2 Class");
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
                //Console.WriteLine("Enter 3 Numbers");
                //int a = Convert.ToInt32(Console.ReadLine());
                //int b = Convert.ToInt32(Console.ReadLine());
                //int c = Convert.ToInt32(Console.ReadLine());
                FindMaxValue.FindMaxValues(a, b, c);
                Console.Write("{0} is greater than {1}, {2}, {3}", FindMaxValue.FindMaxValues(a, b, c), a, b, c);
                Console.WriteLine("2 or 3 values are same");
                break;

            case 5:
                Console.Write("{0} is greater than {1}, {2}, {3}", FindMaxValue.FindMaxValues(p,q,r), p,q,r);
                break;

            case 6:
                FindMaxValue.FindMaxValues(str1, str2, str3);
                Console.Write("{0} is greater than {1}, {2}, {3}", FindMaxValue.FindMaxValues(str1, str2, str3), str1, str2, str3);
                break;

            case 7:
                RefactorMethod<int>.FindMaxValues(a, b, c);
                Console.Write("\n{0} is greater than {1}, {2}, {3}", FindMaxValue.FindMaxValues(a, b, c), a, b, c);
                RefactorMethod<float>.FindMaxValues(p, q, r);
                Console.Write("\n{0} is greater than {1}, {2}, {3}", FindMaxValue.FindMaxValues(p, q, r), p, q, r);
                RefactorMethod<string>.FindMaxValues(str1, str2, str3);
                Console.Write("\n{0} is greater than {1}, {2}, {3}", FindMaxValue.FindMaxValues(str1, str2, str3), str1, str2, str3);
                break;

            case 8:
                RefactorClass<int>.FindMaxValues(a, b, c);
                Console.Write("\nInteger values are {0}, {1}, {2}", a, b, c);
                RefactorClass<int> intValue = new RefactorClass<int>(a,b,c);
                intValue.MaxValue();

                RefactorClass<float>.FindMaxValues(p, q, r);
                Console.Write("\nFloat values are {0}, {1}, {2}", p, q, r);
                RefactorClass<float> floatValue = new RefactorClass<float>(p, q, r);
                floatValue.MaxValue();

                RefactorClass<string>.FindMaxValues(str1, str2, str3);
                Console.Write("\nString values are {0}, {1}, {2}", str1, str2, str3);
                RefactorClass<string> stringValue = new RefactorClass<string>(str1, str2, str3);
                stringValue.MaxValue();
                break;
        }
        Console.ReadLine();
    }
}
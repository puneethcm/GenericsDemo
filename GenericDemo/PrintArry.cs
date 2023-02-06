using System;
namespace GenericDemo
{
    class PrintArry
    {
        public static void ToPrintArray()
        {
            int[] array=new int[5];
            foreach(int element in array)
            {
                Console.Write(element + " ");
            }
        }
        public static void ToPrintArray(double[] array)
        {
            foreach (double element in array)
            {
                Console.Write(element + " ");
            }
        }
        public static void ToPrintArray(char[] array)
        {
            foreach (char element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}


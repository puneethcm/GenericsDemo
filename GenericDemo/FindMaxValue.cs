using System;
namespace GenericDemo
{
	public class FindMaxValue
	{
        public static int FindMaxValues(int firstNumb, int secondNumb, int thirdNumb)
        {
            if (firstNumb.CompareTo(secondNumb) > 0 && firstNumb.CompareTo(thirdNumb) > 0)
            {
                return firstNumb;
            }
            else if (secondNumb.CompareTo(firstNumb) > 0 && secondNumb.CompareTo(thirdNumb) > 0)
            {
                return secondNumb;
            }
            else if (thirdNumb.CompareTo(firstNumb) > 0 && thirdNumb.CompareTo(secondNumb) > 0)
            {
                return thirdNumb;
            }
            throw new Exception("2 or 3 value or same");
        }
        public static float FindMaxValues(float firstNumb, float secondNumb, float thirdNumb)
        {
            if (firstNumb.CompareTo(secondNumb) > 0 && firstNumb.CompareTo(thirdNumb) > 0)
            {
                return firstNumb;
            }
            else if (secondNumb.CompareTo(firstNumb) > 0 && secondNumb.CompareTo(thirdNumb) > 0)
            {
                return secondNumb;
            }
            else if (thirdNumb.CompareTo(firstNumb) > 0 && thirdNumb.CompareTo(secondNumb) > 0)
            {
                return thirdNumb;
            }
            throw new Exception("2 or 3 value or same");
        }
        public static string FindMaxValues(string firstNumb, string secondNumb, string thirdNumb)
        {
            if (firstNumb.CompareTo(secondNumb) > 0 && firstNumb.CompareTo(thirdNumb) > 0)
            {
                return firstNumb;
            }
            else if (secondNumb.CompareTo(firstNumb) > 0 && secondNumb.CompareTo(thirdNumb) > 0)
            {
                return secondNumb;
            }
            else if (thirdNumb.CompareTo(firstNumb) > 0 && thirdNumb.CompareTo(secondNumb) > 0)
            {
                return thirdNumb;
            }
            throw new Exception("2 or 3 value or same");
        }
    }
}


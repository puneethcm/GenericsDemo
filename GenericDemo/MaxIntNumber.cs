using System;
namespace GenericDemo
{
	public class MaxIntNumber
	{
        public static int FindMaxIntValue(int firstNumb, int secondNumb, int thirdNumb)
        {
            if (firstNumb.CompareTo(secondNumb) > 0 && firstNumb.CompareTo(thirdNumb) > 0)
            {
                return firstNumb;
            }
            else if (secondNumb.CompareTo(firstNumb) > 0 && secondNumb.CompareTo(thirdNumb) > 0)
            {
                return secondNumb;
            }
            else
            {
                return thirdNumb;
            }
        }
    }
}


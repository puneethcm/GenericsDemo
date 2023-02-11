using System;
namespace GenericDemo
{
    public class RefactorClass<T> where T : IComparable
    {
        public T firstNumb, secondNumb, thirdNumb;
        public RefactorClass(T firstNumb,T secondNumb,T thirdNumb)
        {
            this.firstNumb = firstNumb;
            this.secondNumb = secondNumb;
            this.thirdNumb = thirdNumb;
        }
        public static T FindMaxValues(T firstNumb, T secondNumb, T thirdNumb)
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
        public void MaxValue()
        {
            T result = FindMaxValues(firstNumb, secondNumb, thirdNumb);
            Console.WriteLine("\nMax Value: " + result);
        }
    }
}


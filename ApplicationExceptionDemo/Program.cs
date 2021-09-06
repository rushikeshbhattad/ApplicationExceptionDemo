using System;

namespace ApplicationExceptionDemo
{

    class Addition
    {
        public int CalculateSum(int a, int b)
        {
            int sum = a + b;

            return sum;
        }
    }
    public class SecondNumCantBeZeroException : ApplicationException
    {
        public SecondNumCantBeZeroException(string message) : base(message)
        {

        }
    }
    class Program
    {
        private static int res;

        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter first operand: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second operand: ");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 0 || b >= 10000)
                {
                    throw (new SecondNumCantBeZeroException("Please Enter Number second operand greater than 0 and less than 1000!!!"));
                }
                Addition addition = new Addition();
                res = addition.CalculateSum(a, b);
            }
            catch (SecondNumCantBeZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The sum is {0}  ", res);
            }
                Console.ReadKey();
        }
    }
}
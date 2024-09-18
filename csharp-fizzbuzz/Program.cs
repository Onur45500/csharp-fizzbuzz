
namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number, we will check until this number if the current number is divisible by 3 and 5 :");
            string stringNumber = Console.ReadLine();

            int intNumber = Convert.ToInt32(stringNumber);
            for(int i = 1; i <= intNumber; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("{0} : Fizz", i);
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("{0} : Buzz", i);
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("{0} : FizzBuzz", i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
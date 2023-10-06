using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entar the least number: ");            //امیرمحمد طاهری
            int start = Convert.ToInt32(Console.ReadLine());      //برنامه سازی پیشرفته 2 استاد حافظی

            Console.Write("Enter the last number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The Palindrome numbers from{start} to {end} are:");

            for (int number = start; number <= end; number++)
            {
                bool isPalindrome = IsPalindrome(number);

                if (isPalindrome)
                    Console.WriteLine(number);
            }

            Console.ReadLine();
        }

        static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number = number / 10;
            }

            return originalNumber == reversedNumber;
        }
    }
}

// Задача 19:
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да











// using System;
// public class ReverseExample
// {
//     public static void Main(string[] args)
//     {
//         int n, reverse = 0, rem;
//         Console.Write("Enter a number: ");
//         n = int.Parse(Console.ReadLine());
//         while (n != 0)
//         {
//             rem = n % 10;
//             reverse = reverse * 10 + rem;
//             n /= 10;
//             if (n == reverse)
//         {
//             Console.Write("palindrom!");
//         }
//         }


//         Console.Write("Reversed Number: " + reverse);
//     }
// }




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, temp, remainder, reverse = 0;
            Console.Write("Enter an integer ");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }
            if (temp == reverse)
            {
                Console.WriteLine($"{temp} is a palindrome");
            }
            Console.WriteLine("Given number is = {0}", temp);
            Console.WriteLine("Its reverse is = {0}", reverse);
        }
    }
}
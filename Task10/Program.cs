// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и
// 2. на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Method(int arg0)
{
    int result = (arg0 % 100) / 10;
    return result;
}


Console.WriteLine("Input a three-digit number: ");
int usrNmbr = Convert.ToInt32(Console.ReadLine());

if (usrNmbr <= 999)
{
    int secondDigit = Method(usrNmbr);
    Console.WriteLine($"{usrNmbr} -> {secondDigit}");
}
else
{
    Console.WriteLine("Incorrect number!");
}


// if (usrNmbr <= 999)
// {
//     int secondDigit = (usrNmbr % 100) / 10;
//     Console.WriteLine($" {usrNmbr} -> {secondDigit}");
// }
// else
// {
//     Console.WriteLine("Incorrect number!");
// }







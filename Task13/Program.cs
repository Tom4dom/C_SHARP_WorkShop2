// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



Console.Write("Input a number:  "); 
int numberA = Convert.ToInt32(Console.ReadLine()); 
 
void ThirdDigit(int num) 
{ 
    int counter = 1; 
    int result = num / 10; 
    while (counter < result) 
    { 
        if (result < 10) 
        { 
            Console.WriteLine("there is no third digit"); 
        } 
        else if (10 * counter <= result & result < 100 * counter) 
        { 
            Console.WriteLine($"third digit - {num / counter % 10}"); 
        } 
        counter *= 10; 
    } 
}  
ThirdDigit(numberA);

















// if (usrNmbr <= 999)
// {
//     int secondDigit = Method(usrNmbr);
//     Console.WriteLine($"{usrNmbr} -> {secondDigit}");
// }
// else
// {
//     Console.WriteLine("Incorrect number!");
// }








// int Method(int arg0)
// {
//     int result = (arg0 % 100) / 10;
//     return result;
// }




// Console.WriteLine("Input a number: ");
// int usrNmbr = Convert.ToInt32(Console.ReadLine());

// if (usrNmbr < 100)
// {
//     Console.WriteLine($"{usrNmbr} -> there is no third digit");
// }
// else
// {
//     while (usrNmbr > 999)
//     {
//         usrNmbr / 10;
//     } 
//     int thirdDigit = usrNmbr % 10;
// }

// Console.WriteLine($"{thirdDigit}");











// while (n>0) {n=n/10; index++}
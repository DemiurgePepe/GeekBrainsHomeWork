// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int userInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int SecondDigit(int argument)
// {
//     int digit = (argument/10%10);
//     return digit;
// }
// int digit= userInput("Input a three-digit number: ");
// if (digit<99||digit>999) Console.WriteLine("Invalid number, it's not a three-digit");
// else Console.WriteLine($"{SecondDigit(digit)}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int userInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int thirdDigit(int argument)
// {
//     while(argument>999)
//     {
//         argument/=10;
//     }
//     int digit = (argument%100%10);
//     return digit;
// }
// int digit= userInput("Input a three-digit number: ");
// if (digit<99) Console.WriteLine("Invalid number, it's not have a three-digit");
// else Console.WriteLine($"{thirdDigit(digit)}");
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// int userInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// bool WeekEnd(int weekDay)
// {
//     if(weekDay == 6|| weekDay==7) return true;
//     else return false;
// }
// int number = userInput("Input number of week: ");
// if(WeekEnd(number)==true) Console.WriteLine("It's Weekend!!!");
// else Console.WriteLine("It's time to work!!!");

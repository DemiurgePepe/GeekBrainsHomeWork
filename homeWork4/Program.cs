// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
// int Exponentiation(int digit, int degree)
// {
//     int result=digit;
//     for(int i = 1; i<degree;i++)
//     {
//         result = digit*result;
//     }
//     return result;
// }

// int UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int digit = UserInput("Input digit: ");
// int degree = UserInput("Input degree: ");

// Console.WriteLine($"{digit} ^ {degree} = {Exponentiation(digit,degree)}");







// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
// int UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int SumDigitInNumber(int number)
// {
//     int result =0;
//     while(number>0)
//     {
//         result+=number%10;
//         number = number/10;
//     }
//     return result;
// }
// int number = UserInput("Введите число, сумму натуральных чисел которого вы хотите знать: ");
// Console.WriteLine(SumDigitInNumber(number));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
// int UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int size = UserInput("Input size of number: ");
// int minValue = UserInput("Input min value of number: ");
// int maxVAlue = UserInput("Input max value of number: ");

// int[] myArray = CreateRandomArray(size, minValue, maxVAlue);

// PrintArray(myArray);
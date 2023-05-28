// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
// int UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// int[] NumbersScore(int size)
// {
//     int[] arrayNumber= new int[size];
//     int score=0;
//      for (int i = 0; i < size; i++)
//     {
//         arrayNumber[i] = UserInput("Введите числа: ");
//         if (arrayNumber[i]>0)
//         {
//             score++;
//         }
//     }
//     System.Console.WriteLine($"Из {size} положительных: {score}");
//     return arrayNumber;
// }
// int size = UserInput("Введите количество чисел M: ");
// int[] array = NumbersScore(size);
// PrintArray(array);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1
// void FindPoint(double k1, double b1, double k2, double b2)
// {
//     double x =(b2-b1)/(k1-k2);
//     double y =k1*((b2-b1)/(k1-k2))+b1;
//     if (k1==k2&&b1==b2) System.Console.WriteLine("Прямые совпадают");
//     else if(k1==k2) System.Console.WriteLine("Прямые парралельны");
//     else Console.WriteLine($"Прямые пересекаются в точке: {x},{y}");
// }
// double k1= UserInput("Введите k1: ");
// double b1= UserInput("Введите b1: ");
// double k2= UserInput("Введите k2: ");
// double b2= UserInput("Введите b2: ");

// FindPoint(k1,b1,k2,b2);







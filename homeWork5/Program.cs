// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// / Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

// int UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// void CheckEvenOrOdd(int[] array)
// {
//     int count =0;
//     int oddCount=0;
//     for(int i=0; i<array.Length; i++)
//     {
//         if(array[i]%2==0) count++;
//         else oddCount++;
//     }
//     Console.WriteLine($"{count} чётных чисел в массиве.");
//     Console.WriteLine($"{oddCount} нечётных чисел в массиве.");
// }

// int size = UserInput("Введите количество элементов: ");
// int minValue= UserInput("Введите минимальное трехзначное значение: ");
// int maxValue= UserInput("Введите максимальное трехзначное значение: ");

// int [] newArray = CreateRandomArray(size, minValue,maxValue);
// PrintArray(newArray);
// CheckEvenOrOdd(newArray);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76 new Random.NextDouble();

// double[] CreateRandomArrayDouble(int size, double minValue, double maxValue)
// {
//     double[] newArray = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().NextDouble()*(maxValue-minValue)+minValue;
//     }
//     return newArray;
// }

// void PrintArrayDouble(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// void DifferenceNumbers(double[] array)
// {
//     double maxValue = array[0];
//     double minValue = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]>maxValue) maxValue = array[i];
//         if(array[i]<minValue) minValue= array[i];
//     }
//     Console.WriteLine($"Разница максимального и минимального значения массива:{maxValue-minValue}");
// }
// int size = UserInput("Введите количество элементов: ");
// double minValue= UserInput("Введите минимальное значение: ");
// double maxValue= UserInput("Введите максимальное значение: ");
// double [] newArray = CreateRandomArrayDouble(size, minValue,maxValue);
// PrintArrayDouble(newArray);
// DifferenceNumbers(newArray);



// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }
// int size = UserInput("Введите количество элементов: ");
// int minValue= UserInput("Введите минимальное значение: ");
// int maxValue= UserInput("Введите максимальное значение: ");
// int [] newArray = CreateRandomArrayDouble(size, minValue,maxValue);

// PrintArray(newArray);
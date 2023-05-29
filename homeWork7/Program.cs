int UserInput(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int [,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int [,] array = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    }
}
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double [,] Create2DDoubleRandomArray(int rows, int columns,double minValue,double maxValue)
// {
//     double [,] array = new double[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i,j] = new Random().NextDouble()*(maxValue-minValue)+minValue;
//         }
//     }
//     return array;
// }
// void Print2DDoubleArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         System.Console.WriteLine();
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//     }
// }

// int rows = UserInput("Введите строки: ");
// int columns = UserInput("Введите столбцы: ");
// double minValue = UserInput("Введите минимальное значение: ");
// double maxValue = UserInput("Введите максимальное значение: ");
// double[,] myArray = Create2DDoubleRandomArray(rows,columns,minValue,maxValue);
// Print2DDoubleArray(myArray);






// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// void SearchNumber(int [,] array, int rows, int columns)
// {
//     if(rows<array.GetLength(0)&& columns<array.GetLength(1)) System.Console.WriteLine($"По позициям: {rows} , {columns} находится число {array[rows,columns]} ");
//     else System.Console.WriteLine($"По позициям: {rows} {columns} ничего не найдено, неверно введены позиции");
// }



int rows = UserInput("Введите количество строк: ");
int columns = UserInput("Введите количество столбцов: ");
int minValue = UserInput("Введите минимальное значение: ");
int maxValue = UserInput("Введите максимальное значение: ");
int[,] myArray = Create2DRandomArray(rows,columns,minValue,maxValue);
// int positionRows= UserInput("Введите строку: ");
// int posititonColumns = UserInput("Введите столбец: ");
Print2DArray(myArray);
// SearchNumber(myArray,positionRows,posititonColumns);
// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// void ArithmeticMeanColumn(int[,]array)
// {
//     int numColumns=0;
//     double count =0;
//     double mean =0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             count+=array[j,i];
            
//         }
//         numColumns++;
//         mean = count/(array.GetLength(1));
//         System.Console.Write($"Среднее арифметическое столбца{numColumns}: {mean} ");
//         System.Console.WriteLine();
//         count =0;
//         mean=0;
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();
// ArithmeticMeanColumn(myArray);




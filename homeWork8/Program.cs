int UserInput(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

// int [,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int [,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i,j] = new Random().Next(minValue,maxValue);
//         }
//     }
//     return array;
// }

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
    System.Console.WriteLine();
}   




// Знакомство с языками программирования (семинары)
// Урок 8. Двумерные массивы. Продолжение
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// int[,] Sort2DArray(int[,] array)
// {
//     int temp;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1)-1; k++)
//             {
//             if(array[i,k]<array[i,k+1])
//             {
//                 temp= array[i,k+1];
//                 array[i,k+1]=array[i,k];
//                 array[i,k]=temp;
//             }
//             }
//         }
//     }
//     return array;
// }
// int rows = UserInput("Введите строки: ");
// int columns = UserInput("Введите столбцы: ");
// int minValue = UserInput("Введите минимальное значение: ");
// int maxValue = UserInput("Введите максимальное значение: ");
// int[,] myArray = Create2DRandomArray(rows,columns,minValue,maxValue);
// Print2DArray(myArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// int [,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int [,] array = new int[rows,columns];
//     if(rows!=columns)
//     {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i,j] = new Random().Next(minValue,maxValue);
//         }
//     }
//     }
//     return array;
// }
// int SearchMinSumRows(int[,] array)
// {
//     int min=10000;
//     int sum=0;
//     int rows = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum+= array[i,j];
//         }
//         System.Console.WriteLine();
//         System.Console.Write(sum+" ");

//         if(sum<min)
//         {
//             rows=i+1;
//             min=sum;
//         }
//         sum=0;
//     }    
//     return rows;
// }
// int rows = UserInput("Введите строки: ");
// int columns = UserInput("Введите столбцы: ");
// int minValue = UserInput("Введите минимальное значение: ");
// int maxValue = UserInput("Введите максимальное значение: ");
// int[,] myArray = Create2DRandomArray(rows,columns,minValue,maxValue);
// Print2DArray(myArray);
// int minSumRows= SearchMinSumRows(myArray);
// System.Console.WriteLine();
// System.Console.WriteLine();
// System.Console.WriteLine($"Наименьшая сумма значений в строке: {minSumRows}");


// // Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// int [,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
// {
//     int [,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i,j] = new Random().Next(minValue,maxValue);
//         }
//     }
//     return array;
// }

// int [,] ProductOfMatrix(int[,] firstMatrix, int[,] secondMatrix)
// {   
//     var thirdMatrix= new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
//     if (firstMatrix.GetLength(1)==secondMatrix.GetLength(0))    
//     {
//         for (int i = 0; i < thirdMatrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < thirdMatrix.GetLength(1); j++)
//             {
//                 thirdMatrix[i, j] = 0;
//                 for (int k = 0; k < firstMatrix.GetLength(1); k++)
//                 {
//                     thirdMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
//                 }
//             }
//         }
//     }
//     System.Console.WriteLine();
//     return thirdMatrix;
// }

// int rows = UserInput("Введите строки: ");
// int columns = UserInput("Введите столбцы: ");
// int minValue = UserInput("Введите минимальное значение: ");
// int maxValue = UserInput("Введите максимальное значение: ");
// int[,] firstMatrix = CreateRandomMatrix(rows,columns,minValue,maxValue);
// int[,] secondMatrix = CreateRandomMatrix(rows,columns,minValue,maxValue);
// Print2DArray(firstMatrix);
// Print2DArray(secondMatrix);
// int[,] productMatrix= ProductOfMatrix(firstMatrix,secondMatrix);
// Print2DArray(productMatrix);

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// int GetUniqueValue(int[,,] array, int min, int max, int i, int j, int k) 
// {
//     int value = default;
//     bool exist = true;
//     while (exist)
//     {
//         bool _break = false;
//         value = new Random().Next(min, max + 1);
//         for (int i1 = 0; i1 < array.GetLength(0); i1++)
//         {
//             if (_break) { break; }
//             for (int j1 = 0; j1 < array.GetLength(1); j1++)
//             {
//                 if (_break) { break; }
//                 for (int k1 = 0; k1 < array.GetLength(2); k1++)
//                 {
//                     if (array[i1, j1, k1] == value) { _break = true; break; }
//                     if (i1 == i && j1 == j && k1 == k) { exist = false; }
//                 }
//             }
//         }
//     }
//     return value;
// }
// Эту часть честно своровал с интернета
// int [,,] CreateRandom3DArray(int x, int y, int z, int minValue, int maxValue)
// {
//     int [,,] array = new int[x,y,z];
//     for (int i = 0; i < x; i++)
//     {
//         for (int j = 0; j < y; j++)
//         {
//             for (int k = 0; k < z; k++)
//             {
//                 if(minValue<100 && minValue>9 && maxValue<100 && maxValue>9)
//                 {
//                     array[i,j,k] = GetUniqueValue(array, minValue, maxValue, i, j, k);
//                 }
//             } 
//         }
//     }
//     return array;
// }
// void Print3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         System.Console.WriteLine();
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k})|");
//             } 
//             System.Console.WriteLine();
//         }
//     }
//     System.Console.WriteLine();
// }   

// int x = UserInput("Введите x: ");
// int y = UserInput("Введите y: ");
// int z = UserInput("Введите z: ");
// int minValue = UserInput("Введите минимальное значение: ");
// int maxValue = UserInput("Введите максимальное значение: ");
// int[,,] myArray= CreateRandom3DArray(x,y,z,minValue,maxValue);
// Print3DArray(myArray);



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int [,] Create2DRandomArray(int rows, int columns)
// {
//     int [,] array = new int[rows,columns];
//     int temp=0;
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             if(i==0)
//             {
//                 for (int n = 0; n < array.GetLength(1); n++)
//                 {
//                     for (int e = 1; e < 5; e++)
//                     {
//                         array[i,n]=e;
//                     }
//                 }
                
//             }
//             if(j==4)
//             {
//                 for (int z = 1; z < array.GetLength(0); z++)
//                 {
//                     for (int x = 1; x < array.GetLength(1); x++)
//                     {
//                         temp=5;
//                         array[z,x]=temp++;
//                     } 
//                 }
               
//             }
//             if(i==3)
//             {
//                 for (int h = 0; h < array.GetLength(1); h++)
//                 {
//                     temp=10;
//                     array[i,h]=temp--;
//                 } 
//             } 
            
//             if (i==1)
//             {
//                 for (int o = 1; o < array.GetLength(0); o++)
//                 {
//                     for (int v = 0; v < array.GetLength(1)-2; v++)
//                     {
//                         temp= 12;
//                         array[o,v]=temp++;
//                     }
//                 }
                
//             }
            
//             if (i==2)
//             {
//                 for (int p = 1; p < array.GetLength(0); p++)
//                 {
//                     for (int t = 0; t < array.GetLength(1)-2; t++)
//                     {
//                         temp=16;
//                         array[p,t]=temp--;
//                     }
//                 }
                
//             }
            
//         } 
        
//     }
//     return array;
// }
   


int rows = UserInput("Введите строки: ");
int columns = UserInput("Введите столбцы: ");
int[,] myArray = Create2DRandomArray(rows,columns);
Print2DArray(myArray);
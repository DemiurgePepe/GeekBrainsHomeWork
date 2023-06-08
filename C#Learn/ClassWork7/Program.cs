//Задача 4. задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагона
// задайте 2мерный массив размером mxn

// int SumElementsMainDiagonal(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i==j) sum+=array[i,j];
//         }
//     }
//     System.Console.WriteLine();
//     return sum;
// }

// int UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

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

// void Print2DArray(int[,] array)
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


// /Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


// int [,] QuadandomArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
            
//             if(i%2==0&& j%2==0) array[i,j]=array[i,j]*array[i,j];
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
// int[,] newArray= QuadandomArray(myArray);
// System.Console.WriteLine();
// Print2DArray(newArray);







//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.




// int [,] Create2DSumRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int [,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i,j]= i+j;
//         }
//     }
//     return array;
// }
// int rows = UserInput("Введите строки: ");
// int columns = UserInput("Введите столбцы: ");
// int minValue = UserInput("Введите минимальное значение: ");
// int maxValue = UserInput("Введите максимальное значение: ");
// int[,] myArray = Create2DSumRandomArray(rows,columns,minValue,maxValue);
// Print2DArray(myArray);



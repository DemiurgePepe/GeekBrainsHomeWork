// /Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
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
            Console.Write(array[i,j]+"\t");
        }
    }
}   


// int[,] RowsTwoColumns(int[,] array)

// {
//     if(array.GetLength(0)!= array.GetLength(1))
//     {
//         System.Console.WriteLine("Invalid number!!!");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = i+1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i,j];
//                 array[i,j]=array[j,i];
//                 array[j,i]=temp;
//             }
//         }
//         return array;
//     }
//     System.Console.WriteLine();
// }





//Задание 3. Из двумерного массива целых чисел занулить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть занулить и строку и столбец в которой находится этот элемент

// int[,] DellRowsColumnsForMin(int[,] array)
// {
//     int min=array[0,0];
//     int mr=0;
//     int mc=0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(array[i,j]<min)
//             {
//                 min=array[i,j];
//                 mr=i;
//                 mc=j;
//             }
//         }
//     }
//     for (int z = 0; z < array.GetLength(0); z++)
//     {
//         array[z,mc]=0;
//     }
//     for (int d = 0; d < array.GetLength(1); d++)
//     {
//         array[mr,d]=0;
//     }
//     return array;
// }

//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

 int[,] LastToFirst(int[,] array, int firstString, int secondString)
{
    int count;
    if(firstString<0||secondString>array.GetLength(0))
    {
        System.Console.WriteLine("Invalid number!!!");
        return array;
    }
    else
    {
    for (int i = 0; i < array.GetLength(1); i++)
    {
        count=array[firstString,i];
        array[firstString,i]=array[secondString,i];
        array[secondString,i]=count;
    }
    return array;
    }
}
int rows = UserInput("Введите строки: ");
int columns = UserInput("Введите столбцы: ");
int minValue = UserInput("Введите минимальное значение: ");
int maxValue = UserInput("Введите максимальное значение: ");
int[,] myArray = Create2DRandomArray(rows,columns,minValue,maxValue);
int firstString= UserInput("Введите какие строку вы хотите поменять: ");
int secondString= UserInput("Введите какие строку вы хотите поменять: ");
Print2DArray(myArray);
myArray=LastToFirst(myArray,firstString,secondString);
System.Console.WriteLine();
Print2DArray(myArray);





void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int UserInput(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}



// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.


// void PosNegSum(int[] array)
// {
//     int sumPos= 0;
//     int sumNeg = 0;
//     for(int i = 0; i<array.Length; i++)
//     {
//         if( array[i]>=0) sumPos+=array[i];
//         else sumNeg+= array[i];
//     }
//     Console.WriteLine($"Summ pos elements =>{sumPos}; Summ neg elements =>{sumNeg}");
// }


// int[] NegPosReverse(int[] array)
// {
//     for(int i = 0; i< array.Length; i++)
//     {
//         if(array[i]>0) array[i]*=-1;
//         else array[i]*=-1;
//     }
//     return array;
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
// int size = UserInput("Введите количество элементов: ");
// int minValue= UserInput("Введите минимальное значение");
// int maxValue= UserInput("Введите максимальное значение");


// int [] newArray = CreateRandomArray(size, minValue,maxValue);

// PrintArray(newArray);

// int [] newArray2 = NegPosReverse(newArray);
// PrintArray(newArray2);
//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]\






//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
int[] CreateNewArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент массива{i+1}");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
// void CheckNumber(int number, int[] array)
// {
//     for(int i = 0; i<array.Length; i++ )
//     {
//         if(array[i]== number) Console.WriteLine($"Yes {i}");
//     }
// }

// int size = UserInput("Введите размер");
// int [] newArray = CreateNewArray(size);
// PrintArray(newArray);
// int number = UserInput("Введите номер который надо найти в массиве");

// CheckNumber(number, newArray);


//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void SearchNumbers(int min, int max,  int[] array)
{
    int count = 0;
    for(int i = 0; i< array.Length; i++)
    {
        if(array[i]>=min && array[i]<= max) count++;
    }
    Console.WriteLine(count);
}
int size = UserInput("Введите количество элементов: ");
int minValue= UserInput("Введите минимальное значение: ");
int maxValue= UserInput("Введите максимальное значение: ");


int [] newArray = CreateRandomArray(size, minValue,maxValue);

int min = UserInput("Введите минимальный порог поиска: ");
int max = UserInput("Введите максимальный порог поиска: ");
PrintArray(newArray);
SearchNumbers(min,max,newArray);


// int size = UserInput("Введите количество элементов: ");
// int minValue= UserInput("Введите минимальное значение");
// int maxValue= UserInput("Введите максимальное значение");

// int [] newArray = CreateRandomArray(size, minValue,maxValue);

// PrintArray(newArray);
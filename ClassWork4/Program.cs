//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// int UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int CountNumber(int number)
// {
//     int i;
//     for(i=0;number>0;i++)
//     {
//         number/=10;
//     }
//     return i;
// }
// int number=UserInput("Введите число: ");
// int digit= CountNumber(number);
// Console.WriteLine(digit);

//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Input array size ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value of element");
int maxVAlue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxVAlue);

PrintArray(myArray);


//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120

// int Factorial(int N)
// {
//     int result=1;
//     for(int i=1; i<=N; i++)
//     {
//         result = result*i;
//     }
//     return result;
// }
// int N = 4;
// Console.WriteLine(Factorial(N));


//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int SumN(int N)
// {
//     int result=0;
//     for(int i=0; i<=N; i++)
//     {
//         result = result+i;
//     }
//     return result;
// }
// int N = 2;
// Console.WriteLine(Factorial(N));








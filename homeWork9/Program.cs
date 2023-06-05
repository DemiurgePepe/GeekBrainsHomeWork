
int UserInput(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// void SumNumbers(int n)
// {
//     if(n>0) 
//     {
//         Console.Write(n+" ");
//         SumNumbers(n-1);
//     }
// }
// int N = 5;
// SumNumbers(5);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void FindNumber(int m, int n)
{
    if(m<n) 
    {
        Console.Write(m+" ");
        FindNumber(m+1,n)+m;
    }
    else if (m>n)
    {
        System.Console.Write(m+" ");
        FindNumber(m-1,n);
    }
    else System.Console.WriteLine(m);
}
int m = UserInput("Введите m: ");
int n = UserInput("Введите n: ");
FindNumber(m,n);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29




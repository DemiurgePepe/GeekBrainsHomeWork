
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

// int FindNumber(int m, int n)
// {
//     int sum=1;
//     if(m<n) 
//     {
//         // Console.Write(m+" ");
//         sum+=FindNumber(m+1,n)+m;
//         return sum;
//     }
//     else if (m>n)
//     {
//         // System.Console.Write(m+" ");
//         sum+=FindNumber(m-1,n)+m;
//         return sum;
        
//     }
//     else return sum;
// }
// int m = UserInput("Введите m: ");
// int n = UserInput("Введите n: ");
// int check =FindNumber(m,n);
// System.Console.WriteLine(check);
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// int AkkermanFunction(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return AkkermanFunction(m - 1, 1);
//     else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
// }
// int m = UserInput("Введите m: ");
// int n = UserInput("Введите n: ");
// int akk= AkkermanFunction(m,n);
// System.Console.WriteLine(akk);






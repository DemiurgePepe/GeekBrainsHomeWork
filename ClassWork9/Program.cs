int UserInput(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"
// void SumNumbers(int n)
// {
//     if(n>0) 
//     {
//         SumNumbers(n-1);
//         Console.Write(n+" ");
//     }
// }
// int N = 5;
// SumNumbers(5);


//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

//453 -> 12
//45 -> 9


// int FindSum(int number)
// {
//     if(number>0)
//     {
//         return FindSum(number/10)+number % 10;
//     }
//     else return number;
// }
// int sum=FindSum(6392);
// System.Console.WriteLine(sum);


//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"
// void FindNumber(int m, int n)
// {
//     if(m<n) 
//     {
//         Console.Write(m+" ");
//         FindNumber(m+1,n);
//     }
//     else if (m>n)
//     {
//         System.Console.Write(m+" ");
//         FindNumber(m-1,n);
//     }
//     else System.Console.WriteLine(m);
// }
// int m = UserInput("Введите m: ");
// int n = UserInput("Введите n: ");
// FindNumber(m,n);

//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// int AStapeB(int a, int b)
// {
//     if(b>0)
//     {
//         return AStapeB(a,b-1)*a;
//     }
//     else return 1;
// }

// int a = UserInput("Введите a: ");
// int b = UserInput("Введите b: ");
// int number = AStapeB(a,b);
// System.Console.WriteLine(number);


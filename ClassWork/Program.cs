// // task1. Запросить число и вывести его квадрат
// Console.Write("input number for take a quad:");
// int num=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"quad = {(num*num)}");


// // task2. Является ли первое число квадратом второго

// Console.Write("input number A for check quad:");
// int a=int.Parse(Console.ReadLine());
// Console.Write("input number B for take a quad:");
// int b=int.Parse(Console.ReadLine());
// if(a==b*b)
// {
// Console.Write($"{a} quad {b}");
// }
// else
// {
//     Console.Write($"{a} not quad {b}");
// }

// Task3. Напишите программу которая принимает на вход число N а на выходе мы получаем строчку от -N до N
// Console.Write("input number N:");
// int N=int.Parse(Console.ReadLine());
// if (N<=0) Console.WriteLine("not correct number");
// int count=N*(-1);
// while(count<=N)
// {
//     Console.Write(count+" ");
//     count++;
// }

// task3.  на вход принимаем 3х значное число
// вывести последнюю цифру числа
Console.Write("input three-digit number N:");
int N=int.Parse(Console.ReadLine());
// if (N>999) Console.WriteLine("invalid number");
Console.WriteLine(N%8);

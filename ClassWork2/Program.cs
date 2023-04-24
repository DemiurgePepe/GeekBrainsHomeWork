// int MaxDigit(int numR)
// {
//     int dec = numR /10; 
//     int ed = numR % 10;
//     if(dec>ed) return dec;
//     else return ed;
// }
// int num = new Random().Next(10,99+1);
// Console.WriteLine($"{num}-> {MaxDigit(num)}");
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

// bool multiplicity(int num1, int num2)
// {
//     if(num1%num2 == 0) return true;
//     else return false;
// }
// Console.WriteLine("Input num1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input num2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num1}, {num2} -> {multiplicity(num1,2)}, ost {num1%num2}");


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// bool multiplicity(int num1)
// {
//     if (num1 % 7 == 0 && num1 % 23 == 0) return true;
//     else return false;
// }
// Console.WriteLine("Input num1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{multiplicity(num1)}");

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// bool quad(int num1, int num2)
// {
//     if (num1 / num2 == num2 || num2 / num1 == num1) return true;
//     else return false;
// }
// Console.WriteLine("Input num1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input num2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{quad(num1, num2)}");


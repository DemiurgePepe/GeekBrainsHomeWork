// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


// 14212 -> нет

// 12821 -> да

// 23432 -> да


// int UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }


// bool PolindrCheck(int number)
// {
//     if(number%10==number/10000 && number%100/10==number/1000%10) return true;
//     else return false;
// }
// int x = UserInput("input 5-digit number: ");
// Console.WriteLine($"it's {PolindrCheck(x)}");




// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     double result = Convert.ToDouble(value);
//     return result;
// }
// double FindDistance(double x, double y, double z)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)),3);
// }
// double x= UserInput("Введите x");
// double y= UserInput("Введите y");
// double z= UserInput("Введите z");
// double result = FindDistance(x,y,z);
// Console.WriteLine($"{result}");



// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

//  void CubeN(int N)
// {
//     int count=1;
//     while(count<=N)
//     {
//         Console.WriteLine($"{count}->{count*count*count} ");
//         count++;
//     }
// }
// int N = UserInput("Input N to get a table of cubes: ");
// CubeN(N);
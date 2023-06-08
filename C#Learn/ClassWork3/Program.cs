//Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// int userInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int FindQuart(int x, int y)
// {
//     if(x>0&&y>0)    return 1;
//     if(x<0&&y>0) return 2;
//     if(x<0&&y<0) return 3;
//     if(x>0&&y<0) return 4;
//     return 0;
// }
// int x = userInput("Введите х:");
// int y = userInput("Введите y:");
// int result =FindQuart(x,y);
// Console.WriteLine($"{result}");
// Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double FindDistance(double xa, double ya, double xb, double yb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)),3);
// }
// double xa= userInput("Введите xa");
// double xb= userInput("Введите xb");
// double ya= userInput("Введите ya");
// double yb= userInput("Введите yb");
// double result = FindDistance(xa,ya,xb,yb);
// Console.WriteLine($"{result}");

//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void FindQuart(int x)
// {
//     if(x==1) Console.WriteLine("x>0&&y>0");
//     if(x==2) Console.WriteLine("x<0&&y>0");
//     if(x==3) Console.WriteLine("x<0&&y<0");
//     if(x==4) Console.WriteLine("x>0&&y<0");
//     else Console.WriteLine("invalid number");
// }

// int x = userInput("Введите х:");
// FindQuart(x);


//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

// void QuadN(int N)
// {
//     int count=1;
//     while(count<=N)
//     {
//         Console.Write($"{count}->{count*count} ");
//         count++;
//     }
// }
// int N = userInput("Input N: ");
// QuadN(N);



















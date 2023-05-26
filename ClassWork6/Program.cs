int UserInput(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}
// int size = UserInput("Введите количество элементов: ");
// int minValue= UserInput("Введите минимальное значение");
// int maxValue= UserInput("Введите максимальное значение");


// Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон

// bool Trikvetr(int a, int b, int c)
// {
//     if(a<b+c && b<c+a && c<a+b) return true;
//     else return false;
// }

// int a = UserInput("Введите a: ");
// int b= UserInput("Введите b: ");
// int c= UserInput("Введите c: ");

// System.Console.WriteLine(Trikvetr(a,b,c));

// Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]

// int fib=0;
// int[] Fibonachi(int size, int first, int second)
// {
//     int[] array =new int[size];
//     array[0]= first;
//     array[1]= second;
//     for (int i = 2; i < size; i++)
//     {
//         array[i]= array[i-1]+array[i-2]; 
//         fib++;
//     }
//     returnAQQAQA!!!!QAQAAAAAAAA!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!QAQAAA1onsole.WriteLine(fib);



//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// int [] ReplaceArray(int [] array)
// {
//     int replace= 0;
//     for (int i = 0; i < array.Length-1-i; i++)
//     {
//         replace= array[i];
//         array[i]= array[array.Length-i-1];
//         array[array.Length-i-1]= replace;
//     }
//     return array;
// }
// int size = UserInput("Введите количество элементов: ");
// int minValue= UserInput("Введите минимальное значение: ");
// int maxValue= UserInput("Введите максимальное значение: ");
// int [] array = CreateRandomArray(size, minValue,maxValue);
// PrintArray(array);
// int[] newArray = ReplaceArray(array);
// PrintArray(newArray);

// int [] ReplaceArray(int [] array)
// {
//     int replace= 0;
//     for (int i = 0; i < array.Length-1-i; i++)
//     {
//         replace= array[i];
//         array[i]= array[array.Length-i-1];
//         array[array.Length-i-1]= replace;
//     }
//     return array;
// }
// int size = UserInput("Введите количество элементов: ");
// int minValue= UserInput("Введите минимальное значение: ");
// int maxValue= UserInput("Введите максимальное значение: ");
// int [] array = CreateRandomArray(size, minValue,maxValue);
// PrintArray(array);
// int[] newArray = ReplaceArray(array);
// PrintArray(newArray);


// Из римских в арабские





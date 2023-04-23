int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    
    return result;
}

int[] array= {11,123,15,61,21,12,17,19,20};
int max= Max
(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);

// Вариации массивов

// int[] Array0={};
// int[] array1= new int[5];
// int[] array2= new int[]{0,0,0,0};
// int[] array3= new int[5]{0,0,0,0,};
// Console.WriteLine(array2);

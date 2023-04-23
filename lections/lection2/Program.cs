// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2>result) result = arg2;
//     if (arg3>result) result = arg3;
    
//     return result;
// }

// int[] array= {11,123,15,61,21,12,17,19,20};
// int max= Max
// (
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );
// Console.WriteLine(max);

// Вариации массивов

// int[] Array0={};
// int[] array1= new int[5];
// int[] array2= new int[]{0,0,0,0};
// int[] array3= new int[5]{0,0,0,0,};
// Console.WriteLine(array2);
// int[] array = {1,2,5,5,1,4};
// int n = array.Length;
// int find = 5;
// int index = 0;
// while(index<n)
// {
//     if (array[index]==find)
//     {
//         Console.WriteLine(index);
//     }
//     index++;
// }
// void FillArray(int[] collection)
// {
//     int length= collection.Length;
//     int index = 0;
//     while(index<length)
//     {
//         collection[index]= new Random().Next(1,10);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count= col.Length;
//     int position= 0;
//     while(position< count)
//     {
//         Console.Write(col[position]+" ");
//         position++;
//     }
// }

// int[] array=new int[10];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// int IndexOf(int[] collection,int find)
// {
//     int count= collection.Length;
//     int index=0;
//     int position = -1;
//     while(index<count)
//     {
//         if(collection[index]==find)
//         {
//             position=index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }
// int pos = IndexOf(array,1);
// if(pos==-1)
// {
//     Console.WriteLine("invalid number");
// }
// else Console.WriteLine(pos+" ");

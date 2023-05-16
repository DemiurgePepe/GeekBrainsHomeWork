// Дан текст пробелы нужно заменить чёрточками 
// маленькие буквы к большими К 
//  маленькие с большими С


// string Text = "Шейла очень смешная старая перечница."+
//              "Это чернокоричневое нечто состоящие из ласки и ярости,"+
//              "любит покушать и хрустяшки, и влажные кусочки"+
//              "Очень мягонкая";
                 
//  string Text =   "Шейла очень смешная старая перечница.Это чернокоричневое нечто состоящие из ласки и ярости,любит покушать и хрустяшки, и влажные кусочки. Очень мягонькая";
// string Convertor(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length= text.Length;
//     for(int i=0;i<length;i++)
//     {
//         if(text[i]==oldValue) result= result +$"{newValue}";
//         else result= result + $"{text[i]}";
//     }
//     return result;
// }
    
// string newText= Convertor(Text,' ','|');
// newText=Convertor(newText,'с','С');
// newText=Convertor(newText,'к','К');
// newText=Convertor(newText,'о','О');
// Console.WriteLine(newText);
int[] array= {1,6,8,2,5,62,76,23};
void PrintArray(int[] array)
{
    int count= array.Length;
    for(int i =0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
     Console.WriteLine();
}
PrintArray(array);

void SortArrayMin(int[] array)
{
    for(int count=0;count<array.Length-1;count++)
    {
        int minPosition=count;
        for(int j =count+1; j<array.Length;j++)
        {
            if(array[j]<array[minPosition]) minPosition = j;

        }
        int temporary = array[count];
        array[count]= array[minPosition];
        array[minPosition]=temporary;
    }
}
void SortArrayMax(int[] array)
{
    for(int i=0;i<array.Length-1;i++)
    {
        int maxPosition=array.Length-1;
        for(int j =i+1; j<array.Length;j++)
        {
            if(array[j]>array[maxPosition]) maxPosition = j;

        }
        int temporary = array[i];
        array[i]= array[maxPosition];
        array[maxPosition]=temporary;
    }
}
SortArrayMax(array);
PrintArray(array);
SortArrayMin(array);
PrintArray(array);




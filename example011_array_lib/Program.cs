﻿void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while ( index < Length)
    {
        collection[index] = new Random().Next( 1, 10);
        index++;
    }
}

void PrintArray( int []coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(coll[position]);
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
       if( collection[index] == find)

       {
        position = index;
        break;
       
       }
       index++;
      
    }
    return position;

}



int[] array = new int[10];

FillArray(array);
PrintArray(array);

System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);


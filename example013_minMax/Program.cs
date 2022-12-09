
int [] arr ={ 1, 3, 4, 8, 6, 9, 2, 1, 1};

void printArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
System.Console.WriteLine();
}
printArray(arr);


void SelectionSort(int []array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j]< array[minPosition]) minPosition = j;

        }



        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
printArray(arr);
SelectionSort(arr);
printArray(arr);
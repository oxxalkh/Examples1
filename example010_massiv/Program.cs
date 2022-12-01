int[] array = {1, 23, 45, 4, 44, 4, 4, 2, 13, 8};

int n = array.Length;
int find = 4;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    // index = index +1;
    index++;
    
}

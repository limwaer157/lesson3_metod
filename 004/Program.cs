// See https://aka.ms/new-console-template for more information
int[] array = {2,5,7,6,4,3,1,9,8,2};

void PrintArray(int[] array)
{
    int count = array.Length;

for (int i = 0; i < count; i++)
{
    Console.Write($"{array[i]} ");

}
Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1 ; j < array.Length ; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(array);
SelectionSort(array);

PrintArray(array);
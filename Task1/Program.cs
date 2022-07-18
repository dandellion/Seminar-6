int[] FillArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write($"{item} ");
    }
}

int CountPositiveNumber(int[] array)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
            count++;
    }

    return count;
}


Console.WriteLine("Сколько чисел вы хотите ввести?");
int number = int.Parse(Console.ReadLine());
int[] array = FillArray(number);
PrintArray(array);
Console.WriteLine();
int result = CountPositiveNumber(array);
Console.WriteLine(result);
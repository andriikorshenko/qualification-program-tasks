int[] array = { 1, 2, 3, 4, 4, 56 };

CheckArray(ref array);

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

static void CheckArray(ref int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == array[i - 1])
        {
            RemoveADuplicateFromArray(i - 1, ref array);
        }
    }
}

static void RemoveADuplicateFromArray(int indexToDelete, ref int[] array)
{
    int[] newArray = new int[array.Length - 1];

    for (int i = 0; i < indexToDelete; i++)
    {
        newArray[i] = array[i];
    }

    for (int i = indexToDelete; i < newArray.Length; i++)
    {
        newArray[i] = array[i + 1];
    }

    array = newArray;
}

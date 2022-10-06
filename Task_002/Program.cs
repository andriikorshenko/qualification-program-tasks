int[] arr1 = { 1, 2, 3, 4, 4, 56 };

int[] arr2 = CheckArray(arr1);

for (int i = 0; i < arr2.Length; i++)
{
    Console.WriteLine(arr2[i]);
}

static int[] CheckArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == array[i - 1])
        {
            RemoveADuplicateFromArray(i - 1, ref array);
        }
    }
    return array;
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

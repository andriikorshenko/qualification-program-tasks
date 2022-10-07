// Linear version: Time-complexity is O(n), Space-complexity is O(1);
int findItem = 10;

Console.WriteLine(FiboLinear(findItem));

int FiboLinear(int number)
{
    if (number == 0)
        return 0;
    else if (number <= 2)
        return 1;

    int[] arr = { 0, 1 };
    int result = default;

    while (number-- > 2)
    {
        result = arr[0] + arr[1];
        arr[0] = arr[1];
        arr[1] = result;
    }
    return result;
}

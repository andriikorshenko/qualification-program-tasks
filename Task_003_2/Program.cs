// Recursion version: Time-complexity is O(2^n), Space-complexity is O(n);
int findItem = 10;

Console.WriteLine(FiboRecursion(findItem));

int FiboRecursion(int number)
{
    if (number == 0)
        return 0;
    else if (number <= 3)
        return 1;

    return FiboRecursion(number - 1) + FiboRecursion(number - 2);
}
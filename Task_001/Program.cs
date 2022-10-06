string text = $"The “C# Professional” course includes the topics " +
    $"I discuss in my CLR via C# book and teaches how the CLR works " +
    $"thereby showing you how to develop applications and reusable components " +
    $"for the .NET Framework.";

string[] str = text.Split(' ');

var groups = str.Distinct()
    .OrderBy(x => x.Length)
    .GroupBy(y => y.Length);

foreach (var group in groups)
{
    Console.WriteLine($"Words of length: {group.Key}, Count: {group.Count()}");

    foreach (var word in group)
    {
        Console.WriteLine(word);
    }
}

string[] array = new string[3] {"12354", "432", "as"};

string[] ArrayItemNumDegree(string[] array, int countOfDigits)
{
    return array.Where(x=> x.Length <= countOfDigits).ToArray();
}

Console.WriteLine($"[{string.Join(",",array)}]->[{string.Join(",", ArrayItemNumDegree(array, 3))}]");
Console.WriteLine($"[{string.Join(",",array)}]->[{string.Join(",", ArrayItemNumDegree(array, 2))}]");
Console.WriteLine($"[{string.Join(",",array)}]->[{string.Join(",", ArrayItemNumDegree(array, 1))}]");
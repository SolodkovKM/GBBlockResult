string[] array = new string[3] {"12354", "432", "as"};

string[] ArrayItemNumDegreeLinq(string[] array, int countOfDigits) // Вариант с использованием Linq
{
    return array.Where(x=> x.Length <= countOfDigits).ToArray();
}

string[] ArrayItemNumDegree(string[] array, int countOfDigits)
{
    int[] itemNumDegreeId = new int[array.Length];
    int countOfItems = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= countOfDigits)
        {
            itemNumDegreeId[countOfItems] = i;
            countOfItems++;
        }
    }
    string[] resultArray = new string[countOfItems];
    for(int i = 0; i < countOfItems; i++)
    {
        resultArray[i] = array[itemNumDegreeId[i]];
    }
    return resultArray;
}


Console.WriteLine($"[{string.Join(",",array)}]->[{string.Join(",", ArrayItemNumDegreeLinq(array, 3))}]");
Console.WriteLine($"[{string.Join(",",array)}]->[{string.Join(",", ArrayItemNumDegreeLinq(array, 2))}]");
Console.WriteLine($"[{string.Join(",",array)}]->[{string.Join(",", ArrayItemNumDegreeLinq(array, 1))}]");

Console.WriteLine($"[{string.Join(",",array)}]->[{string.Join(",", ArrayItemNumDegree(array, 3))}]");
Console.WriteLine($"[{string.Join(",",array)}]->[{string.Join(",", ArrayItemNumDegree(array, 2))}]");
Console.WriteLine($"[{string.Join(",",array)}]->[{string.Join(",", ArrayItemNumDegree(array, 1))}]");
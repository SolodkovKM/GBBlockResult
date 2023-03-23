string[] ArrayItemNumDegreeLinq(string[] array, int countOfDigits) // Вариант с использованием Linq
{
    return array.Where(x=> x.Length <= countOfDigits).ToArray();
}

string[] ArrayItemNumDegree(string[] array, int countOfDigits) // Вариант через дополнительный массив
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

string[] ResizeMethod(string[] array, int countOfDigits) // Вариант через изменение размера массива
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length > countOfDigits) 
        {
            string temp = array[array.Length - 1];
            array[array.Length - 1] = array[i];
            array[i] = temp;
            Array.Resize(ref array, array.Length - 1);
        }
    }
    return array;
}

string[] AppendMethod(string[] array, int countOfDigits) // Вариант через добваление эелементов в конец нового изначально пустого массива
{
    string[] result = new string[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length <= countOfDigits) result.Append(array[i]);
    return result;
}

string[] array1 = new string[4] {"hello", "2", "world", ":-)"};
string[] array2 = new string[4] {"1234", "1567", "-2", "computer science"};
string[] array3 = new string[3] {"Russia", "Denmark", "Kazan"};

Console.WriteLine($"[{string.Join(",",array1)}]->[{string.Join(",", ArrayItemNumDegreeLinq(array1, 3))}]");
Console.WriteLine($"[{string.Join(",",array2)}]->[{string.Join(",", ArrayItemNumDegreeLinq(array2, 3))}]");
Console.WriteLine($"[{string.Join(",",array3)}]->[{string.Join(",", ArrayItemNumDegreeLinq(array3, 3))}]");
Console.WriteLine();
Console.WriteLine($"[{string.Join(",",array1)}]->[{string.Join(",", ArrayItemNumDegree(array1, 3))}]");
Console.WriteLine($"[{string.Join(",",array2)}]->[{string.Join(",", ArrayItemNumDegree(array2, 3))}]");
Console.WriteLine($"[{string.Join(",",array3)}]->[{string.Join(",", ArrayItemNumDegree(array3, 3))}]");
Console.WriteLine();
Console.WriteLine($"[{string.Join(",",array1)}]->[{string.Join(",", ResizeMethod(array1, 3))}]");
Console.WriteLine($"[{string.Join(",",array2)}]->[{string.Join(",", ResizeMethod(array2, 3))}]");
Console.WriteLine($"[{string.Join(",",array3)}]->[{string.Join(",", ResizeMethod(array3, 3))}]");
Console.WriteLine();
Console.WriteLine($"[{string.Join(",",array1)}]->[{string.Join(",", AppendMethod(array1, 3))}]");
Console.WriteLine($"[{string.Join(",",array2)}]->[{string.Join(",", AppendMethod(array2, 3))}]");
Console.WriteLine($"[{string.Join(",",array3)}]->[{string.Join(",", AppendMethod(array3, 3))}]");
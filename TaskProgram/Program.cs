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

string[] array1 = new string[4] {"hello", "2", "world", ":-)"};
Console.WriteLine($"[{string.Join(",",array1)}]->[{string.Join(",", ArrayItemNumDegreeLinq(array1, 3))}]");
string[] array2 = new string[4] {"1234", "1567", "-2", "computer science"};
Console.WriteLine($"[{string.Join(",",array2)}]->[{string.Join(",", ArrayItemNumDegreeLinq(array2, 2))}]");
string[] array3 = new string[3] {"Russia", "Denmark", "Kazan"};
Console.WriteLine($"[{string.Join(",",array3)}]->[{string.Join(",", ArrayItemNumDegreeLinq(array3, 1))}]");
Console.WriteLine();

string[] array4 = new string[4] {"hello", "2", "world", ":-)"};
Console.WriteLine($"[{string.Join(",",array4)}]->[{string.Join(",", ArrayItemNumDegree(array4, 3))}]");
string[] array5 = new string[4] {"1234", "1567", "-2", "computer science"};
Console.WriteLine($"[{string.Join(",",array5)}]->[{string.Join(",", ArrayItemNumDegree(array5, 2))}]");
string[] array6 = new string[3] {"Russia", "Denmark", "Kazan"};
Console.WriteLine($"[{string.Join(",",array6)}]->[{string.Join(",", ArrayItemNumDegree(array6, 1))}]");

string[] OneCycleMethod(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length > 3) 
        {
            string temp = array[array.Length - 1];
            array[array.Length - 1] = array[i];
            array[i] = temp;
            Array.Resize(ref array, array.Length - 1);
        }
    }
    return array;
}

string[] AppendMethod(string[] array)
{
    string[] result = new string[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length <= 3) result.Append(array[i]);
    return result;
}

string[] array = new string[4] {"hello", "2", "world", ":-)"};
Console.WriteLine(string.Join(",", OneCycleMethod(array)));

string[] marray = new string[4] {"hello", "2", "world", ":-)"};
Console.WriteLine(string.Join(",", AppendMethod(marray)));
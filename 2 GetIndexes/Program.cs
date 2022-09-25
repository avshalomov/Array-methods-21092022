Console.Clear();
Console.WriteLine("==================== START ====================\n");
Console.WriteLine("2. GetIndexes\n");

// 2. GetIndexes
// Return indexes of the given data from array.
// Example: ({1,4,2,5,3,6,4,7,5,8,6,9,7,10}, 4) -> {1,6}
// Example: ({1,4,2,5,3,6,4,7,5,8,6,9,7,10}, 11) -> null

int[] Append(int[] array = null, int item = 0)
{
    if (array == null || array.Length == 0) return new int[] { item };
    else
    {
        int[] newArray = new int[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }
        newArray[array.Length] = item;
        return newArray;
    }
}

void Print(int[] array)
{
    if (array == null || array.Length == 0) Console.WriteLine("null");
    else
    {
        Console.Write("{");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1) Console.Write(",");
        }
        Console.WriteLine("}");
    }
}

int[] GetIndexes(int num, int[] array = null)
{
    int[] indexes = {};
    if (array == null || array.Length == 0) return null;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            indexes = Append(indexes, i);
        }
    }
    if (indexes == null || indexes.Length == 0) return null;
    return indexes;
}



int[] myArray = new int[] { 1, 4, 2, 5, 3, 6, 4, 7, 5, 8, 6, 9, 7, 10 };

Print(GetIndexes(4, myArray));
Print(GetIndexes(11, myArray));



Console.WriteLine("\n===================== END =====================");
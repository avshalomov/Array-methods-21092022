Console.Clear();
Console.WriteLine("==================== START ====================\n");
Console.WriteLine("3. GetItemsAbove\n");

// 3. GetItemsAbove
// Return items above the given data from array.
// Example: (4, {1,4,2,5,3,6,4,7,5,8,6,9,7,10}) -> {5,6,7,8,9,10}
// Example: (11, {1,4,2,5,3,6,4,7,5,8,6,9,7,10}) -> null

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

int[] GetItemsAbove(int num, int[] array = null)
{
    if (array == null || array.Length == 0) return null;
    int[] items = { };

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > num)
        {
            items = Append(items, array[i]);
        }
    }

    if (items == null || items.Length == 0) return null;
    return items;
}



int[] array = { 1, 4, 2, 5, 3, 6, 4, 7, 5, 8, 6, 9, 7, 10 };

Print(GetItemsAbove(4, array));
Print(GetItemsAbove(11, array));



Console.WriteLine("\n===================== END =====================");
Console.Clear();
Console.WriteLine("==================== START ====================\n");
Console.WriteLine("4. GetItemsExcept\n");

// 4. GetItemsExcept
// Return all items except the given item.
// Example: (1, {1,4,1,5,9,2}) => {4,5,9,2}
// Example: (2, {1,4,1,5,9,2}) => {1,4,1,5,9}
// Example: (4, {1,4,1,5,9,2}) => {1,1,5,9,2}
// Example: (5, {1,4,1,5,9,2}) => {1,4,1,9,2}
// Example: (9, {1,4,1,5,9,2}) => {1,4,1,5,2}

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

int[] GetItemsExcept(int num, int[] array = null)
{
    if (array == null || array.Length == 0) return null;
    int[] items = { };
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) continue;
        items = Append(items, array[i]);
    }
    if (items == null || items.Length == 0) return null;
    return items;
}



int[] array = { 1, 4, 1, 5, 9, 2 };

Print(GetItemsExcept(1, array));
Print(GetItemsExcept(2, array));
Print(GetItemsExcept(4, array));
Print(GetItemsExcept(5, array));
Print(GetItemsExcept(9, array));



Console.WriteLine("\n===================== END =====================");
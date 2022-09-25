Console.Clear();
Console.WriteLine("==================== START ====================\n");
Console.WriteLine("5. GetAllContains\n");

// 5. GetAllContains
// Return all items that contains the given item.
// Example: (1, {11,4,15,5,1,29,2}) => {11,15,1}
// Example: (5, {11,4,15,5,1,29,2}) => {15,5}
// Example: (9, {11,4,15,5,1,29,2}) => {29}
// Example: (3, {11,4,15,5,1,29,2}) => null

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

int[] GetAllContains(int num, int[] array = null)
{
    if (array == null || array.Length == 0) return null;
    int[] items = { };

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array[i].ToString().Length; j++)
        {
            if (array[i].ToString()[j] == num.ToString()[0])
            {
                items = Append(items, array[i]);
                break;
            }
        }
    }

    if (items == null || items.Length == 0) return null;
    return items;
}



int[] myArray = { 11, 4, 15, 5, 1, 29, 2 };

Print(GetAllContains(1, myArray));
Print(GetAllContains(5, myArray));
Print(GetAllContains(9, myArray));
Print(GetAllContains(3, myArray));



Console.WriteLine("\n===================== END =====================");
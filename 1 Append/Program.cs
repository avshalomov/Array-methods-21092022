Console.Clear();
Console.WriteLine("==================== START ====================\n");
Console.WriteLine("1. Append\n");

// 1. Append
// return new array after appending the item to array.
// example: ({1,2,3}, 4) -> {1,2,3,4}
// example: (null, 3) -> {3}

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



int[] myArray = { 1, 2, 3, 4 };

Print(myArray);
Print(Append(myArray, 999));



Console.WriteLine("\n===================== END =====================");
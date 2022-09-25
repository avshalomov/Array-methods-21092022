Console.Clear();
Console.WriteLine("==================== START ====================\n");
Console.WriteLine("6. GetSorted\n");

// 6. GetSorted
// Return array sorted in ascending order.
// Example: {11,4,15,5,1,29,2} => {1,2,4,5,11,15,29}

int[] RandomArray(int min = 0, int max = 10, int size = 10)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(min, max);
    }
    return array;
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
        Console.WriteLine("}\n");
    }
}

int[] GetSorted(int[] array = null)
{
    if (array == null || array.Length == 0) return null;

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] < array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }

    return array;
}



Console.WriteLine("Original array:");
int[] myArray = RandomArray(0, 1000, 100);
Print(myArray);

Console.WriteLine("Sorted array:");
Print(GetSorted(myArray));



Console.WriteLine("\n===================== END =====================");
Console.Clear();
Console.WriteLine("==================== START ====================\n");
Console.WriteLine("7. AreItemsSame\n");

// 7. AreItemsSame
// Get int[] array and return true if all items are the same, false otherwise
// Example: AreItemsSame(new int[] { 1, 1, 1, 1 }) -> true
// Example: AreItemsSame(new int[] { 1, 2, 3, 4 }) -> false
// Example: AreItemsSame(new int[] {}) -> true
// Example: AreItemsSame(null) -> true

bool AreItemsSame(int[] array = null)
{
    if (array == null || array.Length == 0) return true;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] != array[i + 1]) return false;
    }
    return true;
}



Console.WriteLine(AreItemsSame(new int[] { 1, 1, 1, 1 }));
Console.WriteLine(AreItemsSame(new int[] { 1, 2, 3, 4 }));
Console.WriteLine(AreItemsSame(new int[] { }));
Console.WriteLine(AreItemsSame(null));



Console.WriteLine("\n===================== END =====================");
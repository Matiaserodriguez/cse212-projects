using System.Dynamic;

public static class DisplaySums {
    public static void Run() {
        DisplaySumPairs(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        // Should show something like (order does not matter):
        // 6 4
        // 7 3
        // 8 2
        // 9 1 

        Console.WriteLine("------------");
        DisplaySumPairs(new[] { -20, -15, -10, -5, 0, 5, 10, 15, 20 });
        // Should show something like (order does not matter):
        // 10 0
        // 15 -5
        // 20 -10

        Console.WriteLine("------------");
        DisplaySumPairs(new[] { 5, 11, 2, -4, 6, 8, -1 });
        // Should show something like (order does not matter):
        // 8 2
        // -1 11
    }

    /// <summary>
    /// Display pairs of numbers (no duplicates should be displayed) that sum to
    /// 10 using a set in O(n) time.  We are assuming that there are no duplicates
    /// in the list.
    /// </summary>
    /// <param name="numbers">array of integers</param>
    private static void DisplaySumPairs(int[] numbers) {
        // TODO Problem 2 - This should print pairs of numbers in the given array

        // 0. HashSet<int> numbersSet = new HashSet<int>(numbers);
        HashSet<int> numbersSet = new(numbers);
        // 1. loop over numbersSet
        List<int> intList = [];

        for (var i = 0; i < numbers.Length; ++i) {
        // 2. for each number we do .Contains(10-number) and store this in a variable
            var number = 10 - numbers[i];
            var booleanExpression = numbersSet.Contains(number);
        // 3. if the variable of point 2. is false, we continue looping
        // 4. if the same variable is true, then we add both numbers in the set
            if (booleanExpression) {
                intList.Add(number);
                if (!intList.Contains(numbers[i])) {
                    Console.WriteLine($"{numbers[i]}, {number}");
                }
            }
        }
    }
}
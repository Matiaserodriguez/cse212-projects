public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: The Dequeue function shall remove the item with the highest priority and return its value.
        // Expected Result: The item dequeued was: banana & Queue: [Apple (Pri:1), orange (Pri:1)]
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Apple", 1);
        priorityQueue.Enqueue("banana", 2);
        priorityQueue.Enqueue("orange", 1);
        
        var priorityItem = priorityQueue.Dequeue();
        Console.WriteLine("The item dequeued was: " + priorityItem);
        Console.WriteLine("Queue: " + priorityQueue);

        // Defect(s) Found: The .Dequeue() isn't dequeuing

        Console.WriteLine("---------");

        // Test 2
        // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
        // Expected Result: Queue: [orange (Pri:1), watermelon (Pri:1)]
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("watermelon", 1);
        priorityQueue.Dequeue();
        Console.WriteLine("Queue: " + priorityQueue);

        // Defect(s) Found: The FIFO isn't working as expected

        Console.WriteLine("---------");
        // Test 3
        // Scenario: If the queue is empty, then an error message will be displayed.
        // Expected Result: "The queue is empty."
        Console.WriteLine("Test 3");
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();

        // Add more Test Cases As Needed Below
    }
}
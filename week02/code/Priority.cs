public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        //var priorityQueue = new PriorityQueue();
        //Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add an item to the queue
        // Expected Result: List of queue items
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("firstItem", 1);
        priorityQueue.Enqueue("secondItem", 3);
        priorityQueue.Enqueue("thirdItem", 2);
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Remove an item from the queue with highest priority
        // Expected Result: Item with highest priority will be removed and its value returned
        Console.WriteLine("Test 2");
        var itemRemoved = priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        Console.WriteLine($"{itemRemoved} Removed");

        // Defect(s) Found: The for loop that iterartes through the queue items was wrongly inizialzed with 1 
        //and the condition was wrong too, it should end when index is less than queue count

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: Add items with same priority
        // Expected Result: List of queue items
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("firstItem", 1);
        priorityQueue.Enqueue("secondItem", 3);
        priorityQueue.Enqueue("thirdItem", 5);
        priorityQueue.Enqueue("forthItem", 5);
        priorityQueue.Enqueue("fithItem", 2);
        Console.WriteLine(priorityQueue);

        // Defect(s) Found:
        Console.WriteLine("---------");

        // Test 4
        // Scenario: Remove an item from the queue with highest priority 
        // Expected Result: Item closest to the front of the queue and with highest priority will be removed and its value returned
        Console.WriteLine("Test 4");
        itemRemoved = priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        Console.WriteLine($"{itemRemoved} Removed");
        // Defect(s) Found: In order to remove the highest priority item and colsest to the fron, the if condition has to be greater than, not >=.

        Console.WriteLine("---------");


        // Test 5
        // Scenario: Initialize class but no adds items to queue
        // Expected Result: Empty queue
        Console.WriteLine("Test 5");
        priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found:
        Console.WriteLine("---------");


        // Test 4
        // Scenario: Remove an item from the empty queue
        // Expected Result: An error message
        Console.WriteLine("Test 4");
        priorityQueue.Dequeue();

        // Defect(s) Found: 


    }
}
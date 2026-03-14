using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: A1, B2, C3  Simple priorities
    // Expected Result: Removed in this order C#, B2, A1
    // Defect(s) Found: Expected C, but B. Fixes made in the Dequeue method.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);

        var result = priorityQueue.Dequeue();
        Trace.Assert(result == "C", "Must be C");

        result = priorityQueue.Dequeue();
        Trace.Assert(result == "B", "Must be B");

        result = priorityQueue.Dequeue();
        Trace.Assert(result == "A", "Must be A");


    }

    [TestMethod]
    // Scenario: B2, A2, C1. test for when two share a priority at start.
    // Expected Result: Removed in the order of B2, A2, C1
    // Defect(s) Found: Expected B, actual A. Fixes made in the Dequeue method.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("C", 1);

        var result = priorityQueue.Dequeue();
        Trace.Assert(result == "B");

        result = priorityQueue.Dequeue();
        Trace.Assert(result == "A");

        result = priorityQueue.Dequeue();
        Trace.Assert(result == "C");

    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: A1, B2, C2. Test for when two share a priority at end.
    // Expected Result: Removed at order B2, C2, A1
    // Defect(s) Found: Expected B, But A. Fix made in Dequeue method.

    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 2);

        var result = priorityQueue.Dequeue();
        Trace.Assert(result == "B");

        result = priorityQueue.Dequeue();
        Trace.Assert(result == "C");

        result = priorityQueue.Dequeue();
        Trace.Assert(result == "A");
    
    }

    [TestMethod]
    // Scenario: A3, B1, C2. Test for when priorites are mixed.
    // Expected Result: Removed at order B3, C2, A1
    // Defect(s) Found: Expected A, But B. Fix made in Dequeue method.

    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 3);
        priorityQueue.Enqueue("B", 1);
        priorityQueue.Enqueue("C", 2);

        var result = priorityQueue.Dequeue();
        Trace.Assert(result == "A");

        result = priorityQueue.Dequeue();
        Trace.Assert(result == "C");

        result = priorityQueue.Dequeue();
        Trace.Assert(result == "B");
    
    }
}
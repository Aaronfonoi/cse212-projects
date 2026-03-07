using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
     
    
    /// Part 1: MultiplesOf Funtion using arrays
    /// 
    ///Plan:
    /// 1. Create a new array of doubles with the size of 'count'.
    /// 2. Use a for loop to iterate from 0 to 'count - 1'.
    /// 3. Inside the loop, calculate the multiple by multiplying 'startingNumber' with (i + 1) and store it in the array.
    /// 4. After the loop, return the array containing the multiples of 'startingNumber'.
    public static double[] MultiplesOf(double startingNumber, int count)
    {
        double[] result = new double[count];

        for (int i = 0; i < count; i++)
        {
            result[i] = startingNumber * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    /// 
    /// 
    // Plan:
    // 1. Check if the list is empty or if the amount is less than or equal to 0 or if the amount is equal to the count of the list. If any of these conditions are true, return without making any changes.
    // 2. Create a new list called 'rightPart' that contains the last 'amount' elements of the original list.
    // 3. Create another list called 'leftPart' that contains the remaining elements from the beginning of the original list.
    // 4. Clear the original list to prepare for the rotated elements.
    // 5. Add the elements from 'rightPart' to the original list, followed by the elements from 'leftPart'.
    public static void RotateListRight(List<int> data, int amount)
    {
        int count = data.Count;

        if (count <= 1 || amount <= 0 || amount == count)
            return;

        // Get the last 'amount' elements
        List<int> rightPart = data.GetRange(count - amount, amount);

        // Get the remaining elements from the beginning
        List<int> leftPart = data.GetRange(0, count - amount);

        // Clear the original list
        data.Clear();

        // Add the rotated parts
        data.AddRange(rightPart);
        data.AddRange(leftPart);        
        
        
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}

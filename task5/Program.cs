namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1. Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter the size of the identity matrix : ");
            //int n;

            //// Validate user input
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.WriteLine("Please enter a valid positive integer.");
            //    Console.Write("Enter the size of the identity matrix (n): ");
            //}

            //Console.WriteLine($"\n Identity Matrix of size {n} x {n}:\n");

            //// Generate and print the identity matrix
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine(); // Move to the next row
            //}


            #endregion
            #region q2 Write a program in C# Sharp to find the sum of all elements of the array.

            //Console.Write("Enter the number of elements in the array: ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.WriteLine("Please enter a valid positive integer.");
            //    Console.Write("Enter the number of elements in the array: ");
            //}
            //int[] array = new int[n];
            //Console.WriteLine("\nEnter the elements of the array:");

            //for (int i = 0; i < n; i++)
            //{
            //    while (!int.TryParse(Console.ReadLine(), out array[i]))
            //    {
            //        Console.WriteLine("Please enter a valid integer.");
            //        Console.Write($"Element [{i + 1}]: ");
            //    }
            //}
            //int sum = 0;
            //foreach (int num in array)
            //{
            //    sum += num;
            //}
            //Console.WriteLine($"\nThe sum of all elements in the array is: {sum}");
            #endregion
            #region q3- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //Console.Write("Enter the size of the arrays: ");
            //int n;

            //// Validate user input
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.WriteLine("Please enter a valid positive integer.");
            //    Console.Write("Enter the size of the arrays: ");
            //}

            //int[] array1 = new int[n];
            //int[] array2 = new int[n];

            //Console.WriteLine("\nEnter the elements of the first array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element [{i + 1}]: ");
            //    while (!int.TryParse(Console.ReadLine(), out array1[i]))
            //    {
            //        Console.WriteLine("Please enter a valid integer.");
            //        Console.Write($"Element [{i + 1}]: ");
            //    }
            //}

            //Console.WriteLine("\nEnter the elements of the second array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element [{i + 1}]: ");
            //    while (!int.TryParse(Console.ReadLine(), out array2[i]))
            //    {
            //        Console.WriteLine("Please enter a valid integer.");
            //        Console.Write($"Element [{i + 1}]: ");
            //    }
            //}

            //// Merge the two arrays
            //int[] mergedArray = new int[2 * n];
            //Array.Copy(array1, mergedArray, n);
            //Array.Copy(array2, 0, mergedArray, n, n);

            //// Sort the merged array
            //Array.Sort(mergedArray);

            //Console.WriteLine("\nThe merged array sorted in ascending order:");
            //foreach (int num in mergedArray)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();
            #endregion q4  Write a program in C# Sharp to count the frequency of each element of an array.
            #region q4 Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] array = { 1, 2, 2, 3, 4, 4, 4, 5, 1 };
            //bool[] visited = new bool[array.Length];
            //Console.WriteLine("Element\tFrequency");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (visited[i])
            //        continue;
            //    int count = 1;
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            count++;
            //            visited[j] = true;
            //        }
            //    }

            //    Console.WriteLine($"{array[i]}\t{count}");
            //}
            #endregion
            #region q5 Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] array = { 5, 8, 2, 9, 3, 7, 1, 4 };
            //int max = array[0];
            //int min = array[0];
            //foreach (int element in array)
            //{
            //    if (element > max)
            //        max = element;
            //    if (element < min)
            //        min = element;
            //}
            //Console.WriteLine($"Maximum element: {max}");
            //Console.WriteLine($"Minimum element: {min}");
            #endregion
            #region q6  Write a program in C# Sharp to find the second largest element in an array.
            //int[] array = { 5, 8, 2, 9, 3, 7, 1, 4 };
            //if (array.Length < 2)
            //{
            //    Console.WriteLine("Array must have at least two elements.");
            //    return;
            //}
            //int largest = int.MinValue;
            //int secondLargest = int.MinValue;

            //foreach (int element in array)
            //{
            //    if (element > largest)
            //    {
            //        secondLargest = largest;
            //        largest = element;
            //    }
            //    else if (element > secondLargest && element < largest)
            //    {
            //        secondLargest = element;
            //    }
            //}

            //if (secondLargest == int.MinValue)
            //{
            //    Console.WriteLine("There is no second largest element in the array.");
            //}
            //else
            //{
            //    Console.WriteLine($"The second largest element is: {secondLargest}");
            //}
            #endregion
            #region q7 Consider an Array of Integer values with size N, having values as in this Example

            #endregion
            #region q8
            #endregion
            #region q9 Given a list of space separated words, reverse the order of the words.

            #endregion
            #region q10  Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array.
            
            
            #endregion
            #region q11 Write a Program to Print One Dimensional Array in Reverse Order
            int[] arr = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array in reverse order:");

            // Iterate through the array in reverse
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            #endregion
        }
    }
}
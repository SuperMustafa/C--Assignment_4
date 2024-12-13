using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q2
            //             Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task
            //             .A worker's efficiency level is determined as follows: 
            //- If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //- If the worker takes more than 5 hours, they are required to leave the company.
            //To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

            //============================Answer====================================
            //Console.WriteLine("Please Enter the worker time spend on a task");
            //bool flag = int.TryParse(Console.ReadLine(), out int TaskTime);
            //if (TaskTime >= 2 && TaskTime <= 3)
            //{
            //    Console.WriteLine("Highly Efficient");
            //}
            //else if(TaskTime>=3&&TaskTime <= 4)
            //{
            //    Console.WriteLine("instructed to increase their speed");
            //}
            //else if (TaskTime>=4&&TaskTime<=5) {
            //    Console.WriteLine("provided with training to enhance their speed");
            //}
            //else if (TaskTime>5) {
            //    Console.WriteLine("required to leave the company");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Time should be 2 hours or more.");
            //}
            #endregion
            #region Q3
            //Write a program that prints an identity matrix using for loop,
            //in other words takes a value n from the user and shows the identity table of size n * n.

            //    Console.WriteLine("Enter the size of the identity matrix (n):");
            //    int n = GetMatrixSize();
            //    Console.WriteLine($"Identity Matrix of size {n}x{n}:");
            //    PrintIdentityMatrix(n);
            //}

            //static int GetMatrixSize()
            //{
            //    while (true)
            //    {
            //        Console.Write("n: ");
            //        if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            //        {
            //            return size;
            //        }
            //        Console.WriteLine("Invalid input. Please enter a positive integer.");
            //    }
            //}

            //static void PrintIdentityMatrix(int n)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < n; j++)
            //        {
            //            if (i == j)
            //            {
            //                Console.Write("1 ");
            //            }
            //            else
            //            {
            //                Console.Write("0 ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            #endregion
            #region Q4
            ////Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] Numbers = { 1, 3, 5, 6, 7, 1, 9, 64, 3 };
            //int sum = 0;
            //for(int i = 0; i < Numbers.Length; i++)
            //{
            //    sum += Numbers[i];  
            //}

            //Console.WriteLine("Sum of Array is : "+sum);


            #endregion
            #region Q5
            //  Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //Console.WriteLine("Enter the size of the arrays:");
            //int size;
            //while (true)
            //{
            //    Console.Write("Size: ");
            //    if (int.TryParse(Console.ReadLine(), out size) && size > 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}

            //int[] array1 = new int[size];
            //int[] array2 = new int[size];
            //int[] mergedArray = new int[size * 2];

            //Console.WriteLine("Enter elements for the first array:");
            //for (int i = 0; i < size; i++)
            //{
            //    while (true)
            //    {
            //        Console.Write($"Element {i + 1}: ");
            //        if (int.TryParse(Console.ReadLine(), out int element))
            //        {
            //            array1[i] = element;
            //            break;
            //        }
            //        Console.WriteLine("Invalid input. Please enter an integer.");
            //    }
            //}

            //Console.WriteLine("Enter elements for the second array:");
            //for (int i = 0; i < size; i++)
            //{
            //    while (true)
            //    {
            //        Console.Write($"Element {i + 1}: ");
            //        if (int.TryParse(Console.ReadLine(), out int element))
            //        {
            //            array2[i] = element;
            //            break;
            //        }
            //        Console.WriteLine("Invalid input. Please enter an integer.");
            //    }
            //}

            //// Merge the two arrays
            //for (int i = 0; i < size; i++)
            //{
            //    mergedArray[i] = array1[i];
            //    mergedArray[size + i] = array2[i];
            //}


            //Array.Sort(mergedArray);
            //for (int i = 0; i < mergedArray.Length; i++)
            //{
            //    Console.WriteLine(mergedArray[i]);
            //}




            #endregion
            #region Q6

            //Console.WriteLine("Enter the size of the array:");
            //int size;
            //while (true)
            //{
            //    Console.Write("Size: ");
            //    if (int.TryParse(Console.ReadLine(), out size) && size > 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}

            //int[] array = new int[size];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    while (true)
            //    {
            //        Console.Write($"Element {i + 1}: ");
            //        if (int.TryParse(Console.ReadLine(), out int element))
            //        {
            //            array[i] = element;
            //            break;
            //        }
            //        Console.WriteLine("Invalid input. Please enter an integer.");
            //    }
            //}

            //bool[] visited = new bool[size]; // To track visited elements

            //Console.WriteLine("Frequency of each element:");
            //for (int i = 0; i < size; i++)
            //{
            //    if (visited[i])
            //    {
            //        continue;
            //    }

            //    int count = 1;
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            count++;
            //            visited[j] = true;
            //        }
            //    }

            //    Console.WriteLine($"Element {array[i]}: {count} times");
            //}




            #endregion
            #region Q7
            // Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            //int max = arr.Max();
            //int min =arr.Min();
            //Console.WriteLine($"max number is :{max} ");
            //Console.WriteLine($"min number is :{min} ");


            #endregion
            #region Q8
            //   Write a program in C# Sharp to find the second largest element in an array.
            //    int[] array = { 1, 2, 3, 4, 5, 6,77, 7 };


            //    int largest = int.MinValue;
            //    int secondLargest = int.MinValue;

            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] > largest)
            //        {
            //            secondLargest = largest;
            //            largest = array[i];
            //        }
            //        else if (array[i] > secondLargest && array[i] != largest)
            //        {
            //            secondLargest = array[i];
            //        }
            //    }
            //    Console.WriteLine("Second largest  Number is " + secondLargest);

            //}

            #endregion
            #region Q9
            // write a program find the longest distance between Two equal cells



            //    int[] array = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 9, 5, 7 };

            //    int maxDistance = 0;

            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        for (int j = i + 1; j < array.Length; j++)
            //        {
            //            if (array[i] == array[j])
            //            {
            //                int distance = j - i - 1; // Number of cells between the indices
            //                if (distance > maxDistance)
            //                {
            //                    maxDistance = distance;
            //                }
            //            }
            //        }
            //    }

            //    Console.WriteLine($"The longest distance between two equal cells is: {maxDistance}");
            //}
            #endregion
            #region Q10
            //  Given a list of space separated words, reverse the order of the words.

            //Console.WriteLine("Enter a space-separated list of words:");
            //string input = Console.ReadLine();
            //string[] words = input.Split(' ');

            //Array.Reverse(words);

            //string reversed = string.Join(" ", words);
            //Console.WriteLine("Reversed order of words:");
            //Console.WriteLine(reversed);
            #endregion
            #region Q11
            //Write a Program to Print One Dimensional Array in Reverse Order
            //Console.WriteLine("Enter your array size");
            //bool flag = int.TryParse(Console.ReadLine(), out int size);
            //int[] numbers =new int[size];   
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter index {i+1}");
            //    numbers[i]=int.Parse( Console.ReadLine() );
            //}
           

            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i]);
            //}
            #endregion
        }
    }
}



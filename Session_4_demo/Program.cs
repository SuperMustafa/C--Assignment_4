using System.Runtime.InteropServices;
using System.Text;

namespace Session_4_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string & stringbuilder
            #region string
            //String FName = new string("Mustafa");
            //string LName = "Hamad";
            //LName = FName; //here Lname created a new object of string and but the value of Fname on it and leave the old value and pointer at new value
            //Console.WriteLine(FName.GetHashCode());
            //Console.WriteLine(LName.GetHashCode());
            //has the same refernce at memory and the same hash code

            //string country = "Egypt";
            //Console.WriteLine(country);
            //Console.WriteLine(country.GetHashCode());
            //country += "- Sadat City";
            //Console.WriteLine(country);
            //Console.WriteLine(country.GetHashCode());
            //StringBuilder is refernce type
            //String is immutable type
            #endregion
            #region StringBuilder
            //StringBuilder Country = new StringBuilder();
            //Country.Append("Alexendria");
            //Console.WriteLine(Country);
            //Console.WriteLine(Country.GetHashCode());
            //Country.Append("/ Elmamora");
            //Console.WriteLine(Country);
            //Console.WriteLine(Country.GetHashCode());
            //StringBuilder is mutable type
            //StringBuilder is refernce type



            #endregion
            #endregion

            #region Array
            #region 1D array
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] Numbers;
            //Numbers = new int[5];
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Numbers[i] = i;
            //}
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            #endregion
            #region 2D Array [reactangle array]
            //int[,] marks = new int[3, 5]
            //{
            //    {10,20,30,40,50 }, //row 1 (Student 1 marks)
            //    {10,20,30,40,50 }, //row 2 (Student 2 marks)
            //    {10,20,30,40,50 }, //row 3 (Student 3 marks)

            //};

            //int[,] marks = new int[3, 5];
            //bool flag;

            //for(int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Please enter grades  of student number {i+1}");
            //    for (int j = 0; j < marks.GetLength(1);)
            //    {
            //        Console.WriteLine($"please enter grade of subject number {j+1}");

            //        flag = int.TryParse(Console.ReadLine(), out int grade);
            //        if (flag)
            //        {
            //            j++;
            //        }
            //        marks[i, j] = grade;
            //    }
            //    Console.WriteLine("========================================");
            //}


            #endregion
            #region 2D Array [judged array]
            //int[][] grades = new int [3][];
            //grades[0] = new int[3] {22,32,44};
            //grades[1] = new int[4] { 66, 55, 33, 99 };
            //grades[2] = new int[5] { 66, 55, 33, 99,100 };
            //for(int i = 0; i < grades.Length; i++)
            //{
            //    for(int j = 0; j < grades[i].Length; j++)
            //    {
            //        Console.Write(grades[i][j]+" ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #endregion

            #region Array methods
            //===================Class member methods (static methods)=====================
            //Reverse
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //Array.Reverse(Numbers);
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //Sort
            // int[] Numbers = { 11, 2, 9, 4, 5, 6, 73 };
            //Array.Sort(Numbers);
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //copy

            //int[] numbers1 = new int[5] { 1,2,3,4,5};
            //int[] numbers2 = new int[5];
            //Array.Copy(numbers1, numbers2, 4);
            //for(int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}

            //constrained copy
            //int[] numbers1 = new int[8] { 1, 2, 3, 4, 5,66,44,33};
            //int[] numbers2 = new int[5];
            //Array.ConstrainedCopy(numbers1,1, numbers2, 2,2);
            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}

            //index of
            //int[] nums = new int[7] { 1, 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(Array.IndexOf(nums, 1)); 

            //last index of
            //int[] nums = new int[7] { 1, 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(Array.LastIndexOf(nums, 1));

            //create instance 
            //====== 1d array
            //int [] nums=(int[]) Array.CreateInstance(typeof (int), 6);
            //for(int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //====== 2d array
            //int[,]nums = (int[,])Array.CreateInstance(typeof(int), 6,3);

            //    Console.WriteLine(nums.Length);


            //===================object member methods (non static methods)=====================
            //copy to

            //int[] nums1 = { 1, 2, 55, 77, 99 };
            //int[] nums2 = new int[6];
            //nums1.CopyTo(nums2, 1);
            //for (int i = 0; i < nums2.Length; i++) {
            //    Console.WriteLine(nums2[i]);
            //}

            #endregion
        }
    }
}

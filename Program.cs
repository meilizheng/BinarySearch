using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] randomArray = RandomArray();
            int[] uniqueArray = OrganizedArray(randomArray);

            Console.WriteLine("Unique and sorted numbers:");
            foreach (var number in uniqueArray)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Please enter the number:");
            int userInput = int.Parse(Console.ReadLine());
            int result = BinarySearch(uniqueArray, 0, uniqueArray.Length - 1, userInput);
            Console.WriteLine($"number {userInput}'s index number is {result}");

            DoubleLink doubleLink = new DoubleLink();
            // Convert the array into a doubly linked list
            foreach (int value in uniqueArray)
            {
                doubleLink.Insert(value);
                
            }

            // Insert a new value into the doubly linked list
            //doubleLink.Insert(50);
            //foreach(int value in doubleLink)
            //{
            //    Console.WriteLine(value);
            //}

        }

        public static int[] RandomArray()
        {
            int size = 15;
            Random rand = new Random();
            int[] randomArray = new int[size];
            Console.WriteLine("Random Array:");
            for (int i = 0; i < size; i++)
            {
                randomArray[i] = (rand.Next(1, 10));
                Console.WriteLine(randomArray[i]);
            }

            return randomArray;
        }

        public static int[] SortedArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        // Shift elements to the left by one position
                        for (int k = j; k < array.Length - 1; k++)
                        {
                            array[k] = array[k + 1];
                        }
                        // Decrease array size by one
                        Array.Resize(ref array, array.Length - 1);
                        j--; // Adjust index after removal
                    }
                    else if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        public static int[] OrganizedArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        array[j] = 0; // Replace duplicate with 0
                    }
                }
            }
            Array.Sort(array);

            // Filtering out 0s
            int count = 0;
            foreach (int num in array)
            {
                if (num != 0)
                {
                    count++;
                }
            }

            int[] uniqueArray = new int[count];
            int index = 0;
            foreach (int num in array)
            {
                if (num != 0)
                {
                    uniqueArray[index++] = num;
                }
            }

            return uniqueArray;

        }

        public static int BinarySearch(int[] array, int left, int right, int key)
        {


            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == key)
                {
                    return mid;
                }
                if (array[mid] < key)
                {
                    left = mid + 1;
                }
                if (array[mid] > key)
                {
                    right = mid - 1;
                }
            }
            return -1;
        }


        //public static int[] InsertElement(int value)
        //{
        //    if (array != null && array.Length != 0)
        //    {
        //        DoubleLink doubleLink = new DoubleLink();
        //        doubleLink.Insert(value);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Array is null or empty.");
        //    }
        //    return array;
        //}
    }
}





  
using System;
using System.Collections.Generic;

namespace Sorting
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			List<int> unsortedList = new List<int>() { 9, 1, 9, 3, 7, 0, 6, 2, 4, 5, -1, 8, 1, 9};
        }

        #region Insertion Sort

        private static void Insertion_Sort(List<int> arr)
		{
			/**********************/
			Console.WriteLine("Unsorted list");
			foreach (var item in arr)
			{Console.WriteLine(item);}
			/***********************/


			for (int j = 1; j < arr.Count; j++)
			{
				int key = arr[j];
				int i = j - 1;

				while (i >= 0 && arr[i] > key)
				{
					arr[i + 1] = arr[i];
					i = i - 1;
				}
                arr[i + 1] = key;
			}


			/**********************/
			Console.WriteLine("Sorted list");
			foreach (var item in arr)
			{Console.WriteLine(item);}
            /***********************/

            Console.ReadLine();
		
		}

        private static void Insertion_Sort_Descending(List<int> arr)
        {
            /**********************/
            Console.WriteLine("Unsorted list");
            foreach (var item in arr)
            { Console.WriteLine(item); }
            /***********************/


            for (int j = 1; j < arr.Count; j++)
            {
                int key = arr[j];
                int i = j - 1;

                while (i >= 0 && arr[i] < key)
                {
                    arr[i + 1] = arr[i];
                    i = i - 1;
                }
                arr[i + 1] = key;
            }


            /**********************/
            Console.WriteLine("Sorted list");
            foreach (var item in arr)
            { Console.WriteLine(item); }
            /***********************/

            Console.ReadLine();

        }

        private static void Task_1_2_2()
        {
            for (int n = 2; n < 1000; n++)
            {
                if(n < 8*(Math.Log10(n))/Math.Log10(2))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(n);
                    Console.ReadLine();
                    break;
                }
            }
        }

        private static void Task_1_2_3()
        {
            for (int n = 1; n < 1000; n++)
            {
                if (100*n*n < Math.Pow(2, n))
                {
                    Console.WriteLine(n);
                    Console.ReadLine();
                    break;
                }
            }
        }

        #endregion Insertion Sort

    }
}

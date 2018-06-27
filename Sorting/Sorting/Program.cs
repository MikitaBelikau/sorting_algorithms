using System;
using System.Collections.Generic;

namespace Sorting
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			List<int> unsortedList = new List<int>() { 9, 1, 9, 3, 7, 0, 6, 2, 4, 5, -1, 8, 1, 9};


			Insertion_Sort_Reverse(unsortedList);
		}

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

        private static void Insertion_Sort_Reverse(List<int> arr)
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
    }
}

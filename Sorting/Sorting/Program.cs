using System;
using System.Collections.Generic;

namespace Sorting
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			List<int> unsortedList = new List<int>() { 9, 1, 9, 3, 7, 0, 6, 2, 4, 5, -1, 8, 1, 9};


			Insertion_Sort(unsortedList);
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
					int temp = arr[i + 1];
					arr[i + 1] = arr[i];
					arr[i] = temp;
					i = i - 1;
				}
			}


			/**********************/
			Console.WriteLine("Sorted list");
			foreach (var item in arr)
			{Console.WriteLine(item);}
			/***********************/
		
		}

	}
}

using System;
using System.Collections.Generic;

namespace Sorting
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			#region Merge Sort
			List<int?> unsortedList = new List<int?>() { 2, 1, 7, 3, 5, 4 };

			Merge_Sort(ref unsortedList, 0, 5);

			/**********************/
			Console.WriteLine("Sorted list");
			foreach (var item in unsortedList)
			{ Console.WriteLine(item); }
			/***********************/

			Console.ReadLine();

			#endregion Merge Sort
		}

		#region Insertion Sort

		private static void Insertion_Sort(List<int> arr)
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
			{ Console.WriteLine(item); }
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
				if (n < 8 * (Math.Log10(n)) / Math.Log10(2))
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
				if (100 * n * n < Math.Pow(2, n))
				{
					Console.WriteLine(n);
					Console.ReadLine();
					break;
				}
			}
		}

		#endregion Insertion Sort

		#region Merge Sort

		private static void Merge(ref List<int?> arr, int p, int q, int r)
		{
			int n1 = q - p + 1;
			int n2 = r - q;

			int?[] L = new int?[n1 + 1];
			int?[] R = new int?[n2 + 1];

			for (int l = 0; l < n1; l++)
			{
				L[l] = arr[p + l];
			}

			for (int m = 0; m < n2; m++)
			{
				R[m] = arr[q + m + 1];
			}

			L[n1] = null;
			R[n2] = null;

			int i = 0;
			int j = 0;
			int k;

			for (k = p; k < r; k++)
			{
				if (L[i] <= R[j])
				{
					arr[k] = L[i];
					i++;
				}
				else
				{
					arr[k] = R[j];
					j++;
				}
			}

			while (L[i] != null)
			{
				arr[k] = L[i];
				i++;
				k++;
			}

			while (R[j] != null)
			{
				arr[k] = R[j];
				j++;
				k++;
			}
		}

		private static void Merge_Sort(ref List<int?> arr , int p, int r)
		{
			if (p < r)
			{
				int q = (p + r) / 2;
				Merge_Sort(ref arr, p, q);
				Merge_Sort(ref arr, q + 1, r);

				Merge(ref arr, p, q, r);
			}

		}

		#endregion Merge Sort

	}
}

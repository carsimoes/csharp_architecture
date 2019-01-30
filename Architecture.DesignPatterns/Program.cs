using Architecture.DesignPatterns.Behavioral.Strategy.SortStrategy;
using System;

namespace Architecture.DesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			var collection = new Collection(new int[] { 1, 7, 6, 5, 4, 3, 2 });
			collection.SetSortStrategy(new BubbleSortStrategy());
			collection.Sort();

			Console.WriteLine(collection);
			Console.ReadKey();
		}
	}
}

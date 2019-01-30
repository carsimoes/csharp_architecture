using Architecture.DesignPatterns.Behavioral.Strategy.SortStrategy;
using Xunit;

namespace Architecture.DesignPatterns.Tests
{
	public class SortStrategyTests
	{
		[Fact]
		public void BublueSortStrategyTests()
		{
			var collection = new Collection(new int[] { 1, 7, 6, 5, 4, 3, 2 });
			var collectionExpected = new Collection(new int[] { 1, 2, 3, 4, 5, 6, 7 });
			collection.SetSortStrategy(new BubbleSortStrategy());
			collection.Sort();

			Assert.Equal(collectionExpected.ToString(), collection.ToString());
		}
	}
}

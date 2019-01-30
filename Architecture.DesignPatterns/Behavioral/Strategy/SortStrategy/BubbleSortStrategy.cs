namespace Architecture.DesignPatterns.Behavioral.Strategy.SortStrategy
{
	public class BubbleSortStrategy : ISortStrategy
	{
		public void Sort(ref int[] elements)
		{
			var size = elements.Length;
			bool swapped;
			do
			{
				swapped = false;
				for (int i = 0; i < size - 1; i++)
				{
					if (elements[i] > elements[i + 1])
					{
						this.Swap(ref elements[i], ref elements[i + 1]);
						swapped = true;
					}
				}
				size--;
			} while (swapped);
		}

		protected void Swap(ref int a, ref int b)
		{
			var tmp = a;
			a = b;
			b = tmp;
		}
	}
}

using System;
using System.Linq;

namespace Architecture.DesignPatterns.Behavioral.Strategy.SortStrategy
{
	public class Collection
	{
		protected int[] elements;

		public ISortStrategy SortStrategy { get; private set; }

		public Collection(int[] elements)
		{
			this.elements = elements;
			this.SortStrategy = null;
		}

		public void SetSortStrategy(ISortStrategy sortStrategy)
		{
			this.SortStrategy = sortStrategy;
		}

		public void Sort()
		{
			if (this.SortStrategy != null)
			{
				this.SortStrategy.Sort(ref this.elements);
			}
		}

		public override String ToString()
		{
			return "[" + string.Join(
					", ",
					this.elements.Select(
							item => item.ToString()
					).ToArray()
			) + "]";
		}
		//...
	}
}

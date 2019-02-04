namespace Architecture.DesignPatterns.Creational.Builder.ProductBuilder
{
	public class Director
	{
		Builder builder;

		public Director(Builder builder)
		{
			this.builder = builder;
		}

		public void BuildMinimalViableProduct()
		{
			builder.BuildPartA();
		}

		public void BuildFullFeaturedProduct()
		{
			builder.BuildPartA();
			builder.BuildPartB();
			builder.BuildPartC();
		}
	}
}
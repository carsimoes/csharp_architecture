using System;

namespace Architecture.DesignPatterns.Creational.Builder.ProductBuilder
{
	public class Client
	{
		public void ClientCode(Director director, Builder builder)
		{
			Console.WriteLine("Standart basic product:");
			director.BuildMinimalViableProduct();
			Console.WriteLine(builder.GetProduct().ListParts());

			Console.WriteLine("Standart full featured product:");
			director.BuildFullFeaturedProduct();
			Console.WriteLine(builder.GetProduct().ListParts());

			Console.WriteLine("Custom product:");
			builder.BuildPartA();
			builder.BuildPartC();
			Console.WriteLine(builder.GetProduct().ListParts());
		}
	}
}

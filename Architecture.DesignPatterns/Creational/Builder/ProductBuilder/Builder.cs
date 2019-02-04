using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.DesignPatterns.Creational.Builder.ProductBuilder
{
	public abstract class Builder
	{
		public abstract void BuildPartA();

		public abstract void BuildPartB();

		public abstract void BuildPartC();

		public abstract Product GetProduct();
	}
}

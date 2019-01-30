using Architecture.DesignPatterns.Creational.Factory.UserNameFactory;
using System;
using Xunit;

namespace Architecture.DesignPatterns.Tests
{
	public class UsernameFactoryTests
	{
		private readonly UsernameFactory _factory;

		public UsernameFactoryTests()
		{
			_factory = new UsernameFactory();
		}

		[Fact]
		public void ShouldGetFirstNameFirst()
		{
			//arrange
			var user = "Flexa Loira";

			//act
			var username = _factory.GetUserName(user);

			//assert
			Assert.Equal("Flexa", username.FirstName);
			Assert.Equal("Loira", username.LastName);
		}

		[Fact]
		public void ShouldGetLastNameFirst()
		{
			//arrange
			var user = "Loira, Flexa";

			//act
			var username = _factory.GetUserName(user);

			//assert
			Assert.Equal("Flexa", username.FirstName);
			Assert.Equal("Loira", username.LastName);

		}
	}
}

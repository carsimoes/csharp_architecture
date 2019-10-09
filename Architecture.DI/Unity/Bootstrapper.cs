using Architecture.DI.Ioc.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Di.Ioc.Unity
{
	public static class Bootstrapper
	{
		public static void Init()
		{
			DependencyInjector.Register<IPersonService, PersonService>();
		}
	}
}

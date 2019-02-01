using System;

namespace Architecture.DesignPatterns.Structural.Facade.CarFacade
{
	public class CarFacade
	{
		CarModel model;
		CarEngine engine;
		CarBody body;
		CarAccessories accessories;

		public CarFacade()
		{
			model = new CarModel();
			engine = new CarEngine();
			body = new CarBody();
			accessories = new CarAccessories();
		}

		public bool CreateCompleteCar()
		{
			bool carCreated = true;

			try
			{
				Console.WriteLine("******** Creating a Car **********\n");

				model.SetModel();
				engine.SetEngine();
				body.SetBody();
				accessories.SetAccessories();

				Console.WriteLine("\n******** Car creation complete **********");
			}
			catch
			{
				carCreated = false;
			}

			return carCreated;
		}
	}
}

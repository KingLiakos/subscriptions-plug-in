using System;

namespace subscriptions_plug_in
{
	class Program
	{
		static void Main(string[] args)
		{

			//random class for shuffling
			Random random = new Random();

			// days until expirtation -> shuffling (from 1 to 12)
			int daysUntilExpiration = random.Next(12);

			//percentage discount % 
			int percentageDiscount = 0;


			Console.WriteLine(daysUntilExpiration);

			//expirted subscription

			if (daysUntilExpiration == 0)
			{
				Console.WriteLine("Your subscription has expired.");

			}

			else if (daysUntilExpiration == 1)
			{
				Console.WriteLine("Your subscription expires within a day! Renew now and save 20 % !");
				percentageDiscount = 20;

			}

			else if (daysUntilExpiration <= 5)
			{
				//interpolation
				Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save 10%!");
				percentageDiscount = 10;
			}


			//first output of 10 <=
			else if (daysUntilExpiration <= 10)
			{
				Console.WriteLine("Your subscription will expire soon. Renew now!");

			}

		}
	}
}
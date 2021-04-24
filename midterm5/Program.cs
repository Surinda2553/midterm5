using System;

namespace midterm5
{
	class Program
	{
		static void Main(string[] args)
		{
			int day;
			int time;

			int breakFastSet = 5;
			int weekEndSet = 2;
			int coffee = 3;

			while (true)
			{
				Console.WriteLine("Day of Week:");
				int dayl = Convert.ToInt32(Console.ReadLine());
				if (dayl < 1 || dayl > 7)
				{
					Console.WriteLine("Please input 1-7 only, try again!");
					continue;
				}
				else
				{
					day = dayl;
					break;
				}
			}

			while (true)
			{
				Console.WriteLine("Time of Day:");
				int timel = Convert.ToInt32(Console.ReadLine());
				if (timel < 8 || timel > 18)
				{
					Console.WriteLine("Please input 8-18 only, try again!");
					continue;
				}
				else
				{
					time = timel;
					break;
				}
			}

			while (true)
			{
				Console.WriteLine("Enter a menu:");
				string userOrder = Console.ReadLine();

				if (userOrder == "Breakfast Set")
				{
					if (breakFastSet == 0)
					{
						Console.WriteLine("Sorry, your order is out of stock.");
					}
					if (time > 11)
					{
						Console.WriteLine("Sorry, your order is not available.");
					}
					else
					{
						breakFastSet -= 1;
					}
				}
				else if (userOrder == "Weekend Set")
				{
					if (weekEndSet == 0)
					{
						Console.WriteLine("Sorry, your order is out of stock.");
					}
					if (day > 5)
					{
						Console.WriteLine("Sorry, your order is not available.");
					}
					else
					{
						weekEndSet -= 1;
					}
				}
				else if (userOrder == "coffee")
				{
					if (coffee == 0)
					{
						Console.WriteLine("Sorry, your order is out of stock.");
					}
					else
					{
						coffee -= 1;
					}
				}
				else if (userOrder == "End") { break; }
				else
				{
					Console.WriteLine("Please enter a valid menu");
				}

			}

		}
	}
}

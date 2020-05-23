using snake.clases;
using System;

namespace snake
{
	class Program
	{
		static void Main(string[] args)
		{
			HorizontLine line = new HorizontLine(5, 10, 8, '+');
			line.drow();

			VerticalLine line1 = new VerticalLine(5, 10, 8, '-');
			line1.drow();

			Console.ReadLine();
		}
	}
}

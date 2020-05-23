using snake.clases;
using System;

namespace snake
{
	class Program
	{
		static void Main(string[] args)
		{
			
			drawBord();

			Snake snake = new Snake(new Point(4, 4, '+'), 5, Directions.RIGTH);
			snake.drow();
			Console.ReadLine();

		}

		static void drawBord()
        {

			Console.SetWindowSize(80, 25);
			Console.SetBufferSize(80, 25);

			HorizontLine topLine = new HorizontLine(0, 78, 0, '*');
			HorizontLine bottomLine = new HorizontLine(0, 78, 24, '*');
			VerticalLine leftLine = new VerticalLine(0, 24, 0, '*');
			VerticalLine rightLine = new VerticalLine(0, 24, 78, '*');

			topLine.drow();
			bottomLine.drow();
			leftLine.drow();
			rightLine.drow();
        
		}
	}
}

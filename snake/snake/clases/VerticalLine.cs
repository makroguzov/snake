using System;
using System.Collections.Generic;
using System.Text;

namespace snake.clases
{
	class VerticalLine
	{
		List<Point> line;
		
		public VerticalLine(int yDown, int yTop, int x, char sym)
		{
			line = new List<Point>();
			for (int y = yDown; y <= yTop; y++)
			{

				line.Add(new Point(x, y, sym));
			}
		}

		public void drow()
		{
			foreach (Point point in line)
			{
				point.draw();
			}
		}

	}
}

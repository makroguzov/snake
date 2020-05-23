using System;
using System.Collections.Generic;
using System.Text;

namespace snake.clases
{
	class HorizontLine
	{
		List<Point> line;

		public HorizontLine(int xLeft, int xRight, int y, char sym)
		{
			line = new List<Point>();
			for (int x = xLeft; x <= xRight; x++)
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

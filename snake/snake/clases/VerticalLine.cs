using System;
using System.Collections.Generic;
using System.Text;

namespace snake.clases
{
	class VerticalLine : Figure
	{
		
		public VerticalLine(int yDown, int yTop, int x, char sym)
		{
			pList = new List<Point>();
			for (int y = yDown; y <= yTop; y++)
			{

				pList.Add(new Point(x, y, sym));
			}
		}

	}
}

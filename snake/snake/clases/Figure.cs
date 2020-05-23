using System;
using System.Collections.Generic;
using System.Text;

namespace snake.clases
{

    class Figure
    {
		protected List<Point> pList = new List<Point>();

		public void drow()
		{
			foreach (Point point in pList)
			{
				point.draw();
			}
		}
	}
}

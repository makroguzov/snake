using System;
using System.Collections.Generic;
using System.Text;

namespace snake.clases
{

    class Figure
    {
		protected List<Point> pList;

		public void draw()
		{
			foreach (Point point in pList)
			{
				point.draw();
			}
		}

        internal bool isHit(Figure figure)
        {
           foreach (var p in pList)
            {
                if (figure.isHit(p))
                    return true;
            }
            return false;
        }

        private bool isHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.isHit(point))
                    return true;
            }
            return false;
        }
    }
}

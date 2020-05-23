using System;
using System.Collections.Generic;
using System.Text;

namespace snake.clases
{
    class Snake : Figure
    {
        public Snake(Point tail, int size, Directions directions)
        {
            for (int i = 0; i < size; i++)
            {
                Point p = new Point(tail);
                p.move(i, directions);
                pList.Add(p);
            }
        }

    }
}

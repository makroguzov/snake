using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake.clases
{
    class Snake : Figure
    {
        Directions direction;
        
        public Snake(Point tail, int size, Directions direction)
        {
            this.direction = direction;
            
            pList = new List<Point>();
            for (int i = 0; i < size; i++)
            {
                Point p = new Point(tail);
                p.move(i, direction);
                pList.Add(p);
            }
        }

        internal bool eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.isHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            } else 
                return false;
        }

        internal bool isHitTail()
        {
            Point head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.isHit(pList[i]))
                    return true;
            }
            return false;
        }

        internal void handleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Directions.LEFT;
            }
            if (key == ConsoleKey.RightArrow)
            {
                direction = Directions.RIGTH;
            }
            if (key == ConsoleKey.DownArrow)
            {
                direction = Directions.DOWN;
            }
            if (key == ConsoleKey.UpArrow)
            {
                direction = Directions.UP;
            }
        }

        public void move()
        {
            Point tail = pList.First();
            pList.Remove(tail);

            Point head = GetNextPoint();
            pList.Add(head);

            tail.clear();
            head.draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);

            nextPoint.move(1, direction);
            
            return nextPoint;
        }

    }
}

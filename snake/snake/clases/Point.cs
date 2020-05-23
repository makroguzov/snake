using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace snake.clases
{
	class Point
	{
		public int x;
		public int y;
		public char sym;

		public Point(Point point)
        {
			this.x = point.x;
			this.y = point.y;
			this.sym = point.sym;
        }
		
		public Point(int x ,int y ,char sym) 
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}

		public void draw()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);

		}

		public void move(int offSet, Directions direction)
        {
			if (direction == Directions.RIGTH)
            {
				this.x = this.x + offSet;
            }
			
			if (direction == Directions.LEFT)
			{
				this.x = this.x - offSet;
			}
			
			if (direction == Directions.UP)
			{
				this.y = this.y + offSet;
			}
			
			if (direction == Directions.DOWN)
			{
				this.y = this.y - offSet;
			}

		}
	}
}

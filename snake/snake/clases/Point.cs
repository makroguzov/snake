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
	}
}

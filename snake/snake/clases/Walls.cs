using System;
using System.Collections.Generic;
using System.Text;

namespace snake.clases
{
    class Walls
    {

        List<Figure> wallList;

        public Walls(int fieldWidth, int fielHeigth)
        {
            Console.SetWindowSize(fieldWidth, fielHeigth);
            Console.SetBufferSize(fieldWidth, fielHeigth);

            wallList = new List<Figure>();

            HorizontLine topLine = new HorizontLine(0, fieldWidth - 1, 0, '*');
            wallList.Add(topLine);
            HorizontLine bottomLine = new HorizontLine(0, fieldWidth - 1, fielHeigth - 1, '*');
            wallList.Add(bottomLine);
            VerticalLine leftLine = new VerticalLine(0, fielHeigth - 1, 0, '*');
            wallList.Add(leftLine);
            VerticalLine rightLine = new VerticalLine(0, fielHeigth - 1, fieldWidth - 1, '*');
            wallList.Add(rightLine);

        }

        internal bool isHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.isHit(figure))
                    return true;
            }
            return false;
        }


        public void draw()
        {
            foreach(var wall in wallList)
            {
                wall.draw();
            }
        }

    }
}

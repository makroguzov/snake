using snake.clases;
using System;
using System.Threading;

namespace snake
{
	class Program
	{

		const int fieldWidth = 80;
        const int fielHeigth = 25;

		static void Main(string[] args)
		{

			Walls walls = new Walls(fieldWidth, fielHeigth);
			walls.draw();

			FoodCreator foodCreator = new FoodCreator(fieldWidth, fielHeigth, '$');
			Point food = foodCreator.createFood();
			food.draw();

			Snake snake = new Snake(new Point(4, 4, '+'), 5, Directions.RIGTH);
			snake.draw();

            while (true)
            {
				if (walls.isHit(snake) || snake.isHitTail())
				{
					break;
				}

				if (snake.eat(food))
                {
					food = foodCreator.createFood();
					food.draw();
                }
				else
                {
					snake.move();
                }
				Thread.Sleep(100);

				if (Console.KeyAvailable)
                {
					ConsoleKeyInfo key = Console.ReadKey();
					snake.handleKey(key.Key);
                }
            }

		}
	}
}

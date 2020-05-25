using System;
using System.Collections.Generic;
using System.Text;

namespace snake.clases
{

    class FoodCreator {

        int fieldWidth;
        int fieldHeigth;
        char sym;

        Random random = new Random();

        public FoodCreator(int fieldWidth,int fieldHeigth, char sym)
        {
            this.sym = sym;
            this.fieldHeigth= fieldHeigth;
            this.fieldWidth = fieldWidth;
        }

        public Point createFood()
        {
            int x = random.Next(2, fieldWidth - 2);
            int y = random.Next(2, fieldHeigth - 2);
            return new Point(x, y, sym);
        }
        


    }
}

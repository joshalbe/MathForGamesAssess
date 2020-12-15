using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class ObstacleGeneration : Actor
    {
        public static List<Obstacle> ObstacleList = new List<Obstacle>();


        public ObstacleGeneration()
        {
            for (int i = 1; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    Obstacle _wallV = new Obstacle(82, 100 + (54 * i));
                    AddChild(_wallV);
                }
            }


            //Level 1
            //if (LevelController.currentLevel == 1)
            //{
            for (int i = 1; i < 10; i++)
            {
                if (i == 9)
                {
                    Obstacle _wallV = new Obstacle(800, 100 + (54 * i));
                    AddChild(_wallV);
                }
                if (i % 2 == 0)
                {
                    Obstacle _wallV = new Obstacle(500, 100 + (54 * i));
                    AddChild(_wallV);
                }
            }

            

            for (int i = 1; i < 22; i++)
            {
                if (i > 15 && i < 21 && i % 2 == 0)
                {
                    Obstacle _wallH = new Obstacle(46 + (54 * i), 400);
                    AddChild(_wallH);
                }
            }
            //}
        }
    }
}

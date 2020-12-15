using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class Obstacle : Entity
    {
        private Sprite _sprite = new Sprite("Images/meteorBrown_med1.png");
        public AABB _hitbox;

        public Obstacle(float x, float y) : base(x, y)
        {
            _hitbox = new AABB(_sprite.Width, _sprite.Height);

            AddChild(_hitbox);
            AddChild(_sprite);

            _sprite.X = XAbsolute - 53;
            _sprite.Y = YAbsolute - 35;

            ObstacleGeneration.ObstacleList.Add(this);
        }
    }
}

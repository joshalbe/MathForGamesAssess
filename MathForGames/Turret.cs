using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class Turret : Entity
    {
        private Sprite _sprite = new Sprite("Images/gun07.png");


        public Turret(float x, float y) : base(x, y)
        {
            AddChild(_sprite);
        }

        public void Fire()
        {
            Projectile bulletOne = new Projectile(XAbsolute, YAbsolute);
            bulletOne.Rotate(GetRotation());
            bulletOne.XVelocity = (float)Math.Cos(GetRotation() - Math.PI * .5f) * 400;
            bulletOne.YVelocity = (float)Math.Sin(GetRotation() - Math.PI * .5f) * 400;

            _parent._parent.AddChild(bulletOne);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TestLibrary;

namespace MathForGames
{
    class Entity : Actor
    {
        private Vector3 _velocity = new Vector3();
        private Vector3 _acceleration = new Vector3();

        public float XVelocity
        {
            //## Implement velocity on the X axis ##//
            get { return _velocity.X; }
            set { _velocity.X = value; }
        }
        public float XAcceleration
        {
            //## Implement acceleration on the X axis ##//
            get { return _acceleration.X; }
            set { _acceleration.X = value; }
        }
        public float YVelocity
        {
            //## Implement velocity on the Y axis ##//
            get { return _velocity.Y; }
            set { _velocity.Y = value; }
        }
        public float YAcceleration
        {
            //## Implement acceleration on the Y axis ##//
            get { return _acceleration.Y; }
            set { _acceleration.Y = value; }
        }

        //Creates an Entity at the specified coordinates
        public Entity(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override void Update(float deltaTime)
        {
            //## Calculate velocity from acceleration ##//
            XVelocity = XVelocity + XAcceleration * deltaTime;
            YVelocity = YVelocity + YAcceleration * deltaTime;
            //## Calculate position from velocity ##//
            X += XVelocity * deltaTime;
            Y += YVelocity * deltaTime;
            base.Update(deltaTime);
        }
    }
}

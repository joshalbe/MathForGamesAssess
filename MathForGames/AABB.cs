﻿using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace MathForGames
{
    class AABB : Actor
    {
        public float Width { get; set; } = 1;
        public float Height { get; set; } = 1;

        //Returns the Y coordinate at the top of the box
        public float Top
        {
            get { return YAbsolute - Height / 2; }
        }

        //Returns the Y coordinate at the top of the box
        public float Bottom
        {
            get { return YAbsolute + Height / 2; }
        }

        //Returns the X coordinate at the top of the box
        public float Left
        {
            get { return XAbsolute - Width / 2; }
        }

        //Returns the X coordinate at the top of the box
        public float Right
        {
            get { return XAbsolute + Width / 2; }
        }

        //Creates an AABB of the specifed size
        public AABB(float width, float height)
        {
            Width = width;
            Height = height;
            X = -Width / 2;
            Y = -Height / 2;
        }

        public bool DetectCollision(AABB other)
        {
            //## Implement DetectCollision(AABB) ##//

            if (Right >= other.Left && Bottom >= other.Top && Left <= other.Right && Top <= other.Bottom)
            {
                return true;
            }

            return false;
        }

        //public bool DetectCollision(Vector3 point)
        //{
        //    //## Implement DetectCollision(Vector3) ##//
        //    return false;
        //}

        //Draw the bounding box to the screen
        public override void Draw()
        {
            //Raylib.Rectangle rec = new Raylib.Rectangle(Left, Top, Width, Height);
            //Raylib.Raylib.DrawRectangleLinesEx(rec, 1, color);
            base.Draw();
        }
    }
}

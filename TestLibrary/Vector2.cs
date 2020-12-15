using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Vector2
    {
        private float _x;
        private float _y;

        //Get-Set for the X value
        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        //Get-Set for the Y value
        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        //gets the magnitude of a vector2
        public float Magnitude
        {
            get { return (float)Math.Sqrt(X * X + Y * Y); }
        }

        //gets the normalization of a vector2
        public Vector2 Normalized
        {
            get { return Normalize(this); }
        }

        //Normal constructor
        public Vector2()
        {
            _x = 0;
            _y = 0;
        }

        //Custom vector2 constructor
        public Vector2(float x, float y)
        {
            _x = x;
            _y = y;
        } 

        //Normalizes a specified vector2
        public static Vector2 Normalize(Vector2 vector)
        {
            if (vector.Magnitude == 0)
                return new Vector2();
            return vector / vector.Magnitude;
        }

        //Finds the dot product between two vector2s
        public static float DotProduct(Vector2 lhs, Vector2 rhs)
        {
            return (lhs.X * rhs.X) + (lhs.Y * rhs.Y);
        }

        //Finds the angle of two vector2s
        public static float FindAngle(Vector2 lhs, Vector2 rhs)
        {
            //Normalizes both vectors
            lhs = lhs.Normalized;
            rhs = rhs.Normalized;

            float dotProduct = DotProduct(lhs, rhs);

            //check that the dotproduct is greater than 1
            if (Math.Abs(dotProduct) > 1)
                return 0;

            float angle = (float)Math.Acos(dotProduct);

            //create a perpendicular angle
            Vector2 perpendicular = new Vector2(rhs.Y, -rhs.X);

            //retrieve the dotproduct of the perpendicular angle
            float perpendicularDot = DotProduct(perpendicular, lhs);

            if (perpendicularDot != 0)
                angle *= perpendicularDot / Math.Abs(perpendicularDot);

            //return the angle between the two vectors
            return angle;
        } 

        //Add two vectors
        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.X += rhs.X, lhs.Y += rhs.Y);
        } 

        //subtract a vector from another
        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.X - rhs.X, lhs.Y - rhs.Y);
        } 

        //scale a vector
        public static Vector2 operator *(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.X * scalar, lhs.Y * scalar);
        } 

        //second scalar multiplication
        public static Vector2 operator *(float scalar, Vector2 lhs)
        {
            return new Vector2(lhs.X * scalar, lhs.Y * scalar);
        } 

        //divide a vector by a scalar
        public static Vector2 operator /(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.X / scalar, lhs.Y / scalar);
        } 
    }
}

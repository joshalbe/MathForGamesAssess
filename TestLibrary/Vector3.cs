using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Vector3
    {
        private float _x;
        private float _y;
        private float _z;

        //Get-Set X value
        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        //Get-Set Y value
        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        //Get-Set Z value
        public float Z
        {
            get { return _z; }
            set { _z = value; }
        }

        //Get the magnitude of a Vector3
        public float Magnitude
        {
            get { return (float)Math.Sqrt(X * X + Y * Y + Z * Z); }
        }

        //Get the normalized Vector3
        public Vector3 Normalized
        {
            get { return Normalize(this); }
        }

        //Constructor
        public Vector3()
        {
            _x = 0;
            _y = 0;
            _z = 0;
        }

        //Custom constructor
        public Vector3(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public static Vector3 Normalize(Vector3 vector)
        {
            //If the vector isn't already 1, 
            if (vector.Magnitude == 0)
                return new Vector3();
            //reutrn the new vector normalized
            return vector / vector.Magnitude;
        }

        //find the dotproduct of two vectors
        public static float DotProduct(Vector3 lhs, Vector3 rhs)
        {
            return (lhs.X * rhs.X) + (lhs.Y * rhs.Y) + (lhs.Z * rhs.Z);
        } 

        //find the crossproduct of two vectors
        public static Vector3 CrossProduct(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.Y * rhs.Z - lhs.Z * rhs.Y, 
                               lhs.Z * rhs.X - lhs.X * rhs.Z,
                               lhs.X * rhs.Y - lhs.Y * rhs.X);
        } 

        //multiply a matrix3 by a vector3
        public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        {
            return new Vector3(
                rhs.X * lhs.m11 + rhs.Y * lhs.m12 + rhs.Z * lhs.m13,
                rhs.X * lhs.m21 + rhs.Y * lhs.m22 + rhs.Z * lhs.m23,
                rhs.X * lhs.m31 + rhs.Y * lhs.m32 + rhs.Z * lhs.m33);
        } 

        //add two vectors together
        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        } 

        //subtract a vector from another
        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        } 

        //multiply a vector by a scalar
        public static Vector3 operator *(Vector3 lhs, float scalar)
        {
            return new Vector3(lhs.X * scalar, lhs.Y * scalar, lhs.Z * scalar);
        } 

        public static Vector3 operator *(float scalar, Vector3 lhs)
        {
            return new Vector3(lhs.X * scalar, lhs.Y * scalar, lhs.Z * scalar);
        } 

        //divide a vector by a scalar
        public static Vector3 operator /(Vector3 lhs, float scalar)
        {
            return new Vector3(lhs.X / scalar, lhs.Y / scalar, lhs.Z / scalar);
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Vector4
    {
        private float _x;
        private float _y;
        private float _Z;
        private float _w;

        public Vector4(float X, float Y, float Z, float W)
        {
            _x = X;
            _y = Y;
            _Z = Z;
            _w = W;
        }

        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public float Z
        {
            get
            {
                return _Z;
            }
            set
            {
                _Z = value;
            }
        }

        public float W
        {
            get
            {
                return _w;
            }
            set
            {
                _w = value;
            }
        }

        public float Magnitude(Vector4 input)
        {
            return (float)Math.Sqrt(_x * input.X + _y * input.Y + Z * input.Z + W * input.W);
        }

        public float Distance(Vector4 input)
        {
            float DiffX = _x - input._x;
            float DiffY = _y - input._y;
            float DiffZ = Z - input.Z;
            float DiffW = _w - input._w;
            return (float)Math.Sqrt(DiffX * DiffX + DiffY * DiffY + DiffZ * DiffZ + DiffW * DiffW);
        }

        public float DistanceSq(Vector4 input)
        {
            return (float)Math.Pow(Distance(input), 2);
        }

        public static Vector4 operator *(Vector4 lhs, float rhs)
        {
            return new Vector4(lhs._x * rhs,
                               lhs._y * rhs,
                               lhs.Z * rhs,
                               lhs.W * rhs);
        }

        public static Vector4 operator *(float rhs, Vector4 lhs)
        {
            return new Vector4(lhs._x * rhs,
                               lhs._y * rhs,
                               lhs.Z * rhs,
                               lhs.W * rhs);
        }

        public static Vector4 operator /(Vector4 lhs, float rhs)
        {
            return new Vector4(lhs._x / rhs,
                               lhs._y / rhs,
                               lhs.Z / rhs,
                               lhs.W / rhs);
        }

        public static Vector4 operator /(float lhs, Vector4 rhs)
        {
            return new Vector4(lhs / rhs.X,
                              lhs / rhs.Y,
                              lhs / rhs.Z,
                              lhs / rhs.W);
        }

        public static Vector4 operator -(Vector4 lhs, float rhs)
        {
            return new Vector4(lhs._x - rhs,
                               lhs._y - rhs,
                               lhs.Z - rhs,
                               lhs.W - rhs);
        }

        public static Vector4 operator +(Vector4 lhs, float rhs)
        {
            return new Vector4(lhs._x + rhs,
                               lhs._y + rhs,
                               lhs.Z + rhs,
                               lhs.W + rhs);
        }

        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs._x + rhs.X,
                               lhs._y + rhs.Y,
                               lhs.Z + rhs.Z,
                               lhs.W + rhs.W);
        }

        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs._x - rhs.X,
                               lhs._y - rhs.Y,
                               lhs.Z - rhs.Z,
                               lhs.W - rhs.W);
        }

        public Vector4 Cross(Vector4 Input)
        {
            float varOne = (_y * Input.Z) - (Z * Input._y);
            float varTwo = (Z * Input._x) - (_x * Input.Z);
            float varThree = (_x * Input._y) - (_y * Input._x);

            Vector4 answer = new Vector4(varOne, varTwo, varThree, 0);
            return answer;
        }

        public float Dot(Vector4 input)
        {
            return (_x * input.X + _y * input.Y + _Z * input.Z + W * input.W);
        }

        public void Normalize()
        {
            float m = Magnitude();
            _x /= m;
            _y /= m;
            _Z /= m;
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(_x * _x + _y * _y + _Z * _Z + _w * _w);
        }
    }
}
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

        //static refernce to identity matrix
        public Vector3() : this(0f, 0f, 0f)
        {

        }

        public Vector3(float X, float Y, float Z)
        {
            _x = X;
            _y = Y;
            _z = Z;
        }

        public float x
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

        public float y
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

        public float z
        {
            get
            {
                return _z;
            }
            set
            {
                _z = value;
            }
        }

        public static Vector3 operator /(Vector3 lhs, float rhs)
        {
            return new Vector3(lhs._x / rhs, lhs._y / rhs, lhs._z / rhs);
        }

        public static Vector3 operator *(Vector3 lhs, float rhs)
        {
            return new Vector3(lhs._x * rhs, lhs._y * rhs, lhs._z * rhs);
        }

        public static Vector3 operator *(float rhs, Vector3 lhs)
        {
            return new Vector3(lhs._x * rhs, lhs._y * rhs, lhs._z * rhs);
        }

        public static Vector3 operator -(Vector3 lhs, float rhs)
        {
            return new Vector3(lhs._x - rhs, lhs._y - rhs, lhs._z - rhs);
        }

        public static Vector3 operator -(Vector3 rhs, Vector3 lhs)
        {
            return new Vector3(rhs._x - lhs._x, rhs._y - lhs._y, rhs._z - lhs._z);
        }

        public static Vector3 operator +(Vector3 rhs, Vector3 lhs)
        {
            return new Vector3(lhs._x + rhs._x, lhs._y + rhs._y, lhs._z + rhs._z);
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(_x * _x + _y * _y + _z * _z);
        }

        public float MagnitudeSqr()
        {
            return (_x * _x + _y * _y + _z * _z);
        }

        public float Distance(Vector3 input)
        {
            float DiffX = _x - input._x;
            float DiffY = _y - input._y;
            float DiffZ = _z - input._z;
            return (float)Math.Sqrt(DiffX * DiffX + DiffY * DiffY + DiffZ * DiffZ);
        }

        public float DistanceSq(Vector3 input)
        {
            return (float)Math.Pow(Distance(input), 2);
        }

        public float Dot(Vector3 input)
        {
            return (_x * input.x + _y * input.y + _z * input.z);
        }

        public Vector3 Cross(Vector3 Input)
        {
            float varOne = (_y * Input.z) - (_z * Input._y);
            float varTwo = (_z * Input._x) - (_x * Input._z);
            float varThree = (_x * Input._y) - (_y * Input._x);

            Vector3 answer = new Vector3(varOne, varTwo, varThree);
            return answer;
        }

        public void Normalize()
        {
            float m = Magnitude();
            _x /= m;
            _y /= m;
            _z /= m;
        }

        public Vector3 GetNormalized()
        {
            return (this / Magnitude());
        }

        public float Angle(Vector3 input)
        {
            Vector3 a = GetNormalized();
            Vector3 b = GetNormalized();
            return (float)Math.Acos(a.Dot(b));
        }

        public override string ToString()
        {
            return "[" + _x + "," + _y + "," + _z + "]";
        }
    }
}

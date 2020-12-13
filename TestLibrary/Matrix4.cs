using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Matrix4
    {
        public float m11, m21, m31, m41, m12, m22, m32, m42, m13, m23, m33, m43, m14, m24, m34, m44;


        public static Matrix4 identity = new Matrix4();
        //Creates a Matrix3 equal to the identity matrix
        public Matrix4()
        {
            m11 = 1; m21 = 0; m31 = 0; m41 = 0;
            m12 = 0; m22 = 1; m32 = 0; m42 = 0;
            m13 = 0; m23 = 0; m33 = 1; m43 = 0;
            m14 = 0; m24 = 0; m34 = 0; m44 = 1;
        }

        //Creates a Matrix3 with the specified values
        public Matrix4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
        {
            this.m11 = m11; this.m21 = m12; this.m31 = m13; this.m41 = m14;
            this.m12 = m21; this.m22 = m22; this.m32 = m23; this.m42 = m24;
            this.m13 = m31; this.m23 = m32; this.m33 = m33; this.m43 = m34;
            this.m14 = m41; this.m24 = m42; this.m34 = m43; this.m44 = m44;

        }

        public override string ToString()
        {
            return "[" + m11 + "," + m21 + "," + m31 + "," + m41 + "]" +
                   "\n[" + m12 + "," + m22 + "," + m32 + "," + m42 + "]" +
                   "\n[" + m13 + "," + m23 + "," + m33 + "," + m43 + "]" +
                   "\n[" + m14 + "," + m24 + "," + m34 + "," + m44 + "]";

        }

        public static Matrix4 operator *(Matrix4 rhs, Matrix4 lhs)
        {
            return new Matrix4(
                lhs.m11 * rhs.m11 + lhs.m21 * rhs.m12 + lhs.m31 * rhs.m13 + lhs.m41 * rhs.m14,
                lhs.m11 * rhs.m21 + lhs.m21 * rhs.m22 + lhs.m31 * rhs.m23 + lhs.m41 * rhs.m24,
                lhs.m11 * rhs.m31 + lhs.m21 * rhs.m32 + lhs.m31 * rhs.m33 + lhs.m41 * rhs.m34,
                lhs.m11 * rhs.m41 + lhs.m21 * rhs.m42 + lhs.m31 * rhs.m43 + lhs.m41 * rhs.m44,

                lhs.m12 * rhs.m11 + lhs.m22 * rhs.m12 + lhs.m32 * rhs.m13 + lhs.m42 * rhs.m14,
                lhs.m12 * rhs.m21 + lhs.m22 * rhs.m22 + lhs.m32 * rhs.m23 + lhs.m42 * rhs.m24,
                lhs.m12 * rhs.m31 + lhs.m22 * rhs.m32 + lhs.m32 * rhs.m33 + lhs.m42 * rhs.m34,
                lhs.m12 * rhs.m41 + lhs.m22 * rhs.m42 + lhs.m32 * rhs.m43 + lhs.m42 * rhs.m44,

                lhs.m13 * rhs.m11 + lhs.m23 * rhs.m12 + lhs.m33 * rhs.m13 + lhs.m43 * rhs.m14,
                lhs.m13 * rhs.m21 + lhs.m23 * rhs.m22 + lhs.m33 * rhs.m23 + lhs.m43 * rhs.m24,
                lhs.m13 * rhs.m31 + lhs.m23 * rhs.m32 + lhs.m33 * rhs.m33 + lhs.m43 * rhs.m34,
                lhs.m13 * rhs.m41 + lhs.m23 * rhs.m42 + lhs.m33 * rhs.m43 + lhs.m43 * rhs.m44,

                lhs.m14 * rhs.m11 + lhs.m24 * rhs.m12 + lhs.m34 * rhs.m13 + lhs.m44 * rhs.m14,
                lhs.m14 * rhs.m21 + lhs.m24 * rhs.m22 + lhs.m34 * rhs.m23 + lhs.m44 * rhs.m24,
                lhs.m14 * rhs.m31 + lhs.m24 * rhs.m32 + lhs.m34 * rhs.m33 + lhs.m44 * rhs.m34,
                lhs.m14 * rhs.m41 + lhs.m24 * rhs.m42 + lhs.m34 * rhs.m43 + lhs.m44 * rhs.m44);
        }

        public static Vector4 operator *(Matrix4 lhs, Vector4 rhs)
        {
            return new Vector4(
                lhs.m11 * rhs.X + lhs.m12 * rhs.Y + lhs.m13 * rhs.Z + lhs.m14 * rhs.W,
                lhs.m21 * rhs.X + lhs.m22 * rhs.Y + lhs.m23 * rhs.Z + lhs.m24 * rhs.W,
                lhs.m31 * rhs.X + lhs.m32 * rhs.Y + lhs.m33 * rhs.Z + lhs.m34 * rhs.W,
                lhs.m41 * rhs.X + lhs.m42 * rhs.Y + lhs.m43 * rhs.Z + lhs.m44 * rhs.W);

        }

        public static Matrix4 CreateIdentity()
        {
            return new Matrix4(1.0f, 0.0f, 0.0f, 0.0f,
                0.0f, 1.0f, 0.0f, 0.0f,
                0.0f, 0.0f, 1.0f, 0.0f,
                0.0f, 0.0f, 0.0f, 1.0f);
        }

        public void SetRotateX(double radians)
        {
            Set(1, 0, 0, 0,
                0, (float)Math.Cos(radians), (float)Math.Sin(radians), 0,
                0, (float)-Math.Sin(radians), (float)Math.Cos(radians), 0,
                0, 0, 0, 1);

        }

        public void RotateX(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateX(radians);
            Set(this * m);
        }

        //rotate around Y axis
        public void SetRotateY(double radians)
        {
            Set((float)Math.Cos(radians), 0, (float)-Math.Sin(radians), 0,
                0, 1, 0, 0,
                (float)Math.Sin(radians), 0, (float)Math.Cos(radians), 0,
                0, 0, 0, 1);
        }

        public void RotateY(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateY(radians);
            Set(this * m);
        }

        //Rotate around Z axis
        public void SetRotateZ(double radians)
        {
            Set((float)Math.Cos(radians), (float)Math.Sin(radians), 0, 0,
                 (float)-Math.Sin(radians), (float)Math.Cos(radians), 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1);

        }

        public void RotateZ(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateZ(radians);
            Set(this * m);
        }

        public void Set(Matrix4 Matrix4)
        {
            m11 = Matrix4.m11; m21 = Matrix4.m21; m31 = Matrix4.m31;
            m12 = Matrix4.m12; m22 = Matrix4.m22; m32 = Matrix4.m32;
            m13 = Matrix4.m13; m23 = Matrix4.m23; m33 = Matrix4.m33;
        }

        public void Set(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
        {
            this.m11 = m11; this.m21 = m12; this.m31 = m13; this.m41 = m14;
            this.m12 = m21; this.m22 = m22; this.m32 = m23; this.m42 = m24;
            this.m13 = m31; this.m23 = m32; this.m33 = m33; this.m43 = m34;
            this.m14 = m41; this.m24 = m42; this.m34 = m43; this.m44 = m44;
        }

        public void SetScaled(Vector4 v)
        {
            m11 = v.X; m21 = 0; m31 = 0; m41 = 0;
            m12 = 0; m22 = v.Y; m32 = 0; m42 = 0;
            m13 = 0; m23 = 0; m33 = v.Z; m43 = 0;
            m14 = 0; m24 = 0; m34 = 0; m44 = v.W;

        }

        public void SetScaled(float x, float y, float z)
        {
            m11 = x; m21 = 0; m31 = 0; m41 = 0;
            m12 = 0; m22 = y; m32 = 0; m42 = 0;
            m13 = 0; m23 = 0; m33 = z; m43 = 0;
            m14 = 0; m24 = 0; m34 = 0; m44 = 1;
        }

        public void SetTranslation(float x, float y, float z)
        {
            m41 = x; m42 = y; m43 = z; m44 = 1;
        }

        public void Translate(float x, float y, float z)
        {
            //apply vector offset
            m41 += x; m42 += y; m43 += z;
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Matrix3
    {
        public float m11, m12, m13, m21, m22, m23, m31, m32, m33;

        //Matrix3 Constructor
        public Matrix3()
        {
            m11 = 1; m12 = 0; m13 = 0;
            m21 = 0; m22 = 1; m23 = 0;
            m31 = 0; m32 = 0; m33 = 1;
        }

        //Custom Matrix3 Constructor
        public Matrix3(float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32, float m33)
        {
            this.m11 = m11; this.m12 = m12; this.m13 = m13;
            this.m21 = m21; this.m22 = m22; this.m23 = m23;
            this.m31 = m31; this.m32 = m32; this.m33 = m33;
        }

        public void Set(float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32, float m33)
        {
            this.m11 = m11; this.m12 = m12; this.m13 = m13;
            this.m21 = m21; this.m22 = m22; this.m23 = m23;
            this.m31 = m31; this.m32 = m32; this.m33 = m33;
        }

        public void Set(Matrix3 matrix3)
        {
            m11 = matrix3.m11; m12 = matrix3.m12; m13 = matrix3.m13;
            m21 = matrix3.m21; m22 = matrix3.m22; m23 = matrix3.m23;
            m31 = matrix3.m31; m32 = matrix3.m32; m33 = matrix3.m33;
        }

        public static Matrix3 CreateRotation(float radians)
        {
            //rotates the Matrix based on the given radians
            return new Matrix3(
                               (float)(Math.Cos(radians)), (float)(Math.Sin(radians)), 0,
                               (float)(-1 * Math.Sin(radians)), (float)(Math.Cos(radians)), 0,
                               0, 0, 1
                              );
        } 

        public static Matrix3 CreateTranslation(Vector2 position)
        {
            //Translates the Matrix3 to a new given position
            return new Matrix3(
                               1, 0, position.X,
                               0, 1, position.Y,
                               0, 0, 1);
        }

        public void SetTranslation(float x, float y, float z)
        {
            m13 = x; m23 = y; m33 = z;
        }

        public void SetRotateZ(double radians)
        {
            Set((float)Math.Cos(radians), (float)-Math.Sin(radians), 0,
                (float)Math.Sin(radians), (float)Math.Cos(radians), 0,
                0, 0, 1);
        }

        public void RotateZ(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateZ(radians);
            Set(this * m);
        }

        public static Matrix3 CreateScale(float xScale, float yScale)
        {
            //Scales the Matrix3 according to given x and y
            return new Matrix3(
                               xScale, 0, 0,
                               0, yScale, 0,
                               0, 0, 1);
        } 

        public static Matrix3 operator +(Matrix3 lhs, Matrix3 rhs)
        {
            //Adds matrices
            return new Matrix3(
                lhs.m11 + rhs.m11, lhs.m12 + rhs.m12, lhs.m13 + rhs.m13,
                lhs.m21 + rhs.m21, lhs.m22 + rhs.m22, lhs.m23 + rhs.m23,
                lhs.m31 + rhs.m31, lhs.m32 + rhs.m32, lhs.m33 + rhs.m33);
        } 

        public static Matrix3 operator -(Matrix3 lhs, Matrix3 rhs)
        {
            //subtracts two matrices
            return new Matrix3(
                lhs.m11 - rhs.m11, lhs.m12 - rhs.m12, lhs.m13 - rhs.m13,
                lhs.m21 - rhs.m21, lhs.m22 - rhs.m22, lhs.m23 - rhs.m23,
                lhs.m31 - rhs.m31, lhs.m32 - rhs.m32, lhs.m33 - rhs.m33);
        } 

        public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
        {

            //Multiplies matrices
            return new Matrix3(
                lhs.m11 * rhs.m11 + lhs.m12 * rhs.m21 + lhs.m13 * rhs.m31, 
                lhs.m11 * rhs.m12 + lhs.m12 * rhs.m22 + lhs.m13 * rhs.m32, 
                lhs.m11 * rhs.m13 + lhs.m12 * rhs.m23 + lhs.m13 * rhs.m33, 

                lhs.m21 * rhs.m11 + lhs.m22 * rhs.m21 + lhs.m23 * rhs.m31, 
                lhs.m21 * rhs.m12 + lhs.m22 * rhs.m22 + lhs.m23 * rhs.m32, 
                lhs.m21 * rhs.m13 + lhs.m22 * rhs.m23 + lhs.m23 * rhs.m33, 

                lhs.m31 * rhs.m11 + lhs.m32 * rhs.m21 + lhs.m33 * rhs.m31, 
                lhs.m31 * rhs.m12 + lhs.m32 * rhs.m22 + lhs.m33 * rhs.m32, 
                lhs.m31 * rhs.m13 + lhs.m32 * rhs.m23 + lhs.m33 * rhs.m33); 
        } 
    }
}
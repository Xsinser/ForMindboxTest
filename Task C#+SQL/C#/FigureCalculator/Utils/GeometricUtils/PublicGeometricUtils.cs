using FigureCalculator.Enums;
using FigureCalculator.Figure;
using FigureCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalculator.Utils.GeometricUtils
{
    internal static partial class GeometricUtils
    {
        internal static float HeronFormula(float a, float b, float c)
        {
            float p = (a + b + c) * 0.5f;
            return (float)Math.Sqrt((p - a) * (p - b) * (p - c) * p);
        }
        internal static float CircleArea(float radius)
        {
            return (float)Math.PI * MathF.Pow(radius, 2);
        }
        internal static TraingleType GetTriangleTypeByCorners(Triangle triangle)
        {
            TriangleTypeByCorners triangleTypeByCorners;
            if (IsRightTriangle(triangle))
            {
                triangleTypeByCorners = TriangleTypeByCorners.Right;
            }
            else //Не реализованн третий тип треугольника по углам
            {
                triangleTypeByCorners = TriangleTypeByCorners.Sharp;
            }

            return new TraingleType(triangleTypeByCorners);
        }
    }
}

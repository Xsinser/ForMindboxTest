using FigureCalculator.Enums;
using FigureCalculator.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigureCalculator.Utils.GeometricUtils
{
    internal static partial class GeometricUtils
    {
        private static bool IsRightTriangle(Triangle triangle)
        {
            List<float> arr = new List<float>{ triangle.A, triangle.B, triangle.C };
            float c = arr.Max();
            float leftPart = (float)Math.Pow(c, 2);
            arr.Remove(c);
            float rightPart = 0;
            for(int i = 0; i< arr.Count; i++)
            {
                rightPart += (float)Math.Pow(arr[i], 2);
            }
            if (rightPart == leftPart)
                return true;
            else
                return false;
        }
    }
}

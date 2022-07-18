using FigureCalculator.Enums;
using FigureCalculator.Interfaces;
using FigureCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalculator.Figure.Extension
{
    public static class TriangleExtension
    {
        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns> true - прямоугольный треугольник, false - не прямоугольный треугольник </returns>
        public static bool IsRightTriangle(this IType<TraingleType> triangle)  
        {
            return triangle.GetType.TriangleTypeByCorners == TriangleTypeByCorners.Right;
        }
    }
}

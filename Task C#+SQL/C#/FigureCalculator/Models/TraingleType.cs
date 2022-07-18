using FigureCalculator.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalculator.Models
{
    public struct TraingleType
    {
        public TriangleTypeByCorners TriangleTypeByCorners { get;  }

        // Оставльное место под Тип треугольника по его сторонам

        public TraingleType(TriangleTypeByCorners triangleTypeByCorners)
        {
            TriangleTypeByCorners = triangleTypeByCorners;
        }
    }
}

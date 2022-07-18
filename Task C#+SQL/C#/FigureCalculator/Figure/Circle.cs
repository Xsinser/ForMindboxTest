using FigureCalculator.Interfaces;
using FigureCalculator.Utils;
using FigureCalculator.Utils.GeometricUtils;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalculator.Figure
{
    public class Circle : Figure
    {

        public float Radius { get; }
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public override float Area
        {
            get
            {
                if (_area == -1)
                {
                    _area = (float)Math.Round(GeometricUtils.CircleArea(Radius), 3);
                }
                return _area;
            }
        }
        private float _area = -1;
        public Circle(float radius)
        {
            ExceptionsUtils.NegativeExcpetionCheck(radius);
            Radius = radius;
        }
    }
}

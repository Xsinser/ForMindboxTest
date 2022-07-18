using FigureCalculator.Interfaces;
using FigureCalculator.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using FigureCalculator.Utils.GeometricUtils;
using FigureCalculator.Enums;
using FigureCalculator.Models;

namespace FigureCalculator.Figure
{
    public class Triangle : Figure, IType<TraingleType>
    {
        #region Публичное

        #region Свойства
        public float A { get; }
        public float B { get; }
        public float C { get; }
        public override float Area
        {
            get
            {
                if (_area == -1)
                {
                    _area = (float)Math.Round(GeometricUtils.HeronFormula(A, B, C), 3);
                }
                return _area;
            }
        }
        public TraingleType GetType
        {
            get
            {
                if (!this._triangleTypeByCorners.HasValue)
                {
                    _triangleTypeByCorners = GeometricUtils.GetTriangleTypeByCorners(this);
                }
                return this._triangleTypeByCorners.Value;
            }
        }
        #endregion


        #region Конструкторы
        public Triangle(float a, float b, float c)
        {
            ExceptionsUtils.NegativeExcpetionCheck(a, b, c);
            A = a;
            B = b;
            C = c;
        }


        #endregion

        #endregion


        #region Приватное
        private Triangle() { }

        private float _area = -1;
        private TraingleType? _triangleTypeByCorners = null;
        #endregion
    }
}

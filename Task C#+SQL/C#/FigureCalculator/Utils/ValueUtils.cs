using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalculator.Utils
{
    internal static class ValueUtils
    {
        /// <summary>
        /// Проверка значения на отрицательность
        /// </summary>
        /// <param name="value"></param>
        /// <returns> true - не отрицательное значение, false - положительное  </returns>
        internal static bool IsPositiveValue(float value)
        {
            return value >= 0;
        }
    }
}

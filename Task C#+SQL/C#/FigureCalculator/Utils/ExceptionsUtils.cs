using FigureCalculator.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalculator.Utils
{
    internal static class ExceptionsUtils
    {
        /// <summary>
        /// Проверяет значения на отрицательность. В случае отрицательного значения - генерирует исключение
        /// </summary>
        /// <param name="value"></param>
        internal static void NegativeExcpetionCheck(params float[] values)
        {
            for (int i = 0; i < values.Length; i++)
            { 
                NegativeExcpetionCheck(value: values[i]);
            }

        }
        /// <summary>
        /// Проверяет значение на отрицательность. В случае отрицательного значения - генерирует исключение
        /// </summary>
        /// <param name="value"></param>
        internal static void NegativeExcpetionCheck(float value)
        {
            if (!ValueUtils.IsPositiveValue(value))
            {
                throw new NegativeException("The transmitted value is a negative.", value);
            }
        }
    }
}

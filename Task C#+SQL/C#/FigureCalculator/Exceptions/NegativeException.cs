using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalculator.Exceptions
{
    [Serializable]
    ////Кастомнаый эксепшен, нужен для проверки радиуса и длинны сторон на положительное значение
    class NegativeException : Exception
    {
        public float Value { get; }

        public NegativeException(string message, float value)
            : base(message)
        {
            Value = value;
        }
        public NegativeException(string message, Exception innerException, float value)
            : base(message, innerException)
        {
            Value = value;
        }
    }
}

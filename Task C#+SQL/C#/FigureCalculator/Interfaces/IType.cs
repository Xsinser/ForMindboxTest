using FigureCalculator.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalculator.Interfaces
{
    public interface IType<T>
    {
        public T GetType { get; }
    }
}

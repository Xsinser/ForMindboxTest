using FigureCalculator.Figure;
using FigureCalculator.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FigureCalculator.Figure.Extension;
using FigureCalculator.Models;

namespace FigureCalculator.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Creation_TestWith_FullCorrectValue()
        {

            Figure.Figure triangle = new Triangle(1, 1, 1);
        }
        [TestMethod]

        public void Creation_TestWith_InCorrectValueA()
        {
            Exception exception = null;
            try
            {
                Figure.Figure triangle = new Triangle(-1, 1, 1);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }

        [TestMethod]
        public void Creation_TestWith_InCorrectValueB()
        {
            Exception exception = null;
            try
            {
                Figure.Figure triangle = new Triangle(1, -1, 1);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }

        [TestMethod]
        public void Creation_TestWith_InCorrectValueC()
        {
            Exception exception = null;
            try
            {
                Figure.Figure triangle = new Triangle(1, 1, -1);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }

        [TestMethod]
        public void Area_TestWith_IntValue()
        {
            int[] input = new int[] { 52, 64, 34 };
            float output = 882.029F;

            Figure.Figure triangle = new Triangle(input[0], input[1], input[2]);
            Assert.AreEqual(output, triangle.Area);

        }

        [TestMethod]
        public void Area_TestWith_FloatValue()
        {
            float[] input = new float[] { 5.2F, 6.4F, 3.4F };
            float output = 8.820F;

            Figure.Figure triangle = new Triangle(input[0], input[1], input[2]);
            Assert.AreEqual(output, triangle.Area);

        }

        [TestMethod]
        public void RightTriangle_TestWith_CorrectValue()
        {
            float[] input = new float[] { 10F, 6F, 8F };

            IType<TraingleType> triangle = new Triangle(input[0], input[1], input[2]);
            Assert.AreEqual(true, triangle.IsRightTriangle());

        }

        [TestMethod]
        public void RightTriangle_TestWith_InCorrectValue()
        {
            float[] input = new float[] { 10F, 6.4F, 3.4F };
            IType<TraingleType> triangle = new Triangle(input[0], input[1], input[2]);
            Assert.AreEqual(false, triangle.IsRightTriangle());

        }
    }
}

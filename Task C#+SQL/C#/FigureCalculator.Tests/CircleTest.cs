using FigureCalculator.Figure;
using FigureCalculator.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting; 
using System;

namespace FigureCalculator.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Creation_TestWith_CorrectValue()
        {

            Figure.Figure circle = new Circle(1);

        }

        [TestMethod]
        public void Creation_TestWith_InCorrectValue()
        {
            Exception exception = null;
            try
            {
                Figure.Figure circle = new Circle(-1);
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
            int input = 67987;
            float output = 14521170625;

            Figure.Figure circle = new Circle(input);            
            Assert.AreEqual(output, circle.Area);

        }

        [TestMethod]
        public void Area_TestWith_FloatValue()
        {
            float input = 6.7987F;
            float output = 145.212F;

            Figure.Figure circle = new Circle(input);
            Assert.AreEqual(output, circle.Area);

        }
    }
}

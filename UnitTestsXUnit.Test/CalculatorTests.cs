using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestsXUnit;
using Xunit;

namespace UnitTestsXUnit.Test
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_SimpleValuesShouldCalculate()
        {
            //Arrange
            double expected = 5;

            //Act
            double actual = Calculator.Add(2, 3);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

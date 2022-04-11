using Xunit;

namespace Calculator1.Tests
{

    public class UnitTest1
    {
        private readonly CMethods cM;

        public UnitTest1()
        {
            cM = new CMethods();
        }


        [Theory]
        [InlineData(4.5, 9.7, 14.2)]
        [InlineData(-10.2, -9.7, -19.9)]
        [InlineData(4.0, 51.1, 55.1)]

        public void AddTest(double num1, double num2, double expected)
        {

            //Act

            double actual = cM.Add(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void AddArrayTest()
        {

            //Arrange
            double[] d = new double[] { 3, 7, 8 };
            double expectedValue = 18;


            //Act
            var div = cM.Add(d);

            //Assert
            Assert.Equal(expectedValue, div);
        }

        [Fact]
        public void SubtractTest()
        {
            //Arrange
            double expected = 15.0;

            //Act
           double actual = cM.Subtract(20.0, 5.0);

            //Assertion
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void SubtractArrayTest()
        {
            //Arrange
            double[] d = new double[] { 3, 7, 8 };
            double expectedValue = -12;

            //Act
            var div = cM.Subtract(d);

            //Assert
            Assert.Equal(expectedValue, div);
        }


        [Fact]
        public void MultiplyTest()
        {
            //Arrange
            double expected = 20;

            //act
            double actual = cM.Multiply(10, 2);

            //assertion
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DivisionByZeroTest()
        {
            //Arrange

            string resultDiv = cM.Divide(3, 0).ToString();
            string input = "Du försöker dela med noll";


            Assert.Equal(resultDiv, input);
        }

    }
}



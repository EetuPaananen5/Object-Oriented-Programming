namespace TestProject1
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(int.MinValue,int.MaxValue, -1)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, -1, int.MaxValue)]
        public void CanAddTheory(int value1, int value2, int expected)
        {
            var calculator = new Calculator();

            var result = calculator.Add(value1, value2);

            Assert.Equal(expected, result);
        }
        /* [Fact]


         public void CanAdd()
         {
             var calculator = new Calculator();

             int value1 = 1;
             int value2 = 2;

             var result = calculator.Add(value1, value2);

             Assert.Equal(3, result);
         }*/

    }
}
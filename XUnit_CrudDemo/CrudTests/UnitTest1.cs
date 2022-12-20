using XUnit_CrudDemo;

namespace CrudTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            MyMath m = new MyMath();
            int input1 = 10;
            int input2 = 20;

            int expected = 30;//(assumed)

            //Act
            int actual= m.Add(input1, input2);

            //Assert(comparison)
            Assert.Equal(expected, actual);
            //if true test case passed

        }
    }
}
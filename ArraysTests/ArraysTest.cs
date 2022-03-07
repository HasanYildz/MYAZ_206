using Xunit;

namespace ArraysTests
{
    public class ArraysTest

    {
        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        public void Check_Array(int defaultSize)
        {
            var arr = new Array1(defaultSize);

            Assert.Equal(defaultSize, arr.Length);
        }
        [Fact]

        public void CheckArray2()
        {
            var arr = new Array1(1, 2, 3);
            Assert.Equal(3, arr.Length);

        }

        [Fact]
        public void ChechkArrayValueTest()
        {
            var arr = new Array1();

            arr.SetValue(1, 0);
            arr.SetValue(2, 1);

            Assert.Equal(1, arr.GetValue(0));
            Assert.Equal(2, arr.GetValue(1));
            



        }
        [Fact]
        public void Clone_Test()
        {
            var arr= new Array1(1,2,3,4,5);
            var clone =  arr.Clone() as Array1;

            Assert.Equal(clone.Length, arr.Length);
        }
        [Fact]
        public void ArrayGetEnum()
        {
            var arr = new Array1(1, 2, 3);
            string s = "";

            foreach (var item in arr)
            {
                s += item;
            }
            Assert.Equal("321", s);
        }
    }


}
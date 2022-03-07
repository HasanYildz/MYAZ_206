using ValueAndReferences;
using ValueAndReferenceTypes;
using Xunit;

namespace ValAndRefTypesTest
{
    public class RefAndValueTest

    {

        //[Fact]
        //public void RefTypeTest()

        //{


        //    var t1 = new ReferenceType(3, 4);
        //    var t2 = t1;
        //    //Act 
        //    t1.X = 10;

        //    Assert.Equal(t1.X, t2.X);


        //}
        //[Fact]
        //public void ValTypeTest()

        //{


        //    var t1 = new ValueType(3, 4);
        //    var t2 = t1;
        //    //Act 
        //    t2.X = 10;

        //    Assert.NotEqual(t1.X, t2.X);


        //}
        [Fact]
        public void RecordTest()
        {
            //arrange
            var r1 = new RecordType();
            r1.X = 1;
            r1.Y = 2;

            var r2 = new RecordType();
            r2.X = 1;
            r2.Y = 2;
            
            Assert.Equal(r1, r2);

        }
        [Fact]
        public void SwapVal()
        {
            int a = 23, b = 55;
            var valType = new ValueType();

            valType.Swap(a, b);
            Assert.Equal(23, a);
            Assert.Equal(55, b);
        }
        [Fact]
        public   void SwapRef()
        {
            int a = 23, b = 55;
            var refType = new ReferenceType();
            refType.Swap(ref a, ref b);
            Assert.Equal(55, a);
            Assert.Equal(23, b);


        }
        [Fact]
        public void CheckOutKeyword()
        {
            var refType= new ReferenceType();
            int b = 50;
            refType.CheckOut(out b);
            Assert.Equal(100, b);
        }
    }
}
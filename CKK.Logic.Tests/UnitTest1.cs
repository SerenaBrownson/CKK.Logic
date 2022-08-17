using System;
using Xunit;


 namespace CKK.Logic
{
    public class UnitTest1
    {
        [Fact]
        public void AddProductPassingTest()
        {
            Assert.Equal(1, AddProduct(quantity: 1));
        }

        [Fact]
        public void RemoveProductPassingTest()
        {
            Assert.Equal(null , RemoveProduct(quantity: 1));
        }

        [Fact]
        public void GetTotalPassingTest()
        {
            Assert.Equal(null, GetTotal());
        }


    }
}

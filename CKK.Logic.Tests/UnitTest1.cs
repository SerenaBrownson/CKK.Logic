using System;
using Xunit;
using CKK.Logic.Models;


namespace CKK.Logic.Tests
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
            Assert.Equal(null, RemoveProduct(quantity: 1));
        }

        [Fact]
        public void GetTotalPassingTest()
        {
            Assert.Equal(null, GetTotal());
        }


    }
}

using System;
using Xunit;
using CKK.Logic.Models;

 namespace CKK.Logic
{
    public class UnitTest1
    {

        
        [Fact]
        public void AddProductPassingTest()
        {
            Customer john = new Customer();
            ShoppingCart sc = new ShoppingCart(john);
            Product prod = new Product();
            ShoppingCartItem i = sc.AddProduct(prod,1);
            int qty = i.GetQuantity();
            
            Assert.Equal(1, qty );

        }

        [Fact]
        public void RemoveProductPassingTest()
        {
            Customer john = new Customer();
            ShoppingCart sc = new ShoppingCart(john);
            Product prod = new Product();
            ShoppingCartItem i = sc.AddProduct(prod, 2);
            sc.RemoveProduct(prod, 1);
            int qty = i.GetQuantity();

            Assert.Equal( 1 , qty );
        }

        [Fact]
        public void GetTotalPassingTest()
        {
            Customer john = new Customer();
            ShoppingCart sc = new ShoppingCart(john);

            Product prod1 = new Product();
            ShoppingCartItem i = sc.AddProduct(prod1,1);
            prod1.SetId(1);
            prod1.SetPrice((decimal)15.00);

            //tested and okay
            Product prod2 = new Product();
            ShoppingCartItem i2 = sc.AddProduct(prod2, 1);
            prod2.SetId(2);
            prod2.SetPrice((decimal)10.00);

            Product prod3 = new Product();
            ShoppingCartItem i3 = sc.AddProduct(prod3, 1);
            prod3.SetId(3);
            prod3.SetPrice((decimal)10.00);
            
           

            Assert.Equal(35, sc.GetTotal());
        }


    }
}

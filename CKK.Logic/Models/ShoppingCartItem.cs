using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem
    {
        //instance variables
        private Product product;

        private int quantity;

        //constuctor
        public ShoppingCartItem(Product argProduct, int argQuantity)
        { 
            product = argProduct;
            quantity = argQuantity;
        }
        
        //methods for product
        public Product GetProduct()
        {
            return product;
        }
        public void SetProduct(Product argProduct)
        {
            product = argProduct;
        }

        //methods for quantity
        public int GetQuantity()
        {
            return quantity;
        }
        public void SetQuantity(int argQuantity)
        {
            quantity = argQuantity;
        }

        public decimal GetTotal() 
        { 
            return quantity * product.GetPrice() ; 
        }





    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    internal class StoreItem
    {
        //private instance variables
        private int quantity;
        private Product product;
        

        //constructor
        public StoreItem(int argQuantity,Product argProduct)
        {
            quantity = argQuantity;
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
        
        //method for product
        public Product GetProduct()
        {
            return product;
        }
        public void SetProduct(Product argProduct)
        {
            product = argProduct;
        }

    }
    

}

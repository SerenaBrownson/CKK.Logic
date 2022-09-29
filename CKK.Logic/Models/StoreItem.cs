using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;


namespace CKK.Logic.Models
{
    public class StoreItem : InventoryItem
    {
        
        

        //constructor
        public StoreItem(Product argProduct, int argQuantity)
        {
            Quantity = argQuantity;
            Product = argProduct;
        }
        
        //methods for quantity
        public int GetQuantity()
        {
            return Quantity;
        }
        public void SetQuantity(int argQuantity)
        {
            Quantity = argQuantity;
        }
        
        //method for product
        public Product GetProduct()
        {
            return Product;
        }
        public void SetProduct(Product argProduct)
        {
            Product = argProduct;
        }

    }
    

}

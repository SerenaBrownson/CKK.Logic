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

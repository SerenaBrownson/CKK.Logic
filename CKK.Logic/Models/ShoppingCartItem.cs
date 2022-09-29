using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;


namespace CKK.Logic.Models
{
    public class ShoppingCartItem : InventoryItem
    {

        //constuctor
        public ShoppingCartItem(Product argProduct, int argQuantity)
        {
            Product = argProduct;
            Quantity = argQuantity;
        }
        
        //methods for product
        public Product GetProduct()
        {
            return Product;
        }
        public void SetProduct(Product argProduct)
        {
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

        public decimal GetTotal() 
        { 
            return Quantity * Product.GetPrice() ; 
        }





    }
    
}

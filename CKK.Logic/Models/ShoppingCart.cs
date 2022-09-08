using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        //initial values
       private Customer Customer;
       private List<ShoppingCartItem> products;

       

        //constructor 
        public ShoppingCart(Customer argCust)
        {
           Customer = argCust;
           products = new List<ShoppingCartItem>();
        }
        //GetIDMethod
        public int GetCustomerId()
        {
            return Customer.GetId();
        }
        
         public ShoppingCartItem GetProductById( int ID) // will be the same at stores 
        {
            var item = new Product();
            item.SetId(ID);
            var find = new ShoppingCartItem(item, 0);
            products.Contains(find);
            return find;
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod, 1); 
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity) // should be done 
        {   if (quantity >= 1) //checks for valid quantity
            {
                var item = new ShoppingCartItem(prod, quantity);
                products.Add(item);
                return item;
            }
            else return null;
        }
         
        public ShoppingCartItem RemoveProduct(Product prod, int quantity) 
        {
            if (quantity >= 1)
            {
                var item = new ShoppingCartItem(prod, quantity);
                products.Remove(item);
                return item;
            }

            return null;
        }

        public decimal GetTotal() 
        {
            var shoppingtotal = 0.0M;
            foreach ( var product in products)
            {
                shoppingtotal = product.GetProduct().GetPrice() * product.GetQuantity();
                
            }
            return shoppingtotal; 
            
        }
        
        public List<ShoppingCartItem> GetProducts(int prodNum) //List here now 
        {
            return products;
        }


    }
}
